using course1._0.Application_Data.Functional;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace course1._0.Application_Data.Form_s_for_acces_rights
{
    public partial class Guest : Form
    {

        public Guest()
        {
            InitializeComponent();
        }
          
        private string NameExcel = @"D:\College\Курсовая ВАЖНО\Application\course1.0\bin\Debug\guest.xls";
        private void button__Click(object sender, EventArgs e)
        {
            excel.Application app = new excel.Application();
            excel.Workbook ObjWorkBook = app.Workbooks.Open(NameExcel, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            app.Visible = true;
        }

        private void button_see_letter_imprisoned_Dogovorov_Click(object sender, EventArgs e)
        {
            INFO_company seen = new INFO_company();
            seen.ShowDialog();
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            button__Click(sender, e);
            bindingNav_guest.Visible = false;
        }
    }
}
