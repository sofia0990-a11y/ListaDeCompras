namespace ListaDeCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.piblogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.LblNomeProduto = new System.Windows.Forms.Label();
            this.txbprodutos = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.libCompras = new System.Windows.Forms.ListBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.piblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // piblogo
            // 
            this.piblogo.Image = global::ListaDeCompras.Properties.Resources.Uiconstock_Dynamic_Flat_Android_Cart_256__1_;
            this.piblogo.Location = new System.Drawing.Point(155, 44);
            this.piblogo.Name = "piblogo";
            this.piblogo.Size = new System.Drawing.Size(119, 95);
            this.piblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piblogo.TabIndex = 0;
            this.piblogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(280, 74);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(275, 36);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Lista de Compras";
            // 
            // LblNomeProduto
            // 
            this.LblNomeProduto.AutoSize = true;
            this.LblNomeProduto.Location = new System.Drawing.Point(136, 214);
            this.LblNomeProduto.Name = "LblNomeProduto";
            this.LblNomeProduto.Size = new System.Drawing.Size(127, 16);
            this.LblNomeProduto.TabIndex = 2;
            this.LblNomeProduto.Text = "Nome do Produto:";
            // 
            // txbprodutos
            // 
            this.txbprodutos.BackColor = System.Drawing.Color.White;
            this.txbprodutos.Location = new System.Drawing.Point(139, 233);
            this.txbprodutos.Name = "txbprodutos";
            this.txbprodutos.Size = new System.Drawing.Size(158, 23);
            this.txbprodutos.TabIndex = 3;
            this.txbprodutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbprodutos_KeyDown);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(139, 279);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(161, 36);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // libCompras
            // 
            this.libCompras.FormattingEnabled = true;
            this.libCompras.ItemHeight = 16;
            this.libCompras.Location = new System.Drawing.Point(522, 147);
            this.libCompras.Name = "libCompras";
            this.libCompras.Size = new System.Drawing.Size(379, 260);
            this.libCompras.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(522, 413);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(164, 50);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(716, 413);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(185, 50);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar Lista";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.libCompras);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txbprodutos);
            this.Controls.Add(this.LblNomeProduto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.piblogo);
            this.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "text";
            ((System.ComponentModel.ISupportInitialize)(this.piblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox piblogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label LblNomeProduto;
        private System.Windows.Forms.TextBox txbprodutos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox libCompras;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
    }
}

