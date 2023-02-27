namespace Orders.Classes
{
    partial class Catalogo
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
            this.Btncategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btncategoria
            // 
            this.Btncategoria.Location = new System.Drawing.Point(3, 3);
            this.Btncategoria.Name = "Btncategoria";
            this.Btncategoria.Size = new System.Drawing.Size(144, 144);
            this.Btncategoria.TabIndex = 0;
            this.Btncategoria.Text = "Teste";
            this.Btncategoria.UseVisualStyleBackColor = true;
            this.Btncategoria.Click += new System.EventHandler(this.Btncategoria_Click);
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btncategoria);
            this.Name = "Catalogo";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Btncategoria;
    }
}
