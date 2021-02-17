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

        }
    }
}
