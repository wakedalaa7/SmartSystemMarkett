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
    public partial class login : Form
    {
        private readonly Color MenuText;
        

        string c = "318489366";
        public login()
        {
            InitializeComponent();
            ActiveControl = txtId;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void jTextBox1_Load(object sender, EventArgs e)
        {
            txtId.ForeColor = MenuText;
        }

        private void start_btn_MouseHover(object sender, EventArgs e)
        {
            start_btn.Text = "Start shopping";
        }

        private void start_btn_MouseLeave(object sender, EventArgs e)
        {
            start_btn.Text = "Click To Start";
        }



        private void register_btn_Click(object sender, EventArgs e)
        {
            register registerform = new register();
            registerform.Show();
            this.Hide();
        }

        private void loginlabel_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            int flag = 0;

            flag = ClsUsers.login(txtId.TextValue);
            if (flag == 1)
            {
                BuyingForm bf = new BuyingForm();
                flag = 0;
                bf.Show();
                Close();
            }
            else
            {
                flag = ClsUsers.login2(txtId.TextValue);
                if (flag == 1)
                {

                    Menahel men = new Menahel();
                    flag = 0;
                    men.Show();
                    Close();
                }
            }


        }
    }
}
