using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_project.Методы
{
     static class QuicklyChangeDB
    {

        /// <summary>
        /// Grid Columns Visible
        /// </summary>
        /// <param name="columnNames"></param>
        /// <param name="grid"></param>
        public static void GridVisible(string[] columnNames, System.Windows.Forms.DataGridView grid)
        {
            foreach (var z in columnNames)
            {
                grid.Columns[z].Visible = false;
            }
            
        }
        /// <summary>
        /// Load TextBox
        /// </summary>
        /// <param name="bs"></param>
        /// <param name="field"></param>
        /// <param name="tb"></param>
        public static void TextBox(BindingSource bs, string field,TextBox tb)
        {
            tb.DataBindings.Add("Text", bs, field, true);
        }

        /// <summary>
        /// Settings combobox 
        /// </summary>
        /// <param name="table">прописывается: ds.Tables["НазваниеТаблицы"]</param>
        /// <param name="displayField"></param>
        /// <param name="valueField"></param>
        /// <param name="combo"></param>
        public static void ComboSettings(DataTable table, string displayField, string valueField, ComboBox combo)
        {
            combo.DataSource = table;
            combo.DisplayMember = displayField;
            combo.ValueMember = valueField;
        }
        /// <summary>
        /// Setting combobox
        /// </summary>
        /// <param name="bs"></param>
        /// <param name="displayField"></param>
        /// <param name="valueField"></param>
        /// <param name="combo"></param>
        public static void ComboSettings(BindingSource bs, string displayField, string valueField, ComboBox combo)
        {
                combo.DataSource = bs;
                combo.DisplayMember = displayField;
                combo.ValueMember = valueField;

               
        }
        public static void ComboSettings(BindingSource bs, string displayField, string valueField, ComboBox combo, DataTable dt, string field)
        {
            combo.DataSource = bs;
            combo.DisplayMember = displayField;
            combo.ValueMember = valueField;
            combo.DataBindings.Add("SelectedValue", dt, field, true);
        }
        /// <summary>
        /// PictureBox load
        /// </summary>
        /// <param name="PropertyName"></param>
        /// <param name="bs"></param>
        /// <param name="DataMember"></param>
        public static void Picturebox(string PropertyName,PictureBox pb ,BindingSource bs,string DataMember, bool formattingEnabled)
        {

            pb.DataBindings.Add(PropertyName, bs, DataMember,true);
        }
    }
}
