using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_Kasir
{
    public partial class customtextbox : UserControl
    {
        //field
        private Color borderColor = Color.MediumSlateBlue;
        private int bordersize = 2;
        private bool underlinedStyle = false;
        private int borderRadius = 0;

        public customtextbox()
        {
            InitializeComponent();
        }

        [Category("Ilham Code TB")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
                this.Invalidate();
            }
            set
            {
                borderColor = value;
            }
        }
        [Category("Ilham Code TB")]
        public int Bordersize
        {
            get
            {
                return bordersize;
            }
            set
            {
                bordersize = value;
                this.Invalidate();
            }
        }
        [Category("Ilham Code TB")]
        public bool UnderlinedStyle
        {
            get
            {
                return underlinedStyle;
            }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }
        [Category("Ilham Code TB")]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }
        [Category("Ilham Code TB")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
        [Category("Ilham Code TB")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }
        [Category("Ilham Code TB")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        [Category("Ilham Code TB")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }
        [Category("Ilham Code TB")]
        public string Texts
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        [Category("Ilham Code TB")]
        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                if (value >= 0)
                    borderRadius = value;
                this.Invalidate();
            }
        }



        //OverridenMethod
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Border
            using (Pen penBorder = new Pen(borderColor, bordersize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (underlinedStyle)
                    graph.DrawLine(penBorder, 0, this.Height = 1, this.Width, this.Height = 1);
                else
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }



        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

}
