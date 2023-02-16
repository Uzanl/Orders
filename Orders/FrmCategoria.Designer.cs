namespace Orders
{
    partial class FrmCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FlpCat = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCadNome = new System.Windows.Forms.TextBox();
            this.BtnAdicionarImagem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlpCat
            // 
            this.FlpCat.AutoScroll = true;
            this.FlpCat.Location = new System.Drawing.Point(12, 242);
            this.FlpCat.Name = "FlpCat";
            this.FlpCat.Size = new System.Drawing.Size(403, 282);
            this.FlpCat.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnNovo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtCategoria);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 65);
            this.panel1.TabIndex = 10;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(135, 25);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 24);
            this.BtnNovo.TabIndex = 13;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome:";
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Location = new System.Drawing.Point(29, 28);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(100, 20);
            this.TxtCategoria.TabIndex = 11;
            this.TxtCategoria.TextChanged += new System.EventHandler(this.TxtCategoria_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnCadastrar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCadNome);
            this.panel2.Controls.Add(this.BtnAdicionarImagem);
            this.panel2.Location = new System.Drawing.Point(12, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 153);
            this.panel2.TabIndex = 11;
            this.panel2.Visible = false;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(29, 82);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 20;
            this.BtnCadastrar.Text = "Salvar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome:";
            // 
            // txtCadNome
            // 
            this.txtCadNome.Location = new System.Drawing.Point(29, 27);
            this.txtCadNome.Name = "txtCadNome";
            this.txtCadNome.Size = new System.Drawing.Size(100, 20);
            this.txtCadNome.TabIndex = 18;
            // 
            // BtnAdicionarImagem
            // 
            this.BtnAdicionarImagem.Location = new System.Drawing.Point(29, 53);
            this.BtnAdicionarImagem.Name = "BtnAdicionarImagem";
            this.BtnAdicionarImagem.Size = new System.Drawing.Size(100, 23);
            this.BtnAdicionarImagem.TabIndex = 17;
            this.BtnAdicionarImagem.Text = "Adicionar imagem";
            this.BtnAdicionarImagem.UseVisualStyleBackColor = true;
            this.BtnAdicionarImagem.Click += new System.EventHandler(this.BtnAdicionarImagem_Click);
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 536);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FlpCat);
            this.Name = "FrmCategoria";
            this.Text = "CadastrarCategoria";
            this.Load += new System.EventHandler(this.FrmCadCategoria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlpCat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCadNome;
        private System.Windows.Forms.Button BtnAdicionarImagem;
    }
}