using course1._0.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Course_project;
using Course_project.Методы;
using course1._0.Application_Data.Functional;
using Course_project.Method_s_for_settings_GridView;

namespace course1._0.Application_Data.Form_s_for_acces_rights
{
    public partial class Curator : Form
    {
        public Curator()
        {
            InitializeComponent();
        }

        public Curator(BindingSource bs_Dol)
        {
            InitializeComponent();

        }
        excel.Application app = new excel.Application();
        public DataGridViewButtonColumn del, inf;
        BindingSource bs_Client = new BindingSource();
        BindingSource bs_Dol = new BindingSource();
        BindingSource bs_language = new BindingSource();
        BindingSource bs_sotr = new BindingSource();
        BindingSource bs_Dog = new BindingSource();
        BindingSource bs_archDog = new BindingSource();
        BindingSource bs_work = new BindingSource();
        private void button_change_position_Click(object sender, EventArgs e)
        {
            test_insert_position t = new test_insert_position(bs_Dol);
            t.Show();
        }

        private void button_see_client_Click_1(object sender, EventArgs e)
        {
            GridViewStyles.ButtonGrid("Information", "Inf", "Подробнее", grid_curator, inf);
            
            if (grid_curator.Columns.Contains("Del"))
            {
                grid_curator.Columns.Remove("Del");

            }
            //For Tables T_Client
            DataTable dt = DB.ds.Tables["Т_Клиент"];
            bs_Client.DataSource = DB.ds.Tables["Т_Клиент"];
            grid_curator.DataSource = bs_Client;
            //GridViewStyles.GridClear(grid_for_all);
            bindingNavigator1.BindingSource = bs_Client;
            QuicklyChangeDB.GridVisible(new string[] { "Фото", "ID_Клиента" }, grid_curator);
        }

