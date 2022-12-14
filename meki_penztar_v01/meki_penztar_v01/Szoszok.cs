using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
namespace meki_penztar_v01
{
    public partial class Szoszok : Form
    {
        public string connectionstring = @"datasource=127.0.0.1;port=3306;username=root;password=;database=penztar_adatbazis";
        MySqlConnection connection;
        public List<Button> szoszgombok = new List<Button>();
        public List<szoszokclass> szoszoklista = new List<szoszokclass>();
        public List<Button> ontetgombok = new List<Button>();
        public List<ontetclass> ontetlista = new List<ontetclass>();

        public List<string> lista = new List<string>();
        public int ar = 0;
        public int egesz = 0;
        public int ablakwidth = 0;
        public int ablakheight = 0;

        public string oldal_valaszt = "";



        public szoszokclass szosz1 = new szoszokclass();
        public ontetclass ontet1 = new ontetclass();

        public Color activcolor1 = Color.FromArgb(0,255,255);
        public Color nemactivcolor2 = Color.FromArgb(64, 224, 208);
        public Font gombofont = new Font("Calibri", 14);
        

        public Szoszok()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            connection = new MySqlConnection(connectionstring);
        }
        public string[] szoszoktomb = new string[6]; 
        public int szamolo = 1;

       public class szoszokclass
        {
            public string szoszok;
            public int ar;
        }

