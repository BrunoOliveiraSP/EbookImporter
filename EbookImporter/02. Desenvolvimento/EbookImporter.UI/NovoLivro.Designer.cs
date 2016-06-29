namespace EbookImporter.UI
{
    partial class NovoLivro
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
            this.lblNLNome = new System.Windows.Forms.Label();
            this.lblNL = new System.Windows.Forms.Label();
            this.txtNLNome = new System.Windows.Forms.TextBox();
            this.txtNLAutor = new System.Windows.Forms.TextBox();
            this.lblNLAutor = new System.Windows.Forms.Label();
            this.lblNLEditora = new System.Windows.Forms.Label();
            this.txtNLEditora = new System.Windows.Forms.TextBox();
            this.txtNLAno = new System.Windows.Forms.TextBox();
            this.lblNLAno = new System.Windows.Forms.Label();
            this.btnNLCriar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNLNome
            // 
            this.lblNLNome.AutoSize = true;
            this.lblNLNome.Location = new System.Drawing.Point(24, 56);
            this.lblNLNome.Name = "lblNLNome";
            this.lblNLNome.Size = new System.Drawing.Size(38, 13);
            this.lblNLNome.TabIndex = 0;
            this.lblNLNome.Text = "Nome:";
            // 
            // lblNL
            // 
            this.lblNL.AutoSize = true;
            this.lblNL.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNL.Location = new System.Drawing.Point(13, 16);
            this.lblNL.Name = "lblNL";
            this.lblNL.Size = new System.Drawing.Size(164, 21);
            this.lblNL.TabIndex = 1;
            this.lblNL.Text = "Informações básicas";
            // 
            // txtNLNome
            // 
            this.txtNLNome.Location = new System.Drawing.Point(68, 53);
            this.txtNLNome.Name = "txtNLNome";
            this.txtNLNome.Size = new System.Drawing.Size(214, 20);
            this.txtNLNome.TabIndex = 0;
            // 
            // txtNLAutor
            // 
            this.txtNLAutor.Location = new System.Drawing.Point(68, 79);
            this.txtNLAutor.Name = "txtNLAutor";
            this.txtNLAutor.Size = new System.Drawing.Size(214, 20);
            this.txtNLAutor.TabIndex = 1;
            // 
            // lblNLAutor
            // 
            this.lblNLAutor.AutoSize = true;
            this.lblNLAutor.Location = new System.Drawing.Point(24, 82);
            this.lblNLAutor.Name = "lblNLAutor";
            this.lblNLAutor.Size = new System.Drawing.Size(35, 13);
            this.lblNLAutor.TabIndex = 3;
            this.lblNLAutor.Text = "Autor:";
            // 
            // lblNLEditora
            // 
            this.lblNLEditora.AutoSize = true;
            this.lblNLEditora.Location = new System.Drawing.Point(24, 108);
            this.lblNLEditora.Name = "lblNLEditora";
            this.lblNLEditora.Size = new System.Drawing.Size(43, 13);
            this.lblNLEditora.TabIndex = 3;
            this.lblNLEditora.Text = "Editora:";
            // 
            // txtNLEditora
            // 
            this.txtNLEditora.Location = new System.Drawing.Point(68, 105);
            this.txtNLEditora.Name = "txtNLEditora";
            this.txtNLEditora.Size = new System.Drawing.Size(214, 20);
            this.txtNLEditora.TabIndex = 2;
            // 
            // txtNLAno
            // 
            this.txtNLAno.Location = new System.Drawing.Point(68, 131);
            this.txtNLAno.Name = "txtNLAno";
            this.txtNLAno.Size = new System.Drawing.Size(214, 20);
            this.txtNLAno.TabIndex = 3;
            // 
            // lblNLAno
            // 
            this.lblNLAno.AutoSize = true;
            this.lblNLAno.Location = new System.Drawing.Point(24, 134);
            this.lblNLAno.Name = "lblNLAno";
            this.lblNLAno.Size = new System.Drawing.Size(29, 13);
            this.lblNLAno.TabIndex = 5;
            this.lblNLAno.Text = "Ano:";
            // 
            // btnNLCriar
            // 
            this.btnNLCriar.Location = new System.Drawing.Point(119, 172);
            this.btnNLCriar.Name = "btnNLCriar";
            this.btnNLCriar.Size = new System.Drawing.Size(75, 23);
            this.btnNLCriar.TabIndex = 4;
            this.btnNLCriar.Text = "Criar";
            this.btnNLCriar.UseVisualStyleBackColor = true;
            this.btnNLCriar.Click += new System.EventHandler(this.btnNLCriar_Click);
            // 
            // NovoLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 213);
            this.Controls.Add(this.btnNLCriar);
            this.Controls.Add(this.txtNLAno);
            this.Controls.Add(this.lblNLAno);
            this.Controls.Add(this.txtNLEditora);
            this.Controls.Add(this.lblNLEditora);
            this.Controls.Add(this.txtNLAutor);
            this.Controls.Add(this.lblNLAutor);
            this.Controls.Add(this.txtNLNome);
            this.Controls.Add(this.lblNL);
            this.Controls.Add(this.lblNLNome);
            this.Name = "NovoLivro";
            this.Text = "Novo livro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNLNome;
        private System.Windows.Forms.Label lblNL;
        private System.Windows.Forms.TextBox txtNLNome;
        private System.Windows.Forms.TextBox txtNLAutor;
        private System.Windows.Forms.Label lblNLAutor;
        private System.Windows.Forms.Label lblNLEditora;
        private System.Windows.Forms.TextBox txtNLEditora;
        private System.Windows.Forms.TextBox txtNLAno;
        private System.Windows.Forms.Label lblNLAno;
        private System.Windows.Forms.Button btnNLCriar;
    }
}