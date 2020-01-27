using Course_project;
using Course_project.Методы;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        BindingSource bs_all;
        DataTable dt,dtQuery;
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
            using (myCreatePO_projectEntities context = new myCreatePO_projectEntities())
            {
                var q = from z in context.Т_Клиент.Include(combo_criterion.Text)
                        where z.ФИО.StartsWith(textBox_search.Text)
                        select z;
                grid_search_adm.DataSource = q.ToList();
            }
        }
        private void Search_Adm_Load(object sender, EventArgs e)
        {
            bindingNavigator1.Visible = false;

            //Запрос для вытягивания списка таблиц
            dtQuery = DB.LoadTable($"select TABLE_NAME  from INFORMATION_SCHEMA.TABLES", "Load_all_tables");
            //Заполнение combobox списком таблиц
            QuicklyChangeDB.ComboSettings(dtQuery, "TABLE_NAME", "TABLE_NAME", combo_objectSearch);
        }

        string s = "";
        private void Combo_objectSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            s = combo_objectSearch.Text;
            combo_criterion.Items.Clear();
            //rich.Text = $" bs_all.DataSource = DB.ds.Tables[$"{ s} "]";
            try
            { 
                dt = DB.LoadTable($"select * from {s}", s);
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    combo_criterion.Items.Add(dt.Columns[i].ColumnName);
                }
            }
            catch
            {
                
            }
        }
    }
}
