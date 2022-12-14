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
    public partial class kisszendvicsekk : Form
    {
        #region valtozok
        public List<Button> uditogombok = new List<Button>();
        public Button kivalasztott_udito;
        public List<Button> nagyszendvicsgombok = new List<Button>();



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
        public string burgonya = "burgonya";
        public string uditok = "Coca-Cola";
        public string meret = "Közepes";
        public string uditomeret = "0,4 L";
        public string output = "";
        public int mennyiseg = 1;
        public int vegar = 0;
        public bool menukivalasztva = false;
        MySqlConnection connection;

        public string Label1
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        #endregion
        public kisszendvicsekk()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;



        }

        private void Menuvalasztas()
        {
            label4.Text = $"{menuk} {meret} {burgonya} {meret} {uditok} {uditomeret}";
        }

        private void Beolvasas_nagyszendvicsek_tabla(string valtozo)
        {
            connection = new MySqlConnection(connectionstring);
            connection.Open();
            string sql;
            output = "";
            MySqlCommand command;
            MySqlDataReader datareader;
            sql = $"SELECT * FROM kisszendvicsek WHERE ksz_nev = '{valtozo}'";
            command = new MySqlCommand(sql, connection);
            datareader = command.ExecuteReader();
            datareader.Read();

            nev = datareader.GetValue(1).ToString();
            csar = Convert.ToInt32(datareader.GetValue(2));
            kmenuar = Convert.ToInt32(datareader.GetValue(3));
            nmenuar = Convert.ToInt32(datareader.GetValue(4));


            csszendvics.PerformClick();
            mennyiseg = 1;
            mennyiseglbl.Text = "1";
            kiirtnev.Text = $"{nev} {mennyiseglbl.Text} db {csar * mennyiseg} Ft";



            datareader.Close();
            command.Dispose();
            connection.Close();

            button18.Enabled = true;
            menu.Enabled = true;
            hozzaad.Enabled = true;
            button17.Enabled = true;
            csszendvics.Enabled = true;
        }


        private void nagyszgombcreat(object sender, EventArgs e)
        {
            Button tmb = new Button();
            tmb = sender as Button;
            nagyszendvicsnev = tmb.Text;
            kiirtnev.Visible = true;
            Beolvasas_nagyszendvicsek_tabla(nagyszendvicsnev);
        }

        private void Big_Mac_Click(object sender, EventArgs e)
        {
            nagyszendvicsnev = "Big-Mac";
            Beolvasas_nagyszendvicsek_tabla(nagyszendvicsnev);


            /*connection = new SqlConnection(connectionstring);
            connection.Open();
            string sql;
            output = "";
            SqlCommand command;
            SqlDataReader datareader;
            sql = "SELECT * FROM nagyszendvicsek WHERE nagysz_nev = 'Big-Mac'";
            command = new SqlCommand(sql, connection);
            datareader = command.ExecuteReader();
            datareader.Read();

            nev = datareader.GetValue(1).ToString();
            csar = Convert.ToInt32(datareader.GetValue(2));
            kmenuar = Convert.ToInt32(datareader.GetValue(3));
            nmenuar = Convert.ToInt32(datareader.GetValue(4));



            kiirtnev.Text = $"{nev} {csar*mennyiseg} Ft";

            datareader.Close();
            command.Dispose();
            connection.Close();

            menu.Enabled = true;
            csszendvics.Enabled = true;*/
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menukivalasztva = true;

            for (int i = 0; i < uditogombok.Count; i++)
            {
                uditogombok[i].BackColor = Color.Gold;
                uditogombok[i].Visible = true;
            }
            kozepes_menu.BackColor = Color.Orange;
            nagy_menu.BackColor = Color.Gold;
            label4.Visible = true;
            meret = "Közepes";
            uditomeret = "0,4 L";
            uditok = uditogombok[0].Text;
            kiirtnev.Text = $"{nev} {mennyiseglbl.Text} db {kmenuar * mennyiseg} Ft";
            uditogombok[0].BackColor = Color.Orange;

            kivalasztott_udito = uditogombok[0];

            Menuvalasztas();
            groupBox2.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kozepes_menu.BackColor = Color.Gold;
            nagy_menu.BackColor = Color.Orange;
            kiirtnev.Text = $"{nev} {mennyiseglbl.Text} db {nmenuar * mennyiseg} Ft";
            meret = $"Nagy";
            uditomeret = "0,5 L";
            Menuvalasztas();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            kozepes_menu.BackColor = Color.Orange;
            nagy_menu.BackColor = Color.Gold;
            kiirtnev.Text = $"{nev} {mennyiseglbl.Text} db {kmenuar * mennyiseg} Ft";

            meret = $"Közepes";
            uditomeret = "0,4 L";
            Menuvalasztas();
        }
        private void udito_kivalasztas(object sender, EventArgs e)
        {
            Button tmp = (sender as Button);
            kivalasztott_udito.BackColor = Color.Gold;
            tmp.BackColor = Color.Orange;
            kivalasztott_udito = tmp;
            uditok = tmp.Text;
            Menuvalasztas();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            menukivalasztva = false;
            kiirtnev.Text = $"{nev} {mennyiseglbl.Text} db {csar * mennyiseg} Ft";
            label4.Visible = false;
            groupBox2.Visible = false;
            label4.Text = "";

        }

        private void hozzaad_Click(object sender, EventArgs e)
        {
            string listahozosszefuzo = "";
            string listahozoszzefuz = "";
            if (label4.Text == "")
            {
                listahozosszefuzo = $"{kiirtnev.Text}";
                nagyszlista.Add(listahozosszefuzo);
                listBox1.Items.Add($"{listahozosszefuzo}");
            }
            else
            {
                listahozosszefuzo = $"{kiirtnev.Text} ";
                listahozoszzefuz = $"{label4.Text}   ";
                nagyszlista.Add(listahozosszefuzo);
                nagyszlista.Add(listahozoszzefuz);
                listBox1.Items.Add($"{listahozosszefuzo}");
                listBox1.Items.Add($"{listahozoszzefuz}");
            }
            
           
            ar_mentese();
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


        #region mennyisegert_felelos_resz
        private void mennyiseg_eldontese()
        {
            if (menukivalasztva == true)
            {
                if (menukivalasztva == true && kozepes_menu.BackColor == Color.Orange)
                {
                    kiirtnev.Text = $"{nev} {mennyiseglbl.Text} db {kmenuar * mennyiseg} Ft";
                }
                else if (menukivalasztva == true && nagy_menu.BackColor == Color.Orange)
                {
                    kiirtnev.Text = $"{nev} {mennyiseglbl.Text} db {nmenuar * mennyiseg} Ft";
                }
            }
            else if (menukivalasztva == false)
            {
                kiirtnev.Text = $"{nev} {mennyiseglbl.Text} db {csar * mennyiseg} Ft";
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
        #endregion


        #region foformal_valo_kommunikacio


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
            string vegosszesen_szovegkent = "";
            vegosszesen_szovegkent = vegar.ToString();
            f1.belepettfelhasznalo = felhasznalonev.Tag.ToString();
            f1.btn3.Tag = felhasznalonev.Tag;
            f1.felhasznalo.Text = felhasznalonev.Tag.ToString();
            //this.mainForm.Label1Text = vegosszesen_szovegkent;
            //this.mainForm.vegosszegelbl.Text = $"{vegosszesen_szovegkent} Ft";
            //f1.button2.PerformClick();

            this.Close();
            f1.Show();
            f1.belepettfelhasznalo = belepettfelhasznalo;
            f1.Osszesen();


        }
        private Form1 mainForm = null;
        public kisszendvicsekk(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }













        #endregion

        private void sajtosmcroyal_Click(object sender, EventArgs e)
        {
            nagyszendvicsnev = "Sajtos McRoyal";
            Beolvasas_nagyszendvicsek_tabla(nagyszendvicsnev);
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

        /*private void Form3nagyssz_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            string sql = "SELECT nagysz_nev FROM nagyszendvicsek";
            SqlCommand command;
            SqlDataReader reader;
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            List<string> nagyszendvicslist = new List<string>();
            while (reader.Read())
            {

                nagyszendvicslist.Add(reader.GetValue(0).ToString());
            }
            int n = 20;

            foreach (var item in nagyszendvicslist)
            {
                Button tmd = new Button();
                tmd.Size = new Size(245, 67);
                tmd.BackColor = Color.DarkOrange;
                tmd.Text = item;
                tmd.Font = new Font("Calibri", 20);
                int x = 6;
                int y = 1 * n;
                tmd.Location = new Point(x, y);
                tmd.Click += new EventHandler(nagyszgombcreat);
                tmd.Name = item;
                groupBox1.Controls.Add(tmd);
                panel1.Controls.Add(tmd);
                nagyszendvicsgombok.Add(tmd);
                n += 70;
            }

            connection.Close();
            reader.Close();
            command.Dispose();
            uditocreator();
            kiirtnev.Visible = false;

        }*/
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
                tmd.Text = item;
                tmd.Font = new Font("Calibri", 16);
                int x = (szamlepegeto % 3) * 170 + 5;
                int y = (szamlepegeto / 3)* n +10;
                tmd.Location = new Point(x, y);
                tmd.Click += new EventHandler(uditolenyomas);
                tmd.Name = item;
                tmd.Visible = false;
                uditogombok.Add(tmd);
                panel2.Controls.Add(tmd);
                //nagyszendvicsgombok.Add(tmd);
                
                szamlepegeto++;
            }
            connection.Close();
            reader.Close();
            command.Dispose();
        }
        private void uditolenyomas(object sender, EventArgs e)
        {
            Button tmp = (sender as Button);
            kivalasztott_udito.BackColor = Color.Gold;
            tmp.BackColor = Color.Orange;
            kivalasztott_udito = tmp;
            uditok = tmp.Text;
            Menuvalasztas();
        }

        private void kisszendvicsekk_Load(object sender, EventArgs e)
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
            
            


            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            string sql = "SELECT ksz_nev FROM kisszendvicsek";
            MySqlCommand command;
            MySqlDataReader reader;
            command = new MySqlCommand(sql, connection);
            reader = command.ExecuteReader();
            List<string> nagyszendvicslist = new List<string>();
            while (reader.Read())
            {

                nagyszendvicslist.Add(reader.GetValue(0).ToString());
            }
            int n = 20;

            foreach (var item in nagyszendvicslist)
            {
                Button tmd = new Button();
                tmd.Size = new Size(245, 67);
                tmd.BackColor = Color.DarkOrange;
                tmd.Text = item;
                tmd.Font = new Font("Calibri", 20);
                int x = 6;
                int y = 1 * n;
                tmd.Location = new Point(x, y);
                tmd.Click += new EventHandler(nagyszgombcreat);
                tmd.Name = item;
                groupBox1.Controls.Add(tmd);
                panel1.Controls.Add(tmd);
                nagyszendvicsgombok.Add(tmd);
                n += 70;
            }

            connection.Close();
            reader.Close();
            command.Dispose();
            uditocreator();
            kiirtnev.Visible = false;
        }

        private void felhasznalonev_Click(object sender, EventArgs e)
        {

        }
    }
}
