using System;
using System.Drawing;
using System.Windows.Forms;

namespace Duration
{
    public partial class Library : UserControl
    {
        Connection con = new Connection();
        DataGridStyling styling = new DataGridStyling();
        public int startIndex = 0;
        public Boolean playnext = false;
        string[] FileName, FilePath;

        // Home home = new Home();
        public Library()
        {
            InitializeComponent();
            styling.styleDataGrid(data_library);
            load_Library(data_library);
        }
        // pull data from database
        public void load_Library(DataGridView datagrid)
        {
            con.LoadData("SELECT id, path, title, artist, album, year, genre, date FROM library", datagrid);
            datagrid.Columns[0].Visible = false;
            datagrid.Columns[1].Visible = false;
        }
        // hold current selected song
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

        private void Menu_library_add_Click(object sender, EventArgs e)
        {
            try
            {
                startIndex = 0;
                playnext = false;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                ofd.Filter = "mp3 ,wav ,wma ,3gp, m4a, flac|*.mp3*;*.wav*;*.3gp*;*.wma*;*.m4a*;*.flac*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileName = ofd.SafeFileNames;
                    FilePath = ofd.FileNames;

                    foreach (var items in FilePath)
                    {
                        TagLib.File file = TagLib.File.Create(items);
                        // list_recent.Items.Add(file.Tag.Title);
                        con.ExecuteQuery($"INSERT INTO library (path, title, album, year, artist, genre) VALUES('{items}','{file.Tag.Title}','{file.Tag.Album}','{file.Tag.Year}','{ file.Tag.AlbumArtists[0]}','{file.Tag.Genres[0]}')");
                        load_Library(data_library);
                        // this.Refresh();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Feature not available!", "Assistant");
            }
        }

        // when selecting a track from the library

        private void menu_library_play_Click(object sender, EventArgs e)
        {
            /*
            // stop the current song
            player.Ctlcontrols.stop();
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
            */
        }
        
    }
}
