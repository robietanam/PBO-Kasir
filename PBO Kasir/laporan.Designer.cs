namespace PBO_Kasir
{
    partial class laporan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Transaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pembeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pemasukan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalTransaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HapusBarang = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBox_Kategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Hapus = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Simpan = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins Medium", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Transaksi,
            this.Pembeli,
            this.Pemasukan,
            this.TanggalTransaksi,
            this.HapusBarang});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(30, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(544, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id_Transaksi
            // 
            this.Id_Transaksi.DataPropertyName = "id_transaksi";
            this.Id_Transaksi.FillWeight = 40.60914F;
            this.Id_Transaksi.HeaderText = "ID";
            this.Id_Transaksi.Name = "Id_Transaksi";
            this.Id_Transaksi.ReadOnly = true;
            this.Id_Transaksi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Pembeli
            // 
            this.Pembeli.DataPropertyName = "nama_pelanggan";
            this.Pembeli.FillWeight = 119.7969F;
            this.Pembeli.HeaderText = "Atas Nama";
            this.Pembeli.Name = "Pembeli";
            this.Pembeli.ReadOnly = true;
            this.Pembeli.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Pemasukan
            // 
            this.Pemasukan.DataPropertyName = "jumlah_pemasukan";
            this.Pemasukan.FillWeight = 119.7969F;
            this.Pemasukan.HeaderText = "Pemasukan";
            this.Pemasukan.Name = "Pemasukan";
            this.Pemasukan.ReadOnly = true;
            // 
            // TanggalTransaksi
            // 
            this.TanggalTransaksi.DataPropertyName = "tanggal_transaksi";
            this.TanggalTransaksi.FillWeight = 119.7969F;
            this.TanggalTransaksi.HeaderText = "Tanggal Transaksi";
            this.TanggalTransaksi.Name = "TanggalTransaksi";
            this.TanggalTransaksi.ReadOnly = true;
            // 
            // HapusBarang
            // 
            this.HapusBarang.HeaderText = "Hapus";
            this.HapusBarang.Name = "HapusBarang";
            this.HapusBarang.ReadOnly = true;
            this.HapusBarang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HapusBarang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.HapusBarang.Visible = false;
            // 
            // comboBox_Kategori
            // 
            this.comboBox_Kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Kategori.FormattingEnabled = true;
            this.comboBox_Kategori.Items.AddRange(new object[] {
            "Pembelian",
            "Kasbon"});
            this.comboBox_Kategori.Location = new System.Drawing.Point(95, 29);
            this.comboBox_Kategori.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboBox_Kategori.Name = "comboBox_Kategori";
            this.comboBox_Kategori.Size = new System.Drawing.Size(163, 27);
            this.comboBox_Kategori.TabIndex = 6;
            this.comboBox_Kategori.SelectedIndexChanged += new System.EventHandler(this.comboBox_Kategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Laporan";
            // 
            // button_Hapus
            // 
            this.button_Hapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Hapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.button_Hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Hapus.ForeColor = System.Drawing.Color.White;
            this.button_Hapus.Location = new System.Drawing.Point(481, 29);
            this.button_Hapus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_Hapus.Name = "button_Hapus";
            this.button_Hapus.Size = new System.Drawing.Size(93, 28);
            this.button_Hapus.TabIndex = 13;
            this.button_Hapus.Text = "Hapus";
            this.button_Hapus.UseVisualStyleBackColor = false;
            this.button_Hapus.Click += new System.EventHandler(this.button_Hapus_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.button_Cancel.ForeColor = System.Drawing.Color.White;
            this.button_Cancel.Location = new System.Drawing.Point(276, 29);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(93, 28);
            this.button_Cancel.TabIndex = 12;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Visible = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Simpan
            // 
            this.button_Simpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Simpan.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_Simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Simpan.ForeColor = System.Drawing.Color.White;
            this.button_Simpan.Location = new System.Drawing.Point(378, 29);
            this.button_Simpan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_Simpan.Name = "button_Simpan";
            this.button_Simpan.Size = new System.Drawing.Size(93, 28);
            this.button_Simpan.TabIndex = 11;
            this.button_Simpan.Text = "Simpan";
            this.button_Simpan.UseVisualStyleBackColor = false;
            this.button_Simpan.Visible = false;
            this.button_Simpan.Click += new System.EventHandler(this.button_Simpan_Click);
            // 
            // label_status
            // 
            this.label_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.label_status.ForeColor = System.Drawing.Color.Red;
            this.label_status.Location = new System.Drawing.Point(25, 361);
            this.label_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(45, 25);
            this.label_status.TabIndex = 14;
            this.label_status.Text = "error";
            this.label_status.Visible = false;
            this.label_status.Click += new System.EventHandler(this.label2_Click);
            // 
            // laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.button_Hapus);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Simpan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Kategori);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "laporan";
            this.Size = new System.Drawing.Size(600, 450);
            this.Load += new System.EventHandler(this.laporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_Kategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Hapus;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Simpan;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Transaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pembeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pemasukan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalTransaksi;
        private System.Windows.Forms.DataGridViewButtonColumn HapusBarang;
    }
}
