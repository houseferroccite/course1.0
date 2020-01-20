using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course1._0.Style
{
    class Setting_Application
    {
        
        public static void Notisication_Show(ComboBox tb )
        {
            NotifyIcon I_N = new NotifyIcon();
            //Notification
            I_N.BalloonTipText = $"Вход успешно выполнен!\n Вход произведен под правами - {tb.Text}";
            I_N.BalloonTipTitle = "Добро пожаловать!";
            I_N.BalloonTipIcon = ToolTipIcon.Info;
            I_N.Visible = true;
            I_N.ShowBalloonTip(1000);
        }
    }
}
