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
    public partial class Блюда_Заказ : Form
    {
        public CRUD parent;
        public string BLid = "";
        public string POid = "";
        public Блюда_Заказ()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Блюда";
            g.view = true;
            g.sel_id_name = "id";
            g.ShowDialog();
            if (g.DialogResult == DialogResult.OK)
            {
                BLid = g.sel_id;
                PG.Populate_FK_grid("Блюда", dataGridView2, "id", BLid);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Заказ";
            g.view = true;
            g.sel_id_name = "id";
            g.ShowDialog();
            if (g.DialogResult == DialogResult.OK)
            {
                POid = g.sel_id;
                PG.Populate_FK_grid("Заказ", dataGridView1, "id", POid);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((BLid != "") && (POid != ""))
            {
                parent.tcom = "insert into \"Блюда_Заказ\" values ('" +
                    BLid + "','" + POid + "');";


                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
