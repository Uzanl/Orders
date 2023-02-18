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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pctproduto = new System.Windows.Forms.PictureBox();
            this.LblCategorias = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pctproduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnExcluir);
            this.panel1.Controls.Add(this.LblCategorias);
            this.panel1.Controls.Add(this.Pctproduto);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 94);
            this.panel1.TabIndex = 0;
            // 
            // Pctproduto
            // 
            this.Pctproduto.BackColor = System.Drawing.SystemColors.Window;
            this.Pctproduto.Location = new System.Drawing.Point(10, 12);
            this.Pctproduto.Name = "Pctproduto";
            this.Pctproduto.Size = new System.Drawing.Size(70, 70);
            this.Pctproduto.TabIndex = 9;
            this.Pctproduto.TabStop = false;
            // 
            // LblCategorias
            // 
            this.LblCategorias.AutoSize = true;
            this.LblCategorias.Location = new System.Drawing.Point(156, 43);
            this.LblCategorias.Name = "LblCategorias";
            this.LblCategorias.Size = new System.Drawing.Size(74, 13);
            this.LblCategorias.TabIndex = 10;
            this.LblCategorias.Text = "Nome produto";
       
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(301, 38);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 11;
            this.BtnExcluir.Text = "Remover";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // ProdutoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ProdutoControl";
            this.Size = new System.Drawing.Size(392, 100);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pctproduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button BtnExcluir;
        public System.Windows.Forms.Label LblCategorias;
        public System.Windows.Forms.PictureBox Pctproduto;
    }
}
