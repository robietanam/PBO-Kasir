using PBO_Kasir.models;

namespace PBO_Kasir
{
    partial class Transaksi
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_Barang = new System.Windows.Forms.DataGridView();
            this.KodeBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JumlahBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TambahBarang = new System.Windows.Forms.DataGridViewButtonColumn();
            this.KurangiBarang = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_Selanjutnya = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Kategori = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Barang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Barang
            // 
            this.dataGridView_Barang.AllowUserToAddRows = false;
            this.dataGridView_Barang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Barang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Barang.ColumnHeadersHeight = 30;
            this.dataGridView_Barang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KodeBarang,
            this.NamaBarang,
            this.HargaBarang,
            this.Stok,
            this.JumlahBarang,
            this.TambahBarang,
            this.KurangiBarang});
            this.dataGridView_Barang.Location = new System.Drawing.Point(26, 70);
            this.dataGridView_Barang.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Barang.MaximumSize = new System.Drawing.Size(2333, 2923);
            this.dataGridView_Barang.Name = "dataGridView_Barang";
            this.dataGridView_Barang.RowHeadersVisible = false;
            this.dataGridView_Barang.Size = new System.Drawing.Size(548, 352);
            this.dataGridView_Barang.TabIndex = 4;
            this.dataGridView_Barang.Visible = false;
            this.dataGridView_Barang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Barang_CellContentClick);
            this.dataGridView_Barang.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_Barang_EditingControlShowing);
            // 
            // KodeBarang
            // 
            this.KodeBarang.DataPropertyName = "kode_barang";
            this.KodeBarang.FillWeight = 50F;
            this.KodeBarang.HeaderText = "Kode Barang";
            this.KodeBarang.Name = "KodeBarang";
            this.KodeBarang.ReadOnly = true;
            this.KodeBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NamaBarang
            // 
            this.NamaBarang.DataPropertyName = "nama_barang";
            this.NamaBarang.FillWeight = 65.47089F;
            this.NamaBarang.HeaderText = "Nama Barang";
            this.NamaBarang.Name = "NamaBarang";
            this.NamaBarang.ReadOnly = true;
            this.NamaBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // HargaBarang
            // 
            this.HargaBarang.DataPropertyName = "harga_jual";
            this.HargaBarang.FillWeight = 65.47089F;
            this.HargaBarang.HeaderText = "Harga";
            this.HargaBarang.Name = "HargaBarang";
            this.HargaBarang.ReadOnly = true;
            this.HargaBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Stok
            // 
            this.Stok.DataPropertyName = "stok";
            this.Stok.FillWeight = 45F;
            this.Stok.HeaderText = "Stok";
            this.Stok.Name = "Stok";
            this.Stok.ReadOnly = true;
            this.Stok.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // JumlahBarang
            // 
            this.JumlahBarang.FillWeight = 40F;
            this.JumlahBarang.HeaderText = "Jumlah";
            this.JumlahBarang.Name = "JumlahBarang";
            this.JumlahBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TambahBarang
            // 
            this.TambahBarang.FillWeight = 44.38703F;
            this.TambahBarang.HeaderText = "Tambah";
            this.TambahBarang.Name = "TambahBarang";
            this.TambahBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TambahBarang.Text = "+";
            // 
            // KurangiBarang
            // 
            this.KurangiBarang.FillWeight = 42.00468F;
            this.KurangiBarang.HeaderText = "Kurangi";
            this.KurangiBarang.Name = "KurangiBarang";
            this.KurangiBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.KurangiBarang.Text = "-";
            // 
            // button_Selanjutnya
            // 
            this.button_Selanjutnya.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Selanjutnya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.button_Selanjutnya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Selanjutnya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_Selanjutnya.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Selanjutnya.Location = new System.Drawing.Point(467, 20);
            this.button_Selanjutnya.Margin = new System.Windows.Forms.Padding(4);
            this.button_Selanjutnya.Name = "button_Selanjutnya";
            this.button_Selanjutnya.Size = new System.Drawing.Size(107, 30);
            this.button_Selanjutnya.TabIndex = 2;
            this.button_Selanjutnya.Text = "Selanjutnya";
            this.button_Selanjutnya.UseVisualStyleBackColor = false;
            this.button_Selanjutnya.Click += new System.EventHandler(this.button_Selanjutnya_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Barang";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(271, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Barang";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox_Kategori
            // 
            this.comboBox_Kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Kategori.FormattingEnabled = true;
            this.comboBox_Kategori.Location = new System.Drawing.Point(85, 29);
            this.comboBox_Kategori.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Kategori.Name = "comboBox_Kategori";
            this.comboBox_Kategori.Size = new System.Drawing.Size(140, 21);
            this.comboBox_Kategori.TabIndex = 5;
            this.comboBox_Kategori.SelectedIndexChanged += new System.EventHandler(this.comboBox_Kategori_SelectedIndexChanged);
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Kategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Selanjutnya);
            this.Controls.Add(this.dataGridView_Barang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Transaksi";
            this.Size = new System.Drawing.Size(600, 450);
            this.Load += new System.EventHandler(this.Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Barang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Barang;
        private System.Windows.Forms.Button button_Selanjutnya;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok;
        private System.Windows.Forms.DataGridViewTextBoxColumn JumlahBarang;
        private System.Windows.Forms.DataGridViewButtonColumn TambahBarang;
        private System.Windows.Forms.DataGridViewButtonColumn KurangiBarang;
    }
}
