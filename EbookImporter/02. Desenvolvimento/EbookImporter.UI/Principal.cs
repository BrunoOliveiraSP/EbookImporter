using System;
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
    public partial class Principal : Form
    {
        string file;
        public Livro livro = new Livro();

        public Principal()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            file = openFileDialog1.FileName;

            Uri url = new Uri(file);
            webBrowser.Url = url;

            lblCaminho.Text = file;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoLivro novoLivro = new NovoLivro();
            novoLivro.Show();
        }

        private void btnCapConfirmar_Click(object sender, EventArgs e)
        {
            label1.Text = livro.Nome;
        }
    }
}
