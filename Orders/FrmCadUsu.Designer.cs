namespace Orders
{
    partial class FrmCadUsu
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
            this.chkSenha = new System.Windows.Forms.CheckBox();
            this.txtConfirma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl8Caracteres = new System.Windows.Forms.Label();
            this.lbl1Num = new System.Windows.Forms.Label();
            this.lbl1Minuscula = new System.Windows.Forms.Label();
            this.lbl1Especial = new System.Windows.Forms.Label();
            this.lblMaiuscula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkSenha
            // 
            this.chkSenha.AutoSize = true;
            this.chkSenha.Location = new System.Drawing.Point(231, 167);
            this.chkSenha.Name = "chkSenha";
            this.chkSenha.Size = new System.Drawing.Size(15, 14);
            this.chkSenha.TabIndex = 21;
            this.chkSenha.UseVisualStyleBackColor = true;
            this.chkSenha.CheckedChanged += new System.EventHandler(this.chkSenha_CheckedChanged);
            // 
            // txtConfirma
            // 
            this.txtConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirma.Location = new System.Drawing.Point(119, 195);
            this.txtConfirma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirma.MaxLength = 15;
            this.txtConfirma.Name = "txtConfirma";
            this.txtConfirma.Size = new System.Drawing.Size(127, 26);
            this.txtConfirma.TabIndex = 15;
            this.txtConfirma.UseSystemPasswordChar = true;
            this.txtConfirma.TextChanged += new System.EventHandler(this.txtConfirma_TextChanged);
            this.txtConfirma.Leave += new System.EventHandler(this.txtConfirma_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Conf Senha:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.White;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnCadastrar.FlatAppearance.BorderSize = 2;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(17, 229);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(229, 50);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Administrador",
            "Garçom",
            "Chefe",
            "Mesa"});
            this.cmbCargo.Location = new System.Drawing.Point(119, 11);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(127, 21);
            this.cmbCargo.TabIndex = 17;
            this.cmbCargo.SelectedIndexChanged += new System.EventHandler(this.cmbCargo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cargo:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(120, 159);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSenha.MaxLength = 15;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(127, 26);
            this.txtSenha.TabIndex = 14;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(120, 40);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLogin.MaxLength = 15;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(127, 26);
            this.txtLogin.TabIndex = 13;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Usuário:";
            // 
            // lbl8Caracteres
            // 
            this.lbl8Caracteres.AutoSize = true;
            this.lbl8Caracteres.Location = new System.Drawing.Point(14, 88);
            this.lbl8Caracteres.Name = "lbl8Caracteres";
            this.lbl8Caracteres.Size = new System.Drawing.Size(124, 13);
            this.lbl8Caracteres.TabIndex = 23;
            this.lbl8Caracteres.Text = "Pelo menos 8 caracteres";
            // 
            // lbl1Num
            // 
            this.lbl1Num.AutoSize = true;
            this.lbl1Num.Location = new System.Drawing.Point(14, 101);
            this.lbl1Num.Name = "lbl1Num";
            this.lbl1Num.Size = new System.Drawing.Size(142, 13);
            this.lbl1Num.TabIndex = 24;
            this.lbl1Num.Text = "Pelo Menos 1 Número (0...9)";
            // 
            // lbl1Minuscula
            // 
            this.lbl1Minuscula.AutoSize = true;
            this.lbl1Minuscula.Location = new System.Drawing.Point(14, 114);
            this.lbl1Minuscula.Name = "lbl1Minuscula";
            this.lbl1Minuscula.Size = new System.Drawing.Size(170, 13);
            this.lbl1Minuscula.TabIndex = 25;
            this.lbl1Minuscula.Text = "Pelo menos 1 letra minúscula(a...z)";
            // 
            // lbl1Especial
            // 
            this.lbl1Especial.AutoSize = true;
            this.lbl1Especial.Location = new System.Drawing.Point(14, 127);
            this.lbl1Especial.Name = "lbl1Especial";
            this.lbl1Especial.Size = new System.Drawing.Size(183, 13);
            this.lbl1Especial.TabIndex = 26;
            this.lbl1Especial.Text = "Pelo menos 1 símbolo especial (^...$)";
            // 
            // lblMaiuscula
            // 
            this.lblMaiuscula.AutoSize = true;
            this.lblMaiuscula.Location = new System.Drawing.Point(14, 140);
            this.lblMaiuscula.Name = "lblMaiuscula";
            this.lblMaiuscula.Size = new System.Drawing.Size(176, 13);
            this.lblMaiuscula.TabIndex = 27;
            this.lblMaiuscula.Text = "Pelo menos 1 letra maiúscula (A...Z)";
            // 
            // FrmCadUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 302);
            this.Controls.Add(this.lblMaiuscula);
            this.Controls.Add(this.lbl1Especial);
            this.Controls.Add(this.lbl1Minuscula);
            this.Controls.Add(this.lbl1Num);
            this.Controls.Add(this.lbl8Caracteres);
            this.Controls.Add(this.chkSenha);
            this.Controls.Add(this.txtConfirma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadUsu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadUsu";
            this.Load += new System.EventHandler(this.FrmCadUsu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSenha;
        private System.Windows.Forms.TextBox txtConfirma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl8Caracteres;
        private System.Windows.Forms.Label lbl1Num;
        private System.Windows.Forms.Label lbl1Minuscula;
        private System.Windows.Forms.Label lbl1Especial;
        private System.Windows.Forms.Label lblMaiuscula;
    }
}