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
    public partial class Search_Adm : Form
    {
        public Search_Adm()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            using (myCreatePO_projectEntities2 context = new myCreatePO_projectEntities2())
            {
                var q = from z in context.Т_Клиент.Include(combo_criterion.Text)
                        where z.ФИО.StartsWith(textBox_search.Text)
                        select z;
                grid_search_adm.DataSource = q.ToList();
            }
        }
    }
}
