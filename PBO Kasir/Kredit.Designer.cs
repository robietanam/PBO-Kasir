namespace PBO_Kasir
{
    partial class Kredit
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PBO_Kasir.Properties.Resources.Other_07_1;
            this.pictureBox1.Location = new System.Drawing.Point(152, 34);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(1065, 1032);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Poppins Medium", 15F);
            this.Label1.Location = new System.Drawing.Point(146, 327);
            this.Label1.MaximumSize = new System.Drawing.Size(861, 213);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(289, 72);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Selamat Datang Di Aplikasi\r\nKasir Pintar\r\n";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Kredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(1920, 1090);
            this.Name = "Kredit";
            this.Size = new System.Drawing.Size(600, 444);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label1;
    }
}
