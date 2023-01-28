﻿namespace Duration
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_nowPlaying = new System.Windows.Forms.Panel();
            this.list_recent = new System.Windows.Forms.ListBox();
            this.panel_artwork = new System.Windows.Forms.Panel();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_album = new System.Windows.Forms.Label();
            this.lbl_artist = new System.Windows.Forms.Label();
            this.image_artwork = new System.Windows.Forms.PictureBox();
            this.panel_playlist = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel_search = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel_controls = new System.Windows.Forms.Panel();
            this.panel_volume = new System.Windows.Forms.Panel();
            this.btn_volume = new System.Windows.Forms.Button();
            this.volume = new MetroFramework.Controls.MetroTrackBar();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.image_mini = new System.Windows.Forms.PictureBox();
            this.panel_activity = new System.Windows.Forms.Panel();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.panel_progress = new System.Windows.Forms.Panel();
            this.progressBar = new MetroFramework.Controls.MetroTrackBar();
            this.panel_end = new System.Windows.Forms.Panel();
            this.lbl_end = new System.Windows.Forms.Label();
            this.panel_start = new System.Windows.Forms.Panel();
            this.lbl_start = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel_nav = new System.Windows.Forms.Panel();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_visualize = new System.Windows.Forms.Button();
            this.btn_library = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_nowPlaying = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.panel_main.SuspendLayout();
            this.panel_nowPlaying.SuspendLayout();
            this.panel_artwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_artwork)).BeginInit();
            this.panel_playlist.SuspendLayout();
            this.panel_search.SuspendLayout();
            this.panel_controls.SuspendLayout();
            this.panel_volume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_mini)).BeginInit();
            this.panel_activity.SuspendLayout();
            this.panel_progress.SuspendLayout();
            this.panel_end.SuspendLayout();
            this.panel_start.SuspendLayout();
            this.panel_nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Transparent;
            this.panel_main.Controls.Add(this.panel_nowPlaying);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(172, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(812, 487);
            this.panel_main.TabIndex = 2;
            // 
            // panel_nowPlaying
            // 
            this.panel_nowPlaying.BackColor = System.Drawing.Color.Transparent;
            this.panel_nowPlaying.Controls.Add(this.list_recent);
            this.panel_nowPlaying.Controls.Add(this.panel_artwork);
            this.panel_nowPlaying.Controls.Add(this.panel_playlist);
            this.panel_nowPlaying.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_nowPlaying.Location = new System.Drawing.Point(0, 0);
            this.panel_nowPlaying.Name = "panel_nowPlaying";
            this.panel_nowPlaying.Size = new System.Drawing.Size(812, 487);
            this.panel_nowPlaying.TabIndex = 6;
            // 
            // list_recent
            // 
            this.list_recent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.list_recent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_recent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_recent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.list_recent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(186)))), ((int)(((byte)(199)))));
            this.list_recent.FormattingEnabled = true;
            this.list_recent.ItemHeight = 20;
            this.list_recent.Location = new System.Drawing.Point(210, 50);
            this.list_recent.Name = "list_recent";
            this.list_recent.Size = new System.Drawing.Size(602, 437);
            this.list_recent.TabIndex = 0;
            this.list_recent.SelectedIndexChanged += new System.EventHandler(this.list_recent_SelectedIndexChanged);
            this.list_recent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.List_recent_MouseDoubleClick);
            // 
            // panel_artwork
            // 
            this.panel_artwork.BackColor = System.Drawing.Color.Transparent;
            this.panel_artwork.Controls.Add(this.player);
            this.panel_artwork.Controls.Add(this.lbl_genre);
            this.panel_artwork.Controls.Add(this.lbl_year);
            this.panel_artwork.Controls.Add(this.lbl_album);
            this.panel_artwork.Controls.Add(this.lbl_artist);
            this.panel_artwork.Controls.Add(this.image_artwork);
            this.panel_artwork.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_artwork.Location = new System.Drawing.Point(0, 50);
            this.panel_artwork.Name = "panel_artwork";
            this.panel_artwork.Padding = new System.Windows.Forms.Padding(5);
            this.panel_artwork.Size = new System.Drawing.Size(210, 437);
            this.panel_artwork.TabIndex = 5;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(5, 5);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(200, 200);
            this.player.TabIndex = 6;
            this.player.Visible = false;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer_PlayStateChange);
            // 
            // lbl_genre
            // 
            this.lbl_genre.AutoSize = true;
            this.lbl_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_genre.ForeColor = System.Drawing.Color.Gray;
            this.lbl_genre.Location = new System.Drawing.Point(11, 301);
            this.lbl_genre.Name = "lbl_genre";
            this.lbl_genre.Size = new System.Drawing.Size(50, 15);
            this.lbl_genre.TabIndex = 7;
            this.lbl_genre.Text = "Genre : ";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_year.ForeColor = System.Drawing.Color.Gray;
            this.lbl_year.Location = new System.Drawing.Point(10, 277);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(41, 15);
            this.lbl_year.TabIndex = 7;
            this.lbl_year.Text = "Year : ";
            // 
            // lbl_album
            // 
            this.lbl_album.AutoSize = true;
            this.lbl_album.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_album.ForeColor = System.Drawing.Color.Gray;
            this.lbl_album.Location = new System.Drawing.Point(10, 255);
            this.lbl_album.Name = "lbl_album";
            this.lbl_album.Size = new System.Drawing.Size(51, 15);
            this.lbl_album.TabIndex = 7;
            this.lbl_album.Text = "Album : ";
            // 
            // lbl_artist
            // 
            this.lbl_artist.AutoSize = true;
            this.lbl_artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_artist.ForeColor = System.Drawing.Color.White;
            this.lbl_artist.Location = new System.Drawing.Point(9, 225);
            this.lbl_artist.Name = "lbl_artist";
            this.lbl_artist.Size = new System.Drawing.Size(67, 20);
            this.lbl_artist.TabIndex = 7;
            this.lbl_artist.Text = "Artist : ";
            // 
            // image_artwork
            // 
            this.image_artwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.image_artwork.Dock = System.Windows.Forms.DockStyle.Top;
            this.image_artwork.Image = ((System.Drawing.Image)(resources.GetObject("image_artwork.Image")));
            this.image_artwork.Location = new System.Drawing.Point(5, 5);
            this.image_artwork.Name = "image_artwork";
            this.image_artwork.Size = new System.Drawing.Size(200, 200);
            this.image_artwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_artwork.TabIndex = 1;
            this.image_artwork.TabStop = false;
            // 
            // panel_playlist
            // 
            this.panel_playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.panel_playlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_playlist.Controls.Add(this.lbl_title);
            this.panel_playlist.Controls.Add(this.panel_search);
            this.panel_playlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_playlist.Location = new System.Drawing.Point(0, 0);
            this.panel_playlist.Name = "panel_playlist";
            this.panel_playlist.Padding = new System.Windows.Forms.Padding(5);
            this.panel_playlist.Size = new System.Drawing.Size(812, 50);
            this.panel_playlist.TabIndex = 2;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_title.ForeColor = System.Drawing.Color.Gray;
            this.lbl_title.Location = new System.Drawing.Point(9, 16);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(42, 20);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Title ";
            // 
            // panel_search
            // 
            this.panel_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panel_search.Controls.Add(this.txt_search);
            this.panel_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_search.Location = new System.Drawing.Point(613, 5);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(194, 40);
            this.panel_search.TabIndex = 3;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_search.ForeColor = System.Drawing.Color.Gray;
            this.txt_search.Location = new System.Drawing.Point(8, 11);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(161, 19);
            this.txt_search.TabIndex = 4;
            this.txt_search.Text = "🔎 Search library...";
            this.txt_search.WordWrap = false;
            this.txt_search.Click += new System.EventHandler(this.txt_search_Click);
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            this.txt_search.Leave += new System.EventHandler(this.Txt_search_Leave);
            // 
            // panel_controls
            // 
            this.panel_controls.BackColor = System.Drawing.Color.Transparent;
            this.panel_controls.Controls.Add(this.panel_volume);
            this.panel_controls.Controls.Add(this.image_mini);
            this.panel_controls.Controls.Add(this.panel_activity);
            this.panel_controls.Controls.Add(this.panel_progress);
            this.panel_controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_controls.Location = new System.Drawing.Point(0, 487);
            this.panel_controls.Name = "panel_controls";
            this.panel_controls.Size = new System.Drawing.Size(984, 74);
            this.panel_controls.TabIndex = 1;
            // 
            // panel_volume
            // 
            this.panel_volume.BackColor = System.Drawing.Color.Transparent;
            this.panel_volume.Controls.Add(this.btn_volume);
            this.panel_volume.Controls.Add(this.volume);
            this.panel_volume.Controls.Add(this.lbl_volume);
            this.panel_volume.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_volume.Location = new System.Drawing.Point(716, 26);
            this.panel_volume.Name = "panel_volume";
            this.panel_volume.Size = new System.Drawing.Size(220, 48);
            this.panel_volume.TabIndex = 3;
            // 
            // btn_volume
            // 
            this.btn_volume.FlatAppearance.BorderSize = 0;
            this.btn_volume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_volume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volume.Image = ((System.Drawing.Image)(resources.GetObject("btn_volume.Image")));
            this.btn_volume.Location = new System.Drawing.Point(7, 12);
            this.btn_volume.Name = "btn_volume";
            this.btn_volume.Size = new System.Drawing.Size(40, 23);
            this.btn_volume.TabIndex = 4;
            this.btn_volume.UseVisualStyleBackColor = true;
            this.btn_volume.Click += new System.EventHandler(this.btn_volume_Click);
            // 
            // volume
            // 
            this.volume.BackColor = System.Drawing.Color.Transparent;
            this.volume.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.volume.Location = new System.Drawing.Point(51, 13);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(110, 23);
            this.volume.Style = MetroFramework.MetroColorStyle.Black;
            this.volume.TabIndex = 3;
            this.volume.Text = "metroTrackBar1";
            this.volume.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.volume.UseCustomBackColor = true;
            this.volume.ValueChanged += new System.EventHandler(this.volume_ValueChanged);
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_volume.ForeColor = System.Drawing.Color.White;
            this.lbl_volume.Location = new System.Drawing.Point(167, 16);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(36, 17);
            this.lbl_volume.TabIndex = 2;
            this.lbl_volume.Text = "50%";
            // 
            // image_mini
            // 
            this.image_mini.BackColor = System.Drawing.Color.Transparent;
            this.image_mini.Dock = System.Windows.Forms.DockStyle.Right;
            this.image_mini.Location = new System.Drawing.Point(936, 26);
            this.image_mini.Name = "image_mini";
            this.image_mini.Size = new System.Drawing.Size(48, 48);
            this.image_mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_mini.TabIndex = 4;
            this.image_mini.TabStop = false;
            this.image_mini.Visible = false;
            // 
            // panel_activity
            // 
            this.panel_activity.Controls.Add(this.btn_next);
            this.panel_activity.Controls.Add(this.btn_play);
            this.panel_activity.Controls.Add(this.btn_prev);
            this.panel_activity.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_activity.Location = new System.Drawing.Point(0, 26);
            this.panel_activity.Name = "panel_activity";
            this.panel_activity.Size = new System.Drawing.Size(224, 48);
            this.panel_activity.TabIndex = 1;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_next.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.Location = new System.Drawing.Point(132, 0);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(66, 48);
            this.btn_next.TabIndex = 0;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.ForeColor = System.Drawing.Color.White;
            this.btn_play.Image = ((System.Drawing.Image)(resources.GetObject("btn_play.Image")));
            this.btn_play.Location = new System.Drawing.Point(66, 0);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(66, 48);
            this.btn_play.TabIndex = 0;
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.BackColor = System.Drawing.Color.Transparent;
            this.btn_prev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_prev.FlatAppearance.BorderSize = 0;
            this.btn_prev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prev.ForeColor = System.Drawing.Color.White;
            this.btn_prev.Image = ((System.Drawing.Image)(resources.GetObject("btn_prev.Image")));
            this.btn_prev.Location = new System.Drawing.Point(0, 0);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(66, 48);
            this.btn_prev.TabIndex = 0;
            this.btn_prev.UseVisualStyleBackColor = false;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // panel_progress
            // 
            this.panel_progress.Controls.Add(this.progressBar);
            this.panel_progress.Controls.Add(this.panel_end);
            this.panel_progress.Controls.Add(this.panel_start);
            this.panel_progress.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_progress.Location = new System.Drawing.Point(0, 0);
            this.panel_progress.Name = "panel_progress";
            this.panel_progress.Size = new System.Drawing.Size(984, 26);
            this.panel_progress.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(49, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(881, 26);
            this.progressBar.TabIndex = 0;
            this.progressBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.progressBar.UseCustomBackColor = true;
            this.progressBar.Value = 0;
            this.progressBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ProgressBar_Scroll);
            // 
            // panel_end
            // 
            this.panel_end.Controls.Add(this.lbl_end);
            this.panel_end.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_end.Location = new System.Drawing.Point(930, 0);
            this.panel_end.Name = "panel_end";
            this.panel_end.Size = new System.Drawing.Size(54, 26);
            this.panel_end.TabIndex = 3;
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_end.ForeColor = System.Drawing.Color.White;
            this.lbl_end.Location = new System.Drawing.Point(4, 6);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(36, 17);
            this.lbl_end.TabIndex = 2;
            this.lbl_end.Text = "0:00";
            // 
            // panel_start
            // 
            this.panel_start.Controls.Add(this.lbl_start);
            this.panel_start.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_start.Location = new System.Drawing.Point(0, 0);
            this.panel_start.Name = "panel_start";
            this.panel_start.Size = new System.Drawing.Size(49, 26);
            this.panel_start.TabIndex = 3;
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_start.ForeColor = System.Drawing.Color.White;
            this.lbl_start.Location = new System.Drawing.Point(4, 6);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(36, 17);
            this.lbl_start.TabIndex = 2;
            this.lbl_start.Text = "0:00";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel_nav
            // 
            this.panel_nav.BackColor = System.Drawing.Color.Transparent;
            this.panel_nav.Controls.Add(this.btn_about);
            this.panel_nav.Controls.Add(this.btn_visualize);
            this.panel_nav.Controls.Add(this.btn_library);
            this.panel_nav.Controls.Add(this.btn_browse);
            this.panel_nav.Controls.Add(this.btn_nowPlaying);
            this.panel_nav.Controls.Add(this.btn_menu);
            this.panel_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_nav.Location = new System.Drawing.Point(0, 0);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Padding = new System.Windows.Forms.Padding(5);
            this.panel_nav.Size = new System.Drawing.Size(172, 487);
            this.panel_nav.TabIndex = 5;
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.Color.Transparent;
            this.btn_about.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_about.ForeColor = System.Drawing.Color.White;
            this.btn_about.Image = ((System.Drawing.Image)(resources.GetObject("btn_about.Image")));
            this.btn_about.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_about.Location = new System.Drawing.Point(5, 230);
            this.btn_about.Margin = new System.Windows.Forms.Padding(0);
            this.btn_about.Name = "btn_about";
            this.btn_about.Padding = new System.Windows.Forms.Padding(10);
            this.btn_about.Size = new System.Drawing.Size(162, 45);
            this.btn_about.TabIndex = 9;
            this.btn_about.Text = "About";
            this.btn_about.UseVisualStyleBackColor = false;
            // 
            // btn_visualize
            // 
            this.btn_visualize.BackColor = System.Drawing.Color.Transparent;
            this.btn_visualize.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_visualize.FlatAppearance.BorderSize = 0;
            this.btn_visualize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_visualize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visualize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_visualize.ForeColor = System.Drawing.Color.White;
            this.btn_visualize.Image = ((System.Drawing.Image)(resources.GetObject("btn_visualize.Image")));
            this.btn_visualize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_visualize.Location = new System.Drawing.Point(5, 185);
            this.btn_visualize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_visualize.Name = "btn_visualize";
            this.btn_visualize.Padding = new System.Windows.Forms.Padding(10);
            this.btn_visualize.Size = new System.Drawing.Size(162, 45);
            this.btn_visualize.TabIndex = 6;
            this.btn_visualize.Text = "Visualize";
            this.btn_visualize.UseVisualStyleBackColor = false;
            this.btn_visualize.Click += new System.EventHandler(this.btn_visualize_Click);
            // 
            // btn_library
            // 
            this.btn_library.BackColor = System.Drawing.Color.Transparent;
            this.btn_library.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_library.FlatAppearance.BorderSize = 0;
            this.btn_library.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_library.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_library.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_library.ForeColor = System.Drawing.Color.White;
            this.btn_library.Image = ((System.Drawing.Image)(resources.GetObject("btn_library.Image")));
            this.btn_library.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_library.Location = new System.Drawing.Point(5, 140);
            this.btn_library.Margin = new System.Windows.Forms.Padding(0);
            this.btn_library.Name = "btn_library";
            this.btn_library.Padding = new System.Windows.Forms.Padding(10);
            this.btn_library.Size = new System.Drawing.Size(162, 45);
            this.btn_library.TabIndex = 7;
            this.btn_library.Text = "Library";
            this.btn_library.UseVisualStyleBackColor = false;
            this.btn_library.Click += new System.EventHandler(this.btn_library_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.Transparent;
            this.btn_browse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_browse.FlatAppearance.BorderSize = 0;
            this.btn_browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_browse.ForeColor = System.Drawing.Color.White;
            this.btn_browse.Image = ((System.Drawing.Image)(resources.GetObject("btn_browse.Image")));
            this.btn_browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_browse.Location = new System.Drawing.Point(5, 95);
            this.btn_browse.Margin = new System.Windows.Forms.Padding(0);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Padding = new System.Windows.Forms.Padding(10);
            this.btn_browse.Size = new System.Drawing.Size(162, 45);
            this.btn_browse.TabIndex = 5;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_nowPlaying
            // 
            this.btn_nowPlaying.BackColor = System.Drawing.Color.Transparent;
            this.btn_nowPlaying.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_nowPlaying.FlatAppearance.BorderSize = 0;
            this.btn_nowPlaying.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_nowPlaying.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nowPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_nowPlaying.ForeColor = System.Drawing.Color.White;
            this.btn_nowPlaying.Image = ((System.Drawing.Image)(resources.GetObject("btn_nowPlaying.Image")));
            this.btn_nowPlaying.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nowPlaying.Location = new System.Drawing.Point(5, 50);
            this.btn_nowPlaying.Margin = new System.Windows.Forms.Padding(0);
            this.btn_nowPlaying.Name = "btn_nowPlaying";
            this.btn_nowPlaying.Padding = new System.Windows.Forms.Padding(10);
            this.btn_nowPlaying.Size = new System.Drawing.Size(162, 45);
            this.btn_nowPlaying.TabIndex = 10;
            this.btn_nowPlaying.Text = "Playing";
            this.btn_nowPlaying.UseVisualStyleBackColor = false;
            this.btn_nowPlaying.Click += new System.EventHandler(this.btn_nowPlaying_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu.Location = new System.Drawing.Point(5, 5);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Padding = new System.Windows.Forms.Padding(10);
            this.btn_menu.Size = new System.Drawing.Size(162, 45);
            this.btn_menu.TabIndex = 11;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_nav);
            this.Controls.Add(this.panel_controls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(511, 113);
            this.Name = "Home";
            this.Text = "Duration";
            this.Load += new System.EventHandler(this.Home_Load);
            this.SizeChanged += new System.EventHandler(this.Home_SizeChanged);
            this.panel_main.ResumeLayout(false);
            this.panel_nowPlaying.ResumeLayout(false);
            this.panel_artwork.ResumeLayout(false);
            this.panel_artwork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_artwork)).EndInit();
            this.panel_playlist.ResumeLayout(false);
            this.panel_playlist.PerformLayout();
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            this.panel_controls.ResumeLayout(false);
            this.panel_volume.ResumeLayout(false);
            this.panel_volume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_mini)).EndInit();
            this.panel_activity.ResumeLayout(false);
            this.panel_progress.ResumeLayout(false);
            this.panel_end.ResumeLayout(false);
            this.panel_end.PerformLayout();
            this.panel_start.ResumeLayout(false);
            this.panel_start.PerformLayout();
            this.panel_nav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_controls;
        private System.Windows.Forms.Panel panel_progress;
        private System.Windows.Forms.Panel panel_activity;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Panel panel_volume;
        private MetroFramework.Controls.MetroTrackBar volume;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Button btn_volume;
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Panel panel_playlist;
        private System.Windows.Forms.Panel panel_start;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Panel panel_end;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Button btn_visualize;
        private System.Windows.Forms.Button btn_library;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_nowPlaying;
        public System.Windows.Forms.ListBox list_recent;
        public MetroFramework.Controls.MetroTrackBar progressBar;
        public System.Windows.Forms.Button btn_play;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel_artwork;
        private System.Windows.Forms.PictureBox image_artwork;
        public System.Windows.Forms.Panel panel_nowPlaying;
        public AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Label lbl_genre;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_album;
        private System.Windows.Forms.Label lbl_artist;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox image_mini;
    }
}

