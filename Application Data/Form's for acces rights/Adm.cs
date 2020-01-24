using Course_project;
using Course_project.Method_s_for_quicly_use_DB;
using Course_project.Method_s_for_settings_GridView;
using Course_project.Методы;
using course1._0.Application_Data.Form_s_for_acces_rights;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using excel = Microsoft.Office.Interop.Excel;
using word = Microsoft.Office.Interop.Word;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using course1._0.Application_Data.Functional;
using course1._0.Geo__;
using System.Device.Location;
using System.IO;
using course1._0.Application_Data.Analytics;

namespace course1._0.Forms
{
    public partial class Adm : Form
    {
        public Adm()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();

        public BindingSource bs_Client = new BindingSource();
        public BindingSource bs_Dol = new BindingSource();
        public BindingSource bs_login = new BindingSource();
        public BindingSource bs_language = new BindingSource();
        public BindingSource bs_sotr = new BindingSource();
        public BindingSource bs_Dog = new BindingSource();
        public BindingSource bs_archDog = new BindingSource();
        public BindingSource bs_work = new BindingSource();
        public BindingSource bs_curator = new BindingSource();

        DataGridViewButtonColumn inf,izm;

        public bool s = false;

        excel.Application app = new excel.Application();

        private void Adm_Load(object sender, EventArgs e)
        {
            
            button_search_butn.Visible = false;
            bs_login.DataSource = DB.ds.Tables["Login"];
            GridViewStyles.ChancheViewGrid(grid_for_all);
            #region
            //using (contextstudent context = new contextstudent())
            //{
            //    Student student = new Student
            //    {
            //        Name = "Зарина"
            //    };
            //    context.Студенты.Add(student);
            //    context.SaveChanges();
            //    grid_for_all.DataSource = context.Студенты.ToList();

            //}
            #endregion
            bindingNavigator1.Visible = false;

            //For Tables Т_Кураторы
            bs_curator.DataSource = DB.ds.Tables["Т_Кураторы"];
            //For Tables Т_Язык_программирования
            bs_language.DataSource = DB.ds.Tables["Т_Языки_прог"];
        }

        private void button_create_new_user_Click(object sender, EventArgs e)
        {
            Add_user add = new Add_user(bs_login);
            add.Show();
        }

        private void grid_position_CellClick(object sender, DataGridViewCellEventArgs e)
        {
               if (DB.ds.Tables["Т_Должность"].Rows.Count > e.RowIndex)
               {
                  dbHelper.DeletePosition((int)grid_for_all.CurrentRow.Cells["ID_Должности"].Value);
               }
        }

        private void button1_Click_1(object sender, EventArgs e) //Лямбда поиск 
        { 
                //{
            //    //Лямбда для выборки по какому-то значению
            //    using (myCreatePO_projectEntities1 context = new myCreatePO_projectEntities1())
            //    {
            //        var q = from z in context.Т_Должность
            //                where z.Должность == combotest.Text
            //                select z;
            //        GridViewStyles.GridClear(grid_for_all);
            //        grid_for_all.DataSource = q.ToList();
                //}
        }

        private void button_client_Click(object sender, EventArgs e)
        {
            GridViewStyles.ButtonGrid("Information", "Inf", "Подробнее", grid_for_all,inf);
            GridViewStyles.ButtonGrid("Del", "Delite", "Удалить", grid_for_all, inf);
            
            //For Tables T_Client
            DataTable dt = DB.ds.Tables["Т_Клиент"];
            bs_Client.DataSource = DB.ds.Tables["Т_Клиент"];
            grid_for_all.DataSource = bs_Client;

            bindingNavigator1.BindingSource = bs_Client;
            QuicklyChangeDB.GridVisible(new string []{ "Фото", "ID_Клиента" }, grid_for_all);
        }

