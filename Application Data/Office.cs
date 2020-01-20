using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using course1._0.Forms;
using Course_project;
using Course_project.Методы;
using Course_project.Method_s_for_settings_GridView;

namespace course1._0.Application_Data.Form_s_for_acces_rights
{
    public partial class Office : Form
    {
        public Office()
        {
            InitializeComponent();
        }
        Adm n;
        public Office(Form offciee)
        {
            InitializeComponent();
            n = (Adm)offciee;
        }

        private void Office_Load(object sender, EventArgs e)
        {
            GridViewStyles.ChancheViewGrid(gggg);
        }
        excel.Application app = new excel.Application();
        private void button1_Click(object sender, EventArgs e)
        {
            //создать приложение 

            //рабочую книгу
            excel.Workbook book = app.Workbooks.Add();//(Add(); ("nameBook");)
                                                      //получаем ссылку на лист
            excel.Worksheet sheet = book.Worksheets[1];

            ////выведем текущую дату в виде: | Дата: | 16.11.2018. |
            //sheet.Cells[1, 1] ="Дата:";
            //sheet.Cells[1, 2] = DateTime.Today;
            //                        sheet.Columns[2].Autofit(); //Авто подбор размера 

            Random r = new Random();
            int row = int.Parse(text_j.Text);
            int collumn = int.Parse(text_j.Text);
            int[,] arr = new int[row, collumn];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < collumn; j++)
                {
                    arr[i, j] = r.Next(-50, 50);
                    sheet.Cells[i + 1, j + 1] = arr[i, j];
                    //sheet.Range[sheet.Cells[i + 1, j + 1], sheet.Cells[i + 1, j + 1]].HorizontalAligment = excel.XlHAlign.xlHAlignCenter;
                    if (arr[i, j] > 0)
                    {
                        sheet.Cells[i + 1, j + 1].Font.Color = Color.White;
                        sheet.Cells[i + 1, j + 1].Interior.Color = Color.Brown; //Interiors.Color = Color.Blue;
                    }
                }
            }
            app.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //рабочую книгу
            excel.Workbook book = app.Workbooks.Add();//(Add(); ("nameBook");)
                                                      //получаем ссылку на лист
            excel.Worksheet sheet = book.Worksheets[1];

            DataTable dt = DB.ds.Tables["Т_Клиент"];
            gggg.DataSource = dt;

            string[] arr = new string[] {"ФИО", "Адрес", "Реквизиты банка" };

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
    }
}
