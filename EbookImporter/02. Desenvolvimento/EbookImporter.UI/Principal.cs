using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Newtonsoft.Json;

namespace EbookImporter.UI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        Livro livro;
        int capCounter;
        string caminhoPdf;
        PdfReader pdfreader;

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();

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

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            caminhoPdf = openFileDialog1.FileName;

            Uri url = new Uri(caminhoPdf);
            webBrowser.Url = url;

            lblCaminho.Text = caminhoPdf;

            txtCapNome.Enabled = true;
            txtCapPaginaInicial.Enabled = true;
            txtCapPaginaFinal.Enabled = true;
            btnCapConfirmar.Enabled = true;

            pdfreader = new PdfReader(caminhoPdf);
        }



        private void btnCapConfirmar_Click(object sender, EventArgs e)
        {
            Capitulo cap = new Capitulo();
            cap.Numero = capCounter;
            cap.Nome = txtCapNome.Text;
            cap.PaginaInicial = int.Parse(txtCapPaginaInicial.Text);
            cap.PaginaFinal = int.Parse(txtCapPaginaFinal.Text);
            cap.Texto = ExtractText(pdfreader, cap.PaginaInicial, cap.PaginaFinal);

            ExtractParagraphs(cap);


            capCounter++;
            lblCapNum.Text = capCounter.ToString();

            livro.Capitulos.Add(cap);

            btnFinalizar.Enabled = true;

            dataGridView1.DataSource = livro.Capitulos.ToList();
        }

        private static String ExtractText(PdfReader reader, int PagInicial, int PagFinal)
        {
            StringBuilder text = new StringBuilder();

            for (int i = PagInicial; i <= PagFinal; i++)
            {
                text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
            }

            return text.ToString();
        }

        void ExtractParagraphs(Capitulo capitulo)
        {
            string QUEBRA_DE_PARAGRAFO = ".\n";
            
            var paragrafos = capitulo.Texto.Split(new string[] { QUEBRA_DE_PARAGRAFO }, 
                                                  StringSplitOptions.RemoveEmptyEntries);

            capitulo.Paragrafos = new List<Paragrafo>();
            for (int i = 0; i < paragrafos.Length; i++)
            {
                capitulo.Paragrafos.Add(
                    new Paragrafo
                    {
                        Orderm = i,
                        Texto = paragrafos[i]
                    });
            }

        }



        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = livro.Nome;
            saveFileDialog1.ShowDialog();

            string savePath = saveFileDialog1.FileName;

            System.IO.File.WriteAllText(savePath, JsonConvert.SerializeObject(livro));
        }
        
        private void LimparCampos()
        {
            livro = new Livro();
            capCounter = 1;
            caminhoPdf = null;
            webBrowser.Url = null;
            livro.Capitulos = null;
            txtCapNome.Enabled = false;
            txtCapPaginaInicial.Enabled = false;
            txtCapPaginaFinal.Enabled = false;
            btnCapConfirmar.Enabled = false;
            groupBoxCadastro.Enabled = false;
            btnFinalizar.Enabled = false;
            lblCaminho.Text = "...";
            lblNovo.Text = "-";

            dataGridView1.DataSource = null;
        }
    }
}
