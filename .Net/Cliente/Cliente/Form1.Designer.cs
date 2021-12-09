namespace Cliente
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.DgvDados = new System.Windows.Forms.DataGridView();
            this.BtnExibir = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.TextId = new System.Windows.Forms.TextBox();
            this.TextNome = new System.Windows.Forms.TextBox();
            this.TextNumero = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(530, 185);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 23;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // DgvDados
            // 
            this.DgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDados.Location = new System.Drawing.Point(72, 237);
            this.DgvDados.Name = "DgvDados";
            this.DgvDados.Size = new System.Drawing.Size(656, 179);
            this.DgvDados.TabIndex = 22;
            // 
            // BtnExibir
            // 
            this.BtnExibir.Location = new System.Drawing.Point(431, 185);
            this.BtnExibir.Name = "BtnExibir";
            this.BtnExibir.Size = new System.Drawing.Size(75, 23);
            this.BtnExibir.TabIndex = 21;
            this.BtnExibir.Text = "Exibir";
            this.BtnExibir.UseVisualStyleBackColor = true;
            this.BtnExibir.Click += new System.EventHandler(this.BtnExibir_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(331, 185);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 20;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(229, 185);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 19;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(136, 185);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo.TabIndex = 18;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // TextId
            // 
            this.TextId.Location = new System.Drawing.Point(184, 34);
            this.TextId.Name = "TextId";
            this.TextId.Size = new System.Drawing.Size(100, 20);
            this.TextId.TabIndex = 17;
            // 
            // TextNome
            // 
            this.TextNome.Location = new System.Drawing.Point(184, 64);
            this.TextNome.Name = "TextNome";
            this.TextNome.Size = new System.Drawing.Size(385, 20);
            this.TextNome.TabIndex = 16;
            // 
            // TextNumero
            // 
            this.TextNumero.Location = new System.Drawing.Point(184, 90);
            this.TextNumero.Name = "TextNumero";
            this.TextNumero.Size = new System.Drawing.Size(100, 20);
            this.TextNumero.TabIndex = 15;
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Location = new System.Drawing.Point(133, 89);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(44, 13);
            this.Numero.TabIndex = 14;
            this.Numero.Text = "Numero";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(133, 64);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 13;
            this.Nome.Text = "Nome";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(133, 41);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 12;
            this.Id.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.DgvDados);
            this.Controls.Add(this.BtnExibir);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.TextId);
            this.Controls.Add(this.TextNome);
            this.Controls.Add(this.TextNumero);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Id);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnConsultar;
        internal System.Windows.Forms.DataGridView DgvDados;
        internal System.Windows.Forms.Button BtnExibir;
        internal System.Windows.Forms.Button BtnExcluir;
        internal System.Windows.Forms.Button BtnEditar;
        internal System.Windows.Forms.Button BtnNovo;
        internal System.Windows.Forms.TextBox TextId;
        internal System.Windows.Forms.TextBox TextNome;
        internal System.Windows.Forms.TextBox TextNumero;
        internal System.Windows.Forms.Label Numero;
        internal System.Windows.Forms.Label Nome;
        internal System.Windows.Forms.Label Id;
    }
}

