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
    public partial class Bludo : Form
    {
        public CRUD parent;
        public bool empty_start = true;

        public string BLid = "";
        public string BLmass = "";
        public string BLsell = "";
        public string BLstructt = "";
        public string BLcall = "";
        public Bludo()
        {
            InitializeComponent();
        }

        private void Bludo_Load(object sender, EventArgs e)
        {
            textBox1.Text = BLmass;
            textBox2.Text = BLsell;
            textBox3.Text = BLstructt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mass = textBox1.Text;
            string sell = textBox2.Text;
            string structt = textBox3.Text;

            if ((sell != "") && (mass != "") && (structt != ""))
            {
                if (empty_start)
                    parent.tcom = "insert into Блюда values (DEFAULT, '" +
                        mass + "','" + sell + "','" + structt + "');";
                else
                    parent.tcom = "UPDATE Блюда " +
                        "SET \"Цена\" = '" + mass
                        + "', \"Вес\" = '" + sell
                        + "', \"Название\" = '" + structt
                        + "'WHERE \"id\" = " + BLid + ";";

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
