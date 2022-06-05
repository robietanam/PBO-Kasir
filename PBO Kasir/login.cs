using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_Kasir
{
    public partial class login : UserControl
    {
        mainForm objParent;
        public login()
        {
            InitializeComponent();
            
            
        }
        public login(mainForm p_parent)
        {
            InitializeComponent();
            objParent = p_parent;
        }

        

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_User.Text == "t" && textBox_Pass.Text == "1")
            {
                lblInfo.Text = "";
                textBox_User.Text = "";
                textBox_Pass.Text = "";
                this.Visible = false;
                objParent.showMainForm();

            }
            else
            {
                lblInfo.Text = "Username atau password salah...";
            }
        }

        private void textBox_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_User_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
