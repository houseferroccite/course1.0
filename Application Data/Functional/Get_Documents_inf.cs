using Course_project;
using Course_project.Method_s_for_settings_GridView;
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
    public partial class Get_Documents_inf : Form
    {
        public Get_Documents_inf()
        {
            InitializeComponent();
        }
        DataTable dt,dt2;
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            GridViewStyles.ChancheViewGrid(grid_info_all);
            grid_info_all.Rows.Clear();
            grid_info_all.Columns.Clear();
            //    BindingSource bs_dog = new BindingSource();
            //    bs_dog.DataSource = dt;
            //    dt = DB.LoadTable($"SELECT Т_Договора.Название_договора as aa, Т_Договора.Дата составления as bb, Т_Договора.Штраф as yy,  Т_Договора.Примечание as zz   FROM Т_Договора  WHERE [Дата составления] = {dateTimePicker1.Value}", "Т_Договора");
            //    grid_info_all.DataSource = dt;
            using (myCreatePO_projectEntities context = new myCreatePO_projectEntities())
            {
                var x = from z in context.Т_Договора
                        select z;
                var t = from r in x
                        where r.Дата_составления == dateTimePicker1.Value
                        select r.ToString();
                grid_info_all.DataSource = t.ToList();
            }
        }

        private void ComboBox_Klient_SelectedIndexChanged(object sender, EventArgs e)
        {
            grid_info_all.DataSource = dt2;
            
        }
            BindingSource bs_login = new BindingSource();
            BindingSource bs_KL = new BindingSource();
        private void Get_Documents_inf_Load(object sender, EventArgs e)
        {
            GridViewStyles.ChancheViewGrid(grid_info_all);
            bs_login.DataSource = dt;
            bs_KL.DataSource = dt2;
            dt = DB.LoadTable("SELECT Т_Клиент.ID_Клиента as aa, Т_Клиент.ФИО as bb FROM Т_Клиент", "Т_Клиент");
            dt2 = DB.LoadTable($"SELECT * FROM Т_Клиент  WHERE ФИО = {comboBox_Klient.Text}", "Т_Клиент");
            QuicklyChangeDB.ComboSettings(dt, "ФИО", "ID_Клиента", comboBox_Klient);
        }
    }
}
