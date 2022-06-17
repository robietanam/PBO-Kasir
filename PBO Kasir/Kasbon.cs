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

        private void Kasbon_Load(object sender, EventArgs e)
        {
            StyleDatageidview();

        }
        void StyleDatageidview()
        {
            dataGridView_Bon.BorderStyle = BorderStyle;
            dataGridView_Bon.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(22, 31, 106);
            dataGridView_Bon.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView_Bon.DefaultCellStyle.SelectionBackColor = Color.FromArgb(209, 185, 250);
            dataGridView_Bon.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dataGridView_Bon.EnableHeadersVisualStyles = false;
            dataGridView_Bon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_Bon.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(22, 31, 106);
            dataGridView_Bon.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins Medium", 9);
        }
    }
}
