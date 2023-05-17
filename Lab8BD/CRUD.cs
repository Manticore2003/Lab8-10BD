using Lab8BD;
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

namespace Lab8BD
{
    public partial class CRUD : Form
    {
        public bool view = false;
        public string table = "";
        public string pk_name = "";
        public string pk_name2 = "";
        public int n = 5;
        public bool allow_upd = true; // для переходных таблиц

        public string tcom = "";

        public string sel_id_name = "";
        public string sel_id = "";

        private int sz = 0;
        private int pages = 0;
        public CRUD()
        {
            InitializeComponent();
        }

        private void resize()
        {
            if (table != "")
            {
                sz = (int)PG.Select_size(table);
                pages = sz / n + (sz % n == 0 ? 0 : 1);
            }
        }

        private void reload_view()
        {
            int pg = Convert.ToInt32(textBox1.Text);
            if (table != "") PG.Populate_grid(table, dataGridView1, n, pg - 1);
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            resize();
            reload_view();
            if (view)
            {
                button1.Hide();
                button2.Hide();
                button3.Hide();
            }
            if (!allow_upd) button2.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int pg = Convert.ToInt32(textBox1.Text);
            if (pg > 1) textBox1.Text = (pg - 1).ToString();
            reload_view();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int pg = Convert.ToInt32(textBox1.Text);
            if (pg < pages) textBox1.Text = (pg + 1).ToString();
            reload_view();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int pg;
            try
            {
                pg = Convert.ToInt32(textBox1.Text);
                if ((pg < 1) || (pg > pages)) throw new Exception("pg");
            }
            catch (Exception)
            {
                pg = 1;
                textBox1.Text = "1";
            }
            textBox1.Text = pg.ToString();
            reload_view();
        }











        private void button3_Click(object sender, EventArgs e)
        {
            if ((table != "") && (pk_name != "") && (pk_name2 != ""))
            {
                foreach (DataGridViewRow x in dataGridView1.SelectedRows)
                    PG.Delete2(table, pk_name, (string)x.Cells[pk_name].Value,
                        pk_name2, (string)x.Cells[pk_name2].Value);
            }
            else if ((table != "") && (pk_name != ""))
            {
                foreach (DataGridViewRow x in dataGridView1.SelectedRows)
                    PG.Delete(table, pk_name, (string)x.Cells[pk_name].Value);
            }
            resize();
            reload_view();
            if (dataGridView1.Rows.Count == 0)
            {
                int pg = Convert.ToInt32(textBox1.Text);
                if (pg > 1) textBox1.Text = (pg - 1).ToString();
                reload_view();
            }
        }
























