using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_project.Method_s_for_settings_GridView
{
    static  class GridViewStyles
    {
        public static void ChancheViewGrid(DataGridView grid)
        {
           
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;

            //Color grid
            grid.BackgroundColor = Color.White;

            //Auto size info  
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Only read
            grid.ReadOnly = true;

            grid.RowHeadersVisible = false;

            grid.AllowUserToAddRows = false;


        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="HeaderText"></param>
        /// <param name="textbutton"></param>
        /// <param name="grid"></param>
        public static void ButtonGrid(string Name, string HeaderText, string textbutton,DataGridView grid,DataGridViewButtonColumn dv)
        {
            if (!grid.Columns.Contains(Name))
            {
                dv = new DataGridViewButtonColumn();
                dv.Name = Name;
                dv.HeaderText = HeaderText;
                dv.Text = textbutton;
                dv.UseColumnTextForButtonValue = true;
                grid.Columns.Add(dv);
            }
        }
        public static void ButtonGrid_Remove(string Name, string HeaderText, string textbutton, DataGridView grid)
        {
            if (!grid.Columns.Contains(Name))
            {
                DataGridViewButtonColumn dv = new DataGridViewButtonColumn();
                dv.Name = Name;
                dv.HeaderText = HeaderText;
                dv.Text = textbutton;
                dv.UseColumnTextForButtonValue = true;
                grid.Columns.Remove(dv);
            }
        }
        /// <summary>
        /// Метод для очистки grid
        /// </summary>
        /// <param name="grid"></param>
        
    }
}
