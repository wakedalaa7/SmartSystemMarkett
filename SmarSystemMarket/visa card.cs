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
    public partial class visa_card : Form
    {
        public visa_card()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void visa_card_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            register registerform = new register();
            registerform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Click To Start";
            BuyingForm bf = new BuyingForm();
            bf.Show();
            Hide();
        }
    }
}