        private void button_otch_Curator_Click(object sender, EventArgs e)
        {
            //рабочую книгу
            excel.Workbook book = app.Workbooks.Add();//(Add(); ("nameBook");)
                                                      //получаем ссылку на лист
            excel.Worksheet sheet = book.Worksheets[1];

            DataTable dt = DB.ds.Tables["Т_Клиент"];


            string[] arr = new string[] { "ФИО", "Адрес", "Реквизиты банка" };

            for (int j = 0; j < arr.Length; j++)
            {
                sheet.Cells[1, j + 1] = arr[j];
                sheet.Cells[1, j + 1].Font.Bold = Font.Bold;
                sheet.Cells[1, j + 1].HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;//xlHAlignCenter;
            }
            //Выводить все остаьное
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    sheet.Cells[i + 2, j + 1] = dt.Rows[i][arr[j]];
                }
            }
            sheet.Range["A1:C7"].Borders.LineStyle = excel.XlLineStyle.xlContinuous;
            sheet.Columns.AutoFit();
            app.Visible = true;
        }

        private void grid_curator_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_curator.Columns.Contains("Information"))
            {
                Inform inf = new Inform(bs_Client);
                inf.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GridViewStyles.ButtonGrid("Del", "удалить", "Удалить", grid_curator, del);

            if (grid_curator.Columns.Contains("Information"))
            {
                grid_curator.Columns.Remove("Information");

            }
            //For Tables T_Position
            bs_Dol.DataSource = DB.ds.Tables["Т_Должность"];
            grid_curator.DataSource = bs_Dol;
            //GridViewStyles.GridClear(grid_for_all);
            bindingNavigator1.BindingSource = bs_Dol;
            QuicklyChangeDB.GridVisible(new string[] { "ID_Должности" }, grid_curator);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (grid_curator.Columns.Contains("Information") && grid_curator.Columns.Contains("Del"))
            {
                grid_curator.Columns.Remove("Information");
                grid_curator.Columns.Remove("Del");
            }
            //For Tables Т_Языки_прог

            grid_curator.DataSource = bs_language;
            //GridViewStyles.GridClear(grid_for_all);
            bindingNavigator1.BindingSource = bs_language;
            QuicklyChangeDB.GridVisible(new string[] { "КодЯзыка" }, grid_curator);
        }

        private void button_sotr_cur_Click(object sender, EventArgs e)
        {
            if (grid_curator.Columns.Contains("Information") && grid_curator.Columns.Contains("Del"))
            {
                grid_curator.Columns.Remove("Information");
                grid_curator.Columns.Remove("Del");
            }
            //For Tables Т_Штат сотрудников
            bs_sotr.DataSource = DB.ds.Tables["Т_Штат сотрудников"];
            grid_curator.DataSource = bs_sotr;
            //GridViewStyles.GridClear(grid_for_all);
            bindingNavigator1.BindingSource = bs_sotr;
            QuicklyChangeDB.GridVisible(new string[] { "ID_сотрудника", "ID_Куратора", "Должность" }, grid_curator);
        }

        private void button_Dog_Cur_Click(object sender, EventArgs e)
        {
            if (grid_curator.Columns.Contains("Information") && grid_curator.Columns.Contains("Del"))
            {
                grid_curator.Columns.Remove("Information");
                grid_curator.Columns.Remove("Del");
            }
            //For Tables Т_Договора
            bs_Dog.DataSource = DB.ds.Tables["Т_Договора"];
            grid_curator.DataSource = bs_Dog;
            //GridViewStyles.GridClear(grid_for_all);
            bindingNavigator1.BindingSource = bs_Dog;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (grid_curator.Columns.Contains("Information") && grid_curator.Columns.Contains("Del"))
            {
                grid_curator.Columns.Remove("Information");
                grid_curator.Columns.Remove("Del");
            }
            //For Tables Т_Договора Архив
            bs_archDog.DataSource = DB.ds.Tables["Т_Договора Архив"];
            grid_curator.DataSource = bs_archDog;
            //GridViewStyles.GridClear(grid_for_all);
            bindingNavigator1.BindingSource = bs_archDog;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (grid_curator.Columns.Contains("Information") && grid_curator.Columns.Contains("Del"))
            {
                grid_curator.Columns.Remove("Information");
                grid_curator.Columns.Remove("Del");
            }
            //For Tables Т_Договора Архив
            bs_work.DataSource = DB.ds.Tables["Т_ВидыРабот"];
            grid_curator.DataSource = bs_work;
            //GridViewStyles.GridClear(grid_for_all);
            bindingNavigator1.BindingSource = bs_work;
            QuicklyChangeDB.GridVisible(new string[] { "ID_Работы" }, grid_curator);
        }

        private void button_del_client_Click(object sender, EventArgs e)
        {

        }

        private void Check_serach_activate_CheckedChanged(object sender, EventArgs e)
        {
            if (check_serach_activate.Checked)
            {
                button_search_butn.Visible = true;
                check_serach_activate.FlatAppearance.BorderColor = Color.Green;
            }
            else
            {
                button_search_butn.Visible = false;
                check_serach_activate.FlatAppearance.BorderColor = SystemColors.Desktop;
            }
        }

        private void button_arch_count_prim_Curator_Click(object sender, EventArgs e)
        {
            using (myCreatePO_projectEntities context = new myCreatePO_projectEntities())
            {
                var q1 = from D in context.Т_Договора
                         select D.Название_договора;

                var q2 = from D in context.Т_Договора
                         group D by D.Примечание
                         into g
                         select new
                         {
                             Примечание = g.Key,
                             Количество = g.Count(),
                             Договора = q1
                         };
                excel.Application app = new excel.Application();
                excel.Workbook book = app.Workbooks.Add();
                excel.Worksheet sheet = book.Worksheets[1];

                int i = 2;
                foreach (var z in q2)
                {
                    sheet.Cells[i, 1] = "Примечание";
                    sheet.Cells[i, 2] = "Договора";
                    sheet.Cells[i, 3] = "Дата составления";
                    sheet.Cells[i, 3] = "Количество";

                    //sheet.Cells[i+1, 2] = z.Договора;
                    sheet.Cells[i + 1, 1] = z.Примечание;
                    sheet.Cells[i + 1, 3] = z.Количество;
                    foreach (var c in z.Договора)
                    {
                        sheet.Cells[i + 1, 2] = z.Договора.ToString();
                    }
                    i++;
                }
               
                sheet.Columns.AutoFit();
                app.Visible = true;
            }
        }
    }
}