        private void button1_Click(object sender, EventArgs e)
        {
            if (table == "Гость")
            {
                Гость s = new Гость();
                s.parent = this;
                s.empty_start = true;
                DialogResult d = s.ShowDialog();
                if (d == DialogResult.OK)
                {
                    PG.SendCU(tcom);
                    resize();
                    reload_view();
                }
            }
            if (table == "Меню")
            {
                Меню s = new Меню();
                s.parent = this;
                s.empty_start = true;
                DialogResult d = s.ShowDialog();
                if (d == DialogResult.OK)
                {
                    PG.SendCU(tcom);
                    resize();
                    reload_view();
                }
            }
            if (table == "Сотрудники")
            {
                Сотрудники s = new Сотрудники();
                s.parent = this;
                s.empty_start = true;
                DialogResult d = s.ShowDialog();
                if (d == DialogResult.OK)
                {
                    PG.SendCU(tcom);
                    resize();
                    reload_view();
                }
            }
            if (table == "Заказ")
            {
                Заказ s = new Заказ();
                s.parent = this;
                s.empty_start = true;
                DialogResult d = s.ShowDialog();
                if (d == DialogResult.OK)
                {
                    PG.SendCU(tcom);
                    resize();
                    reload_view();
                }
            }
            if (table == "Продукты")
            {
                Продукты s = new Продукты();
                s.parent = this;
                s.empty_start = true;
                DialogResult d = s.ShowDialog();
                if (d == DialogResult.OK)
                {
                    PG.SendCU(tcom);
                    resize();
                    reload_view();
                }
            }
            if (table == "Блюда")
            {
                Bludo s = new Bludo();
                s.parent = this;
                s.empty_start = true;
                DialogResult d = s.ShowDialog();
                if (d == DialogResult.OK)
                {
                    PG.SendCU(tcom);
                    resize();
                    reload_view();
                }
            }
            if (table == "Продукты_Блюда")
            {
                Продукты_Блюда s = new Продукты_Блюда();
                s.parent = this;
                DialogResult d = s.ShowDialog();
                if (d == DialogResult.OK)
                {
                    PG.SendCU(tcom);
                    resize();
                    reload_view();
                }
            }
            if (table == "Блюда_Меню")
            {
                Bludo_Producted s = new Bludo_Producted();
                s.parent = this;
                DialogResult d = s.ShowDialog();
                if (d == DialogResult.OK)
                {
                    PG.SendCU(tcom);
                    resize();
                    reload_view();
                }
            }
            if (table == "Блюда_Заказ")
            {
                Блюда_Заказ s = new Блюда_Заказ();
                s.parent = this;
                DialogResult d = s.ShowDialog();
                if (d == DialogResult.OK)
                {
                    PG.SendCU(tcom);
                    resize();
                    reload_view();
                }
            }
        }













        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                
                if (table == "Гость")
                {
                    Гость s = new Гость();
                    s.parent = this;
                    s.empty_start = false;

                    s.Aid = (string)dataGridView1.SelectedRows[0].Cells["idГостя"].Value;
                    s.Anum = (string)dataGridView1.SelectedRows[0].Cells["НомерЗаказа"].Value;
                    s.Apol = (string)dataGridView1.SelectedRows[0].Cells["Пол"].Value;
                    s.Ast = (string)dataGridView1.SelectedRows[0].Cells["ЗаказанноеБлюдо"].Value;

                    DialogResult d = s.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        PG.SendCU(tcom);
                        resize();
                        reload_view();
                    }
                }
                if (table == "Сотрудники")
                {
                    Сотрудники s = new Сотрудники();
                    s.parent = this;
                    s.empty_start = false;

                    s.Pid = (string)dataGridView1.SelectedRows[0].Cells["ТабельныйНомер"].Value;
                    s.Pnum = (string)dataGridView1.SelectedRows[0].Cells["Оклад"].Value;
                    s.Pname = (string)dataGridView1.SelectedRows[0].Cells["Должность"].Value;
                    s.Psell = (string)dataGridView1.SelectedRows[0].Cells["Обязанности"].Value;
                    s.Ppol = (string)dataGridView1.SelectedRows[0].Cells["Имя"].Value;

                    DialogResult d = s.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        PG.SendCU(tcom);
                        resize();
                        reload_view();
                    }
                }
                if (table == "Заказ")
                {
                    Заказ s = new Заказ();
                    s.parent = this;
                    s.empty_start = false;

                    s.Zid = (string)dataGridView1.SelectedRows[0].Cells["id"].Value;
                    s.Zsell = (string)dataGridView1.SelectedRows[0].Cells["Стоимость"].Value;

                    DialogResult d = s.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        PG.SendCU(tcom);
                        resize();
                        reload_view();
                    }
                }
                if (table == "Продукты")
                {
                    Продукты s = new Продукты();
                    s.parent = this;
                    s.empty_start = false;

                    s.PRid = (string)dataGridView1.SelectedRows[0].Cells["id"].Value;
                    s.PRsell = (string)dataGridView1.SelectedRows[0].Cells["СрокГодности"].Value;
                    s.PRtime = (string)dataGridView1.SelectedRows[0].Cells["ТемператураХранения"].Value;
                    s.PRmass = (string)dataGridView1.SelectedRows[0].Cells["Название"].Value;


                    DialogResult d = s.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        PG.SendCU(tcom);
                        resize();
                        reload_view();
                    }
                }
                if (table == "Блюда")
                {
                    Bludo s = new Bludo();
                    s.parent = this;
                    s.empty_start = false;

                    s.BLid = (string)dataGridView1.SelectedRows[0].Cells["id"].Value;
                    s.BLmass = (string)dataGridView1.SelectedRows[0].Cells["Цена"].Value;
                    s.BLsell = (string)dataGridView1.SelectedRows[0].Cells["Вес"].Value;
                    s.BLstructt = (string)dataGridView1.SelectedRows[0].Cells["Название"].Value;

                    DialogResult d = s.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        PG.SendCU(tcom);
                        resize();
                        reload_view();
                    }
                }
                if (table == "Меню")
                {
                    Меню s = new Меню();
                    s.parent = this;
                    s.empty_start = false;

                    s.BLid = (string)dataGridView1.SelectedRows[0].Cells["id"].Value;
                    s.BLmass = (string)dataGridView1.SelectedRows[0].Cells["Название"].Value;
                    s.BLsell = (string)dataGridView1.SelectedRows[0].Cells["ДатаСоставления"].Value;
                    s.BLstructt = (string)dataGridView1.SelectedRows[0].Cells["Блюда"].Value;

                    DialogResult d = s.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        PG.SendCU(tcom);
                        resize();
                        reload_view();
                    }
                }
            }
        }





        private void button4_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.SelectedRows.Count != 0) && (sel_id_name != ""))
                sel_id = (string)dataGridView1.SelectedRows[0].Cells[sel_id_name].Value;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
