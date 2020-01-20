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

        private void Inform_Load(object sender, EventArgs e)
        {
            QuicklyChangeDB.TextBox(bs_Client, "ФИО", text_fio);
            QuicklyChangeDB.TextBox(bs_Client, "Адрес", text_adres);
            QuicklyChangeDB.TextBox(bs_Client, "Реквизиты банка", text_rec);

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

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}