        private void button_Dol_Click(object sender, EventArgs e)
        {
            GridViewStyles.ButtonGrid("ChangeContext","Изменить","Изменить", grid_for_all, izm);

            if (grid_for_all.Columns.Contains("Information") && grid_for_all.Columns.Contains("Del"))
            {
                grid_for_all.Columns.Remove("Information");
                grid_for_all.Columns.Remove("Del");
            }
            //For Tables T_Position
            bs_Dol.DataSource = DB.ds.Tables["Т_Должность"];
            grid_for_all.DataSource = bs_Dol;
            
            bindingNavigator1.BindingSource = bs_Dol;
            QuicklyChangeDB.GridVisible(new string[] { "ID_Должности"}, grid_for_all);
        }

        private void button_language_Click(object sender, EventArgs e)
        {
            GridViewStyles.ChancheViewGrid(grid_for_all);
            if (grid_for_all.Columns.Contains("Information") && grid_for_all.Columns.Contains("Del") && grid_for_all.Columns.Contains("ChangeContext"))
            {
                grid_for_all.Columns.Remove("Information");
                grid_for_all.Columns.Remove("Del");
                grid_for_all.Columns.Remove("ChangeContext");
            }
            //For Tables Т_Языки_прог
            
            grid_for_all.DataSource = bs_language;
            //GridViewStyles.GridClear(grid_for_all);
            bindingNavigator1.BindingSource = bs_language;
            QuicklyChangeDB.GridVisible(new string[] { "КодЯзыка"}, grid_for_all);
        }

        private void button_Sotr_Click(object sender, EventArgs e)
        {
            if (grid_for_all.Columns.Contains("Information") && grid_for_all.Columns.Contains("Del"))
            {
                grid_for_all.Columns.Remove("Information");
                grid_for_all.Columns.Remove("Del");
            }
            //For Tables Т_Штат сотрудников
            bs_sotr.DataSource = DB.ds.Tables["Т_Штат сотрудников"];
            grid_for_all.DataSource = bs_sotr;
            //GridViewStyles.GridClear(grid_for_all);
            bindingNavigator1.BindingSource = bs_sotr;
            QuicklyChangeDB.GridVisible(new string[] { "ID_сотрудника", "ID_Куратора","Должность" }, grid_for_all);
        }

        private void buttonDog_Click(object sender, EventArgs e)
        {
            GridViewStyles.ChancheViewGrid(grid_for_all);
            if (grid_for_all.Columns.Contains("Information") && grid_for_all.Columns.Contains("Del") && grid_for_all.Columns.Contains("ChangeContext"))
            {
                grid_for_all.Columns.Remove("Information");
                grid_for_all.Columns.Remove("Del");
                grid_for_all.Columns.Remove("ChangeContext");
            }
            //For Tables Т_Договора
            bs_Dog.DataSource = DB.ds.Tables["Т_Договора"];
            grid_for_all.DataSource = bs_Dog;
            //GridViewStyles.GridClear(grid_for_all);
            bindingNavigator1.BindingSource = bs_Dog;
            
        }

        private void buttonArhDog_Click(object sender, EventArgs e)
        {
            GridViewStyles.ChancheViewGrid(grid_for_all);
            if (grid_for_all.Columns.Contains("Information") && grid_for_all.Columns.Contains("Del"))
            {
                grid_for_all.Columns.Remove("Information");
                grid_for_all.Columns.Remove("Del");
            }
            //For Tables Т_Договора Архив
            bs_archDog.DataSource = DB.ds.Tables["Т_Договора Архив"];
            grid_for_all.DataSource = bs_archDog;
            //GridViewStyles.GridClear(grid_for_all);
            bindingNavigator1.BindingSource = bs_archDog;
        }

