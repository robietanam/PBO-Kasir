namespace PBO_Kasir
{
    partial class Konfirmasi
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
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Konfirmasi = new System.Windows.Forms.Button();
            this.textBox_Nama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Bayar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.msgText = new System.Windows.Forms.Label();
            this.linkLabel_Kembali = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Edit
            // 
            this.button_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Edit.ForeColor = System.Drawing.Color.White;
            this.button_Edit.Location = new System.Drawing.Point(470, 28);
            this.button_Edit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(103, 35);
            this.button_Edit.TabIndex = 1;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = false;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Konfirmasi
            // 
            this.button_Konfirmasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Konfirmasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.button_Konfirmasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Konfirmasi.ForeColor = System.Drawing.Color.White;
            this.button_Konfirmasi.Location = new System.Drawing.Point(470, 315);
            this.button_Konfirmasi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_Konfirmasi.Name = "button_Konfirmasi";
            this.button_Konfirmasi.Size = new System.Drawing.Size(103, 35);
            this.button_Konfirmasi.TabIndex = 2;
            this.button_Konfirmasi.Text = "Konfirmasi";
            this.button_Konfirmasi.UseVisualStyleBackColor = false;
            this.button_Konfirmasi.Click += new System.EventHandler(this.button_Konfirmasi_Click);
            // 
            // textBox_Nama
            // 
            this.textBox_Nama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Nama.Location = new System.Drawing.Point(155, 320);
            this.textBox_Nama.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_Nama.Name = "textBox_Nama";
            this.textBox_Nama.Size = new System.Drawing.Size(212, 24);
            this.textBox_Nama.TabIndex = 3;
            this.textBox_Nama.TextChanged += new System.EventHandler(this.textBox_Nama_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 324);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nama (Opsional) :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 373);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bayar : ";
            // 
            // textBox_Bayar
            // 
            this.textBox_Bayar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Bayar.Location = new System.Drawing.Point(155, 367);
            this.textBox_Bayar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_Bayar.Name = "textBox_Bayar";
            this.textBox_Bayar.Size = new System.Drawing.Size(212, 24);
            this.textBox_Bayar.TabIndex = 5;
            this.textBox_Bayar.TextChanged += new System.EventHandler(this.textBox_Bayar_TextChanged);
            this.textBox_Bayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Bayar_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.label3.Location = new System.Drawing.Point(22, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "List Barang ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // msgText
            // 
            this.msgText.AutoSize = true;
            this.msgText.ForeColor = System.Drawing.Color.IndianRed;
            this.msgText.Location = new System.Drawing.Point(16, 915);
            this.msgText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.msgText.Name = "msgText";
            this.msgText.Size = new System.Drawing.Size(0, 19);
            this.msgText.TabIndex = 8;
            // 
            // linkLabel_Kembali
            // 
            this.linkLabel_Kembali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_Kembali.AutoSize = true;
            this.linkLabel_Kembali.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.linkLabel_Kembali.Location = new System.Drawing.Point(519, 367);
            this.linkLabel_Kembali.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.linkLabel_Kembali.Name = "linkLabel_Kembali";
            this.linkLabel_Kembali.Size = new System.Drawing.Size(54, 19);
            this.linkLabel_Kembali.TabIndex = 9;
            this.linkLabel_Kembali.TabStop = true;
            this.linkLabel_Kembali.Text = "Kembali";
            this.linkLabel_Kembali.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Kembali_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(21, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(2722, 4272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(552, 212);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label_error
            // 
            this.label_error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(302, 402);
            this.label_error.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(71, 19);
            this.label_error.TabIndex = 15;
            this.label_error.Text = "label_error";
            this.label_error.Visible = false;
            this.label_error.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // Konfirmasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linkLabel_Kembali);
            this.Controls.Add(this.msgText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Bayar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Nama);
            this.Controls.Add(this.button_Konfirmasi);
            this.Controls.Add(this.button_Edit);
            this.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Konfirmasi";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Konfirmasi;
        private System.Windows.Forms.TextBox textBox_Nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Bayar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label msgText;
        private System.Windows.Forms.LinkLabel linkLabel_Kembali;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_error;
    }
}
