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
    public partial class Form2 : Form
    {
        
        /*public class MouseOperations
        {
            [Flags]
            public enum MouseEventFlags
            {
                LeftDown = 0x00002,
                LeftUp = 0x00003
            }
        }*/
        public int osszes = 0;
        public int lepes = 0;
        public int[] tombcsillag = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        public int korjon = 0;
        public int nehze_könnyü = 0;
        public int botnehez = 0;
        
        public string formbezaras
        {
            get
            {
                return wichform.Text;
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
                wichform.Text = 1.ToString();
                seged.PerformClick();
                MessageBox.Show("A bot nyert :D \n A Játéknak vége");
                Form5 form5 = new Form5();
                form5.Show();
                Form2 form2 = new Form2();
                // this.Close();
            }

        }
        public void bot_visibliti_false()
        {
            if (label1.Visible == false && label2.Visible == false && label3.Visible == false && label4.Visible == false
                        && label5.Visible == false && label6.Visible == false && label7.Visible == false && label8.Visible == false
                        && label9.Visible == false && label10.Visible == false && label11.Visible == false && label12.Visible == false
                        && label13.Visible == false && label14.Visible == false && label15.Visible == false && label16.Visible == false
                        && label17.Visible == false && label18.Visible == false && label19.Visible == false && label20.Visible == false)
            {
                wichform.Text = 1.ToString();
                seged.PerformClick();
                MessageBox.Show("A játékos nyert \n A Játéknak vége");
                Form5 form5 = new Form5();
                form5.Show();
            }
        }




        public Form2()
        {
            InitializeComponent();
        }

        public string Vszoveg
        {
            get { return PlayerName.Text; }
            set { PlayerName.Text = value; }
        }

        public void hard_bot()
        {
            if (korjon == 0)
            {
                Random rnd = new Random();
                Random kivalaszt = new Random();
                lepes = rnd.Next(1, 4);
                int valsztott_szam = 0;
                int tombcsillaghossza = 0;
                for (int i = 0; i < tombcsillag.Length; i++)
                {
                    if (tombcsillag[i] > 0)
                    {
                        tombcsillaghossza++;
                    }
                }

                if (lepes > tombcsillaghossza && tombcsillaghossza < 4)
                {
                    lepes = tombcsillaghossza;
                }
                 #region másik verzió
                if (tombcsillaghossza == 20)
                {
                    lepes = 3;
                }
                else if (tombcsillaghossza == 19)
                {
                    lepes = 2;
                }
                else if (tombcsillaghossza == 18)
                {
                    lepes = 1;
                }
                else if (tombcsillaghossza == 16)
                {
                    lepes = 3;
                }
                else if (tombcsillaghossza == 15)
                {
                    lepes = 2;
                }
                else if (tombcsillaghossza == 14)
                {
                    lepes = 1;
                }

                else if (tombcsillaghossza == 12)
                {
                    lepes = 3;
                }
                else if (tombcsillaghossza == 11)
                {
                    lepes = 2;
                }
                else if (tombcsillaghossza == 10)
                {
                    lepes = 1;
                }
                else if (tombcsillaghossza == 8)
                {
                    lepes = 3;
                }
                else if (tombcsillaghossza == 7)
                {
                    lepes = 2;
                }
                else if (tombcsillaghossza == 6)
                {
                    lepes = 1;
                }
                else if (tombcsillaghossza == 4)
                {
                    lepes = 3;
                }
                else if (tombcsillaghossza == 3)
                {
                    lepes = 2;
                }
                else if (tombcsillaghossza == 2)
                {
                    lepes = 1;
                }
#endregion
          /*      if (tombcsillaghossza == 19)
                {
                    lepes = 3;
                }
                else if (tombcsillaghossza == 18)
                {
                    lepes = 2;
                }
                else if (tombcsillaghossza == 17)
                {
                    lepes = 1;
                }
                else if (tombcsillaghossza == 15)
                {
                    lepes = 3;
                }
                else if (tombcsillaghossza == 14)
                {
                    lepes = 2;
                }
                else if (tombcsillaghossza == 13)
                {
                    lepes = 1;
                }
    
                else if (tombcsillaghossza == 11)
                {
                    lepes = 3;
                }
                else if (tombcsillaghossza == 10)
                {
                    lepes = 2;
                }
                else if (tombcsillaghossza == 9)
                {
                    lepes = 1;
                }
                else if (tombcsillaghossza == 7)
                {
                    lepes = 3;
                }
                else if (tombcsillaghossza == 6)
                {
                    lepes = 2;
                }
                else if (tombcsillaghossza == 5)
                {
                    lepes = 1;
                }
                else if (tombcsillaghossza == 3)
                {
                    lepes = 3;
                }
                else if (tombcsillaghossza == 2)
                {
                    lepes = 2;
                }
                else if (tombcsillaghossza == 1)
                {
                    lepes = 1;
                }*/
                while (lepes > 0)
                {
                    if (label1.Visible == false && label2.Visible == false && label3.Visible == false && label4.Visible == false
                        && label5.Visible == false && label6.Visible == false && label7.Visible == false && label8.Visible == false
                        && label9.Visible == false && label10.Visible == false && label11.Visible == false && label12.Visible == false
                        && label13.Visible == false && label14.Visible == false && label15.Visible == false && label16.Visible == false
                        && label17.Visible == false && label18.Visible == false && label19.Visible == false && label20.Visible == false)
                    {

                        MessageBox.Show("A Bot nyert \n A Játéknak vége");
                        Form5.ActiveForm.Show();
                    }
                    label21.Text = "lépések száma: " + lepes.ToString();
                    valsztott_szam = kivalaszt.Next(1, 21);
                    
                    if (tombcsillag[valsztott_szam - 1] > 0)
                    {
                        tombcsillag[valsztott_szam - 1] = 0;
                        label21.Text = "Lépések száma: " + lepes.ToString();
                        lepes--;
                        switch (valsztott_szam)
                        {
                            case 1:
                                label1.Visible = false;
                                break;
                            case 2:
                                label2.Visible = false;
                                break;
                            case 3:
                                label3.Visible = false;
                                break;
                            case 4:
                                label4.Visible = false;
                                break;
                            case 5:
                                label5.Visible = false;
                                break;
                            case 6:
                                label6.Visible = false;
                                break;
                            case 7:
                                label7.Visible = false;
                                break;
                            case 8:
                                label8.Visible = false;
                                break;
                            case 9:
                                label9.Visible = false;
                                break;
                            case 10:
                                label10.Visible = false;
                                break;
                            case 11:
                                label11.Visible = false;
                                break;
                            case 12:
                                label12.Visible = false;
                                break;
                            case 13:
                                label13.Visible = false;
                                break;
                            case 14:
                                label14.Visible = false;
                                break;
                            case 15:
                                label15.Visible = false;
                                break;
                            case 16:
                                label16.Visible = false;
                                break;
                            case 17:
                                label17.Visible = false;
                                break;
                            case 18:
                                label18.Visible = false;
                                break;
                            case 19:
                                label19.Visible = false;
                                break;
                            case 20:
                                label20.Visible = false;
                                break;
                            default:

                                break;
                        }
                    }
                    else
                    {

                    }
                }
                    bot_visibliti_false();
                    if (lepes == 0)
                    {
                        korjon = 1;
                        button1korvege.PerformClick();
                    }
                
            }
        }

            public void bot()
        {
            if (korjon == 0)
            {
                Random rnd = new Random();
                Random kivalaszt = new Random();
                lepes = rnd.Next(1, 4);
                int valsztott_szam = 0;
                int tombcsillaghossza = 0;
                for (int i = 0; i < tombcsillag.Length; i++)
                {
                    if (tombcsillag[i]>0)
                    {
                        tombcsillaghossza++;
                    }
                }
                /*if (tombcsillaghossza < 4)
                {
                    lepes = 3;
                }*/
                if (lepes > tombcsillaghossza && tombcsillaghossza < 4 )
                {
                    if (tombcsillaghossza == 3)
                    {
                        lepes = 3;
                    }
                    if (tombcsillaghossza == 2)
                    {
                        lepes = 2;
                    }
                    lepes = tombcsillaghossza;
                }
                while (lepes > 0)
                {
                    if (label1.Visible == false && label2.Visible == false && label3.Visible == false && label4.Visible == false
                        && label5.Visible == false && label6.Visible == false && label7.Visible == false && label8.Visible == false
                        && label9.Visible == false && label10.Visible == false && label11.Visible == false && label12.Visible == false
                        && label13.Visible == false && label14.Visible == false && label15.Visible == false && label16.Visible == false
                        && label17.Visible == false && label18.Visible == false && label19.Visible == false && label20.Visible == false )
                    {

                        MessageBox.Show("A Bot nyert \n A Játéknak vége");
                        Form5.ActiveForm.Show();
                    }
                        label21.Text = "lépések száma: " + lepes.ToString();
                        valsztott_szam = kivalaszt.Next(1, 21);
                        if (tombcsillag[valsztott_szam - 1] > 0)
                        {
                            tombcsillag[valsztott_szam - 1] = 0;
                            label21.Text = "Lépések száma: " + lepes.ToString();
                            lepes--;
                            switch (valsztott_szam)
                            {
                                case 1:
                                    label1.Visible = false;
                                    break;
                                case 2:
                                    label2.Visible = false;
                                    break;
                                case 3:
                                    label3.Visible = false;
                                    break;
                                case 4:
                                    label4.Visible = false;
                                    break;
                                case 5:
                                    label5.Visible = false;
                                    break;
                                case 6:
                                    label6.Visible = false;
                                    break;
                                case 7:
                                    label7.Visible = false;
                                    break;
                                case 8:
                                    label8.Visible = false;
                                    break;
                                case 9:
                                    label9.Visible = false;
                                    break;
                                case 10:
                                    label10.Visible = false;
                                    break;
                                case 11:
                                    label11.Visible = false;
                                    break;
                                case 12:
                                    label12.Visible = false;
                                    break;
                                case 13:
                                    label13.Visible = false;
                                    break;
                                case 14:
                                    label14.Visible = false;
                                    break;
                                case 15:
                                    label15.Visible = false;
                                    break;
                                case 16:
                                    label16.Visible = false;
                                    break;
                                case 17:
                                    label17.Visible = false;
                                    break;
                                case 18:
                                    label18.Visible = false;
                                    break;
                                case 19:
                                    label19.Visible = false;
                                    break;
                                case 20:
                                    label20.Visible = false;
                                    break;
                                default:

                                    break;
                            }
                        }
                        else
                        {

                        }


                }
                bot_visibliti_false();
                if (lepes == 0)
                {
                    korjon = 1;
                    button1korvege.PerformClick();
                }
            }
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
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
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
            radioButton1easy.Checked = true;
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
            using (Form3 form3 = new Form3())
            {
                if (form3.ShowDialog() == DialogResult.Yes) 
                {
                    PlayerName.Text = form3.jatek_nev;
                    kezdojog.Text = form3.kezdes_joga.ToString();
                    difficulities.Text = form3.nehezseg.ToString();
                    
                }
            }
            wichform.Text = "";
             nehze_könnyü = int.Parse(difficulities.Text);
            if (nehze_könnyü == 1)
            {
                radioButton1easy.Checked = true;
            }
            else if (nehze_könnyü == 0)
            {
                radioButton2hard.Checked = true;
            }
            else if (nehze_könnyü == 2)
            {
                radioButton3medium.Checked = true;
            }
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
            if (int.Parse(kezdojog.Text)== 0)
            {
                MessageBox.Show("A kört a játékos kezdi");
            }
            if (int.Parse(kezdojog.Text) == 1)
            {
                if (radioButton1easy.Checked == true)
                {
                    bot();
                    MessageBox.Show("A kört a bot kezdi");
                }
                else if (radioButton2hard.Checked == true)
                {
                    hard_bot();
                    MessageBox.Show("A kört a bot kezdi");
                }
                else if (radioButton3medium.Checked)
                {
                    Random korvalasz = new Random();
                    botnehez = korvalasz.Next(0, 2);
                    if (botnehez == 0)
                    {
                        bot();
                        MessageBox.Show("A kört a bot kezdi");
                    }
                    else if (botnehez == 1)
                    {
                        hard_bot();
                        MessageBox.Show("A kört a bot kezdi");
                    }
                }
            }
            
            Random rnd = new Random();
            if (int.Parse(kezdojog.Text) == 2)
            {
                int sorsolas = rnd.Next(0, 2);

                if (sorsolas == 0)
                {
                    if (radioButton1easy.Checked == true)
                    {
                        bot();
                        MessageBox.Show("A kört a bot kezdi");
                    }
                    else if (radioButton2hard.Checked == true)
                    {
                        hard_bot();
                        MessageBox.Show("A kört a bot kezdi");
                    }

                }
                else if (sorsolas == 1)
                {
                    MessageBox.Show("A kört a játékos kezdi");
                }
            }
            
            lepes = 3;
            label21.Text = "lépések száma: " + lepes.ToString();
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

            }
            
            else if (korjon == 0)
            {
                if (nehze_könnyü < 2 || radioButton3medium.Checked == false)
                {


                    if (radioButton1easy.Checked)
                    {

                        bot();
                        label21.Text = "lépések száma: " + lepes.ToString();
                        //korjon = 1;
                        //korjon = 1;

                    }
                    else if (radioButton2hard.Checked)
                    {
                        hard_bot();
                        label21.Text = "lépések száma: " + lepes.ToString();
                        //korjon = 1;
                    }
                }
                else if (nehze_könnyü == 2 || radioButton3medium.Checked == true)
                {
                    Random valasztas = new Random();
                    botnehez = valasztas.Next(0, 2);
                    if (botnehez == 0)
                    {
                        bot();
                        label21.Text = "lépések száma: " + (lepes-1).ToString();
                    }
                    else if (botnehez == 1)
                    {
                        hard_bot();
                        label21.Text = "lépések száma: " + (lepes-1).ToString();
                    }
                }
            }
            
        }
        #endregion

        private void label2_Click_1(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("A játéknak lényege hogy ugy tudd át adni a kört hogy ellenfeled vegye le az utolsó csillagot" +
                "\n Játékszabályok: " +
                "\n 1. Az nyer aki nem veszi le az utolsó csillagot" +
                "\n 2.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void seged_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            
        }
    }
}
