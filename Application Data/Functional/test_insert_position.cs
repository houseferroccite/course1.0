using Course_project.Method_s_for_quicly_use_DB;
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

namespace course1._0.Forms
{
    public partial class test_insert_position : Form
    {
        public test_insert_position()
        {
            InitializeComponent();
        }
        public test_insert_position(BindingSource bs_position)
        {
            InitializeComponent();
            this.bs_position = bs_position;
        }
        BindingSource bs_position = new BindingSource();
        bool flag = false;
        private void test_insert_position_Load(object sender, EventArgs e)
        {
            QuicklyChangeDB.TextBox(bs_position, "Должность", text_insert_posisiton);
        }

        private void button_Addnew_Click(object sender, EventArgs e)
        {
            bs_position.AddNew();
            flag = true;
            
        }
        Т_Должность z = new Т_Должность();
        private void button_save_Click(object sender, EventArgs e)
        {
            
            if (flag)
            {
                using (myCreatePO_projectEntities context = new myCreatePO_projectEntities())
                {
                    z.Должность = text_insert_posisiton.Text;
                    //форма открыта как новая запись
                    if (context.Т_Должность.FirstOrDefault(x => x.Должность == z.Должность) != null)
                    {
                        MessageBox.Show("Указанная должность есть в БД !", "Проверка данных...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    context.Т_Должность.Add(z);
                    context.SaveChanges();
                    var q = from z in context.Т_Должность select new { z.Должность, z.ID_Должности };
                }
                //int id0 = dbHelper.inserPosition(text_insert_posisiton.Text);
                flag = false;
            }
#region    else
            {
                //DataRowView drPosition = (DataRowView)bs_position.Current;
                //id = (int)drPosition["ID_Должности"];
                //dbHelper.UpdatePosition(text_insert_posisiton.Text, id);
                //    this.Close();
            }
            #endregion
        }
    }
}
