
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
            this.mk_pais = new System.Windows.Forms.MaskedTextBox();
            this.mk_numero = new System.Windows.Forms.MaskedTextBox();
            this.mk_rua = new System.Windows.Forms.MaskedTextBox();
            this.mk_bairro = new System.Windows.Forms.MaskedTextBox();
            this.mk_cidade = new System.Windows.Forms.MaskedTextBox();
            this.mk_cep = new System.Windows.Forms.MaskedTextBox();
            this.mk_email = new System.Windows.Forms.MaskedTextBox();
            this.mk_data = new System.Windows.Forms.MaskedTextBox();
            this.mk_telefone = new System.Windows.Forms.MaskedTextBox();
            this.mk_gerente = new System.Windows.Forms.MaskedTextBox();
            this.mk_razaoSocial = new System.Windows.Forms.MaskedTextBox();
            this.mk_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.mk_nomeFantasia = new System.Windows.Forms.MaskedTextBox();
            this.campoComplemento = new System.Windows.Forms.TextBox();
            this.textoBairro = new System.Windows.Forms.Label();
            this.textoRua = new System.Windows.Forms.Label();
            this.textoNumero = new System.Windows.Forms.Label();
            this.textoComplemento = new System.Windows.Forms.Label();
            this.textoCep = new System.Windows.Forms.Label();
            this.textoCidade = new System.Windows.Forms.Label();
            this.textoPais = new System.Windows.Forms.Label();
            this.textoEndereco = new System.Windows.Forms.Label();
            this.textoEmail = new System.Windows.Forms.Label();
            this.textoGerente = new System.Windows.Forms.Label();
            this.textoData = new System.Windows.Forms.Label();
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
            this.panelFundo.Size = new System.Drawing.Size(821, 367);
            this.panelFundo.TabIndex = 1;
            // 
            // panelFormulario
            // 
            this.panelFormulario.Controls.Add(this.mk_pais);
            this.panelFormulario.Controls.Add(this.mk_numero);
            this.panelFormulario.Controls.Add(this.mk_rua);
            this.panelFormulario.Controls.Add(this.mk_bairro);
            this.panelFormulario.Controls.Add(this.mk_cidade);
            this.panelFormulario.Controls.Add(this.mk_cep);
            this.panelFormulario.Controls.Add(this.mk_email);
            this.panelFormulario.Controls.Add(this.mk_data);
            this.panelFormulario.Controls.Add(this.mk_telefone);
            this.panelFormulario.Controls.Add(this.mk_gerente);
            this.panelFormulario.Controls.Add(this.mk_razaoSocial);
            this.panelFormulario.Controls.Add(this.mk_cnpj);
            this.panelFormulario.Controls.Add(this.mk_nomeFantasia);
            this.panelFormulario.Controls.Add(this.campoComplemento);
            this.panelFormulario.Controls.Add(this.textoBairro);
            this.panelFormulario.Controls.Add(this.textoRua);
            this.panelFormulario.Controls.Add(this.textoNumero);
            this.panelFormulario.Controls.Add(this.textoComplemento);
            this.panelFormulario.Controls.Add(this.textoCep);
            this.panelFormulario.Controls.Add(this.textoCidade);
            this.panelFormulario.Controls.Add(this.textoPais);
            this.panelFormulario.Controls.Add(this.textoEndereco);
            this.panelFormulario.Controls.Add(this.textoEmail);
            this.panelFormulario.Controls.Add(this.textoGerente);
            this.panelFormulario.Controls.Add(this.textoData);
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
            this.panelFormulario.Size = new System.Drawing.Size(797, 347);
            this.panelFormulario.TabIndex = 2;
            // 
            // mk_pais
            // 
            this.mk_pais.Location = new System.Drawing.Point(515, 202);
            this.mk_pais.Name = "mk_pais";
            this.mk_pais.Size = new System.Drawing.Size(178, 22);
            this.mk_pais.TabIndex = 95;
            // 
            // mk_numero
            // 
            this.mk_numero.Location = new System.Drawing.Point(515, 176);
            this.mk_numero.Mask = "900000";
            this.mk_numero.Name = "mk_numero";
            this.mk_numero.Size = new System.Drawing.Size(65, 22);
            this.mk_numero.TabIndex = 94;
            this.mk_numero.ValidatingType = typeof(int);
            // 
            // mk_rua
            // 
            this.mk_rua.Location = new System.Drawing.Point(131, 263);
            this.mk_rua.Name = "mk_rua";
            this.mk_rua.Size = new System.Drawing.Size(212, 22);
            this.mk_rua.TabIndex = 93;
            // 
            // mk_bairro
            // 
            this.mk_bairro.Location = new System.Drawing.Point(131, 231);
            this.mk_bairro.Name = "mk_bairro";
            this.mk_bairro.Size = new System.Drawing.Size(212, 22);
            this.mk_bairro.TabIndex = 92;
            // 
            // mk_cidade
            // 
            this.mk_cidade.Location = new System.Drawing.Point(133, 200);
            this.mk_cidade.Name = "mk_cidade";
            this.mk_cidade.Size = new System.Drawing.Size(212, 22);
            this.mk_cidade.TabIndex = 91;
            // 
            // mk_cep
            // 
            this.mk_cep.Location = new System.Drawing.Point(131, 172);
            this.mk_cep.Mask = "00000000";
            this.mk_cep.Name = "mk_cep";
            this.mk_cep.Size = new System.Drawing.Size(77, 22);
            this.mk_cep.TabIndex = 90;
            // 
            // mk_email
            // 
            this.mk_email.Location = new System.Drawing.Point(499, 118);
            this.mk_email.Name = "mk_email";
            this.mk_email.Size = new System.Drawing.Size(178, 22);
            this.mk_email.TabIndex = 89;
            // 
            // mk_data
            // 
            this.mk_data.Location = new System.Drawing.Point(563, 82);
            this.mk_data.Mask = "00/00/0000";
            this.mk_data.Name = "mk_data";
            this.mk_data.Size = new System.Drawing.Size(178, 22);
            this.mk_data.TabIndex = 88;
            this.mk_data.ValidatingType = typeof(System.DateTime);
            // 
            // mk_telefone
            // 
            this.mk_telefone.Location = new System.Drawing.Point(539, 50);
            this.mk_telefone.Mask = "(999) 9000-0000";
            this.mk_telefone.Name = "mk_telefone";
            this.mk_telefone.Size = new System.Drawing.Size(109, 22);
            this.mk_telefone.TabIndex = 87;
            // 
            // mk_gerente
            // 
            this.mk_gerente.Location = new System.Drawing.Point(165, 116);
            this.mk_gerente.Name = "mk_gerente";
            this.mk_gerente.Size = new System.Drawing.Size(178, 22);
            this.mk_gerente.TabIndex = 86;
            // 
            // mk_razaoSocial
            // 
            this.mk_razaoSocial.Location = new System.Drawing.Point(165, 81);
            this.mk_razaoSocial.Name = "mk_razaoSocial";
            this.mk_razaoSocial.Size = new System.Drawing.Size(178, 22);
            this.mk_razaoSocial.TabIndex = 85;
            // 
            // mk_cnpj
            // 
            this.mk_cnpj.Location = new System.Drawing.Point(165, 46);
            this.mk_cnpj.Mask = "000.000.000-00";
            this.mk_cnpj.Name = "mk_cnpj";
            this.mk_cnpj.Size = new System.Drawing.Size(178, 22);
            this.mk_cnpj.TabIndex = 84;
            // 
            // mk_nomeFantasia
            // 
            this.mk_nomeFantasia.Location = new System.Drawing.Point(165, 9);
            this.mk_nomeFantasia.Name = "mk_nomeFantasia";
            this.mk_nomeFantasia.Size = new System.Drawing.Size(178, 22);
            this.mk_nomeFantasia.TabIndex = 83;
            // 
            // campoComplemento
            // 
            this.campoComplemento.Location = new System.Drawing.Point(515, 234);
            this.campoComplemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.campoComplemento.Multiline = true;
            this.campoComplemento.Name = "campoComplemento";
            this.campoComplemento.Size = new System.Drawing.Size(244, 58);
            this.campoComplemento.TabIndex = 14;
            // 
            // textoBairro
            // 
            this.textoBairro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoBairro.Location = new System.Drawing.Point(52, 231);
            this.textoBairro.Name = "textoBairro";
            this.textoBairro.Size = new System.Drawing.Size(73, 22);
            this.textoBairro.TabIndex = 82;
            this.textoBairro.Text = "Bairro";
            this.textoBairro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoRua
            // 
            this.textoRua.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoRua.Location = new System.Drawing.Point(76, 262);
            this.textoRua.Name = "textoRua";
            this.textoRua.Size = new System.Drawing.Size(49, 22);
            this.textoRua.TabIndex = 76;
            this.textoRua.Text = "Rua";
            this.textoRua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoNumero
            // 
            this.textoNumero.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNumero.Location = new System.Drawing.Point(420, 174);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(89, 22);
            this.textoNumero.TabIndex = 77;
            this.textoNumero.Text = "Número";
            this.textoNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoComplemento
            // 
            this.textoComplemento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoComplemento.Location = new System.Drawing.Point(380, 234);
            this.textoComplemento.Name = "textoComplemento";
            this.textoComplemento.Size = new System.Drawing.Size(129, 22);
            this.textoComplemento.TabIndex = 78;
            this.textoComplemento.Text = "Complemento";
            this.textoComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoCep
            // 
            this.textoCep.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCep.Location = new System.Drawing.Point(77, 172);
            this.textoCep.Name = "textoCep";
            this.textoCep.Size = new System.Drawing.Size(48, 22);
            this.textoCep.TabIndex = 79;
            this.textoCep.Text = "Cep";
            this.textoCep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoCidade
            // 
            this.textoCidade.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCidade.Location = new System.Drawing.Point(48, 201);
            this.textoCidade.Name = "textoCidade";
            this.textoCidade.Size = new System.Drawing.Size(79, 22);
            this.textoCidade.TabIndex = 80;
            this.textoCidade.Text = "Cidade";
            this.textoCidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoPais
            // 
            this.textoPais.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoPais.Location = new System.Drawing.Point(456, 202);
            this.textoPais.Name = "textoPais";
            this.textoPais.Size = new System.Drawing.Size(53, 22);
            this.textoPais.TabIndex = 81;
            this.textoPais.Text = "Pais";
            this.textoPais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoEndereco
            // 
            this.textoEndereco.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoEndereco.Location = new System.Drawing.Point(22, 146);
            this.textoEndereco.Name = "textoEndereco";
            this.textoEndereco.Size = new System.Drawing.Size(109, 22);
            this.textoEndereco.TabIndex = 63;
            this.textoEndereco.Text = "Endereço:";
            this.textoEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoEmail
            // 
            this.textoEmail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoEmail.Location = new System.Drawing.Point(432, 117);
            this.textoEmail.Name = "textoEmail";
            this.textoEmail.Size = new System.Drawing.Size(65, 22);
            this.textoEmail.TabIndex = 61;
            this.textoEmail.Text = "Email";
            this.textoEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoGerente
            // 
            this.textoGerente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoGerente.Location = new System.Drawing.Point(34, 115);
            this.textoGerente.Name = "textoGerente";
            this.textoGerente.Size = new System.Drawing.Size(91, 22);
            this.textoGerente.TabIndex = 59;
            this.textoGerente.Text = "Gerente";
            this.textoGerente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoData
            // 
            this.textoData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoData.Location = new System.Drawing.Point(500, 81);
            this.textoData.Name = "textoData";
            this.textoData.Size = new System.Drawing.Size(57, 22);
            this.textoData.TabIndex = 57;
            this.textoData.Text = "Data";
            this.textoData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.ClientSize = new System.Drawing.Size(821, 367);
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
        private System.Windows.Forms.TextBox campoComplemento;
        private System.Windows.Forms.Label textoBairro;
        private System.Windows.Forms.Label textoRua;
        private System.Windows.Forms.Label textoNumero;
        private System.Windows.Forms.Label textoComplemento;
        private System.Windows.Forms.Label textoCep;
        private System.Windows.Forms.Label textoCidade;
        private System.Windows.Forms.Label textoPais;
        private System.Windows.Forms.Label textoEndereco;
        private System.Windows.Forms.Label textoEmail;
        private System.Windows.Forms.Label textoGerente;
        private System.Windows.Forms.Label textoData;
        private System.Windows.Forms.Label textoTelefone;
        private System.Windows.Forms.Label textoRazaoSocial;
        private System.Windows.Forms.Label textoCnpj;
        private System.Windows.Forms.RadioButton radioButtonMatriz;
        private System.Windows.Forms.RadioButton radioButtonFilial;
        private System.Windows.Forms.Label textoTipo;
        private System.Windows.Forms.Label textoNomeFantasia;
        private System.Windows.Forms.MaskedTextBox mk_pais;
        private System.Windows.Forms.MaskedTextBox mk_numero;
        private System.Windows.Forms.MaskedTextBox mk_rua;
        private System.Windows.Forms.MaskedTextBox mk_bairro;
        private System.Windows.Forms.MaskedTextBox mk_cidade;
        private System.Windows.Forms.MaskedTextBox mk_cep;
        private System.Windows.Forms.MaskedTextBox mk_email;
        private System.Windows.Forms.MaskedTextBox mk_data;
        private System.Windows.Forms.MaskedTextBox mk_telefone;
        private System.Windows.Forms.MaskedTextBox mk_gerente;
        private System.Windows.Forms.MaskedTextBox mk_razaoSocial;
        private System.Windows.Forms.MaskedTextBox mk_cnpj;
        private System.Windows.Forms.MaskedTextBox mk_nomeFantasia;
    }
}