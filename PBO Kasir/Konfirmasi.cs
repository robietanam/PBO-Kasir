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
    public partial class Konfirmasi : UserControl
    {
        mainForm objParent;
        DataTable dtKonfirmasi = new DataTable();
        transaksiModel objTransaksiModel = new transaksiModel();
        barangModel objBarangModel = new barangModel();
        float HargaTotal;
        fitur objFitur = new fitur();

        public Konfirmasi(mainForm pantek_parent)
        {
            InitializeComponent();
            objParent = pantek_parent;
            textBox_Bayar.Text = "0";
        }
        public void isiDatanya(DataTable dt)
        {
            dtKonfirmasi = dt;
            dataGridView1.DataSource = dtKonfirmasi;
        }
        private void button_Konfirmasi_Click(object sender, EventArgs e)
        {            
            float Bayar = float.Parse(textBox_Bayar.Text.ToString());
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                HargaTotal += float.Parse(row.Cells[2].Value.ToString()) * float.Parse(row.Cells[4].Value.ToString());
            }

            if (HargaTotal > Bayar)
            {
                label_error.Text = "Bayar Tidak Cukup";
                objFitur.countdownTimer(label_error);
                HargaTotal = 0;
            }
            else
            {
                if (String.IsNullOrEmpty(textBox_Nama.Text.ToString()))
                {
                    textBox_Nama.Text = "Unknown";
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    float Harga = float.Parse(row.Cells[2].Value.ToString()) - float.Parse(objTransaksiModel.getHargaDasar(row.Cells[0].Value.ToString()).Rows[0][0].ToString());
                    objTransaksiModel.simpanTransaksiBarang(textBox_Nama.Text.ToString(), Harga, row.Cells[0].Value.ToString());
                    objBarangModel.updateStok(row.Cells[0].Value.ToString(), int.Parse(row.Cells[3].Value.ToString()));
                }
                dataGridView1.DataSource = null;
                objParent.ResetTransaksi();
                //objTransaksiModel.simpanTransaksi();
                objParent.showKonfirmasiBerhasilBarang();
                textBox_Nama.Text = "";
                textBox_Bayar.Text = "0";
                
            }
            
        }
        public string[] informasiBerhasil()
        {
            string[] info = { textBox_Nama.Text.ToString(), textBox_Bayar.Text.ToString(), Math.Round((float.Parse(textBox_Bayar.Text) - HargaTotal),2).ToString() };
            return info;
        }
        private void linkLabel_Kembali_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            objParent.showMenuTransaksi();
        }


        private void textBox_Bayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            {
                TextBox tb = sender as TextBox;
                int cursorPosLeft = tb.SelectionStart;
                int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
                string result = tb.Text.Substring(0, cursorPosLeft) + e.KeyChar + tb.Text.Substring(cursorPosRight);
                string[] parts = result.Split(',');
                if (parts.Length > 1)
                {
                    if (parts[1].Length > 2 || parts.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }
        
        private void textBox_Stok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                e.Handled = e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                TextBox tb = e.Control as TextBox;
                tb.KeyPress -= new KeyPressEventHandler(tb_KeyPress);
                if (this.dataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
                }
            }
        }
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != '\b') //allow the backspace key
                {
                    e.Handled = true;
                }
            }
        }
        private void CheckKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        // Load semua kategori terlebih dahulu, di dataTabel yang berbeda
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.RowIndex != dtKonfirmasi.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (e.ColumnIndex == 5)  // edit
                {

                    if (row.Cells[4].Value == null)
                    {
                        row.Cells[4].Value = "1";

                    }
                    else if (row.Cells[4].Value != null)
                    {
                        int num = int.Parse(row.Cells[4].Value.ToString());
                        num += 1;
                        row.Cells[4].Value = num.ToString();
                    }
                }

                else if (e.ColumnIndex == 6) // hapus
                {
                    if (row.Cells[4].Value != null && int.Parse(row.Cells[4].Value.ToString()) > 0)
                    {
                        int num = int.Parse(row.Cells[4].Value.ToString());
                        num -= 1;
                        row.Cells[4].Value = num.ToString();
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            objParent.showMenuTransaksi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox_Bayar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label_error.Text = objTransaksiModel.getHargaDasar(dataGridView1.Rows[0].Cells[0].Value.ToString()).Rows[0][0].ToString();
        }

        private void Konfirmasi_Load(object sender, EventArgs e)
        {
            StyleDatageidview();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
