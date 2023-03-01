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
            this.components = new System.ComponentModel.Container();
            this.Lblid = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.Lblhora = new System.Windows.Forms.Label();
            this.BtnExpandir = new System.Windows.Forms.Button();
            this.FlpProdutos = new System.Windows.Forms.FlowLayoutPanel();
            this.LblStatus = new System.Windows.Forms.Label();
            this.Lbltimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnFinalizar = new System.Windows.Forms.Button();
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
            // BtnExpandir
            // 
            this.BtnExpandir.Location = new System.Drawing.Point(29, 96);
            this.BtnExpandir.Name = "BtnExpandir";
            this.BtnExpandir.Size = new System.Drawing.Size(75, 23);
            this.BtnExpandir.TabIndex = 3;
            this.BtnExpandir.Text = "Expandir";
            this.BtnExpandir.UseVisualStyleBackColor = true;
            this.BtnExpandir.Click += new System.EventHandler(this.BtnExpandir_Click);
            // 
            // FlpProdutos
            // 
            this.FlpProdutos.AutoScroll = true;
            this.FlpProdutos.AutoSize = true;
            this.FlpProdutos.Location = new System.Drawing.Point(29, 125);
            this.FlpProdutos.Name = "FlpProdutos";
            this.FlpProdutos.Size = new System.Drawing.Size(726, 369);
            this.FlpProdutos.TabIndex = 4;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(517, 68);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(37, 13);
            this.LblStatus.TabIndex = 5;
            this.LblStatus.Text = "Status";
            // 
            // Lbltimer
            // 
            this.Lbltimer.AutoSize = true;
            this.Lbltimer.Location = new System.Drawing.Point(653, 68);
            this.Lbltimer.Name = "Lbltimer";
            this.Lbltimer.Size = new System.Drawing.Size(34, 13);
            this.Lbltimer.TabIndex = 6;
            this.Lbltimer.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.Location = new System.Drawing.Point(758, 63);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(101, 23);
            this.BtnFinalizar.TabIndex = 7;
            this.BtnFinalizar.Text = "Finalizar Pedido";
            this.BtnFinalizar.UseVisualStyleBackColor = true;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // PedidoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.Lbltimer);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.FlpProdutos);
            this.Controls.Add(this.BtnExpandir);
            this.Controls.Add(this.Lblhora);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.Lblid);
            this.Name = "PedidoControl";
            this.Size = new System.Drawing.Size(1556, 122);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnExpandir;
        public System.Windows.Forms.Label Lblid;
        public System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.Label Lblhora;
        private System.Windows.Forms.FlowLayoutPanel FlpProdutos;
        private System.Windows.Forms.Label Lbltimer;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Button BtnFinalizar;
    }
}
