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
        //Library library = new Library();
        // Songs songs = new Songs();
        public int startIndex = 0;
        string[] FileName, FilePath;
        public Boolean playnext = false;
        //private int OldFocusedIndex = 0;
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
        // hold current selected song
        private void data_library_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // get id
                DataGridViewRow row = data_library.Rows[e.RowIndex];
                var id = int.Parse(row.Cells[0].Value.ToString());
                var path = con.ReadString($"SELECT path FROM library WHERE id = {id}");
                // pass id to database
                con.ExecuteQuery($"UPDATE session SET `index` = {id}, selectedFilePath = '{path}' WHERE id = 1");

                // obtain audio tag details
                TagLib.File file = TagLib.File.Create(path);

                lbl_title.Text = file.Tag.Title;
                lbl_genre.Text = file.Tag.Genres[0];
                lbl_album.Text = file.Tag.Album;
                lbl_year.Text = file.Tag.Year.ToString();
                lbl_artist.Text = file.Tag.AlbumArtists[0];

                var i = TagLib.File.Create(path);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);

                image_artwork.Image = Image.FromStream(new MemoryStream(bin));

            }
            catch (Exception x)
            {
                // MessageBox.Show(x.ToString());
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
            var FilePath = con.ReadString("SELECT selectedFilePath FROM session WHERE id = 1");
            // clear previous list
            list_recent.Items.Clear();
            TagLib.File file = TagLib.File.Create(FilePath);
            list_recent.Items.Add(file.Tag.Title);

            this.Text = "Duration | " + file.Tag.Title;

            player.URL = FilePath;
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
        // hold event action
        public EventHandler onAction = null;
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
        // play previous track
        private void btn_prev_Click(object sender, EventArgs e)
        {
            if(startIndex > 0)
            {
                startIndex = startIndex - 1;
                list_recent.SelectedIndex --;
            }
            PlayFile(startIndex);
        }
        // play next track
        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                if (startIndex == list_recent.Items.Count - 1)
                {
                    startIndex = list_recent.Items.Count - 1;
                }
                else if (startIndex < list_recent.Items.Count)
                {
                    startIndex = startIndex + 1;
                }
                list_recent.SelectedIndex++;
                PlayFile(startIndex);
            }
            catch (Exception)
            {

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
        // method to see what state is the player in 
        public void axWindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // if the player is still playing
            if(player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                timer.Start();
                //lbl_details.Text = "Now Playing";
            }
            // if the player is paused
            else if(player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer.Stop();
                //lbl_details.Text = "On Pause";
            }
            // if the player is on stop
            else if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer.Stop();
                progressBar.Value = 0;
                //lbl_details.Text = "On Stop";
                btn_play.Image = Image.FromFile(@"res/stop.png");
            }
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
            // the song
            menu_library_play_Click(sender, e);
            // display its tags
            data_library_CellClick(sender, e);
        }
        // when the recents list is clicked
        private void List_recent_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in list_recent.Items)
                {
                    item.BackColor = Color.FromArgb(254, 178, 0);

                }
            }
            catch (Exception)
            {

            }
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
