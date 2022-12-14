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
    public partial class Visual : Form
    {
        Button[] gombok = new Button[90];
        Label[] label = new Label[20];
        public Visual()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <label.Length ; i++)
            {
                Label label1 = new Label();
                label1.Size = new Size(50, 50);
                label1.Image = Bitmap.FromFile(@"C:\Users\ivani\Desktop\kepek\Névtelen.png");
                int x = (i % 10) * 50;
                int y = (i / 10) * 50;
                if (true)
                {

                }
                label1.Location = new Point(x, y);

                label1.Click += new EventHandler(label1_Click);
                label1.BackColor = Color.Black;
                label1.Tag = "Hi";
                label[i] = label1;
                label1.Text = i.ToString();
                label1.ForeColor = Color.White;
                this.Controls.Add(label1);
            }
            for (int i = 0; i < 90; i++)
            {
                Button egygomb = new Button();
                egygomb.Size = new Size(50, 50);
                egygomb.Text = i.ToString();
                int x = (i % 10) * 50;
                int y = (i / 10) * 50;
                egygomb.Location = new Point(x, y);
                egygomb.Click += new EventHandler(button2_Click);
                egygomb.BackColor = Color.Red;
                egygomb.Tag = "Üdv.";
                gombok[i] = egygomb;
                this.Controls.Add(egygomb);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label tmb = (sender as Label);
            tmb.Visible = false;
            
        }
    }
}
