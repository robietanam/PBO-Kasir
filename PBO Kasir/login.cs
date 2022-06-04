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

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text == "t" && textBox_Password.Text == "1")
            {
                lblInfo.Text = "";
                textBox_Username.Text = "";
                textBox_Password.Text = "";
                this.Visible = false;
                objParent.showMainForm();
            }
            else
            {
                lblInfo.Text = "Username atau password salah...";
            }
        }
    }
}
