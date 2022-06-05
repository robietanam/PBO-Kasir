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
using System.Text.RegularExpressions;
using Npgsql;

namespace PBO_Kasir
{
    public partial class StokBarang : UserControl
    {
        mainForm objParent;
        barangModel objBarangModel = new barangModel();
        

        public StokBarang(mainForm pantek_parent)
        {
            InitializeComponent();
            objParent = pantek_parent;
            comboBox_Kategori.DisplayMember = "id_kategori";
            comboBox_Kategori.DataSource = objBarangModel.getKategori();

        }
        public bool checkFormatBarang(string kode, string nama, string hargaDasar, string hargaJual, string stok, string kategori)
        {
            bool check;
            if ((kode.Length < 100 || !objBarangModel.checkValueAda("kode_barang", kode, "barang"))
                || (nama.Length < 255) || (hargaDasar.Length < 100) || (hargaJual.Length < 100)
                || (stok.Length < 100) || (kategori.Length < 255 || objBarangModel.checkValueAda("id_kategori", kategori, "kategori")))
            {
                check = true;
            }
            else check = false;
            return check;
        }

        private void textBox_Kode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox_Kode.Text.Length > 10)
            {
                e.Handled = true;
            }
        }

        private void textBox_HargaDasar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                TextBox tb = sender as TextBox;
                int cursorPosLeft = tb.SelectionStart;
                int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
                string result = tb.Text.Substring(0, cursorPosLeft) + e.KeyChar + tb.Text.Substring(cursorPosRight);
                string[] parts = result.Split('.');
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
        private void textBox_HargaBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                TextBox tb = sender as TextBox;
                int cursorPosLeft = tb.SelectionStart;
                int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
                string result = tb.Text.Substring(0, cursorPosLeft) + e.KeyChar + tb.Text.Substring(cursorPosRight);
                string[] parts = result.Split('.');
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

        
        private void button_simpanBarang_Click(object sender, EventArgs e)
        {
            if (checkFormatBarang(textBox_Kode.Text, textBox_NamaBarang.Text, textBox_HargaDasar.Text, textBox_HargaBarang.Text, textBox_Stok.Text, comboBox_Kategori.Text)) objBarangModel.tambahBarang(textBox_Kode.Text, textBox_NamaBarang.Text, textBox_HargaDasar.Text, textBox_HargaBarang.Text, textBox_Stok.Text, comboBox_Kategori.Text);
            objParent.showMenuBarang();
            
           
            
        }
       
        private void textBox_NamaBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Kode_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_HargaDasar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_HargaBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Kategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_tambahKategori_Click(object sender, EventArgs e)
        {
            
        }
    }
}
