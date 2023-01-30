using System.Drawing;
using System.Windows.Forms;

namespace Duration
{
    class DataGridStyling
    {
        // styling of the datagrid
        public void styleDataGrid(DataGridView dataGrid)
        {
            dataGrid.BackgroundColor = Color.FromArgb(34, 39, 46);
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(34, 39, 46);
            dataGrid.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(173, 186, 199);

            dataGrid.RowsDefaultCellStyle.BackColor = Color.FromArgb(34, 39, 46);
            dataGrid.RowsDefaultCellStyle.ForeColor = Color.FromArgb(173, 186, 199);
            dataGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(34, 39, 46);

            dataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 39, 46);
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(173, 186, 199);

            dataGrid.DefaultCellStyle.Font = new Font("Roboto", 9);
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 12);
            dataGrid.AlternatingRowsDefaultCellStyle.Font = new Font("Roboto", 9);
        }
    }
}
