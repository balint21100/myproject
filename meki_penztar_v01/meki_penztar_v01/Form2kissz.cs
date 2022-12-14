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
    public partial class Form2kissz : Form
    {
        public int udito = 0;
        public bool menu = false;
        public string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ivani\Desktop\Új mappa\meki_penztar_v01\meki_penztar_v01\bin\Debug\mekipeztar_adatbazis.mdf;Integrated Security=True;Connect Timeout=30";
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataReader reader;
        
        
        public Form2kissz()
        {
            InitializeComponent(); 
            //connection = new SqlConnection(connectionstring);
        }


        public string listakiss
        {
            get { return listBox2.Text; }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private Form1 foform1 = null;
        public Form2kissz(Form callingform)
        {
            foform1 = callingform as Form1;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionstring);
            connection.Open();
            string sql;
            string output = "";
            SqlCommand command;
            SqlDataReader reader;
            sql = "Select * From kisszendvicsek";
            command = new SqlCommand(sql, connection);

            reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                output += reader.GetValue(1) + " - " + reader.GetValue(2) + "";
                break;
                
            }
            for (int j = 0; j < 2; j++)
            {
                label6.Text = output + " Ft";
            }
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int t = 300;
            int f =  int.Parse(numericUpDown1.Value.ToString());
            listBox1.Items.Add(label1.Text + " " + t*f + " FT");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            int t = 1;
            int f = int.Parse(txt1.Text);
            int r = f + t;
            txt1.Text = r.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int t = 1;
            int f = int.Parse(txt1.Text);
            int r = f - t;
            if (r>0)
            {
                txt1.Text = r.ToString();
            }
            else 
            { 

            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            menu = true;

            uditovalszto.Visible = true;
            btbalnyil.Visible = true;
            btjobbnyil.Visible = true;
            uditofelirat.Visible = true;
            label9.Text = listBox3.Items[udito].ToString();
            groupBox2.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {

            label10.Text = (txt1.Text+ " " + label6.Text +" "+ 300 * Convert.ToInt32(txt1.Text)+" Ft ");
            uditovalszto.Visible = false;
            btbalnyil.Visible = false;
            btjobbnyil.Visible = false;
            uditofelirat.Visible = false;

        }

        

        private void btjobbnyil_Click(object sender, EventArgs e)
        {
            /*if (udito == 0)
            {
                udito++;
            }*/
            if (udito<listBox3.Items.Count-1)
            {
                udito++;
                label9.Text =listBox3.Items[udito].ToString();
                
            }
            /*if (udito==listBox3.Items.Count)
            {
                udito = listBox3.Items.Count-1;
            }*/
            else
            {
                
            }
            
        }

        private void Form2kissz_Load(object sender, EventArgs e)
        {
            
        }

        private void btbalnyil_Click(object sender, EventArgs e)
        {
            /*if (udito == listBox3.Items.Count-1)
            {
                udito--;
            }*/
            if (udito >= 1)
            {
                udito--;
                label9.Text = listBox3.Items[udito].ToString();
                
            }
            /*if (udito<0)
            {
                udito++;
            }*/
            else
            {

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void hozzaad_Click(object sender, EventArgs e)
        {
            
        }

        private void cola_Click(object sender, EventArgs e)
        {
            cola.BackColor = Color.Orange;
            zerocola.BackColor = Color.White;
            fanta.BackColor = Color.White;
            sprite.BackColor = Color.White;
            icetea.BackColor = Color.White;
            iceteacitrom.BackColor = Color.White;
        }

        private void zerocola_Click(object sender, EventArgs e)
        {
            cola.BackColor = Color.White;
            zerocola.BackColor = Color.Orange;
            fanta.BackColor = Color.White;
            sprite.BackColor = Color.White;
            icetea.BackColor = Color.White;
            iceteacitrom.BackColor = Color.White;
        }

        private void fanta_Click(object sender, EventArgs e)
        {
            cola.BackColor = Color.White;
            zerocola.BackColor = Color.White;
            fanta.BackColor = Color.Orange;
            sprite.BackColor = Color.White;
            icetea.BackColor = Color.White;
            iceteacitrom.BackColor = Color.White;
        }

        private void sprite_Click(object sender, EventArgs e)
        {
            cola.BackColor = Color.White;
            zerocola.BackColor = Color.White;
            fanta.BackColor = Color.White;
            sprite.BackColor = Color.Orange;
            icetea.BackColor = Color.White;
            iceteacitrom.BackColor = Color.White;
        }

        private void icetea_Click(object sender, EventArgs e)
        {
            cola.BackColor = Color.White;
            zerocola.BackColor = Color.White;
            fanta.BackColor = Color.White;
            sprite.BackColor = Color.White;
            icetea.BackColor = Color.Orange;
            iceteacitrom.BackColor = Color.White;
        }

        private void iceteacitrom_Click(object sender, EventArgs e)
        {
            cola.BackColor = Color.White;
            zerocola.BackColor = Color.White;
            fanta.BackColor = Color.White;
            sprite.BackColor = Color.White;
            icetea.BackColor = Color.White;
            iceteacitrom.BackColor = Color.Orange;
        }
    }
}
