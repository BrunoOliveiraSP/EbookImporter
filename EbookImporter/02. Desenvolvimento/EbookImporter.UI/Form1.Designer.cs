namespace EbookImporter.UI
{
    partial class Form1
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblTxtCaminho = new System.Windows.Forms.Label();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(489, 41);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(466, 483);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // groupBoxCadastro
            // 
            this.groupBoxCadastro.Controls.Add(this.btnAbrir);
            this.groupBoxCadastro.Controls.Add(this.lblCaminho);
            this.groupBoxCadastro.Controls.Add(this.lblTxtCaminho);
            this.groupBoxCadastro.Location = new System.Drawing.Point(13, 41);
            this.groupBoxCadastro.Name = "groupBoxCadastro";
            this.groupBoxCadastro.Size = new System.Drawing.Size(470, 483);
            this.groupBoxCadastro.TabIndex = 1;
            this.groupBoxCadastro.TabStop = false;
            this.groupBoxCadastro.Text = "Cadastro";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(13, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo Livro";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // lblTxtCaminho
            // 
            this.lblTxtCaminho.AutoSize = true;
            this.lblTxtCaminho.Location = new System.Drawing.Point(31, 47);
            this.lblTxtCaminho.Name = "lblTxtCaminho";
            this.lblTxtCaminho.Size = new System.Drawing.Size(90, 13);
            this.lblTxtCaminho.TabIndex = 0;
            this.lblTxtCaminho.Text = "Caminho do PDF:";
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(127, 47);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(16, 13);
            this.lblCaminho.TabIndex = 1;
            this.lblCaminho.Text = "...";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(34, 68);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 2;
            this.btnAbrir.Text = "Abrir PDF";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Filter = "PDF|*.pdf";
            this.ofd.ReadOnlyChecked = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 536);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.groupBoxCadastro);
            this.Controls.Add(this.webBrowser);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.groupBoxCadastro.ResumeLayout(false);
            this.groupBoxCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.GroupBox groupBoxCadastro;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.Label lblTxtCaminho;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

