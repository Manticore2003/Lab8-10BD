using Npgsql;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Lab8BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void гостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Гость";
            g.pk_name = "idГостя";
            g.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info Bd= new Info();
            Bd.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                PG.OpenConnection("127.0.0.1", "5432", "postgres", "vlag360", "Cafeteria");
            }
            catch (Exception ex) { MessageBox.Show("Error!\n" + ex.Message); }

        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Сотрудники";
            g.pk_name = "ТабельныйНомер";
            g.Show();
        }

        private void заказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Заказ";
            g.pk_name = "id";
            g.Show();
        }

        private void продуктыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Продукты";
            g.pk_name = "id";
            g.Show();
        }

        private void блюдаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Блюда";
            g.pk_name = "id";
            g.Show();
        }

        private void ЧёрныйЯщикрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "BlackBox";
            g.view = true;
            g.n = (int)PG.Select_size("BlackBox");
            g.Show();
        }


        private void продукты_блюдаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Продукты_Блюда";
            g.pk_name = "idПродукта";
            g.pk_name2 = "idБлюда";
            g.allow_upd = false;
            g.Show();
        }

        private void блюда_менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Блюда_Меню";
            g.pk_name = "idБлюда";
            g.pk_name2 = "idМеню";
            g.allow_upd = false;
            g.Show();
        }

        private void Блюда_заказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Блюда_Заказ";
            g.pk_name = "idБлюда";
            g.pk_name2 = "idЗаказа";
            g.allow_upd = false;
            g.Show();
        }

        private void продуктыПоставщикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Продукты_Поставщик";
            g.pk_name = "Продуктыid";
            g.pk_name2 = "Поставщикid";
            g.allow_upd = false;
            g.Show();
            
        }

        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export export= new Export();
            export.Show();
        }

        private void справочникToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD g = new CRUD();
            g.table = "Меню";
            g.pk_name = "id";
            g.Show();
        }
    }
}
