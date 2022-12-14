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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Location= new Point(150,200);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Singleplayer_Click(object sender, EventArgs e)
        {
            //Form3 form3 = new Form3(this);
            //form3.Show();
            Form2 form2 = new Form2();
            form2.Show();
            Form1 form1 = new Form1();
            form1.Visible = false;
            form2.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Singelplayerbe bot ellen tudsz játszani ahol ki tudod választani hogy easy vagy hard bot legyen" +
                "\n Multiplayerbe barátaiddal ismerősieddel összemérheted logikai képpességedet");
        }

        private void Teszt_Click(object sender, EventArgs e)
        {
            Visual visual = new Visual();
            visual.Show();
        }
    }
}
