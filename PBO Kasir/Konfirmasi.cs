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

        private void Konfirmasi_Load(object sender, EventArgs e)
        {
            StyleDatageidview();
        }
        void StyleDatageidview()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(22, 31, 106);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(209, 185, 250);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;



            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(22, 31, 106);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins Medium", 10);


        }

        private void textBox_Bayar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Bayar1_Load(object sender, EventArgs e)
        {

        }
    }
}
