﻿using System;
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
    }
}