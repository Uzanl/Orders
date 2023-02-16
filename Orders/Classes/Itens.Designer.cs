namespace Orders.Classes
{
    partial class Itens
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblItem = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackgroundImage = global::Orders.Properties.Resources.lixo;
            this.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExcluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnExcluir.Location = new System.Drawing.Point(0, 0);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 65);
            this.BtnExcluir.TabIndex = 0;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblItem);
            this.panel1.Location = new System.Drawing.Point(81, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 59);
            this.panel1.TabIndex = 1;
            // 
            // LblItem
            // 
            this.LblItem.AutoSize = true;
            this.LblItem.Location = new System.Drawing.Point(43, 23);
            this.LblItem.Name = "LblItem";
            this.LblItem.Size = new System.Drawing.Size(92, 13);
            this.LblItem.TabIndex = 0;
            this.LblItem.Text = "Suco de melancia";
            // 
            // Itens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnExcluir);
            this.Name = "Itens";
            this.Size = new System.Drawing.Size(260, 65);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label LblItem;
    }
}
