using System;
using System.Drawing;
using System.Windows.Forms;

namespace Duration
{
    public partial class Library : UserControl
    {
        Connection con = new Connection();
        DataGridStyling styling = new DataGridStyling();
        // Home home = new Home();
        public Library()
        {
            InitializeComponent();
            styling.styleDataGrid(data_library);
            loadLibrary(data_library);
        }
        public void loadLibrary(DataGridView datagrid)
        {
            con.LoadData("SELECT id, path, title, artist, album, year, genre, date FROM library", datagrid);
            datagrid.Columns[0].Visible = false;
            datagrid.Columns[1].Visible = false;
        }

        private void data_library_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // get id
                DataGridViewRow row = data_library.Rows[e.RowIndex];
                var path = con.ReadString($"SELECT path FROM library WHERE id = {int.Parse(row.Cells[0].Value.ToString())}");
                // pass id to database
                con.ExecuteQuery($"UPDATE session SET selectedFilePath = '{path}' WHERE id = 1");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to select!");
            }
        }
        // when selecting a track from the library
        private void menu_library_play_Click(object sender, EventArgs e)
        {
            // stop the current song
            home.player.Ctlcontrols.stop();
            home.startIndex = 0;
            home.playnext = false;
            // retrieve file path
            var FilePath = con.ReadString("SELECT selectedFilePath FROM session WHERE id = 1");
            // search for the new song
            TagLib.File file = TagLib.File.Create(FilePath);
            home.list_recent.Items.Add(file.Tag.Title);
            home.Refresh();
            // play the new song
            home.player.URL = FilePath;
            // refresh list?
            home.list_recent.Refresh();
            home.btn_play.Image = Image.FromFile(@"res/pause.png");
        }
    }
}
