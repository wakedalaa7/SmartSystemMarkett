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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            ActiveControl = txt_f_name;
        }

        private void register_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_visa_page_Click(object sender, EventArgs e)
        {
            visa_card visaform = new visa_card();
            visaform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login loginform = new login();
            loginform.Show();
            this.Hide();
        }
    }
}
