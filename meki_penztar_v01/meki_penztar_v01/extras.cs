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

namespace meki_penztar_v01
{
    public partial class extras : Form
    {
        public string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ivani\Desktop\Új mappa\meki_penztar_v01\meki_penztar_v01\bin\Debug\mekipeztar_adatbazis.mdf;Integrated Security=True;Connect Timeout=30";
        public SqlConnection connection;
        public extras()
        {
            InitializeComponent();
        }

        private void extras_Load(object sender, EventArgs e)
        {

        }

        private void ontetekbetolt()
        {
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


    }
}
