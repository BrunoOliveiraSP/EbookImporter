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
        int capCounter = 1;

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
                lblNovo.Text = String.Format("{0}. ({1}). \"{2}\". {3}", livro.Autor.ToUpper(), livro.Ano, livro.Nome, livro.Editora);

                groupBoxCadastro.Enabled = true;

                livro.Capitulos = new List<Capitulo>();
            }
        }

        private void btnCapConfirmar_Click(object sender, EventArgs e)
        {
            Capitulo cap = new Capitulo();
            cap.Numero = capCounter;
            cap.Nome = txtCapNome.Text;
            cap.Pag = int.Parse(txtCapPag.Text);
            //cap.Texto = 

            capCounter++;
            lblCapNum.Text = capCounter.ToString();

            livro.Capitulos.Add(cap);

            //

            dgv1.DataSource = livro.Capitulos.ToList();
        }
    }
}
