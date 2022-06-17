namespace PBO_Kasir
{
    partial class Barang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kode_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaDasar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaJual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button_TambahBarang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kode_barang,
            this.NamaBarang,
            this.HargaDasar,
            this.HargaJual,
            this.Stok,
            this.Kategori});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.dataGridView1.Location = new System.Drawing.Point(18, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(567, 349);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kode_barang
            // 
            this.kode_barang.DataPropertyName = "kode_barang";
            this.kode_barang.HeaderText = "Kode";
            this.kode_barang.Name = "kode_barang";
            this.kode_barang.ReadOnly = true;
            // 
            // NamaBarang
            // 
            this.NamaBarang.DataPropertyName = "nama_barang";
            this.NamaBarang.FillWeight = 150F;
            this.NamaBarang.HeaderText = "Nama Barang";
            this.NamaBarang.Name = "NamaBarang";
            this.NamaBarang.ReadOnly = true;
            // 
            // HargaDasar
            // 
            this.HargaDasar.DataPropertyName = "harga_dasar";
            this.HargaDasar.HeaderText = "Harga Dasar";
            this.HargaDasar.Name = "HargaDasar";
            this.HargaDasar.ReadOnly = true;
            // 
            // HargaJual
            // 
            this.HargaJual.DataPropertyName = "harga_dasar";
            this.HargaJual.HeaderText = "Harga Jual";
            this.HargaJual.Name = "HargaJual";
            this.HargaJual.ReadOnly = true;
            // 
            // Stok
            // 
            this.Stok.DataPropertyName = "stok";
            this.Stok.HeaderText = "Stok";
            this.Stok.Name = "Stok";
            this.Stok.ReadOnly = true;
            // 
            // Kategori
            // 
            this.Kategori.DataPropertyName = "kategori_id_kategori";
            this.Kategori.HeaderText = "Kategori";
            this.Kategori.Name = "Kategori";
            this.Kategori.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manajemen Barang";
            // 
            // button_TambahBarang
            // 
            this.button_TambahBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_TambahBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.button_TambahBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TambahBarang.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.button_TambahBarang.ForeColor = System.Drawing.Color.White;
            this.button_TambahBarang.Location = new System.Drawing.Point(472, 407);
            this.button_TambahBarang.Name = "button_TambahBarang";
            this.button_TambahBarang.Size = new System.Drawing.Size(113, 35);
            this.button_TambahBarang.TabIndex = 2;
            this.button_TambahBarang.Text = "Tambah Barang";
            this.button_TambahBarang.UseVisualStyleBackColor = false;
            this.button_TambahBarang.Click += new System.EventHandler(this.button_TambahBarang_Click);
            // 
            // Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_TambahBarang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Barang";
            this.Size = new System.Drawing.Size(600, 450);
            this.Load += new System.EventHandler(this.Barang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_TambahBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaDasar;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaJual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategori;
    }
}
