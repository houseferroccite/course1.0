using Course_project;
using Course_project.Методы;
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
    public partial class Seen_Dogovor_guest : Form
    {
        public Seen_Dogovor_guest()
        {
            InitializeComponent();
        }

        DataTable dt; 
        BindingSource bs_dog_guest = new BindingSource();
        private void Seen_Dogovor_guest_Load(object sender, EventArgs e)
        {
           
        }


    }
}
