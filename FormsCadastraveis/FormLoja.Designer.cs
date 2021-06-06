
namespace BancoDadosZe
{
    partial class FormLoja
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.controleUsEndereco = new BancoDadosZe.ControleEndereco();
            this.mk_id = new System.Windows.Forms.MaskedTextBox();
            this.texto_id = new System.Windows.Forms.Label();
            this.mk_IE = new System.Windows.Forms.MaskedTextBox();
            this.textoIe = new System.Windows.Forms.Label();
            this.mk_email = new System.Windows.Forms.MaskedTextBox();
            this.mk_telefone = new System.Windows.Forms.MaskedTextBox();
            this.mk_razaoSocial = new System.Windows.Forms.MaskedTextBox();
            this.mk_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.mk_nomeFantasia = new System.Windows.Forms.MaskedTextBox();
            this.textoEmail = new System.Windows.Forms.Label();
            this.textoTelefone = new System.Windows.Forms.Label();
            this.textoRazaoSocial = new System.Windows.Forms.Label();
            this.textoCnpj = new System.Windows.Forms.Label();
            this.radioButtonMatriz = new System.Windows.Forms.RadioButton();
            this.radioButtonFilial = new System.Windows.Forms.RadioButton();
            this.textoTipo = new System.Windows.Forms.Label();
            this.textoNomeFantasia = new System.Windows.Forms.Label();
            this.panelFundo.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.SystemColors.Info;
            this.panelFundo.Controls.Add(this.panelFormulario);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(821, 417);
            this.panelFundo.TabIndex = 1;
            // 
            // panelFormulario
            // 
            this.panelFormulario.Controls.Add(this.controleUsEndereco);
            this.panelFormulario.Controls.Add(this.mk_id);
            this.panelFormulario.Controls.Add(this.texto_id);
            this.panelFormulario.Controls.Add(this.mk_IE);
            this.panelFormulario.Controls.Add(this.textoIe);
            this.panelFormulario.Controls.Add(this.mk_email);
            this.panelFormulario.Controls.Add(this.mk_telefone);
            this.panelFormulario.Controls.Add(this.mk_razaoSocial);
            this.panelFormulario.Controls.Add(this.mk_cnpj);
            this.panelFormulario.Controls.Add(this.mk_nomeFantasia);
            this.panelFormulario.Controls.Add(this.textoEmail);
            this.panelFormulario.Controls.Add(this.textoTelefone);
            this.panelFormulario.Controls.Add(this.textoRazaoSocial);
            this.panelFormulario.Controls.Add(this.textoCnpj);
            this.panelFormulario.Controls.Add(this.radioButtonMatriz);
            this.panelFormulario.Controls.Add(this.radioButtonFilial);
            this.panelFormulario.Controls.Add(this.textoTipo);
            this.panelFormulario.Controls.Add(this.textoNomeFantasia);
            this.panelFormulario.Location = new System.Drawing.Point(9, 14);
            this.panelFormulario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(797, 401);
            this.panelFormulario.TabIndex = 2;
            // 
            // controleUsEndereco
            // 
            this.controleUsEndereco.Location = new System.Drawing.Point(21, 148);
            this.controleUsEndereco.Name = "controleUsEndereco";
            this.controleUsEndereco.Size = new System.Drawing.Size(740, 204);
            this.controleUsEndereco.TabIndex = 120;
            // 
            // mk_id
            // 
            this.mk_id.Enabled = false;
            this.mk_id.Location = new System.Drawing.Point(539, 120);
            this.mk_id.Name = "mk_id";
            this.mk_id.Size = new System.Drawing.Size(77, 22);
            this.mk_id.TabIndex = 119;
            this.mk_id.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // texto_id
            // 
            this.texto_id.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_id.Location = new System.Drawing.Point(458, 118);
            this.texto_id.Name = "texto_id";
            this.texto_id.Size = new System.Drawing.Size(65, 22);
            this.texto_id.TabIndex = 118;
            this.texto_id.Text = "Id";
            this.texto_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mk_IE
            // 
            this.mk_IE.Location = new System.Drawing.Point(165, 118);
            this.mk_IE.Name = "mk_IE";
            this.mk_IE.Size = new System.Drawing.Size(77, 22);
            this.mk_IE.TabIndex = 89;
            this.mk_IE.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textoIe
            // 
            this.textoIe.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoIe.Location = new System.Drawing.Point(62, 118);
            this.textoIe.Name = "textoIe";
            this.textoIe.Size = new System.Drawing.Size(65, 22);
            this.textoIe.TabIndex = 116;
            this.textoIe.Text = "IE";
            this.textoIe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mk_email
            // 
            this.mk_email.Location = new System.Drawing.Point(539, 82);
            this.mk_email.Name = "mk_email";
            this.mk_email.Size = new System.Drawing.Size(178, 22);
            this.mk_email.TabIndex = 88;
            this.mk_email.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mk_telefone
            // 
            this.mk_telefone.Location = new System.Drawing.Point(539, 50);
            this.mk_telefone.Mask = "(999) 9000-0000";
            this.mk_telefone.Name = "mk_telefone";
            this.mk_telefone.Size = new System.Drawing.Size(109, 22);
            this.mk_telefone.TabIndex = 87;
            this.mk_telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mk_razaoSocial
            // 
            this.mk_razaoSocial.Location = new System.Drawing.Point(165, 81);
            this.mk_razaoSocial.Name = "mk_razaoSocial";
            this.mk_razaoSocial.Size = new System.Drawing.Size(178, 22);
            this.mk_razaoSocial.TabIndex = 85;
            this.mk_razaoSocial.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mk_cnpj
            // 
            this.mk_cnpj.Location = new System.Drawing.Point(165, 46);
            this.mk_cnpj.Mask = "000.000.000-00";
            this.mk_cnpj.Name = "mk_cnpj";
            this.mk_cnpj.Size = new System.Drawing.Size(178, 22);
            this.mk_cnpj.TabIndex = 84;
            this.mk_cnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mk_nomeFantasia
            // 
            this.mk_nomeFantasia.Location = new System.Drawing.Point(165, 9);
            this.mk_nomeFantasia.Name = "mk_nomeFantasia";
            this.mk_nomeFantasia.Size = new System.Drawing.Size(178, 22);
            this.mk_nomeFantasia.TabIndex = 83;
            this.mk_nomeFantasia.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textoEmail
            // 
            this.textoEmail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoEmail.Location = new System.Drawing.Point(458, 80);
            this.textoEmail.Name = "textoEmail";
            this.textoEmail.Size = new System.Drawing.Size(65, 22);
            this.textoEmail.TabIndex = 61;
            this.textoEmail.Text = "Email";
            this.textoEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoTelefone
            // 
            this.textoTelefone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTelefone.Location = new System.Drawing.Point(436, 49);
            this.textoTelefone.Name = "textoTelefone";
            this.textoTelefone.Size = new System.Drawing.Size(97, 22);
            this.textoTelefone.TabIndex = 55;
            this.textoTelefone.Text = "Telefone";
            this.textoTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoRazaoSocial
            // 
            this.textoRazaoSocial.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoRazaoSocial.Location = new System.Drawing.Point(18, 81);
            this.textoRazaoSocial.Name = "textoRazaoSocial";
            this.textoRazaoSocial.Size = new System.Drawing.Size(109, 22);
            this.textoRazaoSocial.TabIndex = 52;
            this.textoRazaoSocial.Text = "Razão Social";
            this.textoRazaoSocial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoCnpj
            // 
            this.textoCnpj.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCnpj.Location = new System.Drawing.Point(63, 45);
            this.textoCnpj.Name = "textoCnpj";
            this.textoCnpj.Size = new System.Drawing.Size(64, 22);
            this.textoCnpj.TabIndex = 50;
            this.textoCnpj.Text = "CNPJ";
            this.textoCnpj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioButtonMatriz
            // 
            this.radioButtonMatriz.AutoSize = true;
            this.radioButtonMatriz.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMatriz.Location = new System.Drawing.Point(665, 10);
            this.radioButtonMatriz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonMatriz.Name = "radioButtonMatriz";
            this.radioButtonMatriz.Size = new System.Drawing.Size(68, 22);
            this.radioButtonMatriz.TabIndex = 49;
            this.radioButtonMatriz.Text = "Matriz";
            this.radioButtonMatriz.UseVisualStyleBackColor = true;
            // 
            // radioButtonFilial
            // 
            this.radioButtonFilial.AutoSize = true;
            this.radioButtonFilial.Checked = true;
            this.radioButtonFilial.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFilial.Location = new System.Drawing.Point(563, 10);
            this.radioButtonFilial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonFilial.Name = "radioButtonFilial";
            this.radioButtonFilial.Size = new System.Drawing.Size(53, 22);
            this.radioButtonFilial.TabIndex = 49;
            this.radioButtonFilial.TabStop = true;
            this.radioButtonFilial.Text = "Filial";
            this.radioButtonFilial.UseVisualStyleBackColor = true;
            // 
            // textoTipo
            // 
            this.textoTipo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTipo.Location = new System.Drawing.Point(470, 10);
            this.textoTipo.Name = "textoTipo";
            this.textoTipo.Size = new System.Drawing.Size(65, 22);
            this.textoTipo.TabIndex = 48;
            this.textoTipo.Text = "Tipo: ";
            this.textoTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoNomeFantasia
            // 
            this.textoNomeFantasia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNomeFantasia.Location = new System.Drawing.Point(-6, 8);
            this.textoNomeFantasia.Name = "textoNomeFantasia";
            this.textoNomeFantasia.Size = new System.Drawing.Size(133, 22);
            this.textoNomeFantasia.TabIndex = 46;
            this.textoNomeFantasia.Text = "Nome Fantasia";
            this.textoNomeFantasia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 417);
            this.Controls.Add(this.panelFundo);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLoja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro Lojas";
            this.panelFundo.ResumeLayout(false);
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Label textoEmail;
        private System.Windows.Forms.Label textoTelefone;
        private System.Windows.Forms.Label textoRazaoSocial;
        private System.Windows.Forms.Label textoCnpj;
        private System.Windows.Forms.RadioButton radioButtonMatriz;
        private System.Windows.Forms.RadioButton radioButtonFilial;
        private System.Windows.Forms.Label textoTipo;
        private System.Windows.Forms.Label textoNomeFantasia;
        private System.Windows.Forms.MaskedTextBox mk_email;
        private System.Windows.Forms.MaskedTextBox mk_telefone;
        private System.Windows.Forms.MaskedTextBox mk_razaoSocial;
        private System.Windows.Forms.MaskedTextBox mk_cnpj;
        private System.Windows.Forms.MaskedTextBox mk_nomeFantasia;
        private System.Windows.Forms.MaskedTextBox mk_IE;
        private System.Windows.Forms.Label textoIe;
        private System.Windows.Forms.MaskedTextBox mk_id;
        private System.Windows.Forms.Label texto_id;
        private ControleEndereco controleUsEndereco;
    }
}