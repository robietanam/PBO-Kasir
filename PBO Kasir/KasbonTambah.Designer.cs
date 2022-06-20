namespace PBO_Kasir
{
    partial class KasbonTambah
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
            this.button_TambahBon = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customtextbox1 = new PBO_Kasir.customtextbox();
            this.textBox_NamaBon1 = new PBO_Kasir.customtextbox();
            this.dateTimePicker_TanggalHutang1 = new PBO_Kasir.DatePackerCustom();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker_TenggatHutang1 = new PBO_Kasir.DatePackerCustom();
=======
            this.dateTimePicker_TanggalHutang = new System.Windows.Forms.DateTimePicker();
            this.textBox_AtasNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_TenggatHutang = new System.Windows.Forms.DateTimePicker();
            this.label_error = new System.Windows.Forms.Label();
            this.textBox_Jumlah = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Kode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
>>>>>>> refs/remotes/origin/master
            this.SuspendLayout();
            // 
            // button_TambahBon
            // 
<<<<<<< HEAD
            this.button_TambahBon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_TambahBon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.button_TambahBon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TambahBon.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.button_TambahBon.ForeColor = System.Drawing.SystemColors.Control;
            this.button_TambahBon.Location = new System.Drawing.Point(238, 375);
=======
            this.button_TambahBon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_TambahBon.Location = new System.Drawing.Point(247, 266);
>>>>>>> refs/remotes/origin/master
            this.button_TambahBon.Name = "button_TambahBon";
            this.button_TambahBon.Size = new System.Drawing.Size(110, 38);
            this.button_TambahBon.TabIndex = 2;
            this.button_TambahBon.Text = "Tambah";
            this.button_TambahBon.UseVisualStyleBackColor = false;
            this.button_TambahBon.Click += new System.EventHandler(this.button_TambahBon_Click);
            // 
<<<<<<< HEAD
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.checkBox1.Location = new System.Drawing.Point(350, 134);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 29);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Tenggat Hutang";
            this.checkBox1.UseVisualStyleBackColor = true;
=======
            // dateTimePicker_TanggalHutang
            // 
            this.dateTimePicker_TanggalHutang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_TanggalHutang.Location = new System.Drawing.Point(323, 125);
            this.dateTimePicker_TanggalHutang.Name = "dateTimePicker_TanggalHutang";
            this.dateTimePicker_TanggalHutang.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker_TanggalHutang.TabIndex = 3;
            // 
            // textBox_AtasNama
            // 
            this.textBox_AtasNama.Location = new System.Drawing.Point(97, 174);
            this.textBox_AtasNama.Name = "textBox_AtasNama";
            this.textBox_AtasNama.Size = new System.Drawing.Size(138, 20);
            this.textBox_AtasNama.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Atas Nama";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tanggal Hutang";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tenggat Hutang";
            // 
            // dateTimePicker_TenggatHutang
            // 
            this.dateTimePicker_TenggatHutang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_TenggatHutang.Location = new System.Drawing.Point(323, 197);
            this.dateTimePicker_TenggatHutang.Name = "dateTimePicker_TenggatHutang";
            this.dateTimePicker_TenggatHutang.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker_TenggatHutang.TabIndex = 7;
            this.dateTimePicker_TenggatHutang.ValueChanged += new System.EventHandler(this.dateTimePicker_TenggatHutang_ValueChanged);
            // 
            // label_error
            // 
            this.label_error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(94, 304);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(56, 13);
            this.label_error.TabIndex = 11;
            this.label_error.Text = "label_error";
            // 
            // textBox_Jumlah
            // 
            this.textBox_Jumlah.Location = new System.Drawing.Point(97, 218);
            this.textBox_Jumlah.Name = "textBox_Jumlah";
            this.textBox_Jumlah.Size = new System.Drawing.Size(138, 20);
            this.textBox_Jumlah.TabIndex = 13;
            this.textBox_Jumlah.TextChanged += new System.EventHandler(this.textBox_Jumlah_TextChanged);
            this.textBox_Jumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_HargaBarang_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Jumlah";
            // 
            // textBox_Kode
            // 
            this.textBox_Kode.Location = new System.Drawing.Point(97, 86);
            this.textBox_Kode.Name = "textBox_Kode";
            this.textBox_Kode.Size = new System.Drawing.Size(138, 20);
            this.textBox_Kode.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kode Bon";
