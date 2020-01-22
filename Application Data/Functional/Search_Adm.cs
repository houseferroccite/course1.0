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
            //using (myCreatePO_projectEntities context = new myCreatePO_projectEntities())
            //{
            //    var q = from z in context.Т_Клиент.Include(combo_criterion.Text)
            //            where z.ФИО.StartsWith(textBox_search.Text)
            //            select z;
            //    grid_search_adm.DataSource = q.ToList();
            //}
        }
        
        
        private void Search_Adm_Load(object sender, EventArgs e)
        {
            bindingNavigator1.Visible = false;

            //Запрос для вытягивания списка таблиц
            dtQuery = DB.LoadTable($"select TABLE_NAME  from INFORMATION_SCHEMA.TABLES", "Load_all_tables");
        }

        private void Combo_objectSearch_TextChanged(object sender, EventArgs e)
        {
            //combo_criterion.Items.Clear();
            //string s = "Model1.edmx" + combo_criterion.Text;
            //Type x = Type.GetType(s);
            //PropertyInfo[] prop = x.GetProperties();
            //string[] g = (from z in prop
            //              select z.Name).ToArray();
            //combo_criterion.Items.AddRange(g);
        }

        private void Button_start_serach_Click(object sender, EventArgs e)
        {
            //Заполнение combobox списком таблиц
            QuicklyChangeDB.ComboSettings(dtQuery, "TABLE_NAME", "TABLE_NAME", combo_objectSearch);

            rich.Text += " -----> " + combo_objectSearch.Text.ToString();
            ////dt = DB.LoadTable($"select * from {combo_obj}", combo_obj.ToString());
            //grid_search_adm.DataSource = dt;
        }
        string s = "";
        private void Combo_objectSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            s = combo_objectSearch.Text;
            //rich.Text = $" bs_all.DataSource = DB.ds.Tables[$"{ s} "]";
            try{
                
                dt = DB.LoadTable($"select * from {s}", s);
                QuicklyChangeDB.ComboSettings(dt, $"{s}", $"{s}", combo_criterion);
                combo_criterion.Items.Clear();
            }
            catch
            {
                MessageBox.Show($" bs_all.DataSource = DB.ds.Tables[${ s}];");
            }
        }
    }
}
