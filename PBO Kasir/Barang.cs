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
        List<string> hapusKodeBarang = new List<string>();
        DataTable dtBarang = new DataTable();
        fitur objFitur = new fitur();
        public Barang(mainForm pantek_parent)
        {
            InitializeComponent();
            objParent = pantek_parent;
            comboBox_Kategori.DisplayMember = "id_kategori";
            comboBox_Kategori.DataSource = objBarangModel.getKategori();
            dataGridView1.DataSource = objBarangModel.getDataBarang(comboBox_Kategori.Text);
            button_Simpan.Visible = false;
            button_Cancel.Visible = false;
            label_Status.Text = "";
        }
        public void updateKategoriBarang()
        {
            comboBox_Kategori.DisplayMember = "id_kategori";
            comboBox_Kategori.DataSource = objBarangModel.getKategori();
        }
        public void updateDataBarang(out DataTable dt)
        {
            dt = objBarangModel.getDataBarang(comboBox_Kategori.Text);
        }
        public void updateData()
        {
            updateDataBarang(out dtBarang);
            dataGridView1.DataSource = dtBarang;
        }
        public void simpanDataBaru()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //row.Cells[1].Value;
                objBarangModel.updateBarang(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), float.Parse(row.Cells[3].Value.ToString()), float.Parse(row.Cells[4].Value.ToString()), row.Cells[5].Value.ToString(), comboBox_Kategori.Text.ToString());
            }
            if (hapusKodeBarang.Count > 0)
            {
                foreach (string kode in hapusKodeBarang)
                {
                    objBarangModel.hapusData(kode, "barang", "kode_barang");
                }
            }
        }

        private void button_TambahBarang_Click(object sender, EventArgs e)
        {
            objParent.showplsStokBarang();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (e.ColumnIndex == 6)  // hapus
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
            updateDataBarang(out dtBarang);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtBarang;
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            button_Simpan.Visible = true;
            button_Cancel.Visible = true;
            button_Hapus.Visible = false;
            dataGridView1.ReadOnly = false;
        }

        private void button_Simpan_Click(object sender, EventArgs e)
        {
            simpanDataBaru();
            button_Edit.Visible = true;
            button_Cancel.Visible = false;
            button_Simpan.Visible = false;
            dataGridView1.ReadOnly = true;
            button_Hapus.Visible = true;
            HapusBarang.Visible = false;
            label_Status.Text = "Data Tersimpan";
            objFitur.countdownTimer(label_Status);
            updateDataBarang(out dtBarang);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtBarang;

            hapusKodeBarang.Clear();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {          
            button_Edit.Visible = true;
            button_Cancel.Visible = false;
            button_Simpan.Visible = false;
            dataGridView1.ReadOnly = true;
            button_Hapus.Visible = true;
            HapusBarang.Visible = false;

            updateDataBarang(out dtBarang);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtBarang;

            hapusKodeBarang.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Hapus_Click(object sender, EventArgs e)
        {
            HapusBarang.Visible = true;
            button_Edit.Visible = false;
            button_Cancel.Visible = true;
            button_Simpan.Visible = true;
        }

        void StyleDatageidview()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(209, 185, 250);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(22, 31, 106);
        }

        private void Barang_Load(object sender, EventArgs e)
        {
            StyleDatageidview();
        }

        private void label_Status_Click(object sender, EventArgs e)
        {

        }
    }
}

