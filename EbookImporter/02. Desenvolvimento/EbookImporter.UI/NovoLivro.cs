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
    public partial class NovoLivro : Form
    {
        Principal main = new Principal();

        public NovoLivro()
        {
            InitializeComponent();
        }

        private void btnNLCriar_Click(object sender, EventArgs e)
        {
            main.livro.Nome = txtNLNome.Text;
            main.livro.Autor = txtNLAutor.Text;
            main.livro.Editora = txtNLEditora.Text;
            main.livro.Ano = int.Parse(txtNLAno.Text);
        }
    }
}
