
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
            this.mk_id = new System.Windows.Forms.MaskedTextBox();
            this.texto_id = new System.Windows.Forms.Label();
            this.controleUsEndereco = new BancoDadosZe.ControleEndereco();
            this.listBoxAreaFornecedor = new System.Windows.Forms.ListBox();
            this.listBoxAreasInicio = new System.Windows.Forms.ListBox();
            this.textoListaAreaAtuacaoFinal = new System.Windows.Forms.Label();
            this.textoListaAreaAtuacaoInicio = new System.Windows.Forms.Label();
            this.mk_Ie = new System.Windows.Forms.MaskedTextBox();
            this.mk_email = new System.Windows.Forms.MaskedTextBox();
            this.mk_telefone = new System.Windows.Forms.MaskedTextBox();
            this.mk_contato = new System.Windows.Forms.MaskedTextBox();
            this.mk_razaoSocial = new System.Windows.Forms.MaskedTextBox();
            this.mk_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.mk_nomeFantasia = new System.Windows.Forms.MaskedTextBox();
            this.textoIE = new System.Windows.Forms.Label();
            this.textoEmail = new System.Windows.Forms.Label();
            this.textoContato = new System.Windows.Forms.Label();
            this.textoTelefone = new System.Windows.Forms.Label();
            this.textoRazaoSocial = new System.Windows.Forms.Label();
            this.textoCnpj = new System.Windows.Forms.Label();
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
            this.panelFundo.Size = new System.Drawing.Size(816, 565);
            this.panelFundo.TabIndex = 1;
            // 
            // panelFormulario
            // 
            this.panelFormulario.Controls.Add(this.mk_id);
            this.panelFormulario.Controls.Add(this.texto_id);
            this.panelFormulario.Controls.Add(this.controleUsEndereco);
            this.panelFormulario.Controls.Add(this.listBoxAreaFornecedor);
            this.panelFormulario.Controls.Add(this.listBoxAreasInicio);
            this.panelFormulario.Controls.Add(this.textoListaAreaAtuacaoFinal);
            this.panelFormulario.Controls.Add(this.textoListaAreaAtuacaoInicio);
            this.panelFormulario.Controls.Add(this.mk_Ie);
            this.panelFormulario.Controls.Add(this.mk_email);
            this.panelFormulario.Controls.Add(this.mk_telefone);
            this.panelFormulario.Controls.Add(this.mk_contato);
            this.panelFormulario.Controls.Add(this.mk_razaoSocial);
            this.panelFormulario.Controls.Add(this.mk_cnpj);
            this.panelFormulario.Controls.Add(this.mk_nomeFantasia);
            this.panelFormulario.Controls.Add(this.textoIE);
            this.panelFormulario.Controls.Add(this.textoEmail);
            this.panelFormulario.Controls.Add(this.textoContato);
            this.panelFormulario.Controls.Add(this.textoTelefone);
            this.panelFormulario.Controls.Add(this.textoRazaoSocial);
            this.panelFormulario.Controls.Add(this.textoCnpj);
            this.panelFormulario.Controls.Add(this.textoNomeFantasia);
            this.panelFormulario.Location = new System.Drawing.Point(8, 14);
            this.panelFormulario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(797, 540);
            this.panelFormulario.TabIndex = 2;
            // 
            // mk_id
            // 
            this.mk_id.Enabled = false;
            this.mk_id.Location = new System.Drawing.Point(584, 117);
            this.mk_id.Name = "mk_id";
            this.mk_id.Size = new System.Drawing.Size(64, 22);
            this.mk_id.TabIndex = 107;
            this.mk_id.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // texto_id
            // 
            this.texto_id.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_id.Location = new System.Drawing.Point(511, 117);
            this.texto_id.Name = "texto_id";
            this.texto_id.Size = new System.Drawing.Size(67, 20);
            this.texto_id.TabIndex = 106;
            this.texto_id.Text = "Id";
            this.texto_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // controleUsEndereco
            // 
            this.controleUsEndereco.Location = new System.Drawing.Point(32, 278);
            this.controleUsEndereco.Name = "controleUsEndereco";
            this.controleUsEndereco.Size = new System.Drawing.Size(740, 204);
            this.controleUsEndereco.TabIndex = 105;
            // 
            // listBoxAreaFornecedor
            // 
            this.listBoxAreaFornecedor.FormattingEnabled = true;
            this.listBoxAreaFornecedor.ItemHeight = 16;
            this.listBoxAreaFornecedor.Location = new System.Drawing.Point(459, 188);
            this.listBoxAreaFornecedor.Name = "listBoxAreaFornecedor";
            this.listBoxAreaFornecedor.Size = new System.Drawing.Size(268, 84);
            this.listBoxAreaFornecedor.TabIndex = 104;
            this.listBoxAreaFornecedor.SelectedIndexChanged += new System.EventHandler(this.ListBoxAreaFornecedor_SelectedIndexChanged);
            // 
            // listBoxAreasInicio
            // 
            this.listBoxAreasInicio.FormattingEnabled = true;
            this.listBoxAreasInicio.ItemHeight = 16;
            this.listBoxAreasInicio.Location = new System.Drawing.Point(62, 188);
            this.listBoxAreasInicio.Name = "listBoxAreasInicio";
            this.listBoxAreasInicio.Size = new System.Drawing.Size(268, 84);
            this.listBoxAreasInicio.TabIndex = 102;
            this.listBoxAreasInicio.SelectedIndexChanged += new System.EventHandler(this.ListBoxAreasInicio_SelectedIndexChanged);
            // 
            // textoListaAreaAtuacaoFinal
            // 
            this.textoListaAreaAtuacaoFinal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoListaAreaAtuacaoFinal.Location = new System.Drawing.Point(456, 154);
            this.textoListaAreaAtuacaoFinal.Name = "textoListaAreaAtuacaoFinal";
            this.textoListaAreaAtuacaoFinal.Size = new System.Drawing.Size(271, 20);
            this.textoListaAreaAtuacaoFinal.TabIndex = 101;
            this.textoListaAreaAtuacaoFinal.Text = "Area atuação Fornecedor";
            this.textoListaAreaAtuacaoFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textoListaAreaAtuacaoInicio
            // 
            this.textoListaAreaAtuacaoInicio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoListaAreaAtuacaoInicio.Location = new System.Drawing.Point(62, 154);
            this.textoListaAreaAtuacaoInicio.Name = "textoListaAreaAtuacaoInicio";
            this.textoListaAreaAtuacaoInicio.Size = new System.Drawing.Size(256, 20);
            this.textoListaAreaAtuacaoInicio.TabIndex = 100;
            this.textoListaAreaAtuacaoInicio.Text = "Area atuação Cadastrada";
            this.textoListaAreaAtuacaoInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mk_Ie
            // 
            this.mk_Ie.Location = new System.Drawing.Point(199, 117);
            this.mk_Ie.Name = "mk_Ie";
            this.mk_Ie.Size = new System.Drawing.Size(181, 22);
            this.mk_Ie.TabIndex = 96;
            this.mk_Ie.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mk_email
            // 
            this.mk_email.Location = new System.Drawing.Point(584, 82);
            this.mk_email.Name = "mk_email";
            this.mk_email.Size = new System.Drawing.Size(188, 22);
            this.mk_email.TabIndex = 99;
            this.mk_email.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mk_telefone
            // 
            this.mk_telefone.Location = new System.Drawing.Point(584, 46);
            this.mk_telefone.Mask = "(999) 9000-0000";
            this.mk_telefone.Name = "mk_telefone";
            this.mk_telefone.Size = new System.Drawing.Size(188, 22);
            this.mk_telefone.TabIndex = 98;
            this.mk_telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mk_contato
            // 
            this.mk_contato.Location = new System.Drawing.Point(584, 10);
            this.mk_contato.Name = "mk_contato";
            this.mk_contato.Size = new System.Drawing.Size(188, 22);
            this.mk_contato.TabIndex = 97;
            this.mk_contato.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mk_razaoSocial
            // 
            this.mk_razaoSocial.Location = new System.Drawing.Point(199, 81);
            this.mk_razaoSocial.Name = "mk_razaoSocial";
            this.mk_razaoSocial.Size = new System.Drawing.Size(247, 22);
            this.mk_razaoSocial.TabIndex = 95;
            this.mk_razaoSocial.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mk_cnpj
            // 
            this.mk_cnpj.Location = new System.Drawing.Point(179, 47);
            this.mk_cnpj.Mask = "00.000.000/00-0000";
            this.mk_cnpj.Name = "mk_cnpj";
            this.mk_cnpj.Size = new System.Drawing.Size(151, 22);
            this.mk_cnpj.TabIndex = 94;
            this.mk_cnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mk_nomeFantasia
            // 
            this.mk_nomeFantasia.Location = new System.Drawing.Point(179, 10);
            this.mk_nomeFantasia.Name = "mk_nomeFantasia";
            this.mk_nomeFantasia.Size = new System.Drawing.Size(247, 22);
            this.mk_nomeFantasia.TabIndex = 93;
            this.mk_nomeFantasia.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textoIE
            // 
            this.textoIE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoIE.Location = new System.Drawing.Point(126, 117);
            this.textoIE.Name = "textoIE";
            this.textoIE.Size = new System.Drawing.Size(67, 20);
            this.textoIE.TabIndex = 90;
            this.textoIE.Text = "IE";
            this.textoIE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoEmail
            // 
            this.textoEmail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoEmail.Location = new System.Drawing.Point(466, 83);
            this.textoEmail.Name = "textoEmail";
            this.textoEmail.Size = new System.Drawing.Size(112, 20);
            this.textoEmail.TabIndex = 61;
            this.textoEmail.Text = "Email";
            this.textoEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // FormFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 565);
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
        private System.Windows.Forms.Label textoContato;
        private System.Windows.Forms.Label textoTelefone;
        private System.Windows.Forms.Label textoRazaoSocial;
        private System.Windows.Forms.Label textoCnpj;
        private System.Windows.Forms.Label textoNomeFantasia;
        private System.Windows.Forms.Label textoIE;
        private System.Windows.Forms.MaskedTextBox mk_nomeFantasia;
        private System.Windows.Forms.MaskedTextBox mk_cnpj;
        private System.Windows.Forms.MaskedTextBox mk_razaoSocial;
        private System.Windows.Forms.MaskedTextBox mk_contato;
        private System.Windows.Forms.MaskedTextBox mk_email;
        private System.Windows.Forms.MaskedTextBox mk_telefone;
        private System.Windows.Forms.MaskedTextBox mk_Ie;
        private System.Windows.Forms.ListBox listBoxAreaFornecedor;
        private System.Windows.Forms.ListBox listBoxAreasInicio;
        private System.Windows.Forms.Label textoListaAreaAtuacaoFinal;
        private System.Windows.Forms.Label textoListaAreaAtuacaoInicio;
        private ControleEndereco controleUsEndereco;
        private System.Windows.Forms.MaskedTextBox mk_id;
        private System.Windows.Forms.Label texto_id;
    }
}