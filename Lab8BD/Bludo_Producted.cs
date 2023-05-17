using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Lab8BD
{
    public partial class Bludo_Producted : Form
    {
        public CRUD parent;
        public string BLid = "";
        public string PRid = "";
        public Bludo_Producted()
        {
            InitializeComponent();
        }

        private void Bludo_Producted_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Блюда";
            g.view = true;
            g.sel_id_name = "id";
            g.ShowDialog();
            if (g.DialogResult == DialogResult.OK)
            {
                BLid = g.sel_id;
                PG.Populate_FK_grid("Блюда", dataGridView1, "id", BLid);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Меню";
            g.view = true;
            g.sel_id_name = "id";
            g.ShowDialog();
            if (g.DialogResult == DialogResult.OK)
            {
                PRid = g.sel_id;
                PG.Populate_FK_grid("Меню", dataGridView2, "id", PRid);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((BLid != "") && (PRid != ""))
            {
                parent.tcom = "insert into \"Блюда_Меню\" values ('" +
                    BLid + "','" + PRid + "');";


                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
