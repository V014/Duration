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
        }

        //private IWavePlayer wavePlayer = new WaveOutEvent();
        

        private readonly Connection con = new Connection();
        private readonly DataGridStyling styling = new DataGridStyling();
        //Library library = new Library();
        // Songs songs = new Songs();
        public int startIndex = 0;
        string[] FileName, FilePath;
        public Boolean playnext = false;
        //private int OldFocusedIndex = 0;
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
            panel_main.Controls.Clear();
            this.panel_main.Controls.Add(panel_nowPlaying);
            panel_nowPlaying.Dock = DockStyle.Fill;
            panel_nowPlaying.Show();
            //lbl_title_mini.Visible = false;
            //lbl_artist_mini.Visible = false;
            //image_mini.Visible = false;
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
            // if the player is still playing
            if(player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                timer.Start();
                //lbl_details.Text = "Now Playing";
                btn_play.FlatAppearance.MouseOverBackColor = Color.Crimson;
            }
            // if the player is paused
            else if(player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer.Stop();
                //lbl_details.Text = "On Pause";
                btn_play.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            }
            // if the player have finished playing a song
            else if(player.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                progressBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                timer.Start();
                //player.Ctlcontrols.currentPlaylist.moveNext();
                if (startIndex < list_recent.Items.Count)
                {
                    startIndex = startIndex + 1;
                }
                // fuction crashing
                list_recent.SelectedIndex++;
                //PlayFile(startIndex);
                player.Ctlcontrols.play();
                btn_play.Image = Image.FromFile(@"res/pause.png");
                //player.Ctlcontrols.next();
                btn_play.FlatAppearance.MouseOverBackColor = Color.Crimson;
            }
            // if the player is on stop
            else if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer.Stop();
                progressBar.Value = 0;
                //lbl_details.Text = "On Stop";
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
        // when user hides the recent list
        private void btn_mini_recent_Click(object sender, EventArgs e)
        {
            if(list_recent.Visible == true)
            {
                list_recent.Visible = false;
            }
            else
            {
                list_recent.Visible = true;
            }
        }
        // when user clicks the visulize button
        private void btn_visualize_Click(object sender, EventArgs e)
        {
            if (player.Visible == Visible)
            {
                player.Visible = false;
                //image_mini.Visible = false;
                //lbl_title_mini.Visible = false;
                //lbl_artist_mini.Visible = false;
            }
            else
            {
                player.Visible = true;
                //image_mini.Visible = true;
                //lbl_title_mini.Visible = true;
                //lbl_artist_mini.Visible = true;
            }
        }
        // when user clicks the library button
        private void btn_library_Click(object sender, EventArgs e)
        {
            this.panel_main.Controls.Clear();
            Library library = new Library();
            this.panel_main.Controls.Add(library);
            library.Dock = DockStyle.Fill;
            library.Show();
            //lbl_title_mini.Visible = true;
            //lbl_artist_mini.Visible = true;
            //image_mini.Visible = true;
            
        }
        // when user clicks the now playing button
        private void btn_nowPlaying_Click(object sender, EventArgs e)
        {
            loadNowPlaying();
        }
        // when user clicks the menu button
        private void btn_menu_Click(object sender, EventArgs e)
        {
            if(panel_nav.Width == 172)
            {
                panel_nav.Width = 75;
                btn_menu.Text = "";
                btn_nowPlaying.Text = "";
                btn_browse.Text = "";
                btn_browse.Text = "";
                btn_library.Text = "";
                btn_visualize.Text = "";
                //btn_extra.Text = "";
                btn_about.Text = "";
            }
            else
            {
                panel_nav.Width = 172;
                btn_menu.Text = "Menu";
                btn_nowPlaying.Text = "Playing";
                btn_browse.Text = "Browse";
                btn_library.Text = "Library";
                btn_visualize.Text = "Visualize";
                //btn_extra.Text = "Extra";
                btn_about.Text = "About";
            }
        }
        // when a user double clicks a song
        private void List_recent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            startIndex = list_recent.SelectedIndex;
            PlayFile(startIndex);
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
                panel_artwork.Visible = false;
            }
            else if(this.Width > 1000)
            {
                panel_search.Visible = true;
                panel_artwork.Visible = true;
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
    }
}
