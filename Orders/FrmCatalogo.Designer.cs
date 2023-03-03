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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnFinalizarpedido = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.FlpItens = new System.Windows.Forms.FlowLayoutPanel();
            this.FlpCategorias = new System.Windows.Forms.FlowLayoutPanel();
            this.LblSubtotal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1920, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategoriasToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Arquivo";
            // 
            // CategoriasToolStripMenuItem
            // 
            this.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem";
            this.CategoriasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.CategoriasToolStripMenuItem.Text = "Catálogo";
            this.CategoriasToolStripMenuItem.Click += new System.EventHandler(this.CategoriasToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.PedidosToolStripMenuItem_Click);
            // 
            // BtnFinalizarpedido
            // 
            this.BtnFinalizarpedido.Location = new System.Drawing.Point(1638, 899);
            this.BtnFinalizarpedido.Name = "BtnFinalizarpedido";
            this.BtnFinalizarpedido.Size = new System.Drawing.Size(262, 63);
            this.BtnFinalizarpedido.TabIndex = 18;
            this.BtnFinalizarpedido.Text = "Finalizar pedido";
            this.BtnFinalizarpedido.UseVisualStyleBackColor = true;
            this.BtnFinalizarpedido.Visible = false;
            this.BtnFinalizarpedido.Click += new System.EventHandler(this.BtnFinalizarpedido_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(288, 98);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(94, 33);
            this.BtnVoltar.TabIndex = 16;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Visible = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FlpItens
            // 
            this.FlpItens.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FlpItens.AutoScroll = true;
            this.FlpItens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlpItens.Location = new System.Drawing.Point(1638, 137);
            this.FlpItens.Name = "FlpItens";
            this.FlpItens.Size = new System.Drawing.Size(262, 756);
            this.FlpItens.TabIndex = 17;
            this.FlpItens.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.FlpItens_ControlAdded);
            this.FlpItens.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.FlpItens_ControlRemoved);
            // 
            // FlpCategorias
            // 
            this.FlpCategorias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FlpCategorias.AutoScroll = true;
            this.FlpCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlpCategorias.Location = new System.Drawing.Point(288, 137);
            this.FlpCategorias.Name = "FlpCategorias";
            this.FlpCategorias.Size = new System.Drawing.Size(1344, 756);
            this.FlpCategorias.TabIndex = 15;
            // 
            // LblSubtotal
            // 
            this.LblSubtotal.AutoSize = true;
            this.LblSubtotal.Location = new System.Drawing.Point(1451, 924);
            this.LblSubtotal.Name = "LblSubtotal";
            this.LblSubtotal.Size = new System.Drawing.Size(0, 13);
            this.LblSubtotal.TabIndex = 19;
            // 
            // FrmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.LblSubtotal);
            this.Controls.Add(this.BtnFinalizarpedido);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.FlpItens);
            this.Controls.Add(this.FlpCategorias);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Catalogo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button BtnFinalizarpedido;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.FlowLayoutPanel FlpItens;
        private System.Windows.Forms.FlowLayoutPanel FlpCategorias;
        private System.Windows.Forms.ToolStripMenuItem CategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        public System.Windows.Forms.Label LblSubtotal;
    }
}