        private void button_work_Click(object sender, EventArgs e)
        {
            if (grid_for_all.Columns.Contains("Information") && grid_for_all.Columns.Contains("Del") && grid_for_all.Columns.Contains("ChangeContext"))
            {
                grid_for_all.Columns.Remove("Information");
                grid_for_all.Columns.Remove("Del");
                grid_for_all.Columns.Remove("ChangeContext");
            }
            //For Tables Т_Договора Архив
            bs_work.DataSource = DB.ds.Tables["Т_ВидыРабот"];
            grid_for_all.DataSource = bs_work;
            
            bindingNavigator1.BindingSource = bs_work;
            QuicklyChangeDB.GridVisible(new string[] { "ID_Работы" }, grid_for_all);
        }

        Т_Должность g;
        Т_Клиент qq;
        
        private void grid_for_all_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //using (myCreatePO_projectEntities2 context = new myCreatePO_projectEntities2())
            //{
            //    int id = (int)grid_for_all.CurrentRow.Cells["ID_Должности"].Value;
            //    //находим нужную запись
            //    g = context.Т_Должность.FirstOrDefault(x => x.ID_Должности == id);

            //    //Кнопка Удалить
            //    if (grid_for_all.Columns[e.ColumnIndex].Name == "Del")
            //    {
            //        //удаляем выбранную запись
            //        context.Т_Должность.Remove(g);

            //        //сохраняем изменения
            //        context.SaveChanges();
            //        var q = from z in context.Т_Должность select new { z.Должность, z.ID_Должности };
            //        grid_for_all.DataSource = q.ToList();
            //    }
            //}
        }

        private void button_arch_prim_Click(object sender, EventArgs e)
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

                sheet.Cells[1, 1] = "Примечание";
                sheet.Cells[1, 2] = "Договора";
                sheet.Cells[1, 3] = "Дата составления";
                sheet.Cells[1, 4] = "Количество";

                int i = 1;
                foreach (var z in q2)
                {
                    //sheet.Cells[i+1, 2] = z.Договора;
                    sheet.Cells[i+1, 1] = z.Примечание;
                    sheet.Cells[i+1, 4] = z.Количество;
                    foreach(var c in z.Договора)
                    {
                        sheet.Cells[i + 1, 2] = c.ToString();
                    }
                    i++;
                }
                sheet.Columns.AutoFit();
                app.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (myCreatePO_projectEntities context = new myCreatePO_projectEntities())
            {
                var q = from sotr in context.Т_Штат_сотрудников
                        join lang in context.Т_Языки_прог
                        on sotr.Язык_программирования equals lang.КодЯзыка
                        group new { sotr, lang }
                        by new { sotr.ФИО, lang.Язык }
                        into gg
                        select new
                        {
                            ФИО = gg.Key.ФИО,
                            Язык_разработки = gg.Key.Язык,
                            Кол_во = gg.Count()
                        };
                app.Visible = true;
                excel.Workbook book = app.Workbooks.Add();
                excel.Worksheet sheet = book.Worksheets[1];

                sheet.Cells[3, 1] = "ФИО";
                sheet.Cells[3, 2] = "Язык программирования";
                sheet.Cells[3, 3] = "Кол-во языков";

                int i = 4;
                foreach (var z in q)
                {
                    sheet.Cells[i, 1] = z.ФИО;
                    sheet.Cells[i, 2] = z.Язык_разработки;
                    sheet.Cells[i, 3] = z.Кол_во;
                    i++;
                }
            
            // Выделяем диапазон ячеек 
            excel.Range _excelCells1 = (excel.Range)sheet.get_Range("A1", "C1").Cells;
            excel.Range _excelCells2 = (excel.Range)sheet.get_Range("A2", "B2").Cells;
            // Производим объединение
            _excelCells1.Merge(Type.Missing);
            _excelCells2.Merge(Type.Missing);
            sheet.Cells[1,1] = "Отчет";
            sheet.Cells[2, 1] = "Дата составления отчета";
            sheet.Cells[2, 3] = DateTime.Today;
                //Настраивание стиля 
                sheet.Range["A1:C5"].Borders.LineStyle = excel.XlLineStyle.xlContinuous;
                sheet.Columns.AutoFit();
                //Выравнивание
                sheet.Range[sheet.Cells[1, 1], sheet.Cells[3, 1]].HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Dogovora dogovor = new Add_Dogovora(bs_curator,bs_language);
            dogovor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GridViewStyles.ChancheViewGrid(grid_for_all);

            if (grid_for_all.Columns.Contains("Information") && grid_for_all.Columns.Contains("Del") && grid_for_all.Columns.Contains("ChangeContext"))
            {
                grid_for_all.Columns.Remove("Information");
                grid_for_all.Columns.Remove("Del");
                grid_for_all.Columns.Remove("ChangeContext");
            }
            grid_for_all.DataSource = bs_curator;
            bindingNavigator1.BindingSource = bs_curator;

            QuicklyChangeDB.GridVisible(new string[] { "ID_Куратора","Должность" }, grid_for_all);
        }

