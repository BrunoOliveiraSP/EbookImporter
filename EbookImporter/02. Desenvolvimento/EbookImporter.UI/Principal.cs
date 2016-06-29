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
        public Principal()
        {
            InitializeComponent();
        }

        Livro livro = new Livro();

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            Uri url = new Uri(openFileDialog1.FileName);
            webBrowser.Url = url;

            lblCaminho.Text = openFileDialog1.FileName;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoLivro novoLivro = new NovoLivro();
            novoLivro.ShowDialog();

            if(novoLivro.DialogResult == DialogResult.OK)
            {
                livro = novoLivro.livroNovo;
                lblNovo.Text = livro.Nome;
                groupBoxCadastro.Enabled = true;
            }
        }

        private void btnCapConfirmar_Click(object sender, EventArgs e)
        {
        }
    }
}
