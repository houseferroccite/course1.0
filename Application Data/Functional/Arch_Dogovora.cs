using Course_project;
using Course_project.Method_s_for_settings_GridView;
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
    public partial class Arch_Dogovora : Form
    {
        public Arch_Dogovora()
        {
            InitializeComponent();
        }
        DataTable dt;
        BindingSource bs_dd =  new BindingSource();
        DataGridViewButtonColumn Archh;
        private void Arch_Dogovora_Load(object sender, EventArgs e)
        {
            GridViewStyles.ButtonGrid("Edit", "Сдача в архив", "Корректировать", grid_Arch_Status, Archh);
            GridViewStyles.ChancheViewGrid(grid_Arch_Status);

            bs_dd.DataSource =  DB.LoadTable($"SELECT Т_Договора.[№_Договора], Т_Договора.Название_договора, Т_Договора.[Дата составления], Т_Договора.Примечание FROM Т_Кураторы INNER JOIN Т_Договора ON Т_Кураторы.ID_Куратора = Т_Договора.Куратор_проекта", "T_Seen_Dogg");

            grid_Arch_Status.DataSource = bs_dd;
        }

        private void Grid_Arch_Status_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_Arch_Status.Columns[e.ColumnIndex].Name == "Edit")
            {
                Add_Dogovora_EditStep add_dog = new Add_Dogovora_EditStep(bs_dd);

                add_dog.ShowDialog();
            }
            
        }
    }
}
