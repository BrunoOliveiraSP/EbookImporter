namespace EbookImporter.UI
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.groupBoxCadastro = new System.Windows.Forms.GroupBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCapNum = new System.Windows.Forms.Label();
            this.lblCap = new System.Windows.Forms.Label();
            this.lblCopiar = new System.Windows.Forms.Label();
            this.lblCapPaginaFinal = new System.Windows.Forms.Label();
            this.lblCapPaginaInicial = new System.Windows.Forms.Label();
            this.txtCapPaginaFinal = new System.Windows.Forms.TextBox();
            this.txtCapPaginaInicial = new System.Windows.Forms.TextBox();
            this.lblCapNome = new System.Windows.Forms.Label();
            this.txtCapNome = new System.Windows.Forms.TextBox();
            this.btnCapConfirmar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.lblTxtCaminho = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblNovo = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(489, 47);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(466, 477);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // groupBoxCadastro
            // 
            this.groupBoxCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxCadastro.Controls.Add(this.btnFinalizar);
            this.groupBoxCadastro.Controls.Add(this.dataGridView1);
            this.groupBoxCadastro.Controls.Add(this.lblCapNum);
            this.groupBoxCadastro.Controls.Add(this.lblCap);
            this.groupBoxCadastro.Controls.Add(this.lblCopiar);
            this.groupBoxCadastro.Controls.Add(this.lblCapPaginaFinal);
            this.groupBoxCadastro.Controls.Add(this.lblCapPaginaInicial);
            this.groupBoxCadastro.Controls.Add(this.txtCapPaginaFinal);
            this.groupBoxCadastro.Controls.Add(this.txtCapPaginaInicial);
            this.groupBoxCadastro.Controls.Add(this.lblCapNome);
            this.groupBoxCadastro.Controls.Add(this.txtCapNome);
            this.groupBoxCadastro.Controls.Add(this.btnCapConfirmar);
            this.groupBoxCadastro.Controls.Add(this.btnAbrir);
            this.groupBoxCadastro.Controls.Add(this.lblCaminho);
            this.groupBoxCadastro.Controls.Add(this.lblTxtCaminho);
            this.groupBoxCadastro.Enabled = false;
            this.groupBoxCadastro.Location = new System.Drawing.Point(13, 41);
            this.groupBoxCadastro.Name = "groupBoxCadastro";
            this.groupBoxCadastro.Size = new System.Drawing.Size(470, 483);
            this.groupBoxCadastro.TabIndex = 1;
            this.groupBoxCadastro.TabStop = false;
            this.groupBoxCadastro.Text = "Cadastro";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(198, 446);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 13;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(424, 168);
            this.dataGridView1.TabIndex = 12;
            // 
            // lblCapNum
            // 
            this.lblCapNum.AutoSize = true;
            this.lblCapNum.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapNum.Location = new System.Drawing.Point(78, 128);
            this.lblCapNum.Name = "lblCapNum";
            this.lblCapNum.Size = new System.Drawing.Size(19, 21);
            this.lblCapNum.TabIndex = 11;
            this.lblCapNum.Text = "1";
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCap.Location = new System.Drawing.Point(16, 129);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(66, 19);
            this.lblCap.TabIndex = 10;
            this.lblCap.Text = "Capítulo";
            // 
            // lblCopiar
            // 
            this.lblCopiar.AutoSize = true;
            this.lblCopiar.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopiar.Location = new System.Drawing.Point(16, 101);
            this.lblCopiar.Name = "lblCopiar";
            this.lblCopiar.Size = new System.Drawing.Size(399, 18);
            this.lblCopiar.TabIndex = 9;
            this.lblCopiar.Text = "Copie as informações do PDF, cole nos campos e confirme";
            // 
            // lblCapPaginaFinal
            // 
            this.lblCapPaginaFinal.AutoSize = true;
            this.lblCapPaginaFinal.Location = new System.Drawing.Point(225, 183);
            this.lblCapPaginaFinal.Name = "lblCapPaginaFinal";
            this.lblCapPaginaFinal.Size = new System.Drawing.Size(120, 13);
            this.lblCapPaginaFinal.TabIndex = 8;
            this.lblCapPaginaFinal.Text = "Última pág. do capítulo:";
            // 
            // lblCapPaginaInicial
            // 
            this.lblCapPaginaInicial.AutoSize = true;
            this.lblCapPaginaInicial.Location = new System.Drawing.Point(16, 183);
            this.lblCapPaginaInicial.Name = "lblCapPaginaInicial";
            this.lblCapPaginaInicial.Size = new System.Drawing.Size(101, 13);
            this.lblCapPaginaInicial.TabIndex = 8;
            this.lblCapPaginaInicial.Text = "1ª pág. do capítulo:";
            // 
            // txtCapPaginaFinal
            // 
            this.txtCapPaginaFinal.Enabled = false;
            this.txtCapPaginaFinal.Location = new System.Drawing.Point(346, 180);
            this.txtCapPaginaFinal.Name = "txtCapPaginaFinal";
            this.txtCapPaginaFinal.Size = new System.Drawing.Size(98, 20);
            this.txtCapPaginaFinal.TabIndex = 7;
            this.txtCapPaginaFinal.Text = "40";
            // 
            // txtCapPaginaInicial
            // 
            this.txtCapPaginaInicial.Enabled = false;
            this.txtCapPaginaInicial.Location = new System.Drawing.Point(118, 180);
            this.txtCapPaginaInicial.Name = "txtCapPaginaInicial";
            this.txtCapPaginaInicial.Size = new System.Drawing.Size(98, 20);
            this.txtCapPaginaInicial.TabIndex = 7;
            this.txtCapPaginaInicial.Text = "17";
            // 
            // lblCapNome
            // 
            this.lblCapNome.AutoSize = true;
            this.lblCapNome.Location = new System.Drawing.Point(16, 157);
            this.lblCapNome.Name = "lblCapNome";
            this.lblCapNome.Size = new System.Drawing.Size(95, 13);
            this.lblCapNome.TabIndex = 5;
            this.lblCapNome.Text = "Nome do capítulo:";
            // 
            // txtCapNome
            // 
            this.txtCapNome.Enabled = false;
            this.txtCapNome.Location = new System.Drawing.Point(118, 154);
            this.txtCapNome.Name = "txtCapNome";
            this.txtCapNome.Size = new System.Drawing.Size(326, 20);
            this.txtCapNome.TabIndex = 4;
            this.txtCapNome.Text = "Introdução";
            // 
            // btnCapConfirmar
            // 
            this.btnCapConfirmar.Enabled = false;
            this.btnCapConfirmar.Location = new System.Drawing.Point(369, 216);
            this.btnCapConfirmar.Name = "btnCapConfirmar";
            this.btnCapConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnCapConfirmar.TabIndex = 3;
            this.btnCapConfirmar.Text = "Confirmar";
            this.btnCapConfirmar.UseVisualStyleBackColor = true;
            this.btnCapConfirmar.Click += new System.EventHandler(this.btnCapConfirmar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(19, 52);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 2;
            this.btnAbrir.Text = "Abrir PDF";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(106, 31);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(16, 13);
            this.lblCaminho.TabIndex = 1;
            this.lblCaminho.Text = "...";
            // 
            // lblTxtCaminho
            // 
            this.lblTxtCaminho.AutoSize = true;
            this.lblTxtCaminho.Location = new System.Drawing.Point(16, 31);
            this.lblTxtCaminho.Name = "lblTxtCaminho";
            this.lblTxtCaminho.Size = new System.Drawing.Size(90, 13);
            this.lblTxtCaminho.TabIndex = 0;
            this.lblTxtCaminho.Text = "Caminho do PDF:";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(13, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo livro";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PDF|*.pdf";
            this.openFileDialog1.ReadOnlyChecked = true;
            // 
            // lblNovo
            // 
            this.lblNovo.AutoSize = true;
            this.lblNovo.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovo.Location = new System.Drawing.Point(92, 13);
            this.lblNovo.Name = "lblNovo";
            this.lblNovo.Size = new System.Drawing.Size(14, 18);
            this.lblNovo.TabIndex = 3;
            this.lblNovo.Text = "-";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "json";
            this.saveFileDialog1.Filter = "JSON|*.json|Documento de texto|*.txt|Todos os documentos|*.*";
            this.saveFileDialog1.Title = "Salvar";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 536);
            this.Controls.Add(this.lblNovo);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.groupBoxCadastro);
            this.Controls.Add(this.webBrowser);
            this.Name = "Principal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Importador de Ebook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxCadastro.ResumeLayout(false);
            this.groupBoxCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.GroupBox groupBoxCadastro;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.Label lblTxtCaminho;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblCapPaginaInicial;
        private System.Windows.Forms.TextBox txtCapPaginaInicial;
        private System.Windows.Forms.Label lblCapNome;
        private System.Windows.Forms.TextBox txtCapNome;
        private System.Windows.Forms.Button btnCapConfirmar;
        private System.Windows.Forms.Label lblCopiar;
        private System.Windows.Forms.Label lblCap;
        private System.Windows.Forms.Label lblNovo;
        private System.Windows.Forms.Label lblCapNum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCapPaginaFinal;
        private System.Windows.Forms.TextBox txtCapPaginaFinal;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

