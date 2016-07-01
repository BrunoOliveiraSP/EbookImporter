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

            livroNovo.Nome = tentar(" nome", txtNLNome.Text);
            
            livroNovo.Autor = tentar(" autor", txtNLAutor.Text);
            
            livroNovo.Editora = tentar("a editora", txtNLEditora.Text);

            try
            {
                livroNovo.Ano = int.Parse(txtNLAno.Text);
            }
            catch
            {
                MessageBox.Show("Digite um ano válido");

                ex = true;
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

                if(texto == "")
                {
                    MessageBox.Show(String.Format("Digite um{0}", tipo));

                    ex = true;
                }
            }
            catch(Exception)
            {
                ex = true;

                if (tipo == "Editora")
                {
                    MessageBox.Show("Digite uma Editora válida");
                }

                MessageBox.Show(String.Format("Digite um{0} válido", tipo));
            }

            return texto;
        }
    }
}
