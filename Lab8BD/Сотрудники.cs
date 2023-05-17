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
using System.Xml.Linq;

namespace Lab8BD
{
    public partial class Сотрудники : Form
    {
        public CRUD parent;
        public bool empty_start = true;

        public string Pid = "";
        public string Pname = "";
        public string Psell = "";
        public string Ppol = "";
        public string Pnum = "";
        public Сотрудники()
        {
            InitializeComponent();
        }

        private void Postavshik_Load(object sender, EventArgs e)
        {
            textBox1.Text = Pnum;
            textBox2.Text = Pname;
            textBox3.Text = Psell;
            textBox4.Text = Ppol;
        }
      
        private void button1_Click_1(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            string fio = textBox2.Text;
            string sell = " ";
            try
            {
                sell = textBox3.Text;
            }
            catch { };
            string pol = textBox4.Text; ;


            if ((num != "") && (fio != "") && (sell != ""))
            {
                if (empty_start)
                    parent.tcom = "insert into Сотрудники values (DEFAULT, '" +
                        num + "','" + fio + "','" + sell + "','" + pol + "');";
                else
                    parent.tcom = "UPDATE Сотрудники " +
                        "SET \"Оклад\" = '" + num
                        + "', \"Должность\" = '" + fio
                        + "', \"Обязанности\" = '" + sell
                        + "', \"Имя\" = '" + pol
                        + "'WHERE \"ТабельныйНомер\" = " + Pid + ";";

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
