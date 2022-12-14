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
    public partial class Form1 : Form
    {
        public int hanyadik = 0;
        public string connectionstring = @"datasource=127.0.0.1;port=3306;username=root;password=;database=penztar_adatbazis";
        MySqlConnection connection;

        public string belepettfelhasznalo = "";




        public string Label1Text
        {
            get { return vegosszegelbl.Text; }
            set { vegosszegelbl.Text = value; }
        }


        public int ablakwidth = 0;
        public int ablakheight = 0;

        public void Osszesen()
        {
            button2.PerformClick();
        }
        public List<string> l = new List<string>();
        public List<string> osszeslista = new List<string>();
        public Form1()
        {
            InitializeComponent();
            button2.PerformClick();
            //FormBorderStyle = FormBorderStyle.None;
            FormBorderStyle = FormBorderStyle.None;
            
            //WindowState = FormWindowState.Maximized; //fullsrcreen
            vegosszegelbl.Text = vegosszeg_form1.ToString();
        }
        public int vegosszeg_form1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            UserControl1 us = new UserControl1();
            us.Show();
        }

        private void btkisszendvics_Click(object sender, EventArgs e)
        {
            Form2kissz Form2kissz = new Form2kissz();
            Form2kissz.Show();
            this.Hide();
            
            
        }

        private void btnagyszendvicsek_Click(object sender, EventArgs e)
        {
            Form3nagyssz form3nnagyssz = new Form3nagyssz();
            form3nnagyssz.ablakwidth = ablakwidth;
            form3nnagyssz.ablakheight = ablakheight;
            form3nnagyssz.Show();
            form3nnagyssz.felhasznalon.Tag = belepettfelhasznalo;
            form3nnagyssz.belepettfelhasznalo = belepettfelhasznalo;
            foreach (var item in osszeslista)
            {
                form3nnagyssz.nagyszlista.Add(item);
            }
            
            form3nnagyssz.vegar += vegosszeg_form1;
            this.Hide();
        }

        private void btsalata_Click(object sender, EventArgs e)
        {

            Form4salatak form4salatak = new Form4salatak();

            form4salatak.ablakwidth = ablakwidth;
            form4salatak.ablakheight = ablakheight;
            form4salatak.felhasznal.Tag = belepettfelhasznalo;
            foreach (var item in osszeslista)
            {
                form4salatak.nagyszlista.Add(item);
            }
            form4salatak.vegar += vegosszeg_form1;
            form4salatak.Show();
            form4salatak.belepettfelhasznalo = belepettfelhasznalo;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form3nagyssz f3 = new Form3nagyssz();
            vegosszegelbl.Text = $"{vegosszeg_form1} Ft";
            //vegosszegelbl.Text = f3.vegar.ToString();
            //Label1Text = vegosszeg_form1.ToString();
            //vegosszegelbl.Text = " valamicske";
        }

        private void listBox1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_ValueMemberChanged(object sender, EventArgs e)
        {
            vegosszegelbl.Text = $"{vegosszeg_form1} Ft";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            double form1szelesseg = form1.Width;
            double form1magassag = form1.Height;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            layouttest laytest = new layouttest();
            laytest.Show();
            this.Hide();
        }
        

        private void Form1_Load(object sender, EventArgs e)
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
            Form1 form1 = new Form1();
            //form1.Location = new Point(100, 100);
            if (btn3.Tag == "")
            {
                felhasznalo.Text = btn3.Tag.ToString();
                
            }
            
            login();
            int ablakfeleszel = 0;
            int ablakfelemagas = 0;
            ablakfeleszel = ablakwidth / 2;
            ablakfelemagas = ablakheight / 2;
            if (ablakwidth > 1500 && ablakheight > 800)
            {
                this.Location = new Point(ablakfeleszel - this.Width / 2, ablakfelemagas - this.Height / 2);
            }
            else
            {
                MessageBox.Show("A monitor túl kicsi a normális megjelenítéshez.");
            }
            

        }

        private void login()
        {
            access belepes = new access();
            if (belepettfelhasznalo == "")
            {
                if (belepes.ShowDialog() == DialogResult.OK)
                {
                    belepettfelhasznalo = belepes.btn.Tag.ToString();
                    felhasznalo.Text = belepes.btn.Tag.ToString();
                    btn3.Tag = felhasznalo.Text;
                    
                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            kisszendvicsekk kissz2 = new kisszendvicsekk();
            kissz2.felhasznalonev.Tag = belepettfelhasznalo;
            kissz2.belepettfelhasznalo = belepettfelhasznalo;
            kissz2.ablakwidth = ablakwidth;
            kissz2.ablakheight = ablakheight;
            foreach (var item in osszeslista)
            {
                kissz2.nagyszlista.Add(item);
            }
            kissz2.vegar += vegosszeg_form1;
            kissz2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int x = listBox1.SelectedIndex;
            List<string> valami = new List<string>();

            int osszegg = 0;
            int osszeg2 = 0;

            string szoveg = listBox1.Items[x].ToString();
            
            if (Convert.ToChar(" ") == szoveg[szoveg.Length-1] && Convert.ToChar(" ") == szoveg[szoveg.Length-2])
            {
                string[] split = listBox1.Items[x-1].ToString().Split(' ');
                osszegg = Convert.ToInt32(split[3]);
                string[] split2 = vegosszegelbl.Text.Split(' ');
                osszeg2 = Convert.ToInt32(split2[0]);
                vegosszegelbl.Text = (osszeg2 - osszegg).ToString() + " Ft";
                listBox1.Items.RemoveAt(x);
                listBox1.Items.RemoveAt(x - 1);
            }
            else if (Convert.ToChar(" ") == szoveg[szoveg.Length-1])
            {
                string[] split = listBox1.Items[x].ToString().Split(' ');
                osszegg = Convert.ToInt32(split[3]);
                string[] split2 = vegosszegelbl.Text.Split(' ');
                osszeg2 = Convert.ToInt32(split2[0]);
                vegosszegelbl.Text = (osszeg2 - osszegg).ToString() + " Ft";
                listBox1.Items.RemoveAt(x + 1);
                listBox1.Items.RemoveAt(x);
                
            }
            else
            {

                string[] split = listBox1.Items[x].ToString().Split(' ');
                osszegg = Convert.ToInt32(split[3]);
                string[] split2 = vegosszegelbl.Text.Split(' ');
                osszeg2 = Convert.ToInt32(split2[0]);
                vegosszegelbl.Text = Convert.ToString(osszeg2 - osszegg) + " Ft";
                listBox1.Items.RemoveAt(x);
            }
            
            //listBox1.Items.RemoveAt(x);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*int x = listBox1.SelectedIndex;
            string szoveg = listBox1.Items[x].ToString();
            if (Convert.ToChar(" ") == szoveg[szoveg.Length] && Convert.ToChar(" ") == szoveg[szoveg.Length - 1])
            {
                //listBox1.SelectedItem(x - 1);
            }*/
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int x = listBox1.SelectedIndex;
            
            listBox1.Items.RemoveAt(x);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            konyha konyha = new konyha();
            
            foreach (var item in listBox1.Items)
            {
                l.Add(item.ToString());
            }
            foreach (var item in l)
            {
                konyha.s.Add(item);
            }
            
            konyha.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int szam = 0;
            foreach (var item in listBox1.Items)
            {
                if (item != "")
                {
                    szam++;
                    break;
                }
            }
            if (szam > 0)
            {
                string listatartalma = "";
                DateTime currentdate1 = DateTime.Now;
                string currentdate = currentdate1.ToString("yyyy-MM-dd");
                
                connection = new MySqlConnection(connectionstring);
                connection.Open();
                
                string sql;
                MySqlDataReader datareader;
                MySqlCommand command;
                MySqlDataAdapter dataadapter = new MySqlDataAdapter();


                foreach (var item in listBox1.Items)
                {
                    listatartalma += item + " ";
                }

                string ar = vegosszegelbl.Text;

                sql = $"INSERT INTO rendelesek (lista_tartalma,hanyadik,datum,ar,felhasznalo) VALUES('{listatartalma}',{hanyadik},'{currentdate}','{ar}','{felhasznalo.Text}')";
                
                
                command = new MySqlCommand(sql, connection);
                datareader = command.ExecuteReader();
                //dataadapter = command.ExecuteReader();

                while (datareader.Read())
                {

                }
                datareader.Close();
                command.Dispose();
                connection.Close();


                listatartalma = "";
                currentdate1 = DateTime.Now;
                currentdate = currentdate1.ToString("yyyy-MM-dd");
                connection = new MySqlConnection(connectionstring);
                connection.Open();
                int igen_nem = 0;
                foreach (var item in listBox1.Items)
                {
                    if (igen_nem == 0)
                    {
                        listatartalma += item;
                        igen_nem = 1;
                    }
                    else
                    {
                        listatartalma += ";" + item;
                    }
                    
                }
                string sql2 = "";
                sql2 = $"INSERT INTO konyha (lista_tartalma,hanyadik,datum,kesz) VALUES('{listatartalma}',{hanyadik},'{currentdate}',{0})";
                
                command = new MySqlCommand(sql2, connection);
                datareader = command.ExecuteReader();
                while (datareader.Read())
                {

                }
                datareader.Close();
                //dataadapter = command.ExecuteReader();
                command.Dispose();
                connection.Close();

                hanyadik++;

                listBox1.Items.Clear();

            }
        }

        

        

        private void kilep_Click(object sender, EventArgs e)
        {
            belepettfelhasznalo = "";
            login();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3nagyssz form3nagyssz = new Form3nagyssz();
            form3nagyssz.Close();
            Form4salatak form4Salatak = new Form4salatak();
            form4Salatak.Close();
            kisszendvicsekk kisszendvicsekk = new kisszendvicsekk();
            kisszendvicsekk.Close();
            konyha konyha = new konyha();
            konyha.Close();
            this.Close();
        }

        private void btszosz_Click(object sender, EventArgs e)
        {
            Szoszok szoszokablak = new Szoszok();

            string[] vegar = vegosszegelbl.Text.Split(' ');
            int vegarr = int.Parse(vegar[0]);
            List<string> lista = new List<string>();
            if (szoszokablak.ShowDialog() == DialogResult.OK)
            {
                vegarr += szoszokablak.ar;
                foreach (var item in szoszokablak.lista)
                {
                    lista.Add(item);
                }
            }

            foreach (var item in lista)
            {
                listBox1.Items.Add(item);
            }
            if (vegosszegelbl.Text == "0")
            {
                vegosszegelbl.Text = vegarr + " Ft";
            }
            else
            {
                vegar[0] = vegarr.ToString();

                string vegar3 = vegar[0] + " " + vegar[1];

                vegosszegelbl.Text = vegar3;
            }
            

            /*foreach (var item in lista)
            {
                nagyszlista.Add(item);
            }*/
        }
    }
}
