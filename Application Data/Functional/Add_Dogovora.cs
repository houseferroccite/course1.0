using Course_project;
using Course_project.Методы;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course1._0.Application_Data.Functional
{
    public partial class Add_Dogovora : Form
    {
        BindingSource bs_curator = new BindingSource();
        BindingSource bs_language = new BindingSource();
        DataTable dt_lang,dt_sotr,dt_curator;
        public Add_Dogovora()
        {
            InitializeComponent();
        }
        public Add_Dogovora(BindingSource bs_curator, BindingSource bs_language)
        {
            InitializeComponent();
            this.bs_curator = bs_curator;
            this.bs_language = bs_language;
        }
        private void button_save_Dog_MouseMove(object sender, MouseEventArgs e)
        {
            button_save_Dog.BackColor = Color.FromArgb(60, 179, 113);
        }

        private void button_save_Dog_MouseLeave(object sender, EventArgs e)
        {
            button_save_Dog.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        private void button_insert_Dog_MouseMove(object sender, MouseEventArgs e)
        {
            button_insert_Dog.BackColor = Color.FromArgb(0, 191, 255);
        }

        private void button_insert_Dog_MouseLeave(object sender, EventArgs e)
        {
            button_insert_Dog.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        private void Add_Dogovora_Load(object sender, EventArgs e)
        {
            BindingSource bs_language= new BindingSource();
            BindingSource bs_curator = new BindingSource();
            BindingSource bs_sotr = new BindingSource();

            bs_language.DataSource = dt_lang;
            bs_curator.DataSource = dt_curator;
            bs_sotr.DataSource = dt_sotr;

            dt_lang = DB.LoadTable("SELECT Т_Языки_прог.КодЯзыка as aa, Т_Языки_прог.Язык as bb FROM Т_Языки_прог", "Т_Языки_прог");
            dt_curator = DB.LoadTable("SELECT Т_Кураторы.ID_Куратора as aa, Т_Кураторы.ФИО as bb FROM Т_Кураторы", "Т_Кураторы");
            dt_sotr = DB.LoadTable("SELECT Т_Штат_сотрудников.ID_сотрудника as aa, Т_Штат_сотрудников.ФИО as bb FROM Т_Штат_сотрудников", "Т_Штат_сотрудников");

            QuicklyChangeDB.ComboSettings(dt_lang, "Язык", "КодЯзыка", comboBox_language_dog);
            QuicklyChangeDB.ComboSettings(dt_curator, "ФИО", "ID_Куратора", combo_Curator);
            QuicklyChangeDB.ComboSettings(dt_sotr, "ФИО", "ID_сотрудника", comboBox_sotryd_dog);
        }
         
        private void DateTime_sostavl_dog_ValueChanged(object sender, EventArgs e)
        {
            DateTime date_time = dateTime_sostavl_dog.Value;
            if (date_time < DateTime.Now.Date) {
                dateTime_sostavl_dog.Enabled = false;
            }
            else{
                dateTime_sostavl_dog.Enabled = true;
            }
        }

        private void numeric_kol_days_ValueChanged(object sender, EventArgs e)
        {
            var dd = dateTime_sostavl_dog.Value.AddDays((double)numeric_kol_days.Value);
            label8.Text += $"{dd.Date.Day}." + $"{ dd.Date.Month }." + $"{dd.Date.Year}";
            label8.Text = "";
        }

        private void TextBox_Dog_TextChanged(object sender, EventArgs e)
        {
            //using (myCreatePO_projectEntities2 context = new myCreatePO_projectEntities2())
            //{
            //    var q1 = from D in context.Т_Договора
            //             select D.Название_договора;
            //    //var q2 = from Z in q1
            //    //         select Z.
            //    if(textBox_Dog.Text == q1.ToString())
            //    {
            //        MessageBox.Show($"Договор с названием - {textBox_Dog.Text} уже емеется в базе. ");
            //    }
            //}
        }
    }
}
