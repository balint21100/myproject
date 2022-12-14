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
    public partial class Form6 : Form
    {
        public int start_find = 0;
        public Form6()
        {
            InitializeComponent();
        }
        public string Player1
        {
            get
            {
                return textBox1.Text;
            }
        }
        public string Player2
        {
            get
            {
                return textBox2.Text;
            }
        }
        public int starter
        {
            get
            {
                return start_find;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                start_find = 1;
            }
            else if (radioButton2.Checked)
            {
                start_find = 0;
            }
            else if (radioButton3.Checked)
            {
                start_find = 2;
            }
        }
    }
}
