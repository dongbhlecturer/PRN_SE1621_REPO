﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN_SE1621_WinFormsApp
{
    public partial class FrmMainApp : Form
    {
        public FrmMainApp()
        {
            InitializeComponent();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1. Khởi tạo đối tượng FrmAddProduct
            FrmAddProduct p = new FrmAddProduct();
            p.MdiParent = this;
            //2. Show
            p.Show();
        }
    }
}
