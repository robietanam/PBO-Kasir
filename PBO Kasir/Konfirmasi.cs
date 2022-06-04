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
    public partial class Konfirmasi : UserControl
    {
        mainForm objParent;
        public Konfirmasi(mainForm pantek_parent)
        {
            InitializeComponent();
            objParent = pantek_parent;
        }

        private void button_Konfirmasi_Click(object sender, EventArgs e)
        {
            objParent.showKonfirmasiBerhasil();
        }
    }
}
