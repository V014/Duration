using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using NAudio.Wave;

namespace Duration
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            styling.styleDataGrid(data_library);
            load_Library(data_library);
        }
 
        private readonly Connection con = new Connection();
        private readonly DataGridStyling styling = new DataGridStyling();

        private int startIndex = 0;
        private int nextRowIndex = 0;
        private int lastPlayedIndex = -1;
        private int row = 0;
        private string[] FileName, FilePath;
        public Boolean playnext = false;
        bool _playing = false;
        
        // check to see if the player is working
        public bool isplaying
        {
            get
            {
                return _playing;
            }
            set
            {
                _playing = value;
                if (_playing)
                {
                    player.Ctlcontrols.pause();
                }
                else
                {
                    player.Ctlcontrols.play(); 
                }
            }
        }
        // when the interface loads
        private void Home_Load(object sender, EventArgs e)
        {
            startIndex = 0;
            playnext = false;
            StopPlayer();
            startIndex = data_library.CurrentCell.RowIndex;

        }
        // stop music method
        public void StopPlayer()
        {
            player.Ctlcontrols.stop();
        }
        // play file method
        public void PlayFile(int PlayListIndex)
        {
            if(list_recent.Items.Count <= 0)
            {
                return;
            }
            if(PlayListIndex < 0)
            {
                return;
            }
            player.settings.autoStart = true;
            player.URL = FilePath[PlayListIndex];
            player.Ctlcontrols.next();
            player.Ctlcontrols.play();
        }
        // browse for music
        private void btn_browse_Click(object sender, EventArgs e)
        {
            try
            {
                startIndex = 0;
                playnext = false;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                ofd.Filter = "mp3 ,wav ,wma,3gp, m4a, flac|*.mp3*;*.wav*;*.3gp*;*.wma*;*.m4a*;*.flac*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // clear previous list
                    list_recent.Items.Clear();
                    FileName = ofd.SafeFileNames;
                    FilePath = ofd.FileNames;

                    foreach (var items in FilePath)
                    {
                        TagLib.File file = TagLib.File.Create(items);
                        list_recent.Items.Add(file.Tag.Title);
                        this.Refresh();
                    }
                    // auto play music
                    startIndex = 0;
                    PlayFile(0);
                    list_recent.SelectedIndex = 0;
                    btn_play.Image = Image.FromFile(@"res/pause.png");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Feature not available!", "Assistant");
            }

        }
        // pull data from database
        public void load_Library(DataGridView datagrid)
        {
            con.LoadData("SELECT id, path, title, artist, album, genre, year FROM library", datagrid);
            datagrid.Columns[0].Visible = false;
            datagrid.Columns[1].Visible = false;
        }
        // hold current selected song from datagrid
        private void data_library_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = data_library.SelectedRows[0];
                string id = selectedRow.Cells[0].Value.ToString();
                string path = con.ReadString($"SELECT path FROM library WHERE ID = '{id}'");
                // obtain audio tag details
                TagLib.File file = TagLib.File.Create(path);
                // tag labels
                lbl_title.Text = file.Tag.Title;
                lbl_genre.Text = file.Tag.Genres[0];
                lbl_album.Text = file.Tag.Album;
                lbl_year.Text = file.Tag.Year.ToString();
                lbl_artist.Text = file.Tag.AlbumArtists[0];
                // tag image
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                image_artwork.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch (Exception)
            {
                // do nothing
            }
        }
        // when user wants to add to library
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
        // when user clicks play
        private void menu_library_play_Click(object sender, EventArgs e)
        {
            // stop the current song
            player.Ctlcontrols.stop();
            playnext = false;

            // retrieve file path from database
            DataGridViewRow selectedRow = data_library.SelectedRows[0];
            string id = selectedRow.Cells[0].Value.ToString();
            string path = con.ReadString($"SELECT path FROM library WHERE ID = '{id}'");

            //clear previous list
            list_recent.Items.Clear();

            TagLib.File file = TagLib.File.Create(path);
            //list_recent.Items.Add(file.Tag.Title);

            this.Text = "Duration | " + file.Tag.Title;

            //int selectedIndex = data_library.SelectedRows[0].Index;
            //PlayNextSong(selectedIndex);

            player.URL = path;
            player.Ctlcontrols.play();

            // change play button styling
            btn_play.Image = Image.FromFile(@"res/pause.png");
            
        }
        // change the volume
        private void volume_ValueChanged(object sender, EventArgs e)
        {
            player.settings.volume = volume.Value;
            lbl_volume.Text = volume.Value.ToString() + "%";
            if (volume.Value > 0)
            {
                btn_volume.Image = Image.FromFile(@"res/audio.png");
            }
            else
            {
                btn_volume.Image = Image.FromFile(@"res/mute.png");
            }
        }
        // progress bar timer
        private void timer_Tick(object sender, EventArgs e)
        {
            if(player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                progressBar.Value = (int)player.Ctlcontrols.currentPosition;
                try
                {
                    lbl_start.Text = player.Ctlcontrols.currentPositionString;
                    lbl_end.Text = player.Ctlcontrols.currentItem.durationString.ToString();
                }
                catch (Exception)
                {

                }
            }
        }
        // hold event action
        public EventHandler onAction = null;
        // method to see what state is the player in 
        public void axWindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // if the player is still playing
            if(player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                timer.Start();
            }
            // if the player is paused
            else if(player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer.Stop();
            }
            // if the player is on stop
            else if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer.Stop();
                progressBar.Value = 0;
                btn_play.Image = Image.FromFile(@"res/play.png");
            }
            // if the song is done playing
            else if (player.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                onAction?.Invoke(this, EventArgs.Empty);
            }
        }
        // universal method that controls both the datagrid and list
        private void PlayNextSong(int index)
        {
            try
            {
                // if the count of rows in the datagrid are more than one and less than the total amount of files
                if(data_library.RowCount > 1 && index < data_library.RowCount - 1)
                {
                    // stop the current song
                    player.Ctlcontrols.stop();
                    playnext = false;
                    startIndex = index;
                    
                    //startIndex = data_library.CurrentCell.RowIndex +1;

                    this.Text = "Duration";

                    // Check if there is a currently selected row
                    if (data_library.SelectedRows.Count > 0)
                    {
                        // Deselect the currently selected row
                        data_library.ClearSelection();
                    }

                    // Get the next row index
                    int nextRowIndex = lastPlayedIndex + 1;

                    // Check if the next row index is within the range of rows in the DataGridView
                    if (nextRowIndex >= 0 && nextRowIndex < data_library.Rows.Count)
                    {
                        // Select the next row
                        DataGridViewRow nextRow = data_library.Rows[nextRowIndex];
                        nextRow.Selected = true;
                        // get selected row
                        DataGridViewRow selectedRow = data_library.SelectedRows[0];
                        string path = selectedRow.Cells[1].Value.ToString();

                        // Get the file path of the selected song from the database
                        // string FilePath = nextRow.Cells["SongFilePath"].Value.ToString();
                        string FilePath = path;

                        // Set the URL property of the axWindowsMediaPlayer control to the file path of the selected song
                        player.URL = FilePath;
                        // Start playing the song
                        player.Ctlcontrols.play();
                        // increment index
                        // Update the index of the last played song
                        lastPlayedIndex = nextRowIndex;
                    }
                    else
                    {
                        // Loop back to the first song in the list
                        // Loop back to the first song in the list
                        data_library.Rows[0].Selected = true;
                        string filePath = data_library.Rows[0].Cells["Path"].Value.ToString();
                        player.URL = filePath;
                        player.Ctlcontrols.play();

                        // Update the index of the last played song
                        lastPlayedIndex = 0;
                    }
                
                    // retrieve file path from database
                    //var FilePath = con.ReadString($"SELECT Path FROM library WHERE id = {startIndex}");
                        

                    // change play button styling
                    btn_play.Image = Image.FromFile(@"res/pause.png");
                } 
                /*
                if (list_recent.Items.Count > 1 && index < list_recent.Items.Count - 1)
                {
                    startIndex = index;
                    list_recent.SelectedIndex = index;
                    PlayFile(startIndex);
                }
                */
            }
            catch (Exception)
            {
                MessageBox.Show("Oops, feature error", "Assistant");
            }
        }
        // user clicks next button
        private void btn_next_Click(object sender, EventArgs e)
        {
            PlayNextSong(startIndex);
        }
        // method to clear the search box
        private void txt_search_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
        }
        // method that controls the volume
        private void btn_volume_Click(object sender, EventArgs e)
        {
            if (player.settings.volume == 0)
            {
                player.settings.volume = volume.Value;
                btn_volume.Image = Image.FromFile(@"res/audio.png");
            }
            else
            {
                player.settings.volume = 0;
                btn_volume.Image = Image.FromFile(@"res/mute.png");
            }
        }
        // when a user is searching for music
        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            int index = list_recent.FindString(txt_search.Text);
            if (0 <= index)
            {
                list_recent.SelectedIndex = index;
            }
        }
        // when a user double clicks a song
        private void List_recent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PlayFile(list_recent.SelectedIndex);
        }
        // when user scrubs progress bar
        private void ProgressBar_Scroll(object sender, ScrollEventArgs e)
        {
            player.Ctlcontrols.currentPosition = progressBar.Value;
        }
        // when the search box looses focus
        private void Txt_search_Leave(object sender, EventArgs e)
        {
            txt_search.Text = "🔎 Search library...";
        }
        // hide or show search depending on size of window
        private void Home_SizeChanged(object sender, EventArgs e)
        {
            if(this.Width < 800)
            {
                panel_search.Visible = false;
                panel_recent.Visible = false;
            }
            if(this.Width < 600)
            {
                panel_nav.Visible = false;
            }
            else if(this.Width > 800)
            {
                panel_search.Visible = true;
                panel_recent.Visible = true;
                panel_nav.Visible = true;
            }
        }
        // when a user deletes a song from the list
        private void Delete_Click(object sender, EventArgs e)
        {
            // retrieve file path from database
            var index = con.ReadString("SELECT `index` FROM session WHERE id = 1");
            // conduct querry
            con.ExecuteQuery($"DELETE FROM library WHERE id = {index}");
            load_Library(data_library);
        }
        // when a user double clicks a song
        private void Data_library_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            menu_library_play_Click(sender, e);
            // display its tags
            data_library_CellClick(sender, e);
        }
        // user clicks image artwork interface
        private void Image_artwork_Click(object sender, EventArgs e)
        {
            if (player.Visible == false)
            {
                player.Visible = true;
            }
            else
            {
                player.Visible = false;
            }
        }
        // user clicks player interface
        private void Player_MouseDownEvent(object sender, AxWMPLib._WMPOCXEvents_MouseDownEvent e)
        {
            if (player.Visible == false)
            {
                player.Visible = true;
            }
            else
            {
                player.Visible = false;
            }
        }
        // user clicks play button
        private void btn_play_Click(object sender, EventArgs e)
        {
            // axWindowsMediaPlayer.Ctlcontrols.play();
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                player.Ctlcontrols.pause();
                btn_play.Image = Image.FromFile(@"res/play.png");
            }
            else
            {
                player.Ctlcontrols.play();
                btn_play.Image = Image.FromFile(@"res/pause.png");
            }
            txt_search.Text = "🔎 Search library...";
        }
        // user clicks previous button
        private void btn_prev_Click(object sender, EventArgs e)
        {
            try
            {
                // changes the current selected item
                if (list_recent.Items.Count >= 0)
                {
                    if (startIndex > 0)
                    {
                        startIndex = startIndex - 1;
                        list_recent.SelectedIndex--;
                    }
                    PlayFile(startIndex);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Oops, feature error", "Assistant");
            }
        }
        // user clicks stop button
        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }
        // when the recent list is changed
        private void list_recent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // obtain audio tag details
                TagLib.File file = TagLib.File.Create(FilePath[list_recent.SelectedIndex]);

                lbl_title.Text = list_recent.Text;
                lbl_genre.Text = file.Tag.Genres[0];
                lbl_album.Text = file.Tag.Album;
                lbl_year.Text = file.Tag.Year.ToString();
                lbl_artist.Text = file.Tag.AlbumArtists[0];

                //lbl_title_mini.Text = list_recent.Text;
                //lbl_artist_mini.Text = file.Tag.AlbumArtists[0];

                var i = TagLib.File.Create(FilePath[list_recent.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);

                image_artwork.Image = Image.FromStream(new MemoryStream(bin));
                //image_mini.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch (Exception)
            {
                image_artwork.Image = Image.FromFile(@"res/music.png");

                lbl_artist.Text = "Artist : Unknown";
                lbl_genre.Text = "Genre : Unknown";
                lbl_year.Text = "Year : Unknown";

            }
        }
    }
}
