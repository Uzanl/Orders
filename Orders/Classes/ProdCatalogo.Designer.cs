namespace Orders.Classes
{
    partial class ProdCatalogo
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
            this.BtnProduto = new System.Windows.Forms.Button();
            this.LblPreco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnProduto
            // 
            this.BtnProduto.Location = new System.Drawing.Point(3, 3);
            this.BtnProduto.Name = "BtnProduto";
            this.BtnProduto.Size = new System.Drawing.Size(144, 144);
            this.BtnProduto.TabIndex = 0;
            this.BtnProduto.Text = "teste";
            this.BtnProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnProduto.UseVisualStyleBackColor = true;
            this.BtnProduto.Click += new System.EventHandler(this.BtnProduto_Click);
            // 
            // LblPreco
            // 
            this.LblPreco.AutoSize = true;
            this.LblPreco.Location = new System.Drawing.Point(76, 63);
            this.LblPreco.Name = "LblPreco";
            this.LblPreco.Size = new System.Drawing.Size(0, 13);
            this.LblPreco.TabIndex = 1;
            this.LblPreco.Visible = false;
            // 
            // ProdCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblPreco);
            this.Controls.Add(this.BtnProduto);
            this.Name = "ProdCatalogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtnProduto;
        public System.Windows.Forms.Label LblPreco;
    }
}
