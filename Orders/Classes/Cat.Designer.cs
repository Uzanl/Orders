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
            this.BtnRemover = new System.Windows.Forms.Button();
            this.LblCategorias = new System.Windows.Forms.Label();
            this.Pctcategoria = new System.Windows.Forms.PictureBox();
            this.FlpProduto = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.BtnNovoProd = new System.Windows.Forms.Button();
            this.PctCadProd = new System.Windows.Forms.PictureBox();
            this.BtnCadProd = new System.Windows.Forms.Button();
            this.LblNomeProd = new System.Windows.Forms.Label();
            this.txtCadProd = new System.Windows.Forms.TextBox();
            this.BtnImgProd = new System.Windows.Forms.Button();
            this.LblPreco = new System.Windows.Forms.Label();
            this.TxtPrecoProd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pctcategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctCadProd)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExpandir
            // 
       
            this.BtnExpandir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExpandir.Enabled = false;
            this.BtnExpandir.Location = new System.Drawing.Point(4, 42);
            this.BtnExpandir.Name = "BtnExpandir";
            this.BtnExpandir.Size = new System.Drawing.Size(40, 38);
            this.BtnExpandir.TabIndex = 13;
            this.BtnExpandir.UseVisualStyleBackColor = true;
            this.BtnExpandir.Click += new System.EventHandler(this.BtnExpandir_Click);
            // 
            // BtnRemover
            // 
            this.BtnRemover.Location = new System.Drawing.Point(680, 50);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(75, 23);
            this.BtnRemover.TabIndex = 3;
            this.BtnRemover.Text = "Remover";
            this.BtnRemover.UseVisualStyleBackColor = true;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
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
            this.TxtProduto.Location = new System.Drawing.Point(189, 97);
            this.TxtProduto.Name = "TxtProduto";
            this.TxtProduto.Size = new System.Drawing.Size(210, 20);
            this.TxtProduto.TabIndex = 1;
            this.TxtProduto.Visible = false;
            this.TxtProduto.TextChanged += new System.EventHandler(this.TxtProduto_TextChanged);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(136, 100);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 15;
            this.lblProduto.Text = "Produto:";
            this.lblProduto.Visible = false;
            // 
            // BtnNovoProd
            // 
            this.BtnNovoProd.Location = new System.Drawing.Point(405, 95);
            this.BtnNovoProd.Name = "BtnNovoProd";
            this.BtnNovoProd.Size = new System.Drawing.Size(75, 23);
            this.BtnNovoProd.TabIndex = 2;
            this.BtnNovoProd.Text = "Novo";
            this.BtnNovoProd.UseVisualStyleBackColor = true;
            this.BtnNovoProd.Visible = false;
            this.BtnNovoProd.Click += new System.EventHandler(this.BtnNovoProd_Click);
            // 
            // PctCadProd
            // 
            this.PctCadProd.BackColor = System.Drawing.Color.Transparent;
            this.PctCadProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PctCadProd.Location = new System.Drawing.Point(960, 12);
            this.PctCadProd.Name = "PctCadProd";
            this.PctCadProd.Size = new System.Drawing.Size(80, 75);
            this.PctCadProd.TabIndex = 26;
            this.PctCadProd.TabStop = false;
            this.PctCadProd.Visible = false;
            // 
            // BtnCadProd
            // 
            this.BtnCadProd.Location = new System.Drawing.Point(854, 95);
            this.BtnCadProd.Name = "BtnCadProd";
            this.BtnCadProd.Size = new System.Drawing.Size(75, 23);
            this.BtnCadProd.TabIndex = 7;
            this.BtnCadProd.Text = "Salvar";
            this.BtnCadProd.UseVisualStyleBackColor = true;
            this.BtnCadProd.Visible = false;
            this.BtnCadProd.Click += new System.EventHandler(this.BtnCadProd_Click);
            // 
            // LblNomeProd
            // 
            this.LblNomeProd.AutoSize = true;
            this.LblNomeProd.Location = new System.Drawing.Point(851, 12);
            this.LblNomeProd.Name = "LblNomeProd";
            this.LblNomeProd.Size = new System.Drawing.Size(38, 13);
            this.LblNomeProd.TabIndex = 24;
            this.LblNomeProd.Text = "Nome:";
            this.LblNomeProd.Visible = false;
            // 
            // txtCadProd
            // 
            this.txtCadProd.Location = new System.Drawing.Point(854, 28);
            this.txtCadProd.Name = "txtCadProd";
            this.txtCadProd.Size = new System.Drawing.Size(100, 20);
            this.txtCadProd.TabIndex = 4;
            this.txtCadProd.Visible = false;
            // 
            // BtnImgProd
            // 
            this.BtnImgProd.Location = new System.Drawing.Point(931, 95);
            this.BtnImgProd.Name = "BtnImgProd";
            this.BtnImgProd.Size = new System.Drawing.Size(109, 23);
            this.BtnImgProd.TabIndex = 6;
            this.BtnImgProd.Text = "Adicionar imagem";
            this.BtnImgProd.UseVisualStyleBackColor = true;
            this.BtnImgProd.Visible = false;
            this.BtnImgProd.Click += new System.EventHandler(this.BtnImgProd_Click);
            // 
            // LblPreco
            // 
            this.LblPreco.AutoSize = true;
            this.LblPreco.Location = new System.Drawing.Point(851, 51);
            this.LblPreco.Name = "LblPreco";
            this.LblPreco.Size = new System.Drawing.Size(38, 13);
            this.LblPreco.TabIndex = 27;
            this.LblPreco.Text = "Preço:";
            this.LblPreco.Visible = false;
            // 
            // TxtPrecoProd
            // 
            this.TxtPrecoProd.Location = new System.Drawing.Point(854, 66);
            this.TxtPrecoProd.Name = "TxtPrecoProd";
            this.TxtPrecoProd.Size = new System.Drawing.Size(75, 20);
            this.TxtPrecoProd.TabIndex = 5;
            this.TxtPrecoProd.Visible = false;
            this.TxtPrecoProd.TextChanged += new System.EventHandler(this.TxtPrecoProd_TextChanged);
            // 
            // Cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.TxtPrecoProd);
            this.Controls.Add(this.LblPreco);
            this.Controls.Add(this.PctCadProd);
            this.Controls.Add(this.BtnCadProd);
            this.Controls.Add(this.LblNomeProd);
            this.Controls.Add(this.txtCadProd);
            this.Controls.Add(this.BtnImgProd);
            this.Controls.Add(this.BtnNovoProd);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.TxtProduto);
            this.Controls.Add(this.BtnExpandir);
            this.Controls.Add(this.BtnRemover);
            this.Controls.Add(this.LblCategorias);
            this.Controls.Add(this.Pctcategoria);
            this.Controls.Add(this.FlpProduto);
            this.Name = "Cat";
            this.Size = new System.Drawing.Size(1500, 122);
            this.Load += new System.EventHandler(this.Catcontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pctcategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctCadProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button BtnExpandir;
        public System.Windows.Forms.Button BtnRemover;
        public System.Windows.Forms.Label LblCategorias;
        public System.Windows.Forms.PictureBox Pctcategoria;
        private System.Windows.Forms.FlowLayoutPanel FlpProduto;
        public System.Windows.Forms.TextBox TxtProduto;
        public System.Windows.Forms.Label lblProduto;
        public System.Windows.Forms.Button BtnNovoProd;
        private System.Windows.Forms.PictureBox PctCadProd;
        private System.Windows.Forms.Button BtnCadProd;
        private System.Windows.Forms.Label LblNomeProd;
        private System.Windows.Forms.TextBox txtCadProd;
        private System.Windows.Forms.Button BtnImgProd;
        private System.Windows.Forms.Label LblPreco;
        private System.Windows.Forms.TextBox TxtPrecoProd;
    }
}
