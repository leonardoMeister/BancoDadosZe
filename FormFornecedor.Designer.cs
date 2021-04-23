
namespace BancoDadosZe
{
    partial class FormFornecedor
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
            this.panelFundo = new System.Windows.Forms.Panel();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.combobox1 = new System.Windows.Forms.ComboBox();
            this.textoEndereco = new System.Windows.Forms.Label();
            this.textoEmail = new System.Windows.Forms.Label();
            this.textoAtuacao = new System.Windows.Forms.Label();
            this.textoContato = new System.Windows.Forms.Label();
            this.textoTelefone = new System.Windows.Forms.Label();
            this.textoRazaoSocial = new System.Windows.Forms.Label();
            this.textoCnpj = new System.Windows.Forms.Label();
            this.textoNomeFantasia = new System.Windows.Forms.Label();
            this.mk_nomeFantasia = new System.Windows.Forms.MaskedTextBox();
            this.mk_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.mk_razaoSocial = new System.Windows.Forms.MaskedTextBox();
            this.mk_contato = new System.Windows.Forms.MaskedTextBox();
            this.mk_telefone = new System.Windows.Forms.MaskedTextBox();
            this.mk_email = new System.Windows.Forms.MaskedTextBox();
            this.mk_enderecoFisico = new System.Windows.Forms.MaskedTextBox();
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
            this.panelFundo.Size = new System.Drawing.Size(816, 268);
            this.panelFundo.TabIndex = 1;
            // 
            // panelFormulario
            // 
            this.panelFormulario.Controls.Add(this.mk_enderecoFisico);
            this.panelFormulario.Controls.Add(this.mk_email);
            this.panelFormulario.Controls.Add(this.mk_telefone);
            this.panelFormulario.Controls.Add(this.mk_contato);
            this.panelFormulario.Controls.Add(this.mk_razaoSocial);
            this.panelFormulario.Controls.Add(this.mk_cnpj);
            this.panelFormulario.Controls.Add(this.mk_nomeFantasia);
            this.panelFormulario.Controls.Add(this.combobox1);
            this.panelFormulario.Controls.Add(this.textoEndereco);
            this.panelFormulario.Controls.Add(this.textoEmail);
            this.panelFormulario.Controls.Add(this.textoAtuacao);
            this.panelFormulario.Controls.Add(this.textoContato);
            this.panelFormulario.Controls.Add(this.textoTelefone);
            this.panelFormulario.Controls.Add(this.textoRazaoSocial);
            this.panelFormulario.Controls.Add(this.textoCnpj);
            this.panelFormulario.Controls.Add(this.textoNomeFantasia);
            this.panelFormulario.Location = new System.Drawing.Point(8, 14);
            this.panelFormulario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(797, 250);
            this.panelFormulario.TabIndex = 2;
            // 
            // combobox1
            // 
            this.combobox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox1.FormattingEnabled = true;
            this.combobox1.Items.AddRange(new object[] {
            "Generos Alimentos",
            "Ropas",
            "Tecnologia"});
            this.combobox1.Location = new System.Drawing.Point(199, 114);
            this.combobox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combobox1.Name = "combobox1";
            this.combobox1.Size = new System.Drawing.Size(184, 24);
            this.combobox1.TabIndex = 92;
            this.combobox1.TabStop = false;
            // 
            // textoEndereco
            // 
            this.textoEndereco.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoEndereco.Location = new System.Drawing.Point(16, 153);
            this.textoEndereco.Name = "textoEndereco";
            this.textoEndereco.Size = new System.Drawing.Size(177, 20);
            this.textoEndereco.TabIndex = 90;
            this.textoEndereco.Text = "Endereço Fisíco";
            this.textoEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoEmail
            // 
            this.textoEmail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoEmail.Location = new System.Drawing.Point(389, 118);
            this.textoEmail.Name = "textoEmail";
            this.textoEmail.Size = new System.Drawing.Size(112, 20);
            this.textoEmail.TabIndex = 61;
            this.textoEmail.Text = "Email";
            this.textoEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoAtuacao
            // 
            this.textoAtuacao.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoAtuacao.Location = new System.Drawing.Point(5, 116);
            this.textoAtuacao.Name = "textoAtuacao";
            this.textoAtuacao.Size = new System.Drawing.Size(188, 23);
            this.textoAtuacao.TabIndex = 59;
            this.textoAtuacao.Text = "Áreas De Atuação";
            this.textoAtuacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoContato
            // 
            this.textoContato.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoContato.Location = new System.Drawing.Point(456, 10);
            this.textoContato.Name = "textoContato";
            this.textoContato.Size = new System.Drawing.Size(122, 21);
            this.textoContato.TabIndex = 57;
            this.textoContato.Text = "Contato";
            this.textoContato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoTelefone
            // 
            this.textoTelefone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTelefone.Location = new System.Drawing.Point(456, 46);
            this.textoTelefone.Name = "textoTelefone";
            this.textoTelefone.Size = new System.Drawing.Size(122, 22);
            this.textoTelefone.TabIndex = 55;
            this.textoTelefone.Text = "Telefone";
            this.textoTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoRazaoSocial
            // 
            this.textoRazaoSocial.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoRazaoSocial.Location = new System.Drawing.Point(20, 81);
            this.textoRazaoSocial.Name = "textoRazaoSocial";
            this.textoRazaoSocial.Size = new System.Drawing.Size(173, 22);
            this.textoRazaoSocial.TabIndex = 52;
            this.textoRazaoSocial.Text = "Razão Social";
            this.textoRazaoSocial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoCnpj
            // 
            this.textoCnpj.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCnpj.Location = new System.Drawing.Point(76, 46);
            this.textoCnpj.Name = "textoCnpj";
            this.textoCnpj.Size = new System.Drawing.Size(97, 22);
            this.textoCnpj.TabIndex = 50;
            this.textoCnpj.Text = "CNPJ";
            this.textoCnpj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoNomeFantasia
            // 
            this.textoNomeFantasia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNomeFantasia.Location = new System.Drawing.Point(5, 9);
            this.textoNomeFantasia.Name = "textoNomeFantasia";
            this.textoNomeFantasia.Size = new System.Drawing.Size(168, 22);
            this.textoNomeFantasia.TabIndex = 46;
            this.textoNomeFantasia.Text = "Nome Fantasia";
            this.textoNomeFantasia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mk_nomeFantasia
            // 
            this.mk_nomeFantasia.Location = new System.Drawing.Point(179, 10);
            this.mk_nomeFantasia.Name = "mk_nomeFantasia";
            this.mk_nomeFantasia.Size = new System.Drawing.Size(247, 22);
            this.mk_nomeFantasia.TabIndex = 93;
            // 
            // mk_cnpj
            // 
            this.mk_cnpj.Location = new System.Drawing.Point(179, 47);
            this.mk_cnpj.Mask = "00.000.000/00-0000";
            this.mk_cnpj.Name = "mk_cnpj";
            this.mk_cnpj.Size = new System.Drawing.Size(151, 22);
            this.mk_cnpj.TabIndex = 94;
            // 
            // mk_razaoSocial
            // 
            this.mk_razaoSocial.Location = new System.Drawing.Point(199, 81);
            this.mk_razaoSocial.Name = "mk_razaoSocial";
            this.mk_razaoSocial.Size = new System.Drawing.Size(247, 22);
            this.mk_razaoSocial.TabIndex = 95;
            // 
            // mk_contato
            // 
            this.mk_contato.Location = new System.Drawing.Point(584, 10);
            this.mk_contato.Name = "mk_contato";
            this.mk_contato.Size = new System.Drawing.Size(188, 22);
            this.mk_contato.TabIndex = 96;
            // 
            // mk_telefone
            // 
            this.mk_telefone.Location = new System.Drawing.Point(584, 46);
            this.mk_telefone.Mask = "(999) 9000-0000";
            this.mk_telefone.Name = "mk_telefone";
            this.mk_telefone.Size = new System.Drawing.Size(188, 22);
            this.mk_telefone.TabIndex = 97;
            // 
            // mk_email
            // 
            this.mk_email.Location = new System.Drawing.Point(507, 117);
            this.mk_email.Name = "mk_email";
            this.mk_email.Size = new System.Drawing.Size(188, 22);
            this.mk_email.TabIndex = 98;
            // 
            // mk_enderecoFisico
            // 
            this.mk_enderecoFisico.Location = new System.Drawing.Point(199, 153);
            this.mk_enderecoFisico.Name = "mk_enderecoFisico";
            this.mk_enderecoFisico.Size = new System.Drawing.Size(291, 22);
            this.mk_enderecoFisico.TabIndex = 99;
            // 
            // FormFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 268);
            this.Controls.Add(this.panelFundo);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Fornecedores";
            this.panelFundo.ResumeLayout(false);
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Label textoEmail;
        private System.Windows.Forms.Label textoAtuacao;
        private System.Windows.Forms.Label textoContato;
        private System.Windows.Forms.Label textoTelefone;
        private System.Windows.Forms.Label textoRazaoSocial;
        private System.Windows.Forms.Label textoCnpj;
        private System.Windows.Forms.Label textoNomeFantasia;
        private System.Windows.Forms.Label textoEndereco;
        private System.Windows.Forms.ComboBox combobox1;
        private System.Windows.Forms.MaskedTextBox mk_nomeFantasia;
        private System.Windows.Forms.MaskedTextBox mk_cnpj;
        private System.Windows.Forms.MaskedTextBox mk_razaoSocial;
        private System.Windows.Forms.MaskedTextBox mk_contato;
        private System.Windows.Forms.MaskedTextBox mk_email;
        private System.Windows.Forms.MaskedTextBox mk_telefone;
        private System.Windows.Forms.MaskedTextBox mk_enderecoFisico;
    }
}