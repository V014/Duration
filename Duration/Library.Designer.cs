namespace Duration
{
    partial class Library
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.data_library = new System.Windows.Forms.DataGridView();
            this.menu_Library = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu_library_play = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_library_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_library_artwork = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_library_add = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.data_library)).BeginInit();
            this.menu_Library.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_library
            // 
            this.data_library.AllowUserToAddRows = false;
            this.data_library.AllowUserToDeleteRows = false;
            this.data_library.AllowUserToResizeRows = false;
            this.data_library.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.data_library.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_library.ColumnHeadersHeight = 30;
            this.data_library.ContextMenuStrip = this.menu_Library;
            this.data_library.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_library.Location = new System.Drawing.Point(10, 10);
            this.data_library.Name = "data_library";
            this.data_library.ReadOnly = true;
            this.data_library.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_library.Size = new System.Drawing.Size(630, 465);
            this.data_library.StandardTab = true;
            this.data_library.TabIndex = 1;
            this.data_library.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_library_CellClick);
            // 
            // menu_Library
            // 
            this.menu_Library.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_library_add,
            this.menu_library_play,
            this.menu_library_remove,
            this.menu_library_artwork});
            this.menu_Library.Name = "menuLibrary";
            this.menu_Library.Size = new System.Drawing.Size(181, 114);
            // 
            // menu_library_play
            // 
            this.menu_library_play.Name = "menu_library_play";
            this.menu_library_play.Size = new System.Drawing.Size(180, 22);
            this.menu_library_play.Text = "Play";
            this.menu_library_play.Click += new System.EventHandler(this.menu_library_play_Click);
            // 
            // menu_library_remove
            // 
            this.menu_library_remove.Name = "menu_library_remove";
            this.menu_library_remove.Size = new System.Drawing.Size(180, 22);
            this.menu_library_remove.Text = "Remove";
            // 
            // menu_library_artwork
            // 
            this.menu_library_artwork.Name = "menu_library_artwork";
            this.menu_library_artwork.Size = new System.Drawing.Size(180, 22);
            this.menu_library_artwork.Text = "Artwork";
            // 
            // menu_library_add
            // 
            this.menu_library_add.Name = "menu_library_add";
            this.menu_library_add.Size = new System.Drawing.Size(180, 22);
            this.menu_library_add.Text = "Add";
            this.menu_library_add.Click += new System.EventHandler(this.Menu_library_add_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.data_library);
            this.Name = "Library";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(650, 485);
            ((System.ComponentModel.ISupportInitialize)(this.data_library)).EndInit();
            this.menu_Library.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip menu_Library;
        private System.Windows.Forms.ToolStripMenuItem menu_library_play;
        private System.Windows.Forms.ToolStripMenuItem menu_library_remove;
        private System.Windows.Forms.ToolStripMenuItem menu_library_artwork;
        public System.Windows.Forms.DataGridView data_library;
        private System.Windows.Forms.ToolStripMenuItem menu_library_add;
    }
}
