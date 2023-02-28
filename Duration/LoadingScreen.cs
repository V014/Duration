using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duration
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            time.Stop();
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void LoadingScreen_Shown(object sender, EventArgs e)
        {
            time = new Timer();
            time.Interval = 4000;
            time.Start();
            time.Tick += new EventHandler(Time_Tick);
        }
    }
}
