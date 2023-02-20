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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExpandir = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.LblCategorias = new System.Windows.Forms.Label();
            this.Pctcategoria = new System.Windows.Forms.PictureBox();
            this.FlpProduto = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pctcategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnExpandir);
            this.panel1.Controls.Add(this.BtnExcluir);
            this.panel1.Controls.Add(this.LblCategorias);
            this.panel1.Controls.Add(this.Pctcategoria);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 116);
            this.panel1.TabIndex = 0;
            // 
            // BtnExpandir
            // 
            this.BtnExpandir.BackgroundImage = global::Orders.Properties.Resources.download;
            this.BtnExpandir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExpandir.Location = new System.Drawing.Point(3, 43);
            this.BtnExpandir.Name = "BtnExpandir";
            this.BtnExpandir.Size = new System.Drawing.Size(40, 40);
            this.BtnExpandir.TabIndex = 9;
            this.BtnExpandir.UseVisualStyleBackColor = true;
            this.BtnExpandir.Click += new System.EventHandler(this.BtnExpandir_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(655, 38);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 8;
            this.BtnExcluir.Text = "Remover";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // LblCategorias
            // 
            this.LblCategorias.AutoSize = true;
            this.LblCategorias.Location = new System.Drawing.Point(339, 43);
            this.LblCategorias.Name = "LblCategorias";
            this.LblCategorias.Size = new System.Drawing.Size(82, 13);
            this.LblCategorias.TabIndex = 7;
            this.LblCategorias.Text = "Nome categoria";
            // 
            // Pctcategoria
            // 
            this.Pctcategoria.BackColor = System.Drawing.SystemColors.Window;
            this.Pctcategoria.Location = new System.Drawing.Point(54, 29);
            this.Pctcategoria.Name = "Pctcategoria";
            this.Pctcategoria.Size = new System.Drawing.Size(84, 70);
            this.Pctcategoria.TabIndex = 6;
            this.Pctcategoria.TabStop = false;
            // 
            // FlpProduto
            // 
            this.FlpProduto.AutoScroll = true;
            this.FlpProduto.Location = new System.Drawing.Point(3, 128);
            this.FlpProduto.Name = "FlpProduto";
            this.FlpProduto.Size = new System.Drawing.Size(386, 184);
            this.FlpProduto.TabIndex = 1;
            // 
            // Cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FlpProduto);
            this.Controls.Add(this.panel1);
            this.Name = "Cat";
            this.Size = new System.Drawing.Size(760, 122);
            this.Load += new System.EventHandler(this.Catcontrol_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pctcategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button BtnExcluir;
        public System.Windows.Forms.Label LblCategorias;
        public System.Windows.Forms.PictureBox Pctcategoria;
        private System.Windows.Forms.FlowLayoutPanel FlpProduto;
        private System.Windows.Forms.Button BtnExpandir;
    }
}
