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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Form2.ActiveForm.Close();
            Form2.ActiveForm.ResetText();
            Form2.ActiveForm.Show();
            
            
            
            
            this.Close();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            using (Form2 form2 = new Form2()) 
            {
                string zene = form2.formbezaras;
                if (zene == 1.ToString())
                {
                    Form2.ActiveForm.Close();
                    Form1.ActiveForm.Activate();
                }
            }
            //form2.Close();
            Form2.ActiveForm.Activate();
            Form2.ActiveForm.Close();


            using (Form4 form4 = new Form4())
            {
                string zene = form4.form4;
                if (zene == 1.ToString())
                {
                    form4.Close();
                    Form4.ActiveForm.Close();
                    Form1.ActiveForm.Activate();
                }
            }
            
            Form4.ActiveForm.Close();
            Form1 form1 = new Form1();
            form1.Show();
            
            Form1.ActiveForm.Show();
        }
    }
}
