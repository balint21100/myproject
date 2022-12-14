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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public int osszes = 0;
        public int lepes = 0;
        public int[] tombcsillag = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        public int korjon = 0;
        public int winner = 0;

        public string form4
        {
            get
            {
                return wichforms.Text;
            }
        }

        public void visibiliti_false()
        {
            if (label1.Visible == false && label2.Visible == false && label3.Visible == false && label4.Visible == false
                        && label5.Visible == false && label6.Visible == false && label7.Visible == false && label8.Visible == false
                        && label9.Visible == false && label10.Visible == false && label11.Visible == false && label12.Visible == false
                        && label13.Visible == false && label14.Visible == false && label15.Visible == false && label16.Visible == false
                        && label17.Visible == false && label18.Visible == false && label19.Visible == false && label20.Visible == false)
            {
                if (winner == 0)
                {
                    wichforms.Text = "1";
                    MessageBox.Show($"{textBox1.Text} Nyert :D \n A Játéknak vége");
                }
                else if (winner == 1)
                {
                    wichforms.Text = "1";
                    MessageBox.Show($"{textBox2.Text} Nyert :D \n A játéknak vége");
                }
                
                Form5 form5 = new Form5();
                form5.Show();
                Form2 form2 = new Form2();
                // this.Close();
            }

        }
        




        


        public string Vszoveg
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        

        
                
      
        public void label_visible()
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;

            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;

            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;

            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            int elso = int.Parse(label1.Text);
            int masodik = int.Parse(label2.Text);
            int harmadik = int.Parse(label3.Text);
            int negyedik = int.Parse(label4.Text);
            int otodik = int.Parse(label5.Text);
            int hatodik = int.Parse(label6.Text);
            int hetedik = int.Parse(label7.Text);
            int nyolcadik = int.Parse(label8.Text);
            int kilencedik = int.Parse(label9.Text);
            int tizedik = int.Parse(label10.Text);
            int tegyedik = int.Parse(label11.Text);
            int tmasodik = int.Parse(label12.Text);
            int tharmadik = int.Parse(label13.Text);
            int tnegyedik = int.Parse(label14.Text);
            int totodik = int.Parse(label15.Text);
            int thatodik = int.Parse(label16.Text);
            int thetedik = int.Parse(label17.Text);
            int tnyolcadik = int.Parse(label18.Text);
            int tkilencedik = int.Parse(label19.Text);
            int huszadik = int.Parse(label20.Text);
            osszes = elso + masodik + harmadik + negyedik + otodik + hatodik + hetedik + nyolcadik + kilencedik + tizedik + tegyedik + tmasodik
                    + tharmadik + tnegyedik + totodik + thatodik + thetedik + tnyolcadik + tkilencedik + huszadik;
            /*label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;

            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;

            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;

            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;*/

        }
        private void buttonstart_Click(object sender, EventArgs e)
        {
            
            using(Form6 form6 = new Form6())
            {
                if (form6.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = form6.Player1;
                    textBox2.Text = form6.Player2;
                    starter.Text = form6.start_find.ToString();
                    
                }
                
            }
            wichforms.Text = "";
            
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;

            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;

            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;

            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;

            for (int i = 0; i < tombcsillag.Length; i++)
            {
                tombcsillag[i] = i + 1;
            }

            Random rnd = new Random();
            int sorsolas = rnd.Next(0, 2);
            if (int.Parse(starter.Text) <3 )
            {
                sorsolas = int.Parse(starter.Text);
            }
            if (sorsolas == 0)
            {
                MessageBox.Show($"A játékot {textBox2.Text} kezdi");
                korjon = 1;
                thisturn.Text = $"{textBox2.Text} van körön";
            }
            else if (sorsolas == 1)
            {
                MessageBox.Show($"A játékot {textBox1.Text} kezdi");
                korjon = 0;
                thisturn.Text = $"{textBox1.Text} van körön";
            }
            lepes = 3;
            label21.Text = "lépések száma: " + lepes.ToString();
            thisturn.Visible = true;
            starter.Visible = false;
            /*label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;

            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;

            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;

            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;*/
        }
        #region Start
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        #endregion
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #region label1
        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            osszes = osszes - int.Parse(label1.Text);
            if (lepes > 0)
            {
                tombcsillag[int.Parse(label1.Text) - 1] = 0;
                lepes--;
                label21.Text = "lépések száma: " + lepes.ToString();
                label1.Visible = false;
                visibiliti_false();
                
            }
            else
            {

            }
        }
        #endregion
        private void Form2_Click(object sender, EventArgs e)
        {

        }
        #region körvége
        private void button1korvege_Click(object sender, EventArgs e)
        {
            if (korjon == 1)
            {
                korjon = 0;
                lepes = 3;
                label21.Text = "lépések száma: " + lepes.ToString();
                winner = 1;
                thisturn.Text = $"{textBox1.Text}'s turn ";
            }

            else if (korjon == 0)
            {
                korjon = 1;
                lepes = 3;
                label21.Text = "lépések száma: " + lepes.ToString();
                winner = 0;
                thisturn.Text = $"{textBox2.Text} van körön";
            }

        }
        #endregion

        private void label2_Click(object sender, EventArgs e)
        {
            osszes = osszes - int.Parse(label2.Text);
            if (lepes > 0)
            {
                tombcsillag[int.Parse(label2.Text) - 1] = 0;
                lepes--;
                label21.Text = "lépések száma: " + lepes.ToString();
                label2.Visible = false;
                visibiliti_false();

            }
            else
            {

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            osszes = osszes - int.Parse(label3.Text);
            if (lepes > 0)
            {

                tombcsillag[int.Parse(label3.Text) - 1] = 0;
                lepes--;
                label21.Text = "lépések száma: " + lepes.ToString();
                label3.Visible = false;
                visibiliti_false();

            }
            else
            {

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            osszes = osszes - int.Parse(label4.Text);
            if (lepes > 0)
            {
                tombcsillag[int.Parse(label4.Text) - 1] = 0;
                lepes--;
                label21.Text = "lépések száma: " + lepes.ToString();
                label4.Visible = false;
                visibiliti_false();

            }
            else
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            osszes = osszes - int.Parse(label5.Text);
            if (lepes > 0)
            {
                tombcsillag[int.Parse(label5.Text) - 1] = 0;
                lepes--;
                label21.Text = "lépések száma: " + lepes.ToString();
                label5.Visible = false;
                visibiliti_false();

            }
            else
            {

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            osszes = osszes - int.Parse(label6.Text);
            if (lepes > 0)
            {
                tombcsillag[int.Parse(label6.Text) - 1] = 0;
                lepes--;
                label21.Text = "lépések száma: " + lepes.ToString();
                label6.Visible = false;
                visibiliti_false();

            }
            else
            {

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            osszes = osszes - int.Parse(label7.Text);
            if (lepes > 0)
            {
                tombcsillag[int.Parse(label7.Text) - 1] = 0;
                lepes--;
                label21.Text = "lépések száma: " + lepes.ToString();
                label7.Visible = false;
                visibiliti_false();

            }
            else
            {

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            osszes = osszes - int.Parse(label8.Text);
            if (lepes > 0)
            {
                tombcsillag[int.Parse(label8.Text) - 1] = 0;
                lepes--;
                label21.Text = "lépések száma: " + lepes.ToString();
                label8.Visible = false;
                visibiliti_false();

            }
            else
            {

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            osszes = osszes - int.Parse(label9.Text);
            if (lepes > 0)
            {
                tombcsillag[int.Parse(label9.Text) - 1] = 0;
                lepes--;
                label21.Text = "lépések száma: " + lepes.ToString();
                label9.Visible = false;
                visibiliti_false();

            }
            else
            {

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            osszes = osszes - int.Parse(label10.Text);
            if (lepes > 0)
            {
                tombcsillag[int.Parse(label10.Text) - 1] = 0;
                lepes--;
                label21.Text = "lépések száma: " + lepes.ToString();
                label10.Visible = false;
                visibiliti_false();

            }
            else
            {

            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            osszes = osszes - int.Parse(label11.Text);
            if (lepes > 0)
            {
                tombcsillag[int.Parse(label11.Text) - 1] = 0;
                lepes--;
                label21.Text = "lépések száma: " + lepes.ToString();
                label11.Visible = false;
                visibiliti_false();

            }
            else
            {

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            osszes = osszes - int.Parse(label12.Text);
            if (lepes > 0)
            {
                tombcsillag[int.Parse(label12.Text) - 1] = 0;
                lepes--;
                label21.Text = "lépések száma: " + lepes.ToString();
                label12.Visible = false;
                visibiliti_false();

            }
            else
            {

            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            osszes = osszes - int.Parse(label13.Text);
            if (lepes > 0)
            {
                tombcsillag[int.Parse(label13.Text) - 1] = 0;
                lepes--;
                label21.Text = "lépések száma: " + lepes.ToString();
                label13.Visible = false;
                visibiliti_false();

            }
            else
            {

            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            osszes = osszes - int.Parse(label14.Text);
            if (lepes > 0)
            {
                tombcsillag[int.Parse(label14.Text) - 1] = 0;
                lepes--;
                label21.Text = "lépések száma: " + lepes.ToString();
                label14.Visible = false;
                visibiliti_false();

            }
            else
            {

            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            osszes = osszes - int.Parse(label15.Text);
            if (lepes > 0)
            {
                tombcsillag[int.Parse(label15.Text) - 1] = 0;
                lepes--;
                label21.Text = "lépések száma: " + lepes.ToString();
                label15.Visible = false;
                visibiliti_false();

            }
            else
            {

            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            osszes = osszes - int.Parse(label16.Text);
            if (lepes > 0)
            {
                tombcsillag[int.Parse(label16.Text) - 1] = 0;
                lepes--;
                label21.Text = "lépések száma: " + lepes.ToString();
                label16.Visible = false;
                visibiliti_false();

            }
            else
            {

            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            osszes = osszes - int.Parse(label17.Text);
            if (lepes > 0)
            {
                tombcsillag[int.Parse(label17.Text) - 1] = 0;
                lepes--;
                label21.Text = "lépések száma: " + lepes.ToString();
                label17.Visible = false;
                visibiliti_false();

            }
            else
            {

            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            osszes = osszes - int.Parse(label18.Text);
            if (lepes > 0)
            {
                tombcsillag[int.Parse(label18.Text) - 1] = 0;
                lepes--;
                label21.Text = "lépések száma: " + lepes.ToString();
                label18.Visible = false;
                visibiliti_false();

            }
            else
            {

            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            osszes = osszes - int.Parse(label19.Text);
            if (lepes > 0)
            {
                tombcsillag[int.Parse(label19.Text) - 1] = 0;
                lepes--;
                label21.Text = "lépések száma: " + lepes.ToString();
                label19.Visible = false;
                visibiliti_false();

            }
            else
            {

            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            osszes = osszes - int.Parse(label20.Text);
            if (lepes > 0)
            {
                tombcsillag[int.Parse(label20.Text) - 1] = 0;
                lepes--;
                label21.Text = "lépések száma: " + lepes.ToString();
                label20.Visible = false;
                visibiliti_false();

            }
            else
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*label1.SetBounds(181, 103, 98, 94);
            label2.SetBounds(label1.Location(valu), 103, 98, 94);*/
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Üdvözöllek a CSillaghullás játékban \n" +
                " A Játékszabályok a következők: \n " +
                "1. Az nyer aki az utolsó csillagot nem tudja levenni \n" +
                "2. Egy körben maximum 3-at lehet lépni\n" +
                "\n" +
                "Jó játékot kívánok");
        }
    }
}
