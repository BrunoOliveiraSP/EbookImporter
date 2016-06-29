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
        public NovoLivro()
        {
            InitializeComponent();
        }
        
        public Livro livroNovo = new Livro();
        bool ex = false;

        private void btnNLCriar_Click(object sender, EventArgs e)
        {
            ex = false;

            livroNovo.Nome = tentar("Nome", txtNLNome.Text);
            
            livroNovo.Autor = tentar("Autor", txtNLAutor.Text);
            
            livroNovo.Editora = tentar("Editora", txtNLEditora.Text);

            try
            {
                livroNovo.Ano = int.Parse(txtNLAno.Text);
            }
            catch (Exception)
            {
                ex = true;

                MessageBox.Show("Ano inválido");
            }

            if (ex == false)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private string tentar(string tipo, string texto)
        {
            try
            {
                string s = texto;
            }
            catch(Exception)
            {
                ex = true;

                if (tipo == "Editora")
                {
                    MessageBox.Show("Editora inválida");
                }

                MessageBox.Show(String.Format("{0} inválido", tipo));
            }

            return texto;
        }
    }
}
