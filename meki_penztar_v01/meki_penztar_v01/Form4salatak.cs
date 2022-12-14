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
    public partial class Form4salatak : Form
    {
        #region valtozok
        public List<Button> uditogombok = new List<Button>();
        public Button kivalasztott_udito;
        public List<Button> nagyszendvicsgombok = new List<Button>();
        public List<Button> ontetlist = new List<Button>();



        public int ablakwidth = 0;
        public int ablakheight = 0;
        public string belepettfelhasznalo = "";
        public string nev = "";
        public int csar = 0;
        public int kmenuar = 0;
        public int nmenuar = 0;
        public string nagyszendvicsnev = "";
        public List<string> nagyszlista = new List<string>();
        public string connectionstring = @"datasource=127.0.0.1;port=3306;username=root;password=;database=penztar_adatbazis";
        public string menuk = "Menü:";
        public string burgonya = "Pirított kenyér";
        public string uditok = "Coca-Cola";
        public string meret = "Közepes";
        public string uditomeret = "0,4 L";
        public string output = "";
        public int mennyiseg = 1;
        public int vegar = 0;
        public bool menukivalasztva = false;
        MySqlConnection connection;


        public Form4salatak()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;


        }


        private void Beolvasas_nagyszendvicsek_tabla(string valtozo)
        {
            connection = new MySqlConnection(connectionstring);
            connection.Open();
            string sql;
            output = "";
            MySqlCommand command;
            MySqlDataReader datareader;
            sql = $"SELECT * FROM Salatak WHERE salata_nev = '{valtozo}'";
            command = new MySqlCommand(sql, connection);
            datareader = command.ExecuteReader();
            datareader.Read();

            nev = datareader.GetValue(1).ToString();
            csar = Convert.ToInt32(datareader.GetValue(2));
            kmenuar = Convert.ToInt32(datareader.GetValue(3));
            nmenuar = Convert.ToInt32(datareader.GetValue(4));


            cssalata.PerformClick();
            mennyiseg = 1;
            mennyiseglbl.Text = "1";
            kiirtnev.Text = $"{nev} {mennyiseglbl.Text} db {ontetlist[0].Text} öntettel  {csar * mennyiseg}  Ft";



            datareader.Close();
            command.Dispose();
            connection.Close();

            menu.Enabled = true;
            hozzaad.Enabled = true;
            cssalata.Enabled = true;
            label3.Visible = true;
            cssalata.BackColor = Color.Orange;
        }

        private void nagyszgombcreat(object sender, EventArgs e)
        {
            Button tmb = new Button();
            tmb = sender as Button;
            nagyszendvicsnev = tmb.Text;
            menu.Enabled = true;
            cssalata.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            flowLayoutPanel1.Visible = true;
            foreach (var item in ontetlist)
            {
                if (item.BackColor == Color.Orange)
                {
                    item.BackColor = Color.Green;
                }
            }
            ontetlist[0].BackColor = Color.Orange;
            Beolvasas_nagyszendvicsek_tabla(nagyszendvicsnev);
        }

        private void Menuvalasztas()
        {
            label4.Text = $"{menuk} {meret} {burgonya} mennyiségü {meret} {uditok} {uditomeret} ";
        }



        private void button6_Click(object sender, EventArgs e)
        {
            menukivalasztva = false;
            kiirttext();
            label4.Visible = false;
            groupBox2.Visible = false;

        }


        private void menu_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            foreach (var item in ontetlist)
            {
                if (item.BackColor == Color.Orange)
                {
                    btn = item;
                }
            }
            cssalata.BackColor = Color.Green;
            menu.BackColor = Color.Orange;
            menukivalasztva = true;
            //uditogombok[0] = cocacola;
            //uditogombok[1] = cocacolazero;
            //uditogombok[2] = liptonicetea;
            //uditogombok[3] = fanta;
            //uditogombok[4] = sprite;
            for (int i = 0; i < uditogombok.Count; i++)
            {
                uditogombok[i].BackColor = Color.Green;
            }
            kozepes_menu.BackColor = Color.Orange;
            nagy_menu.BackColor = Color.Green;
            label4.Visible = true;
            meret = "Közepes";
            uditomeret = "0,4 L";
            uditok = "Coca-Cola";
            kiirtnev.Text = $"{nev} {mennyiseglbl.Text} db {btn.Text} öntettel {kmenuar * mennyiseg} Ft";
            uditogombok[0].BackColor = Color.Orange;

            kivalasztott_udito = uditogombok[0];

            Menuvalasztas();
            groupBox2.Visible = true;
        }


        private void uditolenyomas(object sender, EventArgs e)
        {
            Button tmp = (sender as Button);
            kivalasztott_udito.BackColor = Color.Green;
            tmp.BackColor = Color.Orange;
            kivalasztott_udito = tmp;
            uditok = tmp.Text;
            Menuvalasztas();
        }

        private void kiirttext()
        {
            Button btn = new Button();
            foreach (var item in ontetlist)
            {
                if (item.BackColor == Color.Orange)
                {
                    btn = item;
                }
            }

            kiirtnev.Text = $"{nev} {mennyiseglbl.Text} db {btn.Text} öntettel  {csar * mennyiseg}  Ft";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            foreach (var item in ontetlist)
            {
                if (item.BackColor == Color.Orange)
                {
                    btn = item;
                }
            }
            kozepes_menu.BackColor = Color.Orange;
            nagy_menu.BackColor = Color.Green;
            kiirtnev.Text = $"{nev} {mennyiseglbl.Text} db {btn.Text} öntettel {kmenuar * mennyiseg} Ft";

            meret = $"Közepes";
            uditomeret = "0,4 L";
            Menuvalasztas();

        }


        private void mennyiseg_eldontese()
        {
            Button btn = new Button();
            foreach (var item in ontetlist)
            {
                if (item.BackColor  == Color.Orange)
                {
                    btn = item;
                }
            }
            if (menukivalasztva == true)
            {
                if (menukivalasztva == true && kozepes_menu.BackColor == Color.Orange)
                {
                    kiirtnev.Text = $"{nev} {mennyiseglbl.Text} db {btn.Text} öntettel {kmenuar * mennyiseg} Ft";
                }
                else if (menukivalasztva == true && nagy_menu.BackColor == Color.Orange)
                {
                    kiirtnev.Text = $"{nev} {mennyiseglbl.Text} db {btn.Text} öntettel {nmenuar * mennyiseg} Ft";
                }
            }
            else if (menukivalasztva == false)
            {
                kiirtnev.Text = $"{nev} {mennyiseglbl.Text} db {btn.Text} öntettel {csar * mennyiseg} Ft";
            }
        }


        private void button17_Click(object sender, EventArgs e)
        {
            mennyiseg = Convert.ToInt32(mennyiseglbl.Text);
            mennyiseg_eldontese();
            if (Convert.ToInt32(mennyiseglbl.Text) > 1)
            {
                mennyiseglbl.Text = (Convert.ToInt32(mennyiseglbl.Text) - 1).ToString();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            mennyiseg = Convert.ToInt32(mennyiseglbl.Text);
            mennyiseg_eldontese();

            mennyiseglbl.Text = (Convert.ToInt32(mennyiseglbl.Text) + 1).ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            foreach (var item in ontetlist)
            {
                if (item.BackColor == Color.Orange)
                {
                    btn = item;
                }
            }
            kozepes_menu.BackColor = Color.Green;
            nagy_menu.BackColor = Color.Orange;
            kiirtnev.Text = $"{nev} {mennyiseglbl.Text} db {btn.Text} öntettel {nmenuar * mennyiseg} Ft";
            meret = $"Nagy";
            uditomeret = "0,5 L";
            Menuvalasztas();

        }

        private void Form4salatak_Load(object sender, EventArgs e)
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
            


            uditocreator();
            ontetcreator();
            salatacreator();
            
        }
        #region creatorok

        private void ontetcreator()
        {
            int tagid = 0;
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            string sql = "SELECT ontet_nev FROM Ontet";
            MySqlCommand command;
            MySqlDataReader reader;
            command = new MySqlCommand(sql, connection);
            reader = command.ExecuteReader();
            int y = 0;
            while (reader.Read())
            {
                Button btn = new Button();
                btn.Size = new Size(110, 60);
                btn.Location = new Point(0, y);
                btn.Text = reader.GetValue(0).ToString();
                btn.BackColor = Color.Green;
                btn.ForeColor = Color.Yellow;
                btn.Click += new EventHandler(ontet_click);
                btn.Tag = tagid;
                ontetlist.Add(btn);
                flowLayoutPanel1.Controls.Add(btn);
                y += 70;
                tagid++;
            }
        }

        private void salatacreator()
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            string sql = "SELECT salata_nev FROM Salatak";
            MySqlCommand command;
            MySqlDataReader reader;
            command = new MySqlCommand(sql, connection);
            reader = command.ExecuteReader();
            List<string> Salatalist = new List<string>();
            while (reader.Read())
            {

                Salatalist.Add(reader.GetValue(0).ToString());
            }
            int n = 20;

            foreach (var item in Salatalist)
            {
                Button tmd = new Button();
                tmd.Size = new Size(245, 67);
                tmd.BackColor = Color.Green;
                tmd.ForeColor = Color.Yellow;
                tmd.Text = item;
                tmd.Font = new Font("Calibri", 20);
                int x = 6;
                int y = 1 * n;
                tmd.Location = new Point(x, y);
                tmd.Click += new EventHandler(nagyszgombcreat);
                tmd.Name = item;
                //groupBox1.Controls.Add(tmd);
                panel1.Controls.Add(tmd);
                nagyszendvicsgombok.Add(tmd);
                n += 70;
            }
            connection.Close();
        }

        private void uditocreator()
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            string sql = "SELECT udito_nev FROM Uditok";
            MySqlCommand command;
            MySqlDataReader reader;
            command = new MySqlCommand(sql, connection);
            reader = command.ExecuteReader();
            List<string> uditolist = new List<string>();
            while (reader.Read())
            {

                uditolist.Add(reader.GetValue(0).ToString());
            }
            int n = 20;
            int szamlepegeto = 0;
            n = 70;
            foreach (var item in uditolist)
            {
                Button tmd = new Button();
                tmd.Size = new Size(160, 66);
                tmd.BackColor = Color.DarkOrange;
                tmd.ForeColor = Color.Yellow;
                tmd.Text = item;
                tmd.Font = new Font("Calibri", 16);
                int x = (szamlepegeto % 3) * 170 + 5;
                int y = (szamlepegeto / 3) * n + 10;
                tmd.Location = new Point(x, y);
                tmd.Click += new EventHandler(uditolenyomas);
                tmd.Name = item;
                uditogombok.Add(tmd);
                panel2.Controls.Add(tmd);
                nagyszendvicsgombok.Add(tmd);
                
                szamlepegeto++;
            }
        }


        #endregion
        

        private void ontet_click(object sender, EventArgs e)
        {

            Button tmp = sender as Button;
            Button itemfigyelo = new Button();
            foreach (var item in ontetlist)
            {
                if (item.BackColor == Color.Orange)
                {
                    itemfigyelo = item;
                    item.BackColor = Color.Green;
                }
            }

            if (itemfigyelo.Tag != tmp.Tag)
            {
                ontetlist[Convert.ToInt32(itemfigyelo.Tag)].BackColor = Color.Green;
                tmp.BackColor = Color.Orange;
            }
            else
            {
                tmp.BackColor = Color.Orange;
            }
        }



        private void mennyiseglbl_Click(object sender, EventArgs e)
        {

            Szammegado szammeg = new Szammegado();
            if (szammeg.ShowDialog() == DialogResult.OK)
            {
                mennyiseglbl.Text = szammeg.label1text;
            }


        }

        private void mennyiseglbl_TextChanged(object sender, EventArgs e)
        {
            mennyiseg = Convert.ToInt32(mennyiseglbl.Text);
            mennyiseg_eldontese();

        }

        private void cssalata_Click(object sender, EventArgs e)
        {

            cssalata.BackColor = Color.Orange;
            menu.BackColor = Color.Green;
            label3.Visible = true;
            menukivalasztva = false;
            kiirtnev.Text = $"{nev} {mennyiseglbl.Text} db {csar * mennyiseg} Ft";
            label4.Visible = false;
            groupBox2.Visible = false;
            label4.Text = "";
        }

        private void ar_mentese()
        {
            if (menukivalasztva == true)
            {
                if (menukivalasztva == true && kozepes_menu.BackColor == Color.Orange)
                {
                    vegar += (kmenuar * mennyiseg);
                }
                else if (menukivalasztva == true && nagy_menu.BackColor == Color.Orange)
                {
                    vegar += nmenuar * mennyiseg;
                }
            }
            else if (menukivalasztva == false)
            {
                vegar += csar * mennyiseg;
            }
        }

        private void hozzaad_Click(object sender, EventArgs e)
        {
            string listahozosszefuzo = $"{kiirtnev.Text}";
            string listahozoszzefuz = $"{label4.Text}";
            if (label4.Text == "")
            {
                nagyszlista.Add(listahozosszefuzo);
                listBox1.Items.Add($"{listahozosszefuzo}");
            }
            else
            {
                nagyszlista.Add(listahozosszefuzo);
                nagyszlista.Add(listahozoszzefuz);
                listBox1.Items.Add($"{listahozosszefuzo}");
                listBox1.Items.Add($"{listahozoszzefuz}");
            }
            
            
            ar_mentese();

        }

        private void button16_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();

            

            /*foreach (var item in nagyszlista)
            {

            }*/
            for (int i = 0; i < nagyszlista.Count; i++)
            {
                f1.osszeslista.Add(nagyszlista[i]);
                //f1.listBox1.Items.Add(listBox1.Items[i]);
                f1.listBox1.Items.Add(f1.osszeslista[i]);
            }
            f1.vegosszeg_form1 += vegar;
            f1.btn3.Tag = felhasznal.Tag;
            string vegosszesen_szovegkent = "";
            vegosszesen_szovegkent = vegar.ToString();
            f1.belepettfelhasznalo = felhasznal.Tag.ToString();
            f1.felhasznalo.Text = felhasznal.Tag.ToString();
            //this.mainForm.Label1Text = vegosszesen_szovegkent;
            //this.mainForm.vegosszegelbl.Text = $"{vegosszesen_szovegkent} Ft";
            //f1.button2.PerformClick();

            this.Close();
            f1.Show();
            f1.belepettfelhasznalo = belepettfelhasznalo;
            f1.Osszesen();



        }

        private void button14_Click(object sender, EventArgs e)
        {
            Szoszok szoszokablak = new Szoszok();
            
            List<string> lista = new List<string>();
            if (szoszokablak.ShowDialog() == DialogResult.OK)
            {
                vegar += szoszokablak.ar;
                foreach (var item in szoszokablak.lista)
                {
                    lista.Add(item);
                }
            }

            foreach (var item in lista)
            {
                listBox1.Items.Add(item);
            }
            foreach (var item in lista)
            {
                nagyszlista.Add(item);
            }
        }
    }
}
#endregion