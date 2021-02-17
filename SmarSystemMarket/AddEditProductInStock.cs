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
    public partial class AddEditProductInStock : Form
    {
        public AddEditProductInStock()
        {
            InitializeComponent();
            ActiveControl = textBox1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menahel menahel = new Menahel();
            menahel.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=""&& textBox2.Text != ""&& textBox3.Text != ""&&textBox4.Text != ""&&
               textBox6.Text != ""  )
            {
                int Qty = int.Parse(textBox6.Text);
                float prodprice = float.Parse(textBox4.Text);
                ClsAddProduct.Addprod(textBox1.Text, textBox3.Text, Qty,  textBox2.Text, prodprice);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox1.Focus();
            }
        }

        private void AddEditProductInStock_Load(object sender, EventArgs e)
        {

        }
    }
}
