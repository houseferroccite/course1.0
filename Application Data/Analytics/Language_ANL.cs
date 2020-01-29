using Course_project;
using Course_project.Method_s_for_settings_GridView;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course1._0.Application_Data.Analytics
{
    public partial class Language_ANL : Form
    {
        public Language_ANL()
        {
            InitializeComponent();
        }
        System.Data.DataTable dt, dtQuery, dtQuery1;
        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            DataView dv = new DataView(DB.UpdateTable($"SELECT Т_Языки_прог.Язык, Count(Т_Языки_прог.Язык) AS [Языки_по_договорам] FROM Т_Языки_прог INNER JOIN Т_Договора ON Т_Языки_прог.КодЯзыка = Т_Договора.Язык_разработки Where Т_Договора.[Дата составления] >= '{date_Start_dog.Value}' and Т_Договора.[Дата составления] <= '{date_End_plan.Value}' GROUP BY Т_Языки_прог.Язык, Т_Договора.Язык_разработки;", "Load_language"));
            Diag_language.Series["Т_Языки_прог"].Points.DataBindXY(dv, "Язык", dv, "Языки_по_договорам");

            DataView dv2 = new DataView(DB.UpdateTable($"SELECT Т_Кураторы.ФИО, Count(Т_Договора.Название_договора) AS [Количество_договоров] FROM Т_Кураторы INNER JOIN Т_Договора ON Т_Кураторы.ID_Куратора = Т_Договора.Куратор_проекта GROUP BY Т_Кураторы.ID_Куратора, Т_Кураторы.ФИО", "Load_Kurator"));
            kur_diag.Series["Kurator"].Points.DataBindXY(dv2, "ФИО", dv2, "Количество_договоров");

            dtQuery1 = DB.UpdateTable($"select Т_Договора.Название_договора, Т_Договора.[Дата составления], Т_Договора.Фактическа_Дата, Т_Договора.Штраф,  Т_Договора.Примечание from Т_Договора   Where Т_Договора.[Дата составления] >= '{date_Start_dog.Value}' and Т_Договора.[Дата составления] <= '{date_End_plan.Value}'", "Load_language_in_Dog");
            grid_analitik.DataSource = dtQuery1;
        }

        private void Date_End_plan_ValueChanged(object sender, EventArgs e)
        {
           // SELECT Т_Кураторы.ФИО, Count(Т_Договора.Название_договора) AS[Count - Название_договора] FROM Т_Кураторы INNER JOIN Т_Договора ON Т_Кураторы.ID_Куратора = Т_Договора.Куратор_проекта GROUP BY Т_Кураторы.ID_Куратора, Т_Кураторы.ФИО

        }

        private void Language_ANL_Load(object sender, EventArgs e)
        {
            GridViewStyles.ChancheViewGrid(grid_analitik);
            Button1_Click_1(sender, e);
        }
    }
}