        private void button4_Click(object sender, EventArgs e)
        {
                word.Application appW = new word.Application();
                word.Document documentW = appW.Documents.Open(Directory.GetCurrentDirectory()+@"\111.doc");

                documentW.Bookmarks["Текущая_дата_составления"].Range.Text = DateTime.Today.ToShortDateString().ToString();
                documentW.Bookmarks["Город"].Range.Text = "Челябинск";

                documentW.Bookmarks["День_заключения_договора"].Range.Text = DateTime.Today.Day.ToString();
                documentW.Bookmarks["Год_заключения_договора"].Range.Text = DateTime.Today.Year.ToString();

                appW.Visible = true;
        }

        private void button_otch_Click(object sender, EventArgs e)
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

        private void Grid_for_all_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_for_all.Columns[e.ColumnIndex].Name == "Information")
            {
                Inform inf = new Inform(bs_Client);
                inf.Show();
                
            }
            if (grid_for_all.Columns[e.ColumnIndex].Name == "ChangeContext")
            {
                    test_insert_position t = new test_insert_position(bs_Dol);
                     t.Show();
                     s = true;
            }
            if (grid_for_all.Columns[e.ColumnIndex].Name == "Del")
            {
                using (myCreatePO_projectEntities context = new myCreatePO_projectEntities())
                {
                    if (!String.IsNullOrEmpty(grid_for_all.CurrentRow.Cells["ID_Клиента"].Value.ToString()))
                    {
                         int id = (int)grid_for_all.CurrentRow.Cells["ID_Клиента"].Value;
                    
                        //находим нужную запись     
                        qq = context.Т_Клиент.FirstOrDefault(x => x.ID_Клиента == id);
                        if (qq != null)
                        {
                            //удаляем выбранную запись
                            context.Т_Клиент.Remove(qq);
                            //сохраняем изменения
                            context.SaveChanges();
                        }
                        
                        var q = from z in context.Т_Клиент select new { z.ID_Клиента, z.ФИО, z.Адрес, z.Реквизиты_банка };
                        grid_for_all.DataSource = q.ToList();
                        //grid_for_all.Rows.Remove(grid_for_all.Rows[id]);
                    }
                    else
                    {

                    }
                }
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Search_Adm search_adm = new Search_Adm();
            search_adm.Show();
        }

        private void Check_serach_activate_CheckedChanged(object sender, EventArgs e)
        {
            if (check_serach_activate.Checked)
            {
                button_search_butn.Visible = true;
            }
            else
            {
                button_search_butn.Visible = false;
            }
        }

        private void Button_diag_analytics_Click(object sender, EventArgs e)
        {
            Language_ANL _ANL = new Language_ANL();
            _ANL.ShowDialog();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите закрыть программу?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                this.Close();
               
            }
        }

        private void Button_get_documents_Click(object sender, EventArgs e)
        {
            Get_Documents_inf docum = new Get_Documents_inf();
            docum.Show();
        }

        private void Button_create_Dog_Click(object sender, EventArgs e)
        {
            Add_Dogovora add_Dog = new Add_Dogovora();
            add_Dog.Show();
        }

    }
    
    
}


