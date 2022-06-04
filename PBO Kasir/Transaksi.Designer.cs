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
            this.Harga_Jual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TambahBarang = new System.Windows.Forms.DataGridViewButtonColumn();
            this.JumlahBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KurangiBarang = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_Selanjutnya = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Barang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Barang
            // 
            this.dataGridView_Barang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Barang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Barang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KodeBarang,
            this.NamaBarang,
            this.Harga_Jual,
            this.Stok,
            this.TambahBarang,
            this.JumlahBarang,
            this.KurangiBarang});
            this.dataGridView_Barang.Location = new System.Drawing.Point(30, 31);
            this.dataGridView_Barang.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.dataGridView_Barang.Name = "dataGridView_Barang";
            this.dataGridView_Barang.Size = new System.Drawing.Size(543, 355);
            this.dataGridView_Barang.TabIndex = 4;
            this.dataGridView_Barang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Barang_CellContentClick);
            // 
            // KodeBarang
            // 
            this.KodeBarang.HeaderText = "Kode Barang";
            this.KodeBarang.Name = "KodeBarang";
            this.KodeBarang.ReadOnly = true;
            this.KodeBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NamaBarang
            // 
            this.NamaBarang.HeaderText = "Nama Barang";
            this.NamaBarang.Name = "NamaBarang";
            this.NamaBarang.ReadOnly = true;
            this.NamaBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Harga_Jual
            // 
            this.Harga_Jual.HeaderText = "Harga";
            this.Harga_Jual.Name = "Harga_Jual";
            this.Harga_Jual.ReadOnly = true;
            this.Harga_Jual.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Stok
            // 
            this.Stok.HeaderText = "Stok";
            this.Stok.Name = "Stok";
            this.Stok.ReadOnly = true;
            this.Stok.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TambahBarang
            // 
            this.TambahBarang.HeaderText = "Tambah";
            this.TambahBarang.Name = "TambahBarang";
            this.TambahBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TambahBarang.Text = "+";
            // 
            // JumlahBarang
            // 
            this.JumlahBarang.HeaderText = "Jumlah";
            this.JumlahBarang.Name = "JumlahBarang";
            this.JumlahBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // KurangiBarang
            // 
            this.KurangiBarang.HeaderText = "Kurangi";
            this.KurangiBarang.Name = "KurangiBarang";
            this.KurangiBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.KurangiBarang.Text = "-";
            // 
            // button_Selanjutnya
            // 
            this.button_Selanjutnya.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Selanjutnya.Location = new System.Drawing.Point(481, 401);
            this.button_Selanjutnya.Name = "button_Selanjutnya";
            this.button_Selanjutnya.Size = new System.Drawing.Size(92, 29);
            this.button_Selanjutnya.TabIndex = 2;
            this.button_Selanjutnya.Text = "Selanjutnya";
            this.button_Selanjutnya.UseVisualStyleBackColor = true;
            this.button_Selanjutnya.Click += new System.EventHandler(this.button_Selanjutnya_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Barang";
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Selanjutnya);
            this.Controls.Add(this.dataGridView_Barang);
            this.Name = "Transaksi";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Barang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Barang;
        private System.Windows.Forms.Button button_Selanjutnya;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga_Jual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok;
        private System.Windows.Forms.DataGridViewButtonColumn TambahBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn JumlahBarang;
        private System.Windows.Forms.DataGridViewButtonColumn KurangiBarang;
    }
}
