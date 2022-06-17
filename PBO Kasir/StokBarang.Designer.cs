namespace PBO_Kasir
{
    partial class StokBarang
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
            this.labe1 = new System.Windows.Forms.Label();
            this.textBox_NamaBarang = new System.Windows.Forms.TextBox();
            this.textBox_HargaDasar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_HargaBarang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Kode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Stok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Kategori = new System.Windows.Forms.ComboBox();
            this.button_tambahKategori = new System.Windows.Forms.Button();
            this.button_simpanBarang = new System.Windows.Forms.Button();
            this.label_kode = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxcustom1 = new PBO_Kasir.comboBoxcustom();
            this.textBox_Stok1 = new PBO_Kasir.customtextbox();
            this.textBox_Kode1 = new PBO_Kasir.customtextbox();
            this.textBox_HargaDasar1 = new PBO_Kasir.customtextbox();
            this.textBox_HargaBarang1 = new PBO_Kasir.customtextbox();
            this.textBox_NamaBarang1 = new PBO_Kasir.customtextbox();
            this.SuspendLayout();
            // 
            // labe1
            // 
            this.labe1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labe1.AutoSize = true;
            this.labe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labe1.Location = new System.Drawing.Point(19, 407);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(95, 17);
            this.labe1.TabIndex = 0;
            this.labe1.Text = "Nama Barang";
            // 
            // textBox_NamaBarang
            // 
            this.textBox_NamaBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_NamaBarang.Location = new System.Drawing.Point(19, 427);
            this.textBox_NamaBarang.Name = "textBox_NamaBarang";
            this.textBox_NamaBarang.Size = new System.Drawing.Size(121, 20);
            this.textBox_NamaBarang.TabIndex = 1;
            this.textBox_NamaBarang.TextChanged += new System.EventHandler(this.textBox_NamaBarang_TextChanged);
            // 
            // textBox_HargaDasar
            // 
            this.textBox_HargaDasar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_HargaDasar.Location = new System.Drawing.Point(23, 377);
            this.textBox_HargaDasar.Name = "textBox_HargaDasar";
            this.textBox_HargaDasar.Size = new System.Drawing.Size(121, 20);
            this.textBox_HargaDasar.TabIndex = 3;
            this.textBox_HargaDasar.TextChanged += new System.EventHandler(this.textBox_HargaDasar_TextChanged);
            this.textBox_HargaDasar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_HargaDasar_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(21, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Harga Dasar";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(412, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategori (Opsional)";
            // 
            // textBox_HargaBarang
            // 
            this.textBox_HargaBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_HargaBarang.Location = new System.Drawing.Point(414, 320);
            this.textBox_HargaBarang.Name = "textBox_HargaBarang";
            this.textBox_HargaBarang.Size = new System.Drawing.Size(121, 20);
            this.textBox_HargaBarang.TabIndex = 9;
            this.textBox_HargaBarang.TextChanged += new System.EventHandler(this.textBox_HargaBarang_TextChanged);
            this.textBox_HargaBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_HargaBarang_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(412, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Harga Barang";
            // 
            // textBox_Kode
            // 
            this.textBox_Kode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Kode.Location = new System.Drawing.Point(147, 355);
            this.textBox_Kode.Name = "textBox_Kode";
            this.textBox_Kode.Size = new System.Drawing.Size(121, 20);
            this.textBox_Kode.TabIndex = 11;
            this.textBox_Kode.TextChanged += new System.EventHandler(this.textBox_Kode_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(145, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kode";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_Stok
            // 
            this.textBox_Stok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Stok.Location = new System.Drawing.Point(147, 417);
            this.textBox_Stok.Name = "textBox_Stok";
            this.textBox_Stok.Size = new System.Drawing.Size(121, 20);
            this.textBox_Stok.TabIndex = 13;
            this.textBox_Stok.TextChanged += new System.EventHandler(this.textBox_Stok_TextChanged);
            this.textBox_Stok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Stok_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(145, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Stok";
            // 
            // comboBox_Kategori
            // 
            this.comboBox_Kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Kategori.FormattingEnabled = true;
            this.comboBox_Kategori.Location = new System.Drawing.Point(414, 390);
            this.comboBox_Kategori.Name = "comboBox_Kategori";
            this.comboBox_Kategori.Size = new System.Drawing.Size(129, 21);
            this.comboBox_Kategori.TabIndex = 16;
            this.comboBox_Kategori.SelectedIndexChanged += new System.EventHandler(this.comboBox_Kategori_SelectedIndexChanged);
            // 
            // button_tambahKategori
            // 
            this.button_tambahKategori.Location = new System.Drawing.Point(568, 390);
            this.button_tambahKategori.Name = "button_tambahKategori";
            this.button_tambahKategori.Size = new System.Drawing.Size(25, 23);
            this.button_tambahKategori.TabIndex = 17;
            this.button_tambahKategori.Text = "+";
            this.button_tambahKategori.UseVisualStyleBackColor = true;
            this.button_tambahKategori.Click += new System.EventHandler(this.button_tambahKategori_Click);
            // 
            // button_simpanBarang
            // 
            this.button_simpanBarang.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_simpanBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.button_simpanBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_simpanBarang.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.button_simpanBarang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_simpanBarang.Location = new System.Drawing.Point(263, 347);
            this.button_simpanBarang.Name = "button_simpanBarang";
            this.button_simpanBarang.Size = new System.Drawing.Size(110, 38);
            this.button_simpanBarang.TabIndex = 18;
            this.button_simpanBarang.Text = "SIMPAN";
            this.button_simpanBarang.UseVisualStyleBackColor = false;
            this.button_simpanBarang.Click += new System.EventHandler(this.button_simpanBarang_Click);
            // 
            // label_kode
            // 
            this.label_kode.AutoSize = true;
            this.label_kode.Location = new System.Drawing.Point(192, 339);
            this.label_kode.Name = "label_kode";
            this.label_kode.Size = new System.Drawing.Size(101, 13);
            this.label_kode.TabIndex = 19;
            this.label_kode.Text = "Kode error message";
            // 
            // label_error
            // 
            this.label_error.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_error.Location = new System.Drawing.Point(272, 390);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(93, 17);
            this.label_error.TabIndex = 20;
            this.label_error.Text = "error mesage";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.label6.Location = new System.Drawing.Point(42, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nama Barang";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.label7.Location = new System.Drawing.Point(42, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Harga Barang";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.label8.Location = new System.Drawing.Point(42, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Harga Dasar";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.label9.Location = new System.Drawing.Point(369, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Kode";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.label10.Location = new System.Drawing.Point(369, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "Stok";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.label11.Location = new System.Drawing.Point(369, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 25);
            this.label11.TabIndex = 32;
            this.label11.Text = "Kategori (Opsional)";
            // 
            // comboBoxcustom1
            // 
            this.comboBoxcustom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.comboBoxcustom1.BorderColor = System.Drawing.Color.Transparent;
            this.comboBoxcustom1.BorderSize = 1;
            this.comboBoxcustom1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxcustom1.Font = new System.Drawing.Font("Poppins", 10F);
            this.comboBoxcustom1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxcustom1.IconColor = System.Drawing.Color.Lavender;
            this.comboBoxcustom1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxcustom1.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxcustom1.Location = new System.Drawing.Point(374, 236);
            this.comboBoxcustom1.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxcustom1.Name = "comboBoxcustom1";
            this.comboBoxcustom1.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxcustom1.Size = new System.Drawing.Size(200, 30);
            this.comboBoxcustom1.TabIndex = 31;
            this.comboBoxcustom1.Texts = "";
            this.comboBoxcustom1.ValueMember = "";
            this.comboBoxcustom1.OnSelectedIndexChanged += new System.EventHandler(this.comboBoxcustom1_OnSelectedIndexChanged);
            // 
            // textBox_Stok1
            // 
            this.textBox_Stok1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Stok1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Stok1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.textBox_Stok1.BorderRadius = 0;
            this.textBox_Stok1.Bordersize = 2;
            this.textBox_Stok1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Stok1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Stok1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Stok1.Location = new System.Drawing.Point(374, 149);
            this.textBox_Stok1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Stok1.Multiline = false;
            this.textBox_Stok1.Name = "textBox_Stok1";
            this.textBox_Stok1.Padding = new System.Windows.Forms.Padding(7);
            this.textBox_Stok1.PasswordChar = false;
            this.textBox_Stok1.Size = new System.Drawing.Size(184, 31);
            this.textBox_Stok1.TabIndex = 29;
            this.textBox_Stok1.Texts = "";
            this.textBox_Stok1.UnderlinedStyle = false;
            this.textBox_Stok1.Load += new System.EventHandler(this.textBox_Stok1_Load);
            // 
            // textBox_Kode1
            // 
            this.textBox_Kode1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Kode1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Kode1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.textBox_Kode1.BorderRadius = 0;
            this.textBox_Kode1.Bordersize = 2;
            this.textBox_Kode1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Kode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Kode1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Kode1.Location = new System.Drawing.Point(374, 64);
            this.textBox_Kode1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Kode1.Multiline = false;
            this.textBox_Kode1.Name = "textBox_Kode1";
            this.textBox_Kode1.Padding = new System.Windows.Forms.Padding(7);
            this.textBox_Kode1.PasswordChar = false;
            this.textBox_Kode1.Size = new System.Drawing.Size(184, 31);
            this.textBox_Kode1.TabIndex = 27;
            this.textBox_Kode1.Texts = "";
            this.textBox_Kode1.UnderlinedStyle = false;
            // 
            // textBox_HargaDasar1
            // 
            this.textBox_HargaDasar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_HargaDasar1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_HargaDasar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.textBox_HargaDasar1.BorderRadius = 0;
            this.textBox_HargaDasar1.Bordersize = 2;
            this.textBox_HargaDasar1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_HargaDasar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_HargaDasar1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_HargaDasar1.Location = new System.Drawing.Point(47, 235);
            this.textBox_HargaDasar1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_HargaDasar1.Multiline = false;
            this.textBox_HargaDasar1.Name = "textBox_HargaDasar1";
            this.textBox_HargaDasar1.Padding = new System.Windows.Forms.Padding(7);
            this.textBox_HargaDasar1.PasswordChar = false;
            this.textBox_HargaDasar1.Size = new System.Drawing.Size(184, 31);
            this.textBox_HargaDasar1.TabIndex = 25;
            this.textBox_HargaDasar1.Texts = "";
            this.textBox_HargaDasar1.UnderlinedStyle = false;
            // 
            // textBox_HargaBarang1
            // 
            this.textBox_HargaBarang1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_HargaBarang1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_HargaBarang1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.textBox_HargaBarang1.BorderRadius = 0;
            this.textBox_HargaBarang1.Bordersize = 2;
            this.textBox_HargaBarang1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_HargaBarang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_HargaBarang1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_HargaBarang1.Location = new System.Drawing.Point(47, 149);
            this.textBox_HargaBarang1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_HargaBarang1.Multiline = false;
            this.textBox_HargaBarang1.Name = "textBox_HargaBarang1";
            this.textBox_HargaBarang1.Padding = new System.Windows.Forms.Padding(7);
            this.textBox_HargaBarang1.PasswordChar = false;
            this.textBox_HargaBarang1.Size = new System.Drawing.Size(184, 31);
            this.textBox_HargaBarang1.TabIndex = 23;
            this.textBox_HargaBarang1.Texts = "";
            this.textBox_HargaBarang1.UnderlinedStyle = false;
            // 
            // textBox_NamaBarang1
            // 
            this.textBox_NamaBarang1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_NamaBarang1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_NamaBarang1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.textBox_NamaBarang1.BorderRadius = 0;
            this.textBox_NamaBarang1.Bordersize = 2;
            this.textBox_NamaBarang1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_NamaBarang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NamaBarang1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_NamaBarang1.Location = new System.Drawing.Point(47, 64);
            this.textBox_NamaBarang1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_NamaBarang1.Multiline = false;
            this.textBox_NamaBarang1.Name = "textBox_NamaBarang1";
            this.textBox_NamaBarang1.Padding = new System.Windows.Forms.Padding(7);
            this.textBox_NamaBarang1.PasswordChar = false;
            this.textBox_NamaBarang1.Size = new System.Drawing.Size(184, 31);
            this.textBox_NamaBarang1.TabIndex = 21;
            this.textBox_NamaBarang1.Texts = "";
            this.textBox_NamaBarang1.UnderlinedStyle = false;
            this.textBox_NamaBarang1.Load += new System.EventHandler(this.textBox_NamaBarang1_Load);
            // 
            // StokBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxcustom1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_Stok1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_Kode1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_HargaDasar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_HargaBarang1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_NamaBarang1);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.label_kode);
            this.Controls.Add(this.button_simpanBarang);
            this.Controls.Add(this.button_tambahKategori);
            this.Controls.Add(this.comboBox_Kategori);
            this.Controls.Add(this.textBox_Stok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Kode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_HargaBarang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_HargaDasar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_NamaBarang);
            this.Controls.Add(this.labe1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "StokBarang";
            this.Size = new System.Drawing.Size(600, 450);
            this.Load += new System.EventHandler(this.StokBarang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labe1;
        private System.Windows.Forms.TextBox textBox_NamaBarang;
        private System.Windows.Forms.TextBox textBox_HargaDasar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_HargaBarang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Kode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Stok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Kategori;
        private System.Windows.Forms.Button button_tambahKategori;
        private System.Windows.Forms.Button button_simpanBarang;
        private System.Windows.Forms.Label label_kode;
        private System.Windows.Forms.Label label_error;
        private customtextbox textBox_NamaBarang1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private customtextbox textBox_HargaBarang1;
        private System.Windows.Forms.Label label8;
        private customtextbox textBox_HargaDasar1;
        private System.Windows.Forms.Label label9;
        private customtextbox textBox_Kode1;
        private System.Windows.Forms.Label label10;
        private customtextbox textBox_Stok1;
        private comboBoxcustom comboBoxcustom1;
        private System.Windows.Forms.Label label11;
    }
}
