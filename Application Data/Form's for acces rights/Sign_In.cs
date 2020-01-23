using Course_project;
using Course_project.Методы;
using course1._0.Application_Data.Form_s_for_acces_rights;
using course1._0.Application_Data.Functional;
using course1._0.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace course1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(BindingSource bs_Dol)
        {
            InitializeComponent();
            this.bs_Dol = bs_Dol;
        }

        DataTable dt, dtQuery;
        BindingSource bs_Dol;

        //Notification logout
        public NotifyIcon I_N = new NotifyIcon();
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrWhiteSpace(text_password.Text))
            {
                dtQuery = DB.LoadTable($"SELECT * FROM Login  WHERE Access_rights like '{combo_login.Text}' and Password = {text_password.Text}", "LoginQuery");

                if (dtQuery.Rows.Count == 0) //т.е. если не нашел совпадающего по логину и паролю в Table будет 0 строк
                {
                    text_password.BackColor = System.Drawing.Color.Red;
                    if (MessageBox.Show("Повторите попытку входа!") == DialogResult.OK)
                    {
                        text_password.BackColor = DefaultBackColor;
                        text_password.Clear();
                    }
                }
                else
                {
                    if (combo_login.Text == "Adm")
                    {
                        #region
                        //Notification
                        I_N.BalloonTipText = $"Вход успешно выполнен!\n Вход произведен под правами - {combo_login.Text}";
                        I_N.BalloonTipTitle = "Добро пожаловать!";
                        I_N.BalloonTipIcon = ToolTipIcon.Info;
                        I_N.Icon = this.Icon;
                        I_N.Visible = true;
                        I_N.ShowBalloonTip(1000);
                        #endregion
                        Adm admin = new Adm();
                        admin.ShowDialog();
                        this.Close();
                    }
                    else if (combo_login.Text == "Curator")
                    {
                        #region
                        //Notification
                        I_N.BalloonTipText = $"Вход успешно выполнен!\n Вход произведен под правами - {combo_login.Text}";
                        I_N.BalloonTipTitle = "Добро пожаловать!";
                        I_N.BalloonTipIcon = ToolTipIcon.Info;
                        I_N.Icon = this.Icon;
                        I_N.Visible = true;
                        I_N.ShowBalloonTip(1000);
                        #endregion
                        Curator curator = new Curator(bs_Dol);
                        curator.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        #region
                        //Notification
                        I_N.BalloonTipText = $"Вход успешно выполнен!\n Вход произведен под правами - {combo_login.Text}";
                        I_N.BalloonTipTitle = "Добро пожаловать!";
                        I_N.BalloonTipIcon = ToolTipIcon.Info;
                        I_N.Icon = this.Icon;
                        I_N.Visible = true;
                        I_N.ShowBalloonTip(1000);
                        #endregion
                        Guest guest = new Guest();
                        guest.ShowDialog();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Проверьте правильность введенного пароля!");
            }
        }

       
        private void LinkLabel_Registration_Click(object sender, EventArgs e)
        {
            Add_user add_usr = new Add_user();
            add_usr.Show();
        }

        private void LinkLabel_Help_in_signing_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" < Coming Soon /> ", "Обновление уже готовится....");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //* in password
            text_password.UseSystemPasswordChar = true;

            ToolTip tip = new ToolTip();
            tip.Active.ToString();
            tip.BackColor = System.Drawing.Color.BlueViolet;
            tip.SetToolTip(text_password, "Обязательное поле для ввода!");

            BindingSource bs_login = new BindingSource();
            bs_login.DataSource = dt;
            dt = DB.LoadTable("SELECT Login.ID_rights as aa, Login.Access_rights as bb FROM Login", "Login");
            
            QuicklyChangeDB.ComboSettings(dt, "Access_rights", "ID_rights", combo_login);
        }
    }
}
