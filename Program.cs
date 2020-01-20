using course1._0.Application_Data.Form_s_for_acces_rights;
using course1._0.Application_Data.Functional;
using course1._0.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course1._0
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Add_Dogovora_EditStep());
        }
    }
}
