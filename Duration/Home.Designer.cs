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
            this.data_library = new System.Windows.Forms.DataGridView();
            this.menu_library = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.play = new System.Windows.Forms.ToolStripMenuItem();
            this.pause = new System.Windows.Forms.ToolStripMenuItem();
            this.stop = new System.Windows.Forms.ToolStripMenuItem();
            this.next = new System.Windows.Forms.ToolStripMenuItem();
            this.previous = new System.Windows.Forms.ToolStripMenuItem();
            this.import = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_recent = new System.Windows.Forms.Panel();
            this.btn_newPlaylist = new System.Windows.Forms.Button();
            this.list_playlist = new System.Windows.Forms.ListBox();
            this.panel_playlist = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel_search = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel_activity = new System.Windows.Forms.Panel();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel_artwork = new System.Windows.Forms.Panel();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_album = new System.Windows.Forms.Label();
            this.lbl_artist = new System.Windows.Forms.Label();
            this.image_artwork = new System.Windows.Forms.PictureBox();
            this.panel_controls = new System.Windows.Forms.Panel();
            this.panel_waveForm = new System.Windows.Forms.Panel();
            this.panel_volume = new System.Windows.Forms.Panel();
            this.btn_volume = new System.Windows.Forms.Button();
            this.volume = new MetroFramework.Controls.MetroTrackBar();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.panel_progress = new System.Windows.Forms.Panel();
            this.progressBar = new MetroFramework.Controls.MetroTrackBar();
            this.panel_end = new System.Windows.Forms.Panel();
            this.lbl_end = new System.Windows.Forms.Label();
            this.panel_start = new System.Windows.Forms.Panel();
            this.lbl_start = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel_nav = new System.Windows.Forms.Panel();
            this.lbl_track = new System.Windows.Forms.Label();
            this.lbl_plays = new System.Windows.Forms.Label();
            this.image_like = new System.Windows.Forms.PictureBox();
            this.panel_main.SuspendLayout();
            this.panel_nowPlaying.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_library)).BeginInit();
            this.menu_library.SuspendLayout();
            this.panel_recent.SuspendLayout();
            this.panel_playlist.SuspendLayout();
            this.panel_search.SuspendLayout();
            this.panel_activity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panel_artwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_artwork)).BeginInit();
            this.panel_controls.SuspendLayout();
            this.panel_waveForm.SuspendLayout();
            this.panel_volume.SuspendLayout();
            this.panel_progress.SuspendLayout();
            this.panel_end.SuspendLayout();
            this.panel_start.SuspendLayout();
            this.panel_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_like)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Transparent;
            this.panel_main.Controls.Add(this.panel_nowPlaying);
            this.panel_main.Controls.Add(this.panel_recent);
            this.panel_main.Controls.Add(this.panel_playlist);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(172, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(812, 487);
            this.panel_main.TabIndex = 2;
            // 
            // panel_nowPlaying
            // 
            this.panel_nowPlaying.BackColor = System.Drawing.Color.Transparent;
            this.panel_nowPlaying.Controls.Add(this.data_library);
            this.panel_nowPlaying.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_nowPlaying.Location = new System.Drawing.Point(0, 50);
            this.panel_nowPlaying.Name = "panel_nowPlaying";
            this.panel_nowPlaying.Size = new System.Drawing.Size(579, 437);
            this.panel_nowPlaying.TabIndex = 6;
            // 
            // data_library
            // 
            this.data_library.AllowUserToAddRows = false;
            this.data_library.AllowUserToDeleteRows = false;
            this.data_library.AllowUserToOrderColumns = true;
            this.data_library.AllowUserToResizeRows = false;
            this.data_library.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_library.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.data_library.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_library.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_library.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_library.ColumnHeadersHeight = 30;
            this.data_library.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data_library.ContextMenuStrip = this.menu_library;
            this.data_library.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_library.EnableHeadersVisualStyles = false;
            this.data_library.Location = new System.Drawing.Point(0, 0);
            this.data_library.Name = "data_library";
            this.data_library.ReadOnly = true;
            this.data_library.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_library.RowHeadersVisible = false;
            this.data_library.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data_library.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_library.Size = new System.Drawing.Size(579, 437);
            this.data_library.StandardTab = true;
            this.data_library.TabIndex = 7;
            this.data_library.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_library_CellClick);
            this.data_library.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_library_CellDoubleClick);
            // 
            // menu_library
            // 
            this.menu_library.BackColor = System.Drawing.SystemColors.Control;
            this.menu_library.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.play,
            this.pause,
            this.stop,
            this.next,
            this.previous,
            this.import,
            this.delete});
            this.menu_library.Name = "menu_library";
            this.menu_library.Size = new System.Drawing.Size(120, 158);
            // 
            // play
            // 
            this.play.Image = ((System.Drawing.Image)(resources.GetObject("play.Image")));
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(119, 22);
            this.play.Text = "Play";
            this.play.Click += new System.EventHandler(this.menu_library_play_Click);
            // 
            // pause
            // 
            this.pause.Image = ((System.Drawing.Image)(resources.GetObject("pause.Image")));
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(119, 22);
            this.pause.Text = "Pause";
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // stop
            // 
            this.stop.Image = ((System.Drawing.Image)(resources.GetObject("stop.Image")));
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(119, 22);
            this.stop.Text = "Stop";
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // next
            // 
            this.next.Image = ((System.Drawing.Image)(resources.GetObject("next.Image")));
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(119, 22);
            this.next.Text = "Next";
            // 
            // previous
            // 
            this.previous.Image = ((System.Drawing.Image)(resources.GetObject("previous.Image")));
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(119, 22);
            this.previous.Text = "Previous";
            // 
            // import
            // 
            this.import.Image = ((System.Drawing.Image)(resources.GetObject("import.Image")));
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(119, 22);
            this.import.Text = "Import";
            this.import.Click += new System.EventHandler(this.Menu_library_add_Click);
            // 
            // delete
            // 
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(119, 22);
            this.delete.Text = "Delete";
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // panel_recent
            // 
            this.panel_recent.Controls.Add(this.btn_newPlaylist);
            this.panel_recent.Controls.Add(this.list_playlist);
            this.panel_recent.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_recent.Location = new System.Drawing.Point(579, 50);
            this.panel_recent.Name = "panel_recent";
            this.panel_recent.Padding = new System.Windows.Forms.Padding(5);
            this.panel_recent.Size = new System.Drawing.Size(233, 437);
            this.panel_recent.TabIndex = 8;
            // 
            // btn_newPlaylist
            // 
            this.btn_newPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.btn_newPlaylist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_newPlaylist.FlatAppearance.BorderSize = 0;
            this.btn_newPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_newPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(60)))));
            this.btn_newPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newPlaylist.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_newPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_newPlaylist.Location = new System.Drawing.Point(5, 384);
            this.btn_newPlaylist.Margin = new System.Windows.Forms.Padding(0);
            this.btn_newPlaylist.Name = "btn_newPlaylist";
            this.btn_newPlaylist.Padding = new System.Windows.Forms.Padding(10);
            this.btn_newPlaylist.Size = new System.Drawing.Size(223, 48);
            this.btn_newPlaylist.TabIndex = 5;
            this.btn_newPlaylist.Text = "New Playlist";
            this.btn_newPlaylist.UseVisualStyleBackColor = false;
            this.btn_newPlaylist.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // list_playlist
            // 
            this.list_playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.list_playlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_playlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_playlist.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_playlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(186)))), ((int)(((byte)(199)))));
            this.list_playlist.FormattingEnabled = true;
            this.list_playlist.Location = new System.Drawing.Point(5, 5);
            this.list_playlist.Name = "list_playlist";
            this.list_playlist.Size = new System.Drawing.Size(223, 427);
            this.list_playlist.TabIndex = 0;
            this.list_playlist.SelectedIndexChanged += new System.EventHandler(this.list_recent_SelectedIndexChanged);
            this.list_playlist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.List_recent_MouseDoubleClick);
            // 
            // panel_playlist
            // 
            this.panel_playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_playlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_playlist.Controls.Add(this.lbl_title);
            this.panel_playlist.Controls.Add(this.panel_search);
            this.panel_playlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_playlist.Location = new System.Drawing.Point(0, 0);
            this.panel_playlist.Name = "panel_playlist";
            this.panel_playlist.Padding = new System.Windows.Forms.Padding(5);
            this.panel_playlist.Size = new System.Drawing.Size(812, 50);
            this.panel_playlist.TabIndex = 7;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.lbl_title.Location = new System.Drawing.Point(9, 20);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(32, 13);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Title ";
            // 
            // panel_search
            // 
            this.panel_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel_search.Controls.Add(this.txt_search);
            this.panel_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_search.Location = new System.Drawing.Point(579, 5);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(228, 40);
            this.panel_search.TabIndex = 3;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.White;
            this.txt_search.Location = new System.Drawing.Point(8, 11);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(161, 18);
            this.txt_search.TabIndex = 4;
            this.txt_search.Text = "🔎 Search library...";
            this.txt_search.WordWrap = false;
            this.txt_search.Click += new System.EventHandler(this.txt_search_Click);
            this.txt_search.Leave += new System.EventHandler(this.Txt_search_Leave);
            // 
            // panel_activity
            // 
            this.panel_activity.Controls.Add(this.image_like);
            this.panel_activity.Controls.Add(this.btn_next);
            this.panel_activity.Controls.Add(this.btn_stop);
            this.panel_activity.Controls.Add(this.btn_play);
            this.panel_activity.Controls.Add(this.btn_prev);
            this.panel_activity.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_activity.Location = new System.Drawing.Point(0, 0);
            this.panel_activity.Name = "panel_activity";
            this.panel_activity.Size = new System.Drawing.Size(172, 48);
            this.panel_activity.TabIndex = 1;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_next.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.Location = new System.Drawing.Point(108, 0);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(30, 48);
            this.btn_next.TabIndex = 0;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_stop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_stop.FlatAppearance.BorderSize = 0;
            this.btn_stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_stop.Image")));
            this.btn_stop.Location = new System.Drawing.Point(78, 0);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(30, 48);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.ForeColor = System.Drawing.Color.White;
            this.btn_play.Image = ((System.Drawing.Image)(resources.GetObject("btn_play.Image")));
            this.btn_play.Location = new System.Drawing.Point(30, 0);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(48, 48);
            this.btn_play.TabIndex = 0;
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.BackColor = System.Drawing.Color.Transparent;
            this.btn_prev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_prev.FlatAppearance.BorderSize = 0;
            this.btn_prev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_prev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prev.ForeColor = System.Drawing.Color.White;
            this.btn_prev.Image = ((System.Drawing.Image)(resources.GetObject("btn_prev.Image")));
            this.btn_prev.Location = new System.Drawing.Point(0, 0);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(30, 48);
            this.btn_prev.TabIndex = 0;
            this.btn_prev.UseVisualStyleBackColor = false;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(5, 5);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(152, 152);
            this.player.TabIndex = 6;
            this.player.Visible = false;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer_PlayStateChange);
            this.player.MouseDownEvent += new AxWMPLib._WMPOCXEvents_MouseDownEventHandler(this.Player_MouseDownEvent);
            // 
            // panel_artwork
            // 
            this.panel_artwork.BackColor = System.Drawing.Color.Transparent;
            this.panel_artwork.Controls.Add(this.player);
            this.panel_artwork.Controls.Add(this.lbl_plays);
            this.panel_artwork.Controls.Add(this.lbl_track);
            this.panel_artwork.Controls.Add(this.lbl_genre);
            this.panel_artwork.Controls.Add(this.lbl_year);
            this.panel_artwork.Controls.Add(this.lbl_album);
            this.panel_artwork.Controls.Add(this.lbl_artist);
            this.panel_artwork.Controls.Add(this.image_artwork);
            this.panel_artwork.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_artwork.Location = new System.Drawing.Point(5, 5);
            this.panel_artwork.Name = "panel_artwork";
            this.panel_artwork.Padding = new System.Windows.Forms.Padding(5);
            this.panel_artwork.Size = new System.Drawing.Size(162, 323);
            this.panel_artwork.TabIndex = 5;
            // 
            // lbl_genre
            // 
            this.lbl_genre.AutoSize = true;
            this.lbl_genre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genre.ForeColor = System.Drawing.Color.Gray;
            this.lbl_genre.Location = new System.Drawing.Point(10, 245);
            this.lbl_genre.Name = "lbl_genre";
            this.lbl_genre.Size = new System.Drawing.Size(47, 13);
            this.lbl_genre.TabIndex = 7;
            this.lbl_genre.Text = "Genre : ";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_year.ForeColor = System.Drawing.Color.Gray;
            this.lbl_year.Location = new System.Drawing.Point(9, 221);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(36, 13);
            this.lbl_year.TabIndex = 7;
            this.lbl_year.Text = "Year : ";
            // 
            // lbl_album
            // 
            this.lbl_album.AutoSize = true;
            this.lbl_album.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_album.ForeColor = System.Drawing.Color.Gray;
            this.lbl_album.Location = new System.Drawing.Point(9, 199);
            this.lbl_album.Name = "lbl_album";
            this.lbl_album.Size = new System.Drawing.Size(49, 13);
            this.lbl_album.TabIndex = 7;
            this.lbl_album.Text = "Album : ";
            // 
            // lbl_artist
            // 
            this.lbl_artist.AutoSize = true;
            this.lbl_artist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_artist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(0)))));
            this.lbl_artist.Location = new System.Drawing.Point(8, 170);
            this.lbl_artist.Name = "lbl_artist";
            this.lbl_artist.Size = new System.Drawing.Size(63, 21);
            this.lbl_artist.TabIndex = 7;
            this.lbl_artist.Text = "Artist : ";
            // 
            // image_artwork
            // 
            this.image_artwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.image_artwork.Dock = System.Windows.Forms.DockStyle.Top;
            this.image_artwork.Image = ((System.Drawing.Image)(resources.GetObject("image_artwork.Image")));
            this.image_artwork.Location = new System.Drawing.Point(5, 5);
            this.image_artwork.Name = "image_artwork";
            this.image_artwork.Size = new System.Drawing.Size(152, 152);
            this.image_artwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_artwork.TabIndex = 1;
            this.image_artwork.TabStop = false;
            this.image_artwork.Click += new System.EventHandler(this.Image_artwork_Click);
            // 
            // panel_controls
            // 
            this.panel_controls.BackColor = System.Drawing.Color.Transparent;
            this.panel_controls.Controls.Add(this.panel_waveForm);
            this.panel_controls.Controls.Add(this.panel_volume);
            this.panel_controls.Controls.Add(this.panel_progress);
            this.panel_controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_controls.Location = new System.Drawing.Point(0, 487);
            this.panel_controls.Name = "panel_controls";
            this.panel_controls.Size = new System.Drawing.Size(984, 74);
            this.panel_controls.TabIndex = 1;
            // 
            // panel_waveForm
            // 
            this.panel_waveForm.Controls.Add(this.panel_activity);
            this.panel_waveForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_waveForm.Location = new System.Drawing.Point(0, 26);
            this.panel_waveForm.Name = "panel_waveForm";
            this.panel_waveForm.Size = new System.Drawing.Size(764, 48);
            this.panel_waveForm.TabIndex = 5;
            // 
            // panel_volume
            // 
            this.panel_volume.BackColor = System.Drawing.Color.Transparent;
            this.panel_volume.Controls.Add(this.btn_volume);
            this.panel_volume.Controls.Add(this.volume);
            this.panel_volume.Controls.Add(this.lbl_volume);
            this.panel_volume.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_volume.Location = new System.Drawing.Point(764, 26);
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
            this.volume.Style = MetroFramework.MetroColorStyle.Green;
            this.volume.TabIndex = 3;
            this.volume.Text = "metroTrackBar1";
            this.volume.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.volume.UseCustomBackColor = true;
            this.volume.ValueChanged += new System.EventHandler(this.volume_ValueChanged);
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_volume.ForeColor = System.Drawing.Color.White;
            this.lbl_volume.Location = new System.Drawing.Point(167, 17);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(28, 13);
            this.lbl_volume.TabIndex = 2;
            this.lbl_volume.Text = "50%";
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
            this.progressBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(49, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(869, 26);
            this.progressBar.Style = MetroFramework.MetroColorStyle.Orange;
            this.progressBar.TabIndex = 0;
            this.progressBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.progressBar.Value = 0;
            this.progressBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ProgressBar_Scroll);
            // 
            // panel_end
            // 
            this.panel_end.Controls.Add(this.lbl_end);
            this.panel_end.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_end.Location = new System.Drawing.Point(918, 0);
            this.panel_end.Name = "panel_end";
            this.panel_end.Size = new System.Drawing.Size(66, 26);
            this.panel_end.TabIndex = 3;
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_end.ForeColor = System.Drawing.Color.White;
            this.lbl_end.Location = new System.Drawing.Point(11, 6);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(28, 13);
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
            this.lbl_start.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_start.ForeColor = System.Drawing.Color.White;
            this.lbl_start.Location = new System.Drawing.Point(12, 6);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(28, 13);
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
            this.panel_nav.Controls.Add(this.panel_artwork);
            this.panel_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_nav.Location = new System.Drawing.Point(0, 0);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Padding = new System.Windows.Forms.Padding(5);
            this.panel_nav.Size = new System.Drawing.Size(172, 487);
            this.panel_nav.TabIndex = 5;
            // 
            // lbl_track
            // 
            this.lbl_track.AutoSize = true;
            this.lbl_track.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track.ForeColor = System.Drawing.Color.Gray;
            this.lbl_track.Location = new System.Drawing.Point(10, 270);
            this.lbl_track.Name = "lbl_track";
            this.lbl_track.Size = new System.Drawing.Size(42, 13);
            this.lbl_track.TabIndex = 7;
            this.lbl_track.Text = "Track : ";
            // 
            // lbl_plays
            // 
            this.lbl_plays.AutoSize = true;
            this.lbl_plays.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_plays.ForeColor = System.Drawing.Color.Gray;
            this.lbl_plays.Location = new System.Drawing.Point(10, 293);
            this.lbl_plays.Name = "lbl_plays";
            this.lbl_plays.Size = new System.Drawing.Size(41, 13);
            this.lbl_plays.TabIndex = 7;
            this.lbl_plays.Text = "Plays : ";
            // 
            // image_like
            // 
            this.image_like.BackColor = System.Drawing.Color.Transparent;
            this.image_like.Dock = System.Windows.Forms.DockStyle.Right;
            this.image_like.Image = ((System.Drawing.Image)(resources.GetObject("image_like.Image")));
            this.image_like.Location = new System.Drawing.Point(144, 0);
            this.image_like.Name = "image_like";
            this.image_like.Size = new System.Drawing.Size(28, 48);
            this.image_like.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.image_like.TabIndex = 8;
            this.image_like.TabStop = false;
            this.image_like.Click += new System.EventHandler(this.Image_like_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_nav);
            this.Controls.Add(this.panel_controls);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(511, 113);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.SizeChanged += new System.EventHandler(this.Home_SizeChanged);
            this.panel_main.ResumeLayout(false);
            this.panel_nowPlaying.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_library)).EndInit();
            this.menu_library.ResumeLayout(false);
            this.panel_recent.ResumeLayout(false);
            this.panel_playlist.ResumeLayout(false);
            this.panel_playlist.PerformLayout();
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            this.panel_activity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panel_artwork.ResumeLayout(false);
            this.panel_artwork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_artwork)).EndInit();
            this.panel_controls.ResumeLayout(false);
            this.panel_waveForm.ResumeLayout(false);
            this.panel_volume.ResumeLayout(false);
            this.panel_volume.PerformLayout();
            this.panel_progress.ResumeLayout(false);
            this.panel_end.ResumeLayout(false);
            this.panel_end.PerformLayout();
            this.panel_start.ResumeLayout(false);
            this.panel_start.PerformLayout();
            this.panel_nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image_like)).EndInit();
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
        private System.Windows.Forms.Panel panel_start;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Panel panel_end;
        private System.Windows.Forms.Label lbl_end;
        public MetroFramework.Controls.MetroTrackBar progressBar;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel_artwork;
        private System.Windows.Forms.PictureBox image_artwork;
        public System.Windows.Forms.Panel panel_nowPlaying;
        public AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Label lbl_genre;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_album;
        private System.Windows.Forms.Label lbl_artist;
        private System.Windows.Forms.Panel panel_waveForm;
        private MetroFramework.Controls.MetroContextMenu menu_library;
        private System.Windows.Forms.ToolStripMenuItem import;
        private System.Windows.Forms.ToolStripMenuItem play;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.DataGridView data_library;
        private System.Windows.Forms.Panel panel_playlist;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.TextBox txt_search;
        public System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Panel panel_recent;
        private System.Windows.Forms.Button btn_newPlaylist;
        public System.Windows.Forms.ListBox list_playlist;
        private System.Windows.Forms.ToolStripMenuItem pause;
        private System.Windows.Forms.ToolStripMenuItem stop;
        private System.Windows.Forms.ToolStripMenuItem next;
        private System.Windows.Forms.ToolStripMenuItem previous;
        private System.Windows.Forms.Label lbl_track;
        private System.Windows.Forms.Label lbl_plays;
        private System.Windows.Forms.PictureBox image_like;
    }
}

