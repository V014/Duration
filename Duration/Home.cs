using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Duration
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        // Songs songs = new Songs();
        public int startIndex = 0;
        string[] FileName, FilePath;
        public Boolean playnext = false;

        bool _playing = false;
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
        void loadNowPlaying()
        {
            this.panel_main.Controls.Clear();
            this.panel_main.Controls.Add(panel_nowPlaying);
            panel_nowPlaying.Dock = DockStyle.Fill;
            panel_nowPlaying.AutoSize = true;
            panel_nowPlaying.Show();
        }
        // stop music method
        public void StopPlayer()
        {
            player.Ctlcontrols.stop();
        }
        // play file method
        public void PlayFile(int PLayListIndex)
        {
            if(list_recent.Items.Count <= 0)
            {
                return;
            }
            if(PLayListIndex < 0)
            {
                return;
            }
            player.settings.autoStart = true;
            player.URL = FilePath[PLayListIndex];
            // axWindowsMediaPlayer.Ctlcontrols.next();
            // axWindowsMediaPlayer.Ctlcontrols.play();
        }
        // change song when selected from list
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TagLib.File file = TagLib.File.Create(FilePath[list_recent.SelectedIndex]);
            startIndex = list_recent.SelectedIndex;
            PlayFile(startIndex);
           
            try
            {
                lbl_title.Text = "Title : " + list_recent.Text;
                lbl_title_mini.Text = list_recent.Text;
                lbl_album.Text = "Album : " + file.Tag.Album;
                lbl_year.Text = "Year : " + file.Tag.Year;
                lbl_artist.Text = "Artist : " + file.Tag.AlbumArtists[0];
                lbl_artist_mini.Text = file.Tag.AlbumArtists[0];
                lbl_genre.Text = "Genre : " + file.Tag.Genres[0];

                try
                {
                    con.ExecuteQuery($"INSERT INTO library (path, title, album, year, artist, genre) VALUES('{FilePath[list_recent.SelectedIndex]}','{list_recent.Text}','{file.Tag.Album}','{file.Tag.Year}','{ file.Tag.AlbumArtists[0]}','{file.Tag.Genres[0]}')");
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }                

                var i = TagLib.File.Create(FilePath[list_recent.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                image_artwork.Image = Image.FromStream(new MemoryStream(bin));
                image_mini.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch (Exception)
            {
                image_artwork.Image = Image.FromFile(@"res/music.png");
                lbl_artist.Text = "Artist : Unknown";
                lbl_genre.Text = "Genre : Unknown";
                lbl_year.Text = "Year : Unknown";
            }
        }
        // browse for music
        private void btn_browse_Click(object sender, EventArgs e)
        {
            startIndex = 0;
            playnext = false;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "mp3 ,wav ,wmv ,3gp, m4a|*.mp3*;*.wav*;*.3gp*;*.wmv*;*.m4a*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                FileName = ofd.SafeFileNames;
                FilePath = ofd.FileNames;

                foreach(var items in FilePath)
                {
                    TagLib.File file = TagLib.File.Create(items);
                    list_recent.Items.Add(file.Tag.Title);
                    this.Refresh();
                }

                startIndex = 0;
                PlayFile(0);
                list_recent.SelectedIndex = 0;
                btn_play.Image = Image.FromFile(@"res/pause.png");
            }
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
        private void axWindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if(player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                timer.Start();
                lbl_details.Text = "Now Playing";
                btn_play.FlatAppearance.MouseOverBackColor = Color.Crimson;
            }
            else if(player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer.Stop();
                lbl_details.Text = "On Pause";
                btn_play.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            }
            else if(player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer.Stop();
                progressBar.Value = 0;
                lbl_details.Text = "On Stop";
                btn_play.Image = Image.FromFile(@"res/stop.png");
                btn_play.FlatAppearance.MouseOverBackColor = Color.Orange;
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
        private void btn_mini_recent_Click(object sender, EventArgs e)
        {
            if(list_recent.Visible == true)
            {
                list_recent.Visible = false;
                btn_extra.Visible = true;
                btn_about.Visible = true;
                btn_visualize.Visible = true;
            }
            else
            {
                list_recent.Visible = true;
                btn_extra.Visible = false;
                btn_about.Visible = false;
                btn_visualize.Visible = false;
            }
        }

        private void btn_mini_library_Click(object sender, EventArgs e)
        {

        }

        private void btn_visualize_Click(object sender, EventArgs e)
        {
            if (player.Visible == Visible)
            {
                player.Visible = false;
            }
            else
            {
                player.Visible = true;
            }
        }

        private void btn_library_Click(object sender, EventArgs e)
        {
            this.panel_main.Controls.Clear();
            Library library = new Library();
            this.panel_main.Controls.Add(library);
            library.Dock = DockStyle.Fill;
            library.Show();
            lbl_title_mini.Visible = true;
            lbl_artist_mini.Visible = true;
            image_mini.Visible = true;
        }

        private void btn_nowPlaying_Click(object sender, EventArgs e)
        {
            loadNowPlaying();
            lbl_title_mini.Visible = false;
            lbl_artist_mini.Visible = false;
            image_mini.Visible = false;
        }

        // play next track
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (startIndex == list_recent.Items.Count - 1)
            {
                startIndex = list_recent.Items.Count - 1;
            }
            else if (startIndex < list_recent.Items.Count)
            {
                startIndex = startIndex + 1;
            }
            // fuction crashing
            list_recent.SelectedIndex ++;
            PlayFile(startIndex);
        }
    }
}
