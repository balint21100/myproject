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
    public partial class layouttest : Form
    {
        List<Button> gomblista = new List<Button>();
        public string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ivani\Desktop\Új mappa\meki_penztar_v01\meki_penztar_v01\bin\Debug\mekipeztar_adatbazis.mdf;Integrated Security=True;Connect Timeout=30";
        public List<Panel> panellista = new List<Panel>();
        public layouttest()
        {
            InitializeComponent();
        }
        private void button_creator(int size_width, int size_height, int x, int y,string fontstring, int fontsize, string text ,int column, int row, int column_or_row, int spanvalue, int wichtablelayout)
        {
            Button btn = new Button();
            btn.Size = new Size(size_width, size_height);
            int x1 = x;
            int y1 = y;
            btn.Location = new Point(x1, y1);
            btn.BackColor = Color.Black;
            btn.ForeColor = Color.Red;

            //btn.Dock = DockStyle.Right;
            btn.Font = new Font(fontstring, fontsize);
            btn.Text = text;
            btn.Tag = Convert.ToString(wichtablelayout + column + row);
            gomblista.Add(btn);
            set_columnspan_rowspan(btn, column, row, column_or_row, spanvalue, wichtablelayout);
        }
        private void button_setcolumspan()
        {
            Button butn = new Button();
            butn.Size = new Size(80, 10);
            butn.Dock = DockStyle.Fill;
            butn.BackColor = Color.Black;
            int x = 0;
            int y = 0;
            butn.Location = new Point(x, y);

            
        }
        private void set_columnspan_rowspan(Button btn,int column, int row, int column_or_row, int spanvalue, int wichtablelayout)
        {
            if (wichtablelayout == 1 && column_or_row == 0)
            {
                tableLayoutPanel1.Controls.Add(btn, column, row);
                tableLayoutPanel1.SetColumnSpan(btn, spanvalue);
                
            }
            else if(wichtablelayout == 1 && column_or_row == 1)
            {
                tableLayoutPanel1.Controls.Add(btn, column, row);
                tableLayoutPanel1.SetRowSpan(btn, spanvalue);
            }

            else if (wichtablelayout == 2 && column_or_row == 0)
            {
                tableLayoutPanel2.Controls.Add(btn, column, row);
                tableLayoutPanel2.SetColumnSpan(btn, spanvalue);
            }
            else if (wichtablelayout == 2 && column_or_row == 1)
            {
                tableLayoutPanel2.Controls.Add(btn, column, row);
                tableLayoutPanel2.SetRowSpan(btn, spanvalue);
            }

            else if (wichtablelayout == 3 && column_or_row == 0)
            {
                tableLayoutPanel3.Controls.Add(btn, column, row);
                tableLayoutPanel3.SetColumnSpan(btn, spanvalue);
            }
            else if (wichtablelayout == 3 && column_or_row == 1)
            {
                tableLayoutPanel3.Controls.Add(btn, column, row);
                tableLayoutPanel3.SetRowSpan(btn, spanvalue);
            }

            else if (wichtablelayout == 4 && column_or_row == 0)
            {
                tableLayoutPanel1.Controls.Add(btn, column, row);
                tableLayoutPanel1.SetColumnSpan(btn, spanvalue);
            }
            else if (wichtablelayout == 4 && column_or_row == 1)
            {
                tableLayoutPanel1.Controls.Add(btn, column, row);
                tableLayoutPanel1.SetRowSpan(btn, spanvalue);
            }

        }

        private void layouttest_Load(object sender, EventArgs e)
        {
            Panel panel11 = new Panel();
            int widthpanel = tableLayoutPanel1.ClientSize.Width / 10 * 3;
            int heightpanel = tableLayoutPanel1.ClientSize.Height / 10 * 6;

            panel11.Size = new Size(widthpanel, heightpanel);
            int x = 0;
            int y = tableLayoutPanel1.ClientSize.Height / 10 * 1;
            panel11.Location = new Point(x, y);
            panel11.Dock = DockStyle.Fill;
            panellista.Add(panel11);
            tableLayoutPanel1.Controls.Add(panel11, 0, 1);

            Label label11 = new Label();
            label11.Font = new Font("Calibri", 22);
            label11.Text = "Saláták";
            label11.Location = new Point(tableLayoutPanel1.ClientSize.Width / 10 * 2, tableLayoutPanel1.ClientSize.Height / 10 * 4);
            
            label11.Size = new Size(tableLayoutPanel1.ClientSize.Width / 10 * 7, tableLayoutPanel1.ClientSize.Height / 10 * 5);
            tableLayoutPanel1.Controls.Add(label11, 0, 0);
            //tableLayoutPanel2.Controls.Add(panel11,1,2);
            //tableLayoutPanel1.Controls.Add(panel11);
            




            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            string sql = "SELECT nagysz_nev FROM nagyszendvicsek";
            SqlCommand command;
            SqlDataReader reader;
            command = new SqlCommand(sql, connection);
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
                tmd.BackColor = Color.DarkOrange;
                tmd.Text = item;
                tmd.Font = new Font("Calibri", 20);
                int x1 = 6;
                int y2 = 1 * n;
                tmd.Location = new Point(x1, y2);
                //tmd.Click += new EventHandler(nagyszgombcreat);
                tmd.Name = item;
                //groupBox1.Controls.Add(tmd);
                panellista[0].Controls.Add(tmd);
                //nagyszendvicsgombok.Add(tmd);
                n += 70;
            }

            

            connection.Close();



            button_setcolumspan();
            button_creator(tableLayoutPanel3.ClientSize.Width / 2, tableLayoutPanel3.ClientSize.Height, tableLayoutPanel3.ClientSize.Width / 2, 0, "Calibri", 18, "Menü", 0, 0, 0, 1, 3);
            button_creator(tableLayoutPanel3.ClientSize.Width / 2, tableLayoutPanel3.ClientSize.Height, tableLayoutPanel3.ClientSize.Width / 2, 0, "Calibri", 18, "Csak a szendvics", 2, 0, 0, 1, 3);
            //button_creator(tab,tableLayoutPanel3)
            //tableLayoutPanel3.get
            TableLayoutPanelCellPosition pos = tableLayoutPanel3.GetCellPosition(gomblista[0]);
            int wid = tableLayoutPanel3.GetColumnWidths()[pos.Column];
            int hei = tableLayoutPanel3.GetRowHeights()[pos.Column];
            gomblista[0].Size = new Size(wid / 10 * 8, hei);
            gomblista[0].Dock = DockStyle.Right;
            gomblista[1].Size = new Size(wid / 10 * 8, hei);
            gomblista[0].TextAlign = ContentAlignment.MiddleCenter;
            gomblista[1].TextAlign = ContentAlignment.MiddleCenter;
            button_creator(tableLayoutPanel3.ClientSize.Width / 2, tableLayoutPanel3.ClientSize.Height, tableLayoutPanel3.ClientSize.Width / 2, 0, "Calibri", 18, "-", 0, 2, 0, 1, 3);
            button_creator(tableLayoutPanel3.ClientSize.Width / 2, tableLayoutPanel3.ClientSize.Height, tableLayoutPanel3.ClientSize.Width / 2, 0, "Calibri", 18, "+", 2, 2, 0, 1, 3);
            button_creator(tableLayoutPanel3.ClientSize.Width / 2, tableLayoutPanel3.ClientSize.Height, tableLayoutPanel3.ClientSize.Width / 2, 0, "Calibri", 16, "Közepes menü", 0, 4, 0, 1, 3);
            button_creator(tableLayoutPanel3.ClientSize.Width / 2, tableLayoutPanel3.ClientSize.Height, tableLayoutPanel3.ClientSize.Width / 2, 0, "Calibri", 16, "Nagy Menü", 2, 4, 0, 1, 3);

            gomblista[2].Size = new Size(wid / 10 * 4, hei/10 * 8);
            gomblista[3].Size = new Size(wid / 10 * 4, hei / 10 * 8);
            gomblista[2].Dock = DockStyle.Right;
            gomblista[3].Dock = DockStyle.Left;
            TableLayoutPanelCellPosition pos2 = tableLayoutPanel3.GetCellPosition(gomblista[4]);
            int wid2 = tableLayoutPanel3.GetColumnWidths()[pos2.Column];
            int hei2 = tableLayoutPanel3.GetRowHeights()[pos2.Column];
            gomblista[4].Size = new Size(wid2 , hei2 / 10 * 7);
            gomblista[5].Size = new Size(wid2 , hei2 / 10 * 7);
            //gomblista[4].Dock = DockStyle.Right;
            //gomblista[5].Dock = DockStyle.Left;
            osszetevoklbl();
            uditopanel();
            gomblista[0].Click += new EventHandler(probaevent);
        }

        private void osszetevoklbl()
        {
            Label lbl = new Label();
            lbl.Size = new Size(tableLayoutPanel3.ClientSize.Width, tableLayoutPanel3.ClientSize.Height);
            lbl.Location = new Point(0, 0);
            lbl.BackColor = Color.Red;
            tableLayoutPanel1.Controls.Add(lbl,0,2);
            tableLayoutPanel1.SetRowSpan(lbl, 2);
        }

        private void uditopanel()
        {
            Panel panel = new Panel();
            panel.Size = new Size(ClientSize.Width, ClientSize.Height);
            panel.BackColor = Color.Black;
            panel.Location = new Point(0, 0);
            tableLayoutPanel3.Controls.Add(panel, 0, 5);
            tableLayoutPanel3.SetColumnSpan(panel, 3);

            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            string sql = "SELECT udito_nev FROM Uditok";
            SqlCommand command;
            SqlDataReader reader;
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            List<string> Uditoklist = new List<string>();
            while (reader.Read())
            {

                Uditoklist.Add(reader.GetValue(0).ToString());
            }
            int n = 20;

            foreach (var item in Uditoklist)
            {
                Button tmd = new Button();
                tmd.Size = new Size(245, 67);
                tmd.BackColor = Color.DarkOrange;
                tmd.Text = item;
                tmd.Font = new Font("Calibri", 20);
                int x1 = 6;
                int y2 = 1 * n;
                tmd.Location = new Point(x1, y2);
                //tmd.Click += new EventHandler(nagyszgombcreat);
                tmd.Name = item;
                //groupBox1.Controls.Add(tmd);
                panellista[0].Controls.Add(tmd);
                //nagyszendvicsgombok.Add(tmd);
                n += 70;
            }



            connection.Close();

        }
        private void probaevent(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn = sender as Button;
            MessageBox.Show("sikeres gombfunkcio");
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
