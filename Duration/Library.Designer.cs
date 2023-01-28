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
            this.menuLibrary = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu_library_play = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_library_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_library_artwork = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_library)).BeginInit();
            this.menuLibrary.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.data_library.ContextMenuStrip = this.menuLibrary;
            this.data_library.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_library.Location = new System.Drawing.Point(10, 10);
            this.data_library.Name = "data_library";
            this.data_library.ReadOnly = true;
            this.data_library.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_library.Size = new System.Drawing.Size(630, 420);
            this.data_library.StandardTab = true;
            this.data_library.TabIndex = 1;
            this.data_library.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_library_CellClick);
            // 
            // menuLibrary
            // 
            this.menuLibrary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_library_play,
            this.menu_library_remove,
            this.menu_library_artwork});
            this.menuLibrary.Name = "menuLibrary";
            this.menuLibrary.Size = new System.Drawing.Size(181, 92);
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
            this.menu_library_remove.Size = new System.Drawing.Size(117, 22);
            this.menu_library_remove.Text = "Remove";
            // 
            // menu_library_artwork
            // 
            this.menu_library_artwork.Name = "menu_library_artwork";
            this.menu_library_artwork.Size = new System.Drawing.Size(117, 22);
            this.menu_library_artwork.Text = "Artwork";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 45);
            this.panel1.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(508, 0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(122, 45);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.data_library);
            this.Controls.Add(this.panel1);
            this.Name = "Library";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(650, 485);
            ((System.ComponentModel.ISupportInitialize)(this.data_library)).EndInit();
            this.menuLibrary.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip menuLibrary;
        private System.Windows.Forms.ToolStripMenuItem menu_library_play;
        private System.Windows.Forms.ToolStripMenuItem menu_library_remove;
        private System.Windows.Forms.ToolStripMenuItem menu_library_artwork;
        public System.Windows.Forms.DataGridView data_library;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add;
    }
}
