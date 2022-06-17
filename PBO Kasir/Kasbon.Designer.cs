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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Kasbonlabel = new System.Windows.Forms.Label();
            this.dataGridView_Bon = new System.Windows.Forms.DataGridView();
            this.button_TambahBon = new System.Windows.Forms.Button();
            this.NamaBon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalBon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenggatBon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BayarBon = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bon)).BeginInit();
            this.SuspendLayout();
            // 
            // Kasbonlabel
            // 
            this.Kasbonlabel.AutoSize = true;
            this.Kasbonlabel.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.Kasbonlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.Kasbonlabel.Location = new System.Drawing.Point(14, 4);
            this.Kasbonlabel.Name = "Kasbonlabel";
            this.Kasbonlabel.Size = new System.Drawing.Size(73, 28);
            this.Kasbonlabel.TabIndex = 0;
            this.Kasbonlabel.Text = "Kasbon";
            // 
            // dataGridView_Bon
            // 
            this.dataGridView_Bon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Bon.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Poppins", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Bon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_Bon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Bon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamaBon,
            this.Nama,
            this.TanggalBon,
            this.TenggatBon,
            this.BayarBon});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Bon.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView_Bon.Location = new System.Drawing.Point(19, 35);
            this.dataGridView_Bon.Name = "dataGridView_Bon";
            this.dataGridView_Bon.Size = new System.Drawing.Size(567, 349);
            this.dataGridView_Bon.TabIndex = 1;
            this.dataGridView_Bon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Bon_CellContentClick);
            // 
            // button_TambahBon
            // 
            this.button_TambahBon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_TambahBon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.button_TambahBon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TambahBon.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.button_TambahBon.ForeColor = System.Drawing.Color.White;
            this.button_TambahBon.Location = new System.Drawing.Point(473, 390);
            this.button_TambahBon.Name = "button_TambahBon";
            this.button_TambahBon.Size = new System.Drawing.Size(113, 35);
            this.button_TambahBon.TabIndex = 2;
            this.button_TambahBon.Text = "Tambah Bon";
            this.button_TambahBon.UseVisualStyleBackColor = false;
            this.button_TambahBon.Click += new System.EventHandler(this.button_TambahBon_Click);
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
            this.TanggalBon.Width = 120;
            // 
            // TenggatBon
            // 
            this.TenggatBon.HeaderText = "Tenggat Bon";
            this.TenggatBon.Name = "TenggatBon";
            this.TenggatBon.Width = 110;
            // 
            // BayarBon
            // 
            this.BayarBon.HeaderText = "Bayar";
            this.BayarBon.Name = "BayarBon";
            this.BayarBon.Width = 94;
            // 
            // Kasbon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_TambahBon);
            this.Controls.Add(this.dataGridView_Bon);
            this.Controls.Add(this.Kasbonlabel);
            this.Name = "Kasbon";
            this.Size = new System.Drawing.Size(600, 450);
            this.Load += new System.EventHandler(this.Kasbon_Load);
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
