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
    public partial class konyha : Form
    {
        public string connectionstring = @"datasource=127.0.0.1;port=3306;username=root;password=;database=penztar_adatbazis";
        public List<string> s = new List<string>();
        public List<lekerclass> listboxlist = new List<lekerclass>();
        public List<Button> elkeszitvegomlist = new List<Button>();
        public bool nagy_kicsi = true;
        public int ablakwidth = 0;
        public int ablakheight = 0;
        //public int elkeszitvegomtag = 0;


        public konyha()
        {
            InitializeComponent();
        }

        public class tagszetbontoclass
        {
            public string megnyitva;
            public string id;
        }

        public class lekerclass
        {
            public ListBox listabox;
            public int id;
        }



        private void konyha_Load(object sender, EventArgs e)
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

            /*ListBox listidoleges = new ListBox();
            listidoleges.Size = new Size(flowLayoutPanel1.Width, 150);

            flowLayoutPanel1.Controls.Add(listidoleges);
            foreach (var item in s)
            {
                listidoleges.Items.Add(item);
            }
            s2.Add(listidoleges);
            flowLayoutPanel1.Controls.Add(listidoleges);*/

            Font fontfamily = new Font("Times New Roman", 16, FontStyle.Bold);
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            string sql = "SELECT kesz, lista_tartalma, id FROM konyha";
            MySqlCommand command;
            MySqlDataReader reader;
            command = new MySqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                int kesz_van_e = Convert.ToInt32(reader.GetValue(0));
                if (kesz_van_e == 0)
                {
                    string szoveg = reader.GetValue(1).ToString();
                    int id2 = Convert.ToInt32(reader.GetValue(2));
                    rendelesszetbontasa(szoveg);
                    ListBox ideigleneslistbox = new ListBox();
                    ideigleneslistbox.Size = new Size(flowLayoutPanel1.Width, 80);
                    ideigleneslistbox.Click += new EventHandler(listbox_click);
                    ideigleneslistbox.Font = fontfamily;
                    flowLayoutPanel1.Controls.Add(ideigleneslistbox);
                    ideigleneslistbox.Tag = 0;
                    lekerclass lekervaltozo = new lekerclass();
                    
                    foreach (var item in s)
                    {
                        ideigleneslistbox.Items.Add(item);
                    }
                    lekervaltozo.listabox = ideigleneslistbox;
                    lekervaltozo.id = id2;
                    listboxlist.Add(lekervaltozo);
                    s.Clear();

                    Button btn = new Button();
                    btn.Size = new Size(80, 80);
                    btn.Text = "Elkészült";
                    int y = ideigleneslistbox.Location.Y;
                    int x = ideigleneslistbox.Location.X;

                    btn.Location = new Point(flowLayoutPanel1.Width + 25, y + 10);
                    btn.Tag = reader.GetValue(2);
                    btn.BackColor = Color.LightGray;
                    btn.Click += new EventHandler(elkeszult_click);
                    this.Controls.Add(btn);
                    elkeszitvegomlist.Add(btn);



                }
            }

            reader.Close();
            command.Dispose();
            connection.Close();



            

        }
        //ez azért felelős hogy a listboxokat ki nyissa vagy éppen összecsukja
        private void listbox_click(object sender, EventArgs e)
        {
            
            ListBox tmp = sender as ListBox;




            foreach (var item in listboxlist)
            {
                for (int i = 0; i < item.listabox.Items.Count; i++)
                {
                    item.listabox.SelectedItem = false;
                }
            }




            /*string tagstring = tmp.Tag.ToString();
            tagszetbontoclass tagstring2 = new tagszetbontoclass();
            tagstring2.megnyitva = tagstring[0].ToString();
            for (int i = 1; i < tagstring.Length; i++)
            {
                tagstring2.id += tagstring[i].ToString();
            }

            string itemtagstring = "";
            tagszetbontoclass itemtagstring2 = new tagszetbontoclass();*/





            int x1 = tmp.Location.X;
            int y1 = tmp.Location.Y;




            if (Convert.ToInt32(tmp.Tag) == 1)
            {
                tmp.Size = new Size(flowLayoutPanel1.Width, 80);
                tmp.Tag = 0;
                /*for (int i = 0; i < listboxlist.Count; i++)
                {
                    int x2 = listboxlist[i].listabox.Location.X;
                    int y2 = listboxlist[i].listabox.Location.Y;
                    if (x1 == x2 && y1 == y2)
                    {

                    }
                }*/
                for (int i = 0; i < elkeszitvegomlist.Count; i++)
                {
                    int y = listboxlist[i].listabox.Location.Y;
                    elkeszitvegomlist[i].Location = new Point(flowLayoutPanel1.Width + 25, y + 10);
                }
            }
            else
            {
                foreach (var item in listboxlist)
                {
                   
                    if (Convert.ToInt32(item.listabox.Tag) == 1)
                    {
                        tmp.Size = new Size(flowLayoutPanel1.Width, 170);
                        tmp.Tag = 1;
                        item.listabox.Size = new Size(flowLayoutPanel1.Width, 80);
                        item.listabox.Tag = 0;
                        for (int i = 0; i < elkeszitvegomlist.Count; i++)
                        {
                            int y = listboxlist[i].listabox.Location.Y;
                            elkeszitvegomlist[i].Location = new Point(flowLayoutPanel1.Width + 25, y + 10);
                        }
                    }
                    else
                    {
                        tmp.Size = new Size(flowLayoutPanel1.Width, 170);
                        tmp.Tag = 1;
                        for (int i = 0; i < elkeszitvegomlist.Count; i++)
                        {
                            int y = listboxlist[i].listabox.Location.Y;
                            elkeszitvegomlist[i].Location = new Point(flowLayoutPanel1.Width + 25, y + 10);
                        }
                    }
                }
            }


            

        }
        //

        private void elkeszult_click(object sender, EventArgs e)
        {
            Button tmp = new Button();
            tmp = sender as Button;
            int tmpid = Convert.ToInt32(tmp.Tag);
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            string sql = $"UPDATE konyha set kesz = 1 WHERE id = {tmpid}";

            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter dataadapter = new MySqlDataAdapter();

            dataadapter.InsertCommand = new MySqlCommand(sql, connection);
            dataadapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            connection.Close();



            for (int i = 0; i < listboxlist.Count; i++)
            {
                if (listboxlist[i].listabox != null && listboxlist[i].id == tmpid)
                {
                    flowLayoutPanel1.Controls.Remove(listboxlist[i].listabox);
                    for (int j = 0; j < elkeszitvegomlist.Count; j++)
                    {
                        int y3 = listboxlist[j].listabox.Location.Y;
                        elkeszitvegomlist[j].Location = new Point(flowLayoutPanel1.Width + 25, y3 + 10);
                    }
                }
                
            }


            this.Controls.Remove(tmp);


        }


        private void rendelesszetbontasa(string sor)
        {
            int vesszok = 0;
            for (int i = 0; i < sor.Length; i++)
            {
                if (sor[i] == ';')
                {
                    vesszok++;
                }
            }
            for (int i = 0; i < vesszok; i++)
            {
                string[] szetbontas = sor.Split(';');
                s.Add(szetbontas[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Controls.Remove(s2[0]);
        }
    }
}
