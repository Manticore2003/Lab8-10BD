using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8BD
{
    public partial class Продукты : Form
    {
        public CRUD parent;
        public bool empty_start = true;

        public string PRid = "";
        public string PRsell = "";
        public string PRtime = "";
        public string PRmass = "";
        public Продукты()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sell = textBox1.Text;
            string time = textBox2.Text;
            string mass = textBox3.Text;


            if ((sell != "") && (time != "") && (mass != ""))
            {
                if (empty_start)
                    parent.tcom = "insert into Продукты values (DEFAULT, '" +
                        sell + "','" + time + "','" + mass + "');";
                else
                    parent.tcom = "UPDATE Продукты" +
                        "SET \"СрокГодности\" = '" + sell
                        + "', \"ТемператураХранения\" = '" + time
                        + "', \"Название\" = '" + mass
                        + "'WHERE \"id\" = " + PRid + ";";

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            textBox1.Text = PRsell;
            textBox2.Text = PRtime;
            textBox3.Text = PRmass;
        }
    }
}
