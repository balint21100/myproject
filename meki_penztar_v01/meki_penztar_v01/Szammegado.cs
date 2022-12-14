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
    public partial class Szammegado : Form
    {
        public Szammegado()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;


        }

        public string label1text = "";


        private void bt1_Click(object sender, EventArgs e)
        {
            label1.Text += 1.ToString();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            label1.Text += 2.ToString();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            label1.Text += 3.ToString();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            label1.Text += 4.ToString();
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            label1.Text += 5.ToString();
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            label1.Text += 6.ToString();
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            label1.Text += 7.ToString();
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            label1.Text += 8.ToString();
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            label1.Text += 9.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1text = label1.Text;
            label1.Text = "";
            if (label1text == "")
            {

            }
            else
            {
                for (int i = 0; i < label1text.Length - 1; i++)
                {
                    label1.Text += label1text[i];
                }
            }

        }

        
        private void button15_Click(object sender, EventArgs e)
        {
            Form3nagyssz f3nagysz = new Form3nagyssz();
            label1text = label1.Text;
            if (label1.Text == "" && label1.Text == "0")
            {
                label1text = "1";
            }
            if (Convert.ToInt32(label1.Text) > 999)
            {
                label1text = "999";
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += 0.ToString();
        }
    }
}
