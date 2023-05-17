using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8BD
{
    public partial class Producted_Postavshik : Form
    {
        public CRUD parent;
        public string PRid = "";
        public string POid = "";
        public Producted_Postavshik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Продукты";
            g.view = true;
            g.sel_id_name = "ID";
            g.ShowDialog();
            if (g.DialogResult == DialogResult.OK)
            {
                PRid = g.sel_id;
                PG.Populate_FK_grid("Продукты", dataGridView1, "ID", PRid);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Поставщик";
            g.view = true;
            g.sel_id_name = "ID";
            g.ShowDialog();
            if (g.DialogResult == DialogResult.OK)
            {
                POid = g.sel_id;
                PG.Populate_FK_grid("Поставщик", dataGridView2, "ID", POid);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((PRid != "") && (POid != ""))
            {
                parent.tcom = "insert into \"Продукты_Поставщик\" values ('" +
                    PRid + "','" + POid + "');";


                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
