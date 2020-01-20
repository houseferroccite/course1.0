using course1._0.Application_Data.Functional;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course1._0.Application_Data.Form_s_for_acces_rights
{
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
        }

        private void button__Click(object sender, EventArgs e)
        {

        }

        private void button_see_letter_imprisoned_Dogovorov_Click(object sender, EventArgs e)
        {
            
            Seen_Dogovor_guest seen = new Seen_Dogovor_guest();
            seen.Show();
            
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            bindingNav_guest.Visible = false;
        }
    }
}
