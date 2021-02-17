using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmarSystemMarket
{
    public partial class BuyingForm : Form
    {
        public BuyingForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
  
        }

        private void BuyingForm_Load(object sender, EventArgs e)
        {
 
        }
        public void Panelvis ()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login ln = new login();
            ln.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menahel men = new Menahel();
            men.Show();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string[] barcode = new string[3];
            barcode[0] = textBox1.Text;
            barcode = ClsBuyingForm.BuyPro(barcode);
            textBox2.Text = barcode[1];
            textBox3.Text = barcode[2];
            
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            //textBox1.ReadOnly = true;


        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.ReadOnly == true)
            {
                //int Qty = int.Parse(textBox4.Text);

                //int price = int.Parse(textBox3.Text);
                //int total = Qty * price;
                //textBox5.Text = total.ToString();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;

            ActiveControl = textBox1;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            int Qty = int.Parse(textBox4.Text);

            int price = int.Parse(textBox3.Text);
            int total = Qty * price;
            textBox5.Text = total.ToString();
        }
    }
}
