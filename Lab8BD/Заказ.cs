using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lab8BD
{
    public partial class Заказ : Form
    {
        public CRUD parent;
        public bool empty_start = true;

        public string Zid = "";
        public string Zsell = "";

        public Заказ()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zakazed_Load(object sender, EventArgs e)
        {
            textBox1.Text = Zsell;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sell = textBox1.Text;

            if ((sell != ""))
            {
                if (empty_start)
                    parent.tcom = "insert into Заказ values (DEFAULT, '" +
                        sell + "');";
                else
                    parent.tcom = "UPDATE Заказ " +
                        "SET \"Стоимость\" = '" + sell
                        + "'WHERE \"id\" = " + Zid + ";";

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
