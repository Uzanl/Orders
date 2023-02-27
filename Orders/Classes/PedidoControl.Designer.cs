namespace Orders.Classes
{
    partial class PedidoControl
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
            this.Lblid = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.Lblhora = new System.Windows.Forms.Label();
            this.BtnProdutos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lblid
            // 
            this.Lblid.AutoSize = true;
            this.Lblid.Location = new System.Drawing.Point(26, 68);
            this.Lblid.Name = "Lblid";
            this.Lblid.Size = new System.Drawing.Size(13, 13);
            this.Lblid.TabIndex = 0;
            this.Lblid.Text = "1";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(207, 68);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // Lblhora
            // 
            this.Lblhora.AutoSize = true;
            this.Lblhora.Location = new System.Drawing.Point(368, 68);
            this.Lblhora.Name = "Lblhora";
            this.Lblhora.Size = new System.Drawing.Size(38, 13);
            this.Lblhora.TabIndex = 2;
            this.Lblhora.Text = "hh:mm";
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.Location = new System.Drawing.Point(29, 96);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Size = new System.Drawing.Size(75, 23);
            this.BtnProdutos.TabIndex = 3;
            this.BtnProdutos.Text = "Expandir";
            this.BtnProdutos.UseVisualStyleBackColor = true;
            // 
            // PedidoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnProdutos);
            this.Controls.Add(this.Lblhora);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.Lblid);
            this.Name = "PedidoControl";
            this.Size = new System.Drawing.Size(1556, 122);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnProdutos;
        public System.Windows.Forms.Label Lblid;
        public System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.Label Lblhora;
    }
}