>>>>>>> refs/remotes/origin/master
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.label5.Location = new System.Drawing.Point(39, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nama Bon";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.label6.Location = new System.Drawing.Point(39, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Atas Nama";
            // 
            // customtextbox1
            // 
            this.customtextbox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customtextbox1.AutoSize = true;
            this.customtextbox1.BackColor = System.Drawing.SystemColors.Window;
            this.customtextbox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.customtextbox1.BorderRadius = 0;
            this.customtextbox1.Bordersize = 2;
            this.customtextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customtextbox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.customtextbox1.Location = new System.Drawing.Point(42, 165);
            this.customtextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.customtextbox1.Multiline = false;
            this.customtextbox1.Name = "customtextbox1";
            this.customtextbox1.Padding = new System.Windows.Forms.Padding(7);
            this.customtextbox1.PasswordChar = false;
            this.customtextbox1.Size = new System.Drawing.Size(199, 31);
            this.customtextbox1.TabIndex = 12;
            this.customtextbox1.Texts = "";
            this.customtextbox1.UnderlinedStyle = false;
            // 
            // textBox_NamaBon1
            // 
            this.textBox_NamaBon1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_NamaBon1.AutoSize = true;
            this.textBox_NamaBon1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_NamaBon1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.textBox_NamaBon1.BorderRadius = 0;
            this.textBox_NamaBon1.Bordersize = 2;
            this.textBox_NamaBon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NamaBon1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_NamaBon1.Location = new System.Drawing.Point(42, 78);
            this.textBox_NamaBon1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_NamaBon1.Multiline = false;
            this.textBox_NamaBon1.Name = "textBox_NamaBon1";
            this.textBox_NamaBon1.Padding = new System.Windows.Forms.Padding(7);
            this.textBox_NamaBon1.PasswordChar = false;
            this.textBox_NamaBon1.Size = new System.Drawing.Size(199, 31);
            this.textBox_NamaBon1.TabIndex = 10;
            this.textBox_NamaBon1.Texts = "";
            this.textBox_NamaBon1.UnderlinedStyle = false;
            this.textBox_NamaBon1.Load += new System.EventHandler(this.textBox_NamaBon1_Load);
            // 
            // dateTimePicker_TanggalHutang1
            // 
            this.dateTimePicker_TanggalHutang1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_TanggalHutang1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.dateTimePicker_TanggalHutang1.BorderSize = 2;
            this.dateTimePicker_TanggalHutang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateTimePicker_TanggalHutang1.Location = new System.Drawing.Point(350, 74);
            this.dateTimePicker_TanggalHutang1.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTimePicker_TanggalHutang1.Name = "dateTimePicker_TanggalHutang1";
            this.dateTimePicker_TanggalHutang1.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker_TanggalHutang1.SkinColor = System.Drawing.Color.Transparent;
            this.dateTimePicker_TanggalHutang1.TabIndex = 14;
            this.dateTimePicker_TanggalHutang1.TextColor = System.Drawing.Color.Black;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.label7.Location = new System.Drawing.Point(345, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tanggal Hutang";
            // 
            // dateTimePicker_TenggatHutang1
            // 
            this.dateTimePicker_TenggatHutang1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_TenggatHutang1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.dateTimePicker_TenggatHutang1.BorderSize = 2;
            this.dateTimePicker_TenggatHutang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateTimePicker_TenggatHutang1.Location = new System.Drawing.Point(350, 161);
            this.dateTimePicker_TenggatHutang1.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTimePicker_TenggatHutang1.Name = "dateTimePicker_TenggatHutang1";
            this.dateTimePicker_TenggatHutang1.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker_TenggatHutang1.SkinColor = System.Drawing.Color.Transparent;
            this.dateTimePicker_TenggatHutang1.TabIndex = 16;
            this.dateTimePicker_TenggatHutang1.TextColor = System.Drawing.Color.Black;
            // 
            // KasbonTambah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dateTimePicker_TenggatHutang1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker_TanggalHutang1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customtextbox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_NamaBon1);
            this.Controls.Add(this.checkBox1);
=======
            this.Controls.Add(this.textBox_Kode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Jumlah);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker_TenggatHutang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_AtasNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_TanggalHutang);
>>>>>>> refs/remotes/origin/master
            this.Controls.Add(this.button_TambahBon);
            this.Name = "KasbonTambah";
            this.Size = new System.Drawing.Size(600, 450);
            this.Load += new System.EventHandler(this.KasbonTambah_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_TambahBon;
<<<<<<< HEAD
        private System.Windows.Forms.CheckBox checkBox1;
        private customtextbox textBox_NamaBon1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private customtextbox customtextbox1;
        private DatePackerCustom dateTimePicker_TanggalHutang1;
        private System.Windows.Forms.Label label7;
        private DatePackerCustom dateTimePicker_TenggatHutang1;
=======
        private System.Windows.Forms.DateTimePicker dateTimePicker_TanggalHutang;
        private System.Windows.Forms.TextBox textBox_AtasNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TenggatHutang;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.TextBox textBox_Jumlah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Kode;
        private System.Windows.Forms.Label label6;
>>>>>>> refs/remotes/origin/master
    }
}