        public class ontetclass
        {
            public string ontet;
            public int ar;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(mennyiseg.Text)<999)
            {
                szamolo = Convert.ToInt32(mennyiseg.Text);
                szamolo++;
                mennyiseg.Text = szamolo.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(mennyiseg.Text)>1)
            {
                szamolo = Convert.ToInt32(mennyiseg.Text);
                szamolo--;
                mennyiseg.Text = szamolo.ToString();
            }
        }


        private void szoszok_lekerese()
        {
            connection.Open();

            string szoszosql_lekerese = "SELECT szosz_nev, szosz_ar FROM Szoszok WHERE szosz_nev IS NOT NULL";
            MySqlCommand command = new MySqlCommand(szoszosql_lekerese, connection);
            MySqlDataReader lekero;
            lekero = command.ExecuteReader();
            int l = 0;
            string output = "";
            while (lekero.Read())
            {
                szoszokclass szoszok = new szoszokclass();
                szoszok.szoszok = Convert.ToString($"{lekero.GetValue(0)}");
                szoszok.ar = Convert.ToInt32(lekero.GetValue(1));
                szoszoklista.Add(szoszok);
                output += $"{lekero.GetValue(0).ToString()}";
                l = l + 1;
            }
            //MessageBox.Show(output);
            lekero.Close();
            command.Dispose();
            connection.Close();
        }

        public void szoszgombclick(object sender, EventArgs e)
        {
            Button tmp = new Button();
            tmp = sender as Button;


            foreach (var item in ontetgombok)
            {
                item.BackColor = nemactivcolor2;
            }

            foreach (var item in szoszgombok)
            {
                if (item.BackColor == activcolor1)
                {
                    item.BackColor = nemactivcolor2;
                }
                
            }


            tmp.BackColor = activcolor1;

            foreach (var item in szoszoklista)
            {
                if (tmp.Tag.ToString() == item.szoszok)
                {
                    szosz1.szoszok = item.szoszok;
                    szosz1.ar = item.ar;
                    label6.Text = ($"{szosz1.szoszok} szósz {mennyiseg.Text} db {szosz1.ar * Convert.ToInt32(mennyiseg.Text)} Ft"); 
                }
            }

            mennyiseg.Text = "1";

            button6.Enabled = true;
            button4.Enabled = false;
            button8.Enabled = true;
            button9.Enabled = true;
            mennyiseg.Enabled = true;
        }



        private void szosz_gombok_felrakasa()
        {
            
            
            for (int i = 0; i < szoszoklista.Count; i++)
            {
                Button tmg = new Button();
                tmg.Size = new Size(130, 80);
                int x = (i % 3) * 140 + 10;
                int y = (i / 3) * 80 + 10;
                tmg.BackColor = nemactivcolor2;
                tmg.Font = gombofont;
                tmg.Location = new Point(x, y);
                tmg.TextAlign = ContentAlignment.MiddleCenter;
                tmg.Click += new EventHandler(szoszgombclick);
                tmg.Text = alsovonal(szoszoklista[i].szoszok);
                tmg.Tag = szoszoklista[i].szoszok;
                szoszgombok.Add(tmg);
                //this.Controls.Add(tmg);
                flowLayoutPanel2.Controls.Add(tmg);
                
                
            }
            foreach (var item in szoszoklista)
            {

            }
        }


        private string arvaltozas(string ara)
        {
            string[] osszese = ara.Split(' ');
            string elose = osszese[0];

            int szosz_ontet = 0;
            string ertek = "";

            foreach (var item in osszese)
            {
                if (item.Contains("öntet"))
                {
                    szosz_ontet = 1;
                    break;
                }
                else
                {
                    szosz_ontet = 0;
                }
            }
            if (szosz_ontet == 0)
            {
                

                

                for (int i = 0; i < szoszoklista.Count; i++)
                {
                    if (szoszoklista[i].szoszok.Contains(elose))
                    {
                        ertek = szoszoklista[i].ar.ToString();
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < ontetlista.Count; i++)
                {
                    if (ontetlista[i].ontet.Contains(elose))
                    {

                        ertek = ontetlista[i].ar.ToString();

                        //return ontetlista[i].ar.ToString();
                        break;
                        
                    }
                }
            }

            return ertek;

        }

        private void ontetek_lekerese()
        {
            connection.Open();

            string szoszosql_lekerese = "SELECT ontet_nev, ontet_ar FROM ontet WHERE ontet_nev IS NOT NULL";
            MySqlCommand command = new MySqlCommand(szoszosql_lekerese, connection);
            MySqlDataReader lekero;
            lekero = command.ExecuteReader();
            int l = 0;
            string output = "";
            while (lekero.Read())
            {
                ontetclass ontetek = new ontetclass();
                ontetek.ontet = lekero.GetValue(0).ToString();
                ontetek.ar = Convert.ToInt32(lekero.GetValue(1));
                ontetlista.Add(ontetek);
                output += $"{lekero.GetValue(0).ToString()};";
                l = l + 1;
            }
            //MessageBox.Show(output);
            lekero.Close();
            command.Dispose();
            connection.Close();
        }

        private void ontet_gombok_felrakasa()
        {


            for (int i = 0; i < ontetlista.Count; i++)
            {
                Button tmg = new Button();
                tmg.Size = new Size(130, 80);
                int x = (i % 3) * 140 + 10;
                int y = (i / 3) * 80 + 10;
                tmg.BackColor = nemactivcolor2;
                tmg.TextAlign = ContentAlignment.MiddleCenter;
                tmg.Font = gombofont;
                tmg.Location = new Point(x, y);
                tmg.Click += new EventHandler(ontegombclick);
                tmg.Text = alsovonal(ontetlista[i].ontet);
                tmg.Tag = ontetlista[i].ontet;
                ontetgombok.Add(tmg);
                flowLayoutPanel1.Controls.Add(tmg);


            }
            foreach (var item in szoszoklista)
            {

            }
        }




        public void ontegombclick(object sender, EventArgs e)
        {
            Button tmp = new Button();
            tmp = sender as Button;


            foreach (var item in szoszgombok)
            {
                item.BackColor = nemactivcolor2;
            }


            foreach (var item in ontetgombok)
            {
                if (item.BackColor == activcolor1)
                {
                    item.BackColor = nemactivcolor2;
                }

            }


            tmp.BackColor = activcolor1;

            foreach (var item in ontetlista)
            {
                if (tmp.Tag.ToString() == item.ontet)
                {
                    ontet1.ontet = item.ontet;
                    ontet1.ar = item.ar;
                    label6.Text = ($"{ontet1.ontet} öntet {mennyiseg.Text} db {ontet1.ar * Convert.ToInt32(mennyiseg.Text)} Ft");
                }
            }

            mennyiseg.Text = "1";
            button4.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button6.Enabled = false;
            mennyiseg.Enabled = true;

        }


        public string alsovonal(string sor) 
        {

            string atalakitott = sor.Replace('_', '\n');


            return atalakitott;

        }





        private void Szoszok_Load(object sender, EventArgs e)
        {
            Screenlekero screenlekero = new Screenlekero();
            if (screenlekero.ShowDialog() == DialogResult.OK)
            {
                ablakwidth = screenlekero.ablakwidth;
                ablakheight = screenlekero.ablakheight;
            }
            int ablak_feleszel = 0;
            int ablak_fele2magas = 0;

            ablak_feleszel = ablakwidth / 2;
            ablak_fele2magas = ablakheight / 2;
            this.Location = new Point(ablak_feleszel - this.Width / 2, ablak_fele2magas - this.Height / 2);
            szoszok_lekerese();
            szosz_gombok_felrakasa();
            ontetek_lekerese();
            ontet_gombok_felrakasa();



        }

        private void button7_Click(object sender, EventArgs e)
        {
            szoszok_lekerese();
            szosz_gombok_felrakasa();
            ontetek_lekerese();
            ontet_gombok_felrakasa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = listBox1.SelectedIndex;
            if (x > -1)
            {

                string arkereső = listBox1.Items[x].ToString();
                string[] are = arkereső.Split(' ');
                int ertek = 0;
                for (int i = 0; i < are.Length; i++)
                {

                    if (are[i] == "Ft")
                    {
                        ertek = Convert.ToInt32(are[i - 1]);
                    }

                }
                int ertekosszes = Convert.ToInt32(label4.Text);
                int erteke = ertekosszes - ertek;

                listBox1.Items.RemoveAt(x);
                label4.Text = erteke.ToString();

                if (listBox1.Items.Count == 0)
                {
                    button2.Enabled = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string szoszadd = $"{szosz1.szoszok} {mennyiseg.Text} db {szosz1.ar* int.Parse(mennyiseg.Text)} Ft";
            
            if (label4.Text != "")
            {
                ar = Convert.ToInt32(label4.Text);
                label4.Text = (ar + szosz1.ar * Convert.ToInt32(mennyiseg.Text)).ToString();
            }
            else
            {
                label4.Text = (szosz1.ar * int.Parse(mennyiseg.Text)).ToString();
            }
            
              

            listBox1.Items.Add($"{szoszadd}");
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (var item in listBox1.Items)
            {

                lista.Add(item.ToString());
                

            }
            if (label4.Text == "")
            {
                ar = 0;
            }
            else
            {


                ar = int.Parse(label4.Text);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ontetadd = $"{ontet1.ontet} {mennyiseg.Text} db {ontet1.ar * int.Parse(mennyiseg.Text)} Ft";

            if (label4.Text != "")
            {
                ar = Convert.ToInt32(label4.Text);
                label4.Text = (ar + ontet1.ar * Convert.ToInt32(mennyiseg.Text)).ToString();
            }
            else
            {
                label4.Text = (ontet1.ar * int.Parse(mennyiseg.Text)).ToString();
            }


            listBox1.Items.Add(ontetadd);
            button2.Enabled = true;

        }

        private void arertekkiiras()
        {



        }

        private void mennyiseg_TextChanged(object sender, EventArgs e)
        {
            if (label6.Text != "")
            {

                string[] split = label6.Text.Split(' ');

                for (int i = 0; i < split.Length; i++)
                {
                    if (split[i] == "db")
                    {

                        split[i - 1] = mennyiseg.Text;

                    }

                    

                }

                for (int i = 0; i < split.Length; i++)
                {
                    if (split[i] == "Ft")
                    {

                        int szam = Convert.ToInt32(arvaltozas(label6.Text));
                        split[i - 1] = (szam * Convert.ToInt32(mennyiseg.Text)).ToString();

                    }
                }

                string sorvisszaalakitas = "";
                for (int i = 0; i < split.Length; i++)
                {

                    if (i == 0)
                    {
                        sorvisszaalakitas = split[i];
                    }
                    else
                    {
                        sorvisszaalakitas += " " + split[i];
                    }
                    

                }

                label6.Text = sorvisszaalakitas;

            }
        }

        private void mennyiseg_Click(object sender, EventArgs e)
        {

            Szammegado szammeg = new Szammegado();
            if (szammeg.ShowDialog() == DialogResult.OK)
            {
                mennyiseg.Text = szammeg.label1text;
            }

        }

        private void listBox1_TabIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {


                button2.Enabled = false;

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
