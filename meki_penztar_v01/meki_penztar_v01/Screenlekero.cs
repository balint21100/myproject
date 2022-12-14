using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meki_penztar_v01
{
    public partial class Screenlekero : Form
    {
        public int ablakwidth = 0;
        public int ablakheight = 0;
        public Screenlekero()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

        }

        private void Screenlekero_Load(object sender, EventArgs e)
        {
            ablakwidth = this.Width;
            ablakheight = this.Height;
            button1.PerformClick();
        }
    }
}
