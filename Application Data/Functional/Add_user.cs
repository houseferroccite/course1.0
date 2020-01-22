using Course_project.Method_s_for_quicly_use_DB;
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
    public partial class Add_user : Form
    {
        public Add_user()
        {
            InitializeComponent();
        }
        public Add_user(BindingSource bs_login)
        {
            InitializeComponent();
        }
        ToolTip mess = new ToolTip();
        private void button_add_user_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(text_Add_password.Text))
            {
                label_Ж_red.ForeColor = Color.Red;
                mess.Show("Обязательное поле заполнения!",text_Add_password);
            }
            try
            {
                dbHelper.Insert_Login(text_Add_login.Text,int.Parse(text_Add_password.Text));
            }
            catch
            {
                MessageBox.Show("Произошла ошибка, Входная строка имела неверный формат.", "Ошибка", buttons: MessageBoxButtons.OK);
            }
         
        }

        private void Check_see_password_CheckedChanged(object sender, EventArgs e)
        {
            if (check_see_password.Checked)
            {
                text_Add_password.UseSystemPasswordChar = false;
            }
            else
            {
                text_Add_password.UseSystemPasswordChar = true;
            }
        }

        private void Add_user_Load(object sender, EventArgs e)
        {
            
        }
    }
}
