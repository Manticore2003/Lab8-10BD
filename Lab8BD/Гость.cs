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
    public partial class Гость : Form
    {
        public CRUD parent;
        public bool empty_start = true;

        public string Aid = "";
        public string Ast = "";
        public string Apol = "";
        public string Anum = "";

        public Гость()
        {
            InitializeComponent();
        }



        private void Povar_Load(object sender, EventArgs e)
        {
            textBox1.Text = Anum;
            textBox2.Text = Ast;
            textBox3.Text = Apol;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            string stag = textBox2.Text;
            string pol = textBox3.Text;
       

            if ((num != "") && (stag != "") && (pol != ""))
            {
                if (empty_start)
                    parent.tcom = "insert into Гость values (DEFAULT, '" +
                        num + "','" + pol + "','" + stag + "');";
                else
                    parent.tcom = "UPDATE Гость " +
                        "SET \"НомерЗаказа\" = '" + num
                        + "', \"Пол\" = '" + pol
                        + "', \"ЗаказанноеБлюдо\" = '" + stag
                        + "'WHERE \"idГостя\" = " + Aid + ";";

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
