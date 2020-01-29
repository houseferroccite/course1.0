using Course_project;
using Course_project.Method_s_for_quicly_use_DB;
using Course_project.Method_s_for_settings_GridView;
using Course_project.Методы;
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

namespace course1._0.Forms
{
    public partial class Inform : Form
    {
        public Inform()
        {
            InitializeComponent();
        }

        public Inform(BindingSource bs_Client)
        {
            InitializeComponent();
            this.bs_Client = bs_Client;
        }
        BindingSource bs_Client = new BindingSource();
        bool flag = false;
        DataTable dt;
        private void Inform_Load(object sender, EventArgs e)
        {
            GridViewStyles.ChancheViewGrid(grid_KL_DOG);
            grid_KL_DOG.Visible = false;
            QuicklyChangeDB.TextBox(bs_Client, "ФИО", text_fio);
            QuicklyChangeDB.TextBox(bs_Client, "Адрес", text_adres);
            QuicklyChangeDB.TextBox(bs_Client, "Реквизиты банка", text_rec);
            QuicklyChangeDB.TextBox(bs_Client, "ID_Клиента", textBox_KL);
            QuicklyChangeDB.Picturebox("Image", pic_client, bs_Client, "Фото", true);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bs_Client.AddNew();
            flag = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (flag)
            {
                int id0 = dbHelper.InsertClient(text_fio.Text, text_adres.Text, text_rec.Text, pic_client.ImageLocation);
                flag = false;
            }
            else
            {
                DataRowView drCl = (DataRowView)bs_Client.Current;
                id = (int)drCl["ID_Клиента"];
                dbHelper.UpdateClient(text_fio.Text, id, text_adres.Text, text_rec.Text, pic_client.ImageLocation);
            }
        }

        private void pic_client_DoubleClick(object sender, EventArgs e)
        {
            //Подгрузка нового изображения
            //Настройка
            ToolTip tip = new ToolTip();
            tip.Active.ToString();
            tip.SetToolTip(pic_client, "Для выбора изображения, щелкните по области....");
            //Открытие
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Изображение(*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png|Все файлы (*.*)|*.*";
            string fileName = "";

            if (dialog.ShowDialog() == DialogResult.OK) fileName = dialog.FileName;
            pic_client.ImageLocation = fileName;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите закрыть программу?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Radio_Visible_Dog_grid_CheckedChanged(object sender, EventArgs e)
        {
            if(radio_Visible_Dog_grid.Checked == true)
            {
                grid_KL_DOG.Visible = true;
                dt = DB.UpdateTable($"SELECT Т_Договора.Название_договора, Т_Договора.[Дата составления], Т_Договора.Примечание FROM Т_Клиент INNER JOIN Т_Договора ON Т_Клиент.ID_Клиента = Т_Договора.ФИО_Клиента WHERE(((Т_Договора.ФИО_Клиента) = {int.Parse(textBox_KL.Text)} ))", "T_KL");/*{int.Parse(textBox_KL_ID.Text)}*/
                grid_KL_DOG.DataSource = dt;
            }
        }

        private void RadioButton_not_visible_grid_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_not_visible_grid.Checked == true)
            {
                grid_KL_DOG.Visible = false;
            }
        }
    }
}

