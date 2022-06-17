using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBO_Kasir.models;

namespace PBO_Kasir
{
    public partial class KategoriTambah : UserControl
    {
        barangModel objBarangModel = new barangModel();
        mainForm objParent;
        public KategoriTambah(mainForm pantek_parent)
        {
            InitializeComponent();
            objParent = pantek_parent;
            isiDataKategori();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void isiDataKategori()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = objBarangModel.getKategori(); ;
        }
        private void button_Tambah_Click(object sender, EventArgs e)
        {
            if (objBarangModel.checkValueAda("id_kategori", textBox_Kategori1.Text, "kategori"))
            {
                label_error.Text = "Kategori sudah ada";
            }
            else if (String.IsNullOrWhiteSpace(textBox_Kategori1.Text))
            {
                label_error.Text = "Kategori perlu diisi";
            }
            else
            {
                objBarangModel.tambahKategori(textBox_Kategori1.Text);
            }
            isiDataKategori();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel_Kembali_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            objParent.showMenuBarang();
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
    }
}
