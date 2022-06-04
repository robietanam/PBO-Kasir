namespace PBO_Kasir
{
    partial class Kasbon
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
            this.Kasbonlabel = new System.Windows.Forms.Label();
            this.dataGridView_Bon = new System.Windows.Forms.DataGridView();
            this.NamaBon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalBon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenggatBon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BayarBon = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_TambahBon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bon)).BeginInit();
            this.SuspendLayout();
            // 
            // Kasbonlabel
            // 
            this.Kasbonlabel.AutoSize = true;
            this.Kasbonlabel.Location = new System.Drawing.Point(38, 45);
            this.Kasbonlabel.Name = "Kasbonlabel";
            this.Kasbonlabel.Size = new System.Drawing.Size(43, 13);
            this.Kasbonlabel.TabIndex = 0;
            this.Kasbonlabel.Text = "Kasbon";
            // 
            // dataGridView_Bon
            // 
            this.dataGridView_Bon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Bon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Bon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamaBon,
            this.Nama,
            this.TanggalBon,
            this.TenggatBon,
            this.BayarBon});
            this.dataGridView_Bon.Location = new System.Drawing.Point(41, 61);
            this.dataGridView_Bon.Name = "dataGridView_Bon";
            this.dataGridView_Bon.Size = new System.Drawing.Size(532, 302);
            this.dataGridView_Bon.TabIndex = 1;
            this.dataGridView_Bon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Bon_CellContentClick);
            // 
            // NamaBon
            // 
            this.NamaBon.HeaderText = "Bon";
            this.NamaBon.Name = "NamaBon";
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.Name = "Nama";
            // 
            // TanggalBon
            // 
            this.TanggalBon.HeaderText = "Tanggal Bon";
            this.TanggalBon.Name = "TanggalBon";
            // 
            // TenggatBon
            // 
            this.TenggatBon.HeaderText = "Tenggat Bon";
            this.TenggatBon.Name = "TenggatBon";
            // 
            // BayarBon
            // 
            this.BayarBon.HeaderText = "Bayar";
            this.BayarBon.Name = "BayarBon";
            // 
            // button_TambahBon
            // 
            this.button_TambahBon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_TambahBon.Location = new System.Drawing.Point(475, 32);
            this.button_TambahBon.Name = "button_TambahBon";
            this.button_TambahBon.Size = new System.Drawing.Size(98, 23);
            this.button_TambahBon.TabIndex = 2;
            this.button_TambahBon.Text = "Tambah Bon";
            this.button_TambahBon.UseVisualStyleBackColor = true;
            this.button_TambahBon.Click += new System.EventHandler(this.button_TambahBon_Click);
            // 
            // Kasbon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_TambahBon);
            this.Controls.Add(this.dataGridView_Bon);
            this.Controls.Add(this.Kasbonlabel);
            this.Name = "Kasbon";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kasbonlabel;
        private System.Windows.Forms.DataGridView dataGridView_Bon;
        private System.Windows.Forms.Button button_TambahBon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalBon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenggatBon;
        private System.Windows.Forms.DataGridViewButtonColumn BayarBon;
    }
}
