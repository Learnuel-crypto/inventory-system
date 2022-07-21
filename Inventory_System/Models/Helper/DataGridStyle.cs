using System.Drawing;
using System.Windows.Forms;

namespace Inventory_System.Model
{
    /// <summary>
    /// handle all logic for datagridview design
    /// </summary>
     static  class DataGridStyle 
    { 
        /// <summary>
        /// Style DataGridView
        /// </summary>
        /// <param name="dgv"></param>
            public static void StyleDatagridview(DataGridView dgv)

            {
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
                dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dgv.BackgroundColor = Color.White;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.Font=new Font("Segoe UI", 10, FontStyle.Regular);
                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.RowHeadersWidth = 20;

            }
        /// <summary>
        /// Fixed size display
        /// </summary>
        /// <param name="dgv"></param>
        public static void StyleDatagridviewFixed(DataGridView dgv)

        {
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv.BackgroundColor = Color.White;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        /// <summary>
        /// Change the row color of the datagridview
        /// </summary>
        /// <param name="dgv"></param>
        public static void StyleRowColor(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[7].Value.ToString() == "Returned")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                if (row.Cells[7].Value.ToString() == "Sold")
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                if (row.Cells[6].Value.ToString() == "Cheque")
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }
    }
}
