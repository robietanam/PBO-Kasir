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
    public partial class Kasbon : UserControl
    {
        mainForm objParent;
    public Kasbon(mainForm pantek_parent)
        {
            InitializeComponent();
            objParent = pantek_parent;
        }

        private void dataGridView_Bon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button_TambahBon_Click(object sender, EventArgs e)
        {
            objParent.showKasbonTambah();
        }
    }
}
