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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Konfirmasi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msgText = new System.Windows.Forms.Label();
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
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(75, 34);
            this.button_Edit.TabIndex = 1;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = false;
            // 
            // button_Konfirmasi
            // 
            this.button_Konfirmasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.button_Konfirmasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Konfirmasi.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.button_Konfirmasi.ForeColor = System.Drawing.Color.White;
            this.button_Konfirmasi.Location = new System.Drawing.Point(505, 397);
            this.button_Konfirmasi.Name = "button_Konfirmasi";
            this.button_Konfirmasi.Size = new System.Drawing.Size(75, 31);
            this.button_Konfirmasi.TabIndex = 2;
            this.button_Konfirmasi.Text = "Konfirmasi";
            this.button_Konfirmasi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Konfirmasi.UseVisualStyleBackColor = false;
            this.button_Konfirmasi.Click += new System.EventHandler(this.button_Konfirmasi_Click);
            // 
            // label1
            // 
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
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.label2.Location = new System.Drawing.Point(79, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bayar : ";
            // 
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
            // 
            // Konfirmasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBox_Nama1);
            this.Controls.Add(this.textBox_Bayar1);
            this.Controls.Add(this.msgText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Konfirmasi);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Konfirmasi";
            this.Size = new System.Drawing.Size(600, 450);
            this.Load += new System.EventHandler(this.Konfirmasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Konfirmasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label msgText;
        private customtextbox textBox_Bayar1;
        private customtextbox textBox_Nama1;
    }
}
