using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csillahul
{
    public partial class Form3 : Form
    {
        public int kezdes_joga = 0;
        public int diff = 0;
        public Form3()
        {
            InitializeComponent();
        }
        
        public string jatek_nev
        {
            get
            {
                return textBox2.Text;
            }
        }
        public int kezdo
        {
            get
            {
                return kezdes_joga;
            }
        }
        public int nehezseg
        {
            get
            {
                return diff;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (playerstart.Checked)
            {
                kezdes_joga = 0;
            }
            else if (botstart.Checked)
            {
                kezdes_joga = 1;
            }
            else if (startrand.Checked)
            {
                kezdes_joga = 2;
            }
            if (boteasy.Checked)
            {
                diff = 1;
            }
            else if (bothard.Checked)
            {
                diff = 0;
            }
            else if (botmedium.Checked)
            {
                diff = 2;
            }
        }
    }
}
