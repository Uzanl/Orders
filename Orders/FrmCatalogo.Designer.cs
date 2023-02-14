namespace Orders
{
    partial class FrmCatalogo
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
            this.FlpCategorias = new System.Windows.Forms.FlowLayoutPanel();
            this.FlpItens = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnFinalizarpedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FlpCategorias
            // 
            this.FlpCategorias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FlpCategorias.AutoScroll = true;
            this.FlpCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlpCategorias.Location = new System.Drawing.Point(288, 162);
            this.FlpCategorias.Name = "FlpCategorias";
            this.FlpCategorias.Size = new System.Drawing.Size(1344, 756);
            this.FlpCategorias.TabIndex = 7;
            // 
            // FlpItens
            // 
            this.FlpItens.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FlpItens.AutoScroll = true;
            this.FlpItens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlpItens.Location = new System.Drawing.Point(1638, 162);
            this.FlpItens.Name = "FlpItens";
            this.FlpItens.Size = new System.Drawing.Size(262, 756);
            this.FlpItens.TabIndex = 9;
            this.FlpItens.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.FlpItens_ControlRemoved);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(291, 123);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(94, 33);
            this.BtnVoltar.TabIndex = 8;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Visible = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // BtnFinalizarpedido
            // 
            this.BtnFinalizarpedido.Location = new System.Drawing.Point(1638, 924);
            this.BtnFinalizarpedido.Name = "BtnFinalizarpedido";
            this.BtnFinalizarpedido.Size = new System.Drawing.Size(262, 63);
            this.BtnFinalizarpedido.TabIndex = 10;
            this.BtnFinalizarpedido.Text = "Finalizar pedido";
            this.BtnFinalizarpedido.UseVisualStyleBackColor = true;
            this.BtnFinalizarpedido.Visible = false;
            // 
            // FrmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.BtnFinalizarpedido);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.FlpItens);
            this.Controls.Add(this.FlpCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCatalogo";
            this.Text = "Catálogo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Catalogo_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FlpCategorias;
        private System.Windows.Forms.FlowLayoutPanel FlpItens;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnFinalizarpedido;
    }
}

