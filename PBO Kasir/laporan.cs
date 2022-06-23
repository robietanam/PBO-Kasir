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
    public partial class laporan : UserControl
    {
        mainForm objParent;
        List<string> hapusKodeBarang = new List<string>();
        DataTable dtTransaski = new DataTable();
        laporanModel objFiturModel = new laporanModel();
        public laporan()
        {
            InitializeComponent();
            dataGridView1.DataSource = objFiturModel.getHasilTransaksi(comboBox_Kategori.Text);
            comboBox_Kategori.Text = "Pembelian";
        }
        public void updateDataBarang(out DataTable dt)
        {
            dt = objFiturModel.getHasilTransaksi(comboBox_Kategori.Text);
        }

        public void simpanDataBaru()
        {
            label_status.Text = "Data Berhasil Disimpan";
            if (hapusKodeBarang.Count > 0)
            {
                foreach (string kode in hapusKodeBarang)
                {
                    objFiturModel.hapusData(kode, "transaksi", "id_transaksi");
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                label_status.Visible = true;
                label_status.Text = e.ColumnIndex.ToString();
                if (e.ColumnIndex == 0)  // hapus
                {
                    if (row.Cells[1].Value != null)
                    {
                        hapusKodeBarang.Add(row.Cells[1].Value.ToString());
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }
        private void comboBox_Kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDataBarang(out dtTransaski);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtTransaski;
        }

        private void laporan_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button_Simpan_Click(object sender, EventArgs e)
        {
            simpanDataBaru();
            button_Cancel.Visible = false;
            button_Simpan.Visible = false;
            dataGridView1.ReadOnly = true;
            button_Hapus.Visible = true;
            HapusBarang.Visible = false;
            label_status.Text = "Data Tersimpan";

            updateDataBarang(out dtTransaski);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtTransaski;

            hapusKodeBarang.Clear();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            button_Cancel.Visible = false;
            button_Simpan.Visible = false;
            dataGridView1.ReadOnly = true;
            button_Hapus.Visible = true;
            HapusBarang.Visible = false;

            updateDataBarang(out dtTransaski);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtTransaski;

            hapusKodeBarang.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Hapus_Click(object sender, EventArgs e)
        {
            HapusBarang.Visible = true;
            button_Cancel.Visible = true;
            button_Simpan.Visible = true;
        }

        private void button_Hapus_Click_1(object sender, EventArgs e)
        {

        }

        private void button_Simpan_Click_1(object sender, EventArgs e)
        {

        }

        private void button_Cancel_Click_1(object sender, EventArgs e)
        {

        }
    }
}
