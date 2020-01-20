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
    public partial class Notification_registration_form : Form
    {
        public Notification_registration_form()
        {
            InitializeComponent();
            Rectangle screenSize = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            this.Location = new Point(screenSize.Width - this.Width, screenSize.Height - this.Height);
        
        }
        //public Notification_registration_form()
        //{
            

        //}
        private void Notification_registration_form_Load(object sender, EventArgs e)
        {
           
            toolStripStatusLabel_Date.Text += DateTime.Today.ToShortDateString();
            toolStripStatusLabel_Time.Text += DateTime.Today.Date.Hour;
        }
    }
}
