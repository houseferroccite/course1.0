using Course_project.Method_s_for_quicly_use_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if(text_Add_password.Text == text_Add_password_replace.Text)
            {
                button_add_user.Enabled = true;
            }
            else
            {
                MessageBox.Show("Произошла ошибка, пароли не совпадают.", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            if (String.IsNullOrEmpty(text_Add_password.Text))
            {
                label_Ж_red.ForeColor = Color.Red;
                label_ж_red1.ForeColor = Color.Red;
                MessageBox.Show("Обязательное поле для заполнения.", "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            try
            {
                dbHelper.Insert_Login(text_Add_login.Text,int.Parse(text_Add_password.Text));
            }
            catch
            {
                MessageBox.Show("Произошла ошибка, Входная строка имела неверный формат.", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
         
        }

        private void Check_see_password_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Add_user_Load(object sender, EventArgs e)
        {
            button_add_user.Enabled = false;
        }

        private void Text_Add_password_TextChanged(object sender, EventArgs e)
        {
            Regex.IsMatch(text_Add_password.Text, @"^(?:\d()|[A-Za-z]()){8,}\1\2$");
        }

        private void Text_Add_password_replace_TextChanged(object sender, EventArgs e)
        {
            Regex.IsMatch(text_Add_password_replace.Text, @"^(?:\d()|[A-Za-z]()){8,}\1\2$");
        }
    }
}
