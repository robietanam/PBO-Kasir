﻿using System;
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
    public partial class StokBarang : UserControl
    {
        mainForm objParent;
        public StokBarang(mainForm pantek_parent)
        {
            InitializeComponent();
            objParent = pantek_parent;
        }

        private void button_simpanBarang_Click(object sender, EventArgs e)
        {
            objParent.showMenuBarang();
        }
    }
}
