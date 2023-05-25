namespace Orders.Classes
{
    partial class ProdutoControl
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.LblProduto = new System.Windows.Forms.Label();
            this.Pctproduto = new System.Windows.Forms.PictureBox();
            this.LblPreco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pctproduto)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(550, 56);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 14;
            this.BtnExcluir.Text = "Remover";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // LblProduto
            // 
            this.LblProduto.AutoSize = true;
            this.LblProduto.Location = new System.Drawing.Point(89, 61);
            this.LblProduto.Name = "LblProduto";
            this.LblProduto.Size = new System.Drawing.Size(74, 13);
            this.LblProduto.TabIndex = 13;
            this.LblProduto.Text = "Nome produto";
            // 
            // Pctproduto
            // 
            this.Pctproduto.BackColor = System.Drawing.SystemColors.Window;
            this.Pctproduto.Location = new System.Drawing.Point(3, 23);
            this.Pctproduto.Name = "Pctproduto";
            this.Pctproduto.Size = new System.Drawing.Size(80, 80);
            this.Pctproduto.TabIndex = 12;
            this.Pctproduto.TabStop = false;
            // 
            // LblPreco
            // 
            this.LblPreco.AutoSize = true;
            this.LblPreco.Location = new System.Drawing.Point(222, 61);
            this.LblPreco.Name = "LblPreco";
            this.LblPreco.Size = new System.Drawing.Size(0, 13);
            this.LblPreco.TabIndex = 15;
            // 
            // ProdutoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblPreco);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.LblProduto);
            this.Controls.Add(this.Pctproduto);
            this.Name = "ProdutoControl";
            this.Size = new System.Drawing.Size(628, 122);
            this.Load += new System.EventHandler(this.ProdutoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pctproduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtnExcluir;
        public System.Windows.Forms.Label LblProduto;
        public System.Windows.Forms.PictureBox Pctproduto;
        public System.Windows.Forms.Label LblPreco;
    }
}
