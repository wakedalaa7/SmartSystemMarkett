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
    public partial class Menahel : Form
    {
        
        public Menahel()
        {
            InitializeComponent();
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportFilterStock ReportStock = new ReportFilterStock();
            ReportStock.Show();
            this.Hide();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            Cart invitation = new Cart();
            invitation.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            BuyingForm buyf = new BuyingForm();
            buyf.button2.Visible = true;
            buyf.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddEditProduct Addpro = new AddEditProduct();
            Addpro.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddEditProductInStock AddproSt = new AddEditProductInStock();
            AddproSt.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            login loginform = new login();
            loginform.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Hide();

        }

        private void Menahel_Load(object sender, EventArgs e)
        {

        }
    }
}
