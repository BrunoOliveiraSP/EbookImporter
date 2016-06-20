﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EbookImporter.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Uri url = new Uri(ofd.FileName);

                webBrowser.Url = url;
            }
        }
    }
}
