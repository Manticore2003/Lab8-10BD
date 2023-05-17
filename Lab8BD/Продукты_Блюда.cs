using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Security.Cryptography;

namespace Lab8BD
{
    public partial class Продукты_Блюда : Form
    {
        public CRUD parent;
       

        public string BLid = "";
        public string ZAid = "";
        public Продукты_Блюда()
        {
            InitializeComponent();
        }

        private void Bludo_Zakazed_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Продукты";
            g.view = true;
            g.sel_id_name = "id";
            g.ShowDialog();
            if (g.DialogResult == DialogResult.OK)
            {
                BLid = g.sel_id;
                PG.Populate_FK_grid("Продукты", dataGridView1, "id", BLid);
            }
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
                ZAid = g.sel_id;
                PG.Populate_FK_grid("Блюда", dataGridView2, "id", ZAid);
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if ((ZAid != "") && (BLid != ""))
            {         
                    parent.tcom = "insert into \"Продукты_Блюда\" values ('" +
                        BLid + "','" + ZAid + "');";
               

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
