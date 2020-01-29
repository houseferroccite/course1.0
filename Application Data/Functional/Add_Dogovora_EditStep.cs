using Course_project;
using Course_project.Методы;
using course1._0.Forms;
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
    public partial class Add_Dogovora_EditStep : Form
    {
        public Add_Dogovora_EditStep()
        {
            InitializeComponent();
           
        }
        BindingSource bs_Dog = new BindingSource();
        public Add_Dogovora_EditStep(BindingSource bs_Dog)
        {
            InitializeComponent();
            this.bs_Dog = bs_Dog;
        }
        DataTable dt_Arch;
        private void Add_Dogovora_EditStep_Load(object sender, EventArgs e)
        {
            QuicklyChangeDB.TextBox(bs_Dog, "Название_договора", textBox_Dog);
        }

        private void Button_save_Dog_end_arch_Click(object sender, EventArgs e)
        {
            //dt_Arch = DB.LoadTable($"INSERT INTO [Т_Договора Архив] ( №_Договора, Название_договора, Куратор_проекта, ФИО_Клиента, [Дата составления], [Язык разработки], Колво_дней, Плановая_дата, Фактическа_Дата, Примечание, Штраф ) SELECT Т_Договора.[№_Договора], Т_Договора.Название_договора, Т_Договора.Куратор_проекта, Т_Договора.ФИО_Клиента, Т_Договора.[Дата составления], Т_Договора.[Язык разработки], Т_Договора.Колво_дней, Т_Договора.Плановая_дата, Т_Договора.Фактическа_Дата, Т_Договора.Примечание, Т_Договора.Штраф FROM Т_Договора WHERE(((Т_Договора.[№_Договора]) = ", "");

            //this.Close();
        }
    }
}
