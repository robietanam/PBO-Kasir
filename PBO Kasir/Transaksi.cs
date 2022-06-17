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
    public partial class Transaksi : UserControl
    {
        mainForm objParent;
        public Transaksi(mainForm pantek_parent)
        {
            InitializeComponent();
            objParent = pantek_parent;
        }
        private void dataGridView_Barang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Selanjutnya_Click(object sender, EventArgs e)
        {
            objParent.showKonfirmasi();
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            StyleDatageidview();
        }
        void StyleDatageidview()
        {
            dataGridView_Barang.BorderStyle = BorderStyle.None;
            dataGridView_Barang.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(22, 31, 106);
            dataGridView_Barang.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView_Barang.DefaultCellStyle.SelectionBackColor = Color.FromArgb(209, 185, 250);
            dataGridView_Barang.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;



            dataGridView_Barang.EnableHeadersVisualStyles = false;
            dataGridView_Barang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_Barang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(22, 31, 106);
            dataGridView_Barang.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins Medium", 10);

            
        }
    }
}
