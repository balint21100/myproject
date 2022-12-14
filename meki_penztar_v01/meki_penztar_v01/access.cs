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
    public partial class access : Form
    {

        public string connectionstring = @"datasource=127.0.0.1;port=3306;username=root;password=;database=penztar_adatbazis";
        public access()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }
        public Button btn = new Button();

        public int ablakwidth = 0;
        public int ablakheight = 0;



        public felhasznalok1 egyfelhasznalo = new felhasznalok1();
        public List<felhasznalok1> felhasznalolista = new List<felhasznalok1>();
        public class felhasznalok1
        {
            public string felhasznalonev;
            public string jelszo;
            public int access_tipus;
        }

        private void access_Load(object sender, EventArgs e)
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
            

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);

            try
            {




                connection.Open();

                MySqlCommand command;
                MySqlDataReader reader;


                string sql = "SELECT felhasznalonev, jelszo, access_tipus FROM Felhasznalok";
                command = new MySqlCommand(sql, connection);
                reader = command.ExecuteReader();
                egyfelhasznalo.felhasznalonev = "";
                egyfelhasznalo.access_tipus = 0;

                while (reader.Read())
                {
                    if (felhasznalotxt.Text == reader.GetValue(0).ToString() || jelszotxt.Text == reader.GetValue(1).ToString())
                    {
                        egyfelhasznalo.felhasznalonev = felhasznalotxt.Text;//reader.GetValue(0).ToString();
                        egyfelhasznalo.access_tipus = Convert.ToInt32(reader.GetValue(2));



                        button2.PerformClick();

                        int x = 0;
                        int y = 0;
                        btn.Location = new Point(x, y);
                        btn.Size = new Size(10, 10);
                        btn.Tag = felhasznalotxt.Text;
                        btn.DialogResult = DialogResult.OK;



                        btn.Click += new EventHandler(btnclick);
                        this.Controls.Add(btn);
                        btn.PerformClick();


                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("El kell indítani az adatbázist");
            }
        }
        private void btnclick(object sender, EventArgs e)
        {
            Button tmp = new Button();
            tmp = sender as Button;

        }
    }
}
