﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoar
{
    public partial class QL_SanPham : Form
    {
        public QL_SanPham()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Them_sua them = new Them_sua();
            them.ShowDialog();
        }

        private void tbx_search_TextChanged(object sender, EventArgs e)
        {
            tbx_search.Text = "";
        }
    }
}
