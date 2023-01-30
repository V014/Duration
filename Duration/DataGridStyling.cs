using System.Drawing;
using System.Windows.Forms;

namespace Duration
{
    class DataGridStyling
    {
        // styling of the datagrid
        public void styleDataGrid(DataGridView dataGrid)
        {
            dataGrid.BackgroundColor = Color.FromArgb(17, 17, 17);
            // alternating body background
            dataGrid.AlternatingRowsDefaultCellStyle.Font = new Font("Roboto", 9);
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(17, 17, 17);
            dataGrid.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            // default body background
            dataGrid.RowsDefaultCellStyle.BackColor = Color.FromArgb(24, 24, 24);
            dataGrid.RowsDefaultCellStyle.ForeColor = Color.White;
            dataGrid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(254, 178, 0);
            dataGrid.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(17, 17, 17);
            // header
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 24, 24);
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(24, 24, 24);
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 12);

            dataGrid.DefaultCellStyle.Font = new Font("Roboto", 9);
            dataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            
            
        }
    }
}
