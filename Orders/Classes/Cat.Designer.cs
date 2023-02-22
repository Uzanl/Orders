namespace Orders.Classes
{
    partial class Cat
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
            this.BtnExpandir = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.LblCategorias = new System.Windows.Forms.Label();
            this.Pctcategoria = new System.Windows.Forms.PictureBox();
            this.FlpProduto = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pctcategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExpandir
            // 
            this.BtnExpandir.BackgroundImage = global::Orders.Properties.Resources.download;
            this.BtnExpandir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExpandir.Location = new System.Drawing.Point(4, 42);
            this.BtnExpandir.Name = "BtnExpandir";
            this.BtnExpandir.Size = new System.Drawing.Size(40, 38);
            this.BtnExpandir.TabIndex = 13;
            this.BtnExpandir.UseVisualStyleBackColor = true;
            this.BtnExpandir.Click += new System.EventHandler(this.BtnExpandir_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(680, 50);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 12;
            this.BtnExcluir.Text = "Remover";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // LblCategorias
            // 
            this.LblCategorias.AutoSize = true;
            this.LblCategorias.Location = new System.Drawing.Point(136, 55);
            this.LblCategorias.Name = "LblCategorias";
            this.LblCategorias.Size = new System.Drawing.Size(82, 13);
            this.LblCategorias.TabIndex = 11;
            this.LblCategorias.Text = "Nome categoria";
            // 
            // Pctcategoria
            // 
            this.Pctcategoria.BackColor = System.Drawing.Color.White;
            this.Pctcategoria.Location = new System.Drawing.Point(50, 17);
            this.Pctcategoria.Name = "Pctcategoria";
            this.Pctcategoria.Size = new System.Drawing.Size(80, 80);
            this.Pctcategoria.TabIndex = 10;
            this.Pctcategoria.TabStop = false;
            // 
            // FlpProduto
            // 
            this.FlpProduto.AutoScroll = true;
            this.FlpProduto.Location = new System.Drawing.Point(128, 125);
            this.FlpProduto.Name = "FlpProduto";
            this.FlpProduto.Size = new System.Drawing.Size(726, 216);
            this.FlpProduto.TabIndex = 1;
            // 
            // TxtProduto
            // 
            this.TxtProduto.Location = new System.Drawing.Point(189, 102);
            this.TxtProduto.Name = "TxtProduto";
            this.TxtProduto.Size = new System.Drawing.Size(210, 20);
            this.TxtProduto.TabIndex = 14;
            this.TxtProduto.Visible = false;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(136, 105);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 15;
            this.lblProduto.Text = "Produto:";
            this.lblProduto.Visible = false;
            // 
            // Cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.TxtProduto);
            this.Controls.Add(this.BtnExpandir);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.LblCategorias);
            this.Controls.Add(this.Pctcategoria);
            this.Controls.Add(this.FlpProduto);
            this.Name = "Cat";
            this.Size = new System.Drawing.Size(758, 122);
            this.Load += new System.EventHandler(this.Catcontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pctcategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button BtnExpandir;
        public System.Windows.Forms.Button BtnExcluir;
        public System.Windows.Forms.Label LblCategorias;
        public System.Windows.Forms.PictureBox Pctcategoria;
        private System.Windows.Forms.FlowLayoutPanel FlpProduto;
        private System.Windows.Forms.TextBox TxtProduto;
        private System.Windows.Forms.Label lblProduto;
    }
}
