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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msgText = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.textBox_Bayar1 = new PBO_Kasir.customtextbox();
            this.textBox_Nama1 = new PBO_Kasir.customtextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_Edit
            // 
            this.button_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Edit.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.button_Edit.ForeColor = System.Drawing.Color.White;
            this.button_Edit.Location = new System.Drawing.Point(505, 17);
=======
            this.linkLabel_Kembali = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Edit
            // 
            this.button_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Edit.Location = new System.Drawing.Point(505, 39);
>>>>>>> refs/remotes/origin/master
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(75, 34);
            this.button_Edit.TabIndex = 1;
            this.button_Edit.Text = "Edit";
<<<<<<< HEAD
            this.button_Edit.UseVisualStyleBackColor = false;
            // 
            // button_Konfirmasi
            // 
            this.button_Konfirmasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.button_Konfirmasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Konfirmasi.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.button_Konfirmasi.ForeColor = System.Drawing.Color.White;
            this.button_Konfirmasi.Location = new System.Drawing.Point(505, 397);
=======
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Konfirmasi
            // 
            this.button_Konfirmasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Konfirmasi.Location = new System.Drawing.Point(513, 405);
>>>>>>> refs/remotes/origin/master
            this.button_Konfirmasi.Name = "button_Konfirmasi";
            this.button_Konfirmasi.Size = new System.Drawing.Size(75, 31);
            this.button_Konfirmasi.TabIndex = 2;
            this.button_Konfirmasi.Text = "Konfirmasi";
            this.button_Konfirmasi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Konfirmasi.UseVisualStyleBackColor = false;
            this.button_Konfirmasi.Click += new System.EventHandler(this.button_Konfirmasi_Click);
            // 
<<<<<<< HEAD
=======
            // textBox_Nama
            // 
            this.textBox_Nama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Nama.Location = new System.Drawing.Point(350, 381);
            this.textBox_Nama.Name = "textBox_Nama";
            this.textBox_Nama.Size = new System.Drawing.Size(157, 20);
            this.textBox_Nama.TabIndex = 3;
            this.textBox_Nama.TextChanged += new System.EventHandler(this.textBox_Nama_TextChanged);
            // 
>>>>>>> refs/remotes/origin/master
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.label1.Location = new System.Drawing.Point(13, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nama (Opsional) :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.label2.Location = new System.Drawing.Point(79, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bayar : ";
            // 
<<<<<<< HEAD
=======
            // textBox_Bayar
            // 
            this.textBox_Bayar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Bayar.Location = new System.Drawing.Point(350, 407);
            this.textBox_Bayar.Name = "textBox_Bayar";
            this.textBox_Bayar.Size = new System.Drawing.Size(157, 20);
            this.textBox_Bayar.TabIndex = 5;
            // 
>>>>>>> refs/remotes/origin/master
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.label3.Location = new System.Drawing.Point(10, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "List Barang ";
            // 
            // msgText
            // 
            this.msgText.AutoSize = true;
            this.msgText.ForeColor = System.Drawing.Color.IndianRed;
            this.msgText.Location = new System.Drawing.Point(12, 428);
            this.msgText.Name = "msgText";
            this.msgText.Size = new System.Drawing.Size(0, 13);
            this.msgText.TabIndex = 8;
            // 
<<<<<<< HEAD
            // textBox_Bayar1
            // 
            this.textBox_Bayar1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Bayar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.textBox_Bayar1.BorderRadius = 0;
            this.textBox_Bayar1.Bordersize = 2;
            this.textBox_Bayar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Bayar1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Bayar1.Location = new System.Drawing.Point(153, 397);
            this.textBox_Bayar1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Bayar1.Multiline = false;
            this.textBox_Bayar1.Name = "textBox_Bayar1";
            this.textBox_Bayar1.Padding = new System.Windows.Forms.Padding(7);
            this.textBox_Bayar1.PasswordChar = false;
            this.textBox_Bayar1.Size = new System.Drawing.Size(167, 31);
            this.textBox_Bayar1.TabIndex = 9;
            this.textBox_Bayar1.Texts = "";
            this.textBox_Bayar1.UnderlinedStyle = false;
            this.textBox_Bayar1.Load += new System.EventHandler(this.textBox_Bayar1_Load);
            // 
            // textBox_Nama1
            // 
            this.textBox_Nama1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Nama1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.textBox_Nama1.BorderRadius = 0;
            this.textBox_Nama1.Bordersize = 2;
            this.textBox_Nama1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nama1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Nama1.Location = new System.Drawing.Point(153, 344);
            this.textBox_Nama1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Nama1.Multiline = false;
            this.textBox_Nama1.Name = "textBox_Nama1";
            this.textBox_Nama1.Padding = new System.Windows.Forms.Padding(7);
            this.textBox_Nama1.PasswordChar = false;
            this.textBox_Nama1.Size = new System.Drawing.Size(167, 31);
            this.textBox_Nama1.TabIndex = 10;
            this.textBox_Nama1.Texts = "";
            this.textBox_Nama1.UnderlinedStyle = false;
=======
            // linkLabel_Kembali
            // 
            this.linkLabel_Kembali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel_Kembali.AutoSize = true;
            this.linkLabel_Kembali.Location = new System.Drawing.Point(12, 415);
            this.linkLabel_Kembali.Name = "linkLabel_Kembali";
            this.linkLabel_Kembali.Size = new System.Drawing.Size(44, 13);
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
            this.dataGridView1.Location = new System.Drawing.Point(15, 68);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(565, 298);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label_error
            // 
            this.label_error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(301, 430);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(56, 13);
            this.label_error.TabIndex = 15;
            this.label_error.Text = "label_error";
            this.label_error.Click += new System.EventHandler(this.label4_Click_1);
>>>>>>> refs/remotes/origin/master
            // 
            // Konfirmasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBox_Nama1);
            this.Controls.Add(this.textBox_Bayar1);
=======
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linkLabel_Kembali);
>>>>>>> refs/remotes/origin/master
            this.Controls.Add(this.msgText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Konfirmasi);
            this.Controls.Add(this.button_Edit);
            this.Name = "Konfirmasi";
            this.Size = new System.Drawing.Size(600, 450);
            this.Load += new System.EventHandler(this.Konfirmasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Konfirmasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label msgText;
<<<<<<< HEAD
        private customtextbox textBox_Bayar1;
        private customtextbox textBox_Nama1;
=======
        private System.Windows.Forms.LinkLabel linkLabel_Kembali;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_error;
>>>>>>> refs/remotes/origin/master
    }
}
