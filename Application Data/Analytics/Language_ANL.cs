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

        private void Button1_Click(object sender, EventArgs e)
        {
           using(myCreatePO_projectEntities context = new myCreatePO_projectEntities())
            {
                Diag_language.DataSource = context.Т_Языки_прог.ToList();
                Diag_language.Series["Т_Языки_прог"].XValueMember = "КодЯзыка";
                Diag_language.Series["Т_Языки_прог"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
                Diag_language.Series["Т_Языки_прог"].YValueMembers = "Востребованность";
                Diag_language.Series["Т_Языки_прог"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            }
        }
    }
}
