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
    public partial class KonfirmasiBerhasil : UserControl
    {
        mainForm objParent;
        public KonfirmasiBerhasil(mainForm pantek_parent)
        {
            InitializeComponent();
            objParent = pantek_parent;
        }

        private void linkLabel_Kembali_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            objParent.showMenuTransaksi();
        }
    }
}
