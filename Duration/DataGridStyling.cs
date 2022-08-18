using System.Drawing;
using System.Windows.Forms;

namespace Duration
{
    class DataGridStyling
    {
        // styling of the datagrid
        public void styleDataGrid(DataGridView dataGrid)
        {
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.RowHeadersVisible = false;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            // dataGrid.RowHeadersWidth = 30;
            dataGrid.ColumnHeadersHeight = 50;

            dataGrid.BackgroundColor = Color.FromArgb(17,17,17);
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(17, 17, 17);
            dataGrid.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            dataGrid.RowsDefaultCellStyle.BackColor = Color.FromArgb(17, 17, 17);
            dataGrid.RowsDefaultCellStyle.ForeColor = Color.White;
            // dataGrid.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);

            dataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGrid.DefaultCellStyle.Font = new Font("Roboto", 9);
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 12);
            dataGrid.AlternatingRowsDefaultCellStyle.Font = new Font("Roboto", 9);
        }
    }
}
