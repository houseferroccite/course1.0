using Course_project;
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
        System.Data.DataTable dt, dtQuery;
        private void Button1_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(DB.ds.Tables["Т_Языки_прог"]);
            Diag_language.Series["Т_Языки_прог"].Points.DataBindXY(dv,"Язык",dv, "Востребованность");


        }

        private void Language_ANL_Load(object sender, EventArgs e)
        {
            dtQuery = DB.LoadTable($"select [Язык_разработки], count(*) as count from Т_Договора group by [Язык_разработки]", "Load_language");
            grid_analitik.DataSource = dtQuery;
        }
    }
}
