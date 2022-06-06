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
    public partial class Barang : UserControl
    {
        mainForm objParent;
        barangModel objBarangModel = new barangModel();
        DataTable dtBarang = new DataTable();
        public Barang(mainForm pantek_parent)
        {
            InitializeComponent();
            objParent = pantek_parent;
            comboBox_Kategori.DisplayMember = "id_kategori";
            comboBox_Kategori.DataSource = objBarangModel.getKategori();
        }
        public void isiDataUsers()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = objBarangModel.getDataBarang(comboBox_Kategori.Text); ;
        }
        private void button_TambahBarang_Click(object sender, EventArgs e)
        {
            objParent.showplsStokBarang();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_Kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            isiDataUsers();
        }
    }
}

