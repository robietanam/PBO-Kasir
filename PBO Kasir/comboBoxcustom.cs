using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;


namespace PBO_Kasir
{
    [DefaultEvent("OnSelectedIndexChanged")]
    internal class comboBoxcustom : UserControl
    {
        //Fields
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor = Color.FromArgb(230, 228, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 1;

        private ComboBox cmbList;
        private Label lblText;
        private Button btnIcon;
        //--------------------------------///
        [Category("Cstom Combo Box")]
        public new Color BackColor
        {
            get
            { 
                return backColor; 
            }
            set 
            { 
                backColor = value;
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
            } 
        }
        [Category("Cstom Combo Box")]
        public Color IconColor 
        { 
            get 
            { return iconColor; }
            set
            { 
                iconColor = value;
                btnIcon.Invalidate();
            }    
        }
        [Category("Cstom Combo Box")]
        public Color ListBackColor 
        {
            get
            { return listBackColor; }
            set
            { 
                listBackColor = value; 
                cmbList.BackColor = listBackColor;
            }
        }
        [Category("Cstom Combo Box")]
        public Color ListTextColor 
        {
            get 
            { return listTextColor; }
            set 
            { 
                listTextColor = value; 
                cmbList.ForeColor = listTextColor;
            }
        }
        [Category("Cstom Combo Box")]
        public Color BorderColor 
        {
            get
            { return borderColor; }
            set
            { 
                borderColor = value;
                base.BackColor = borderColor;
            } 
        }
        [Category("Cstom Combo Box")]
        public int BorderSize 
        {
            get
            {
                return borderSize;
            }
            set 
            { 
                borderSize = value;
                this.Padding = new Padding(borderSize);
                AdjustComboBoxDimensions();
            }
        }
        [Category("Cstom Combo Box")]
        public override Color ForeColor 
        {
            get
            {
               return base.ForeColor;
            }
            set
            { 
                base.ForeColor = value; 
                lblText.ForeColor = value;
            }
        }
        [Category("Cstom Combo Box")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                lblText.Font = value;
                cmbList.Font = value;
            }
        }
        [Category("Cstom Combo Box")]
        public string Texts
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }
        [Category("Cstom Combo Box")]
        public ComboBoxStyle DropDownStyle
        {
            get { return cmbList.DropDownStyle; }
            set
            {
                if (cmbList.DropDownStyle != ComboBoxStyle.Simple)
                    cmbList.DropDownStyle = value;
            }
        }
        //--------------------------//
       
        public string ValueMember
        {
            get { return cmbList.ValueMember; }
            set { cmbList.ValueMember = value; }
        }

        public event EventHandler OnSelectedIndexChanged;

        public comboBoxcustom()
        {
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            cmbList.BackColor = listBackColor;
            cmbList.Font = new Font(this.Font.Name, 10F);
            cmbList.ForeColor = listTextColor;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);//Default event
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged);

            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click);//Open dropdown list
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);

            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 10F);

            lblText.Click += new EventHandler(Surface_Click);
            lblText.MouseEnter += new EventHandler(Surface_MouseEnter);
            lblText.MouseLeave += new EventHandler(Surface_MouseLeave);

            this.Controls.Add(lblText);//2
            this.Controls.Add(btnIcon);//1
            this.Controls.Add(cmbList);//0
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);//Border Size
            this.Font = new Font(this.Font.Name, 10F);
            base.BackColor = borderColor; //Border Color
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        private void AdjustComboBoxDimensions()
        {
            cmbList.Width = lblText.Width;
            cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
        }

        //Event Method
        //Default
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            lblText.Text = cmbList.Text; //text akan refresh
        }
        //Label Action
        private void Icon_Paint(object sender, PaintEventArgs e)
        {
           
            int iconWidht = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidht) / 2, (btnIcon.Height - iconHeight) / 2, iconWidht, iconHeight);
            Graphics graph = e.Graphics;
            //Draw arrow down icon
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        ///------//////

        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            //Select combo box
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true;
        }

      

        private void Icon_Click(object sender, EventArgs e)
        {
            cmbList.Select();
            cmbList.DroppedDown = true;
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            lblText.Text = cmbList.Text;
        }

        
    }
}
