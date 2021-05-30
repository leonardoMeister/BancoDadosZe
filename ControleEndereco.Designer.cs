
namespace BancoDadosZe
{
    partial class ControleEndereco
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
            this.grupEndereco = new System.Windows.Forms.GroupBox();
            this.textoId = new System.Windows.Forms.Label();
            this.mk_id = new System.Windows.Forms.MaskedTextBox();
            this.mk_logradouro = new System.Windows.Forms.MaskedTextBox();
            this.textLogradouro = new System.Windows.Forms.Label();
            this.textoEstado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.textoBairro = new System.Windows.Forms.Label();
            this.textoCidade = new System.Windows.Forms.Label();
            this.mk_numero = new System.Windows.Forms.MaskedTextBox();
            this.textoCep = new System.Windows.Forms.Label();
            this.campoComplemento = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.Label();
            this.textoComplemento = new System.Windows.Forms.Label();
            this.textoPais = new System.Windows.Forms.Label();
            this.mk_bairro = new System.Windows.Forms.MaskedTextBox();
            this.mk_cep = new System.Windows.Forms.MaskedTextBox();
            this.mk_cidade = new System.Windows.Forms.MaskedTextBox();
            this.grupEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupEndereco
            // 
            this.grupEndereco.Controls.Add(this.textoId);
            this.grupEndereco.Controls.Add(this.mk_id);
            this.grupEndereco.Controls.Add(this.mk_logradouro);
            this.grupEndereco.Controls.Add(this.textLogradouro);
            this.grupEndereco.Controls.Add(this.textoEstado);
            this.grupEndereco.Controls.Add(this.comboBoxEstado);
            this.grupEndereco.Controls.Add(this.comboBoxPais);
            this.grupEndereco.Controls.Add(this.textoBairro);
            this.grupEndereco.Controls.Add(this.textoCidade);
            this.grupEndereco.Controls.Add(this.mk_numero);
            this.grupEndereco.Controls.Add(this.textoCep);
            this.grupEndereco.Controls.Add(this.campoComplemento);
            this.grupEndereco.Controls.Add(this.textoNumero);
            this.grupEndereco.Controls.Add(this.textoComplemento);
            this.grupEndereco.Controls.Add(this.textoPais);
            this.grupEndereco.Controls.Add(this.mk_bairro);
            this.grupEndereco.Controls.Add(this.mk_cep);
            this.grupEndereco.Controls.Add(this.mk_cidade);
            this.grupEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grupEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grupEndereco.Location = new System.Drawing.Point(0, 0);
            this.grupEndereco.Name = "grupEndereco";
            this.grupEndereco.Size = new System.Drawing.Size(740, 204);
            this.grupEndereco.TabIndex = 0;
            this.grupEndereco.TabStop = false;
            this.grupEndereco.Text = "Endereço";
            // 
            // textoId
            // 
            this.textoId.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoId.Location = new System.Drawing.Point(13, 157);
            this.textoId.Name = "textoId";
            this.textoId.Size = new System.Drawing.Size(73, 22);
            this.textoId.TabIndex = 118;
            this.textoId.Text = "Id";
            this.textoId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mk_id
            // 
            this.mk_id.Enabled = false;
            this.mk_id.Location = new System.Drawing.Point(113, 157);
            this.mk_id.Name = "mk_id";
            this.mk_id.Size = new System.Drawing.Size(77, 22);
            this.mk_id.TabIndex = 119;
            this.mk_id.TabStop = false;
            this.mk_id.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mk_logradouro
            // 
            this.mk_logradouro.Location = new System.Drawing.Point(471, 157);
            this.mk_logradouro.Name = "mk_logradouro";
            this.mk_logradouro.Size = new System.Drawing.Size(186, 22);
            this.mk_logradouro.TabIndex = 8;
            this.mk_logradouro.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textLogradouro
            // 
            this.textLogradouro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLogradouro.Location = new System.Drawing.Point(346, 156);
            this.textLogradouro.Name = "textLogradouro";
            this.textLogradouro.Size = new System.Drawing.Size(119, 22);
            this.textLogradouro.TabIndex = 116;
            this.textLogradouro.Text = "Logradouro";
            this.textLogradouro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoEstado
            // 
            this.textoEstado.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoEstado.Location = new System.Drawing.Point(7, 58);
            this.textoEstado.Name = "textoEstado";
            this.textoEstado.Size = new System.Drawing.Size(79, 22);
            this.textoEstado.TabIndex = 115;
            this.textoEstado.Text = "Estado";
            this.textoEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Categoria 1",
            "Categoria 2",
            "Categoria 3",
            "Categoria 4"});
            this.comboBoxEstado.Location = new System.Drawing.Point(113, 59);
            this.comboBoxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(180, 24);
            this.comboBoxEstado.TabIndex = 2;
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Items.AddRange(new object[] {
            "Categoria 1",
            "Categoria 2",
            "Categoria 3",
            "Categoria 4"});
            this.comboBoxPais.Location = new System.Drawing.Point(471, 57);
            this.comboBoxPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(180, 24);
            this.comboBoxPais.TabIndex = 6;
            // 
            // textoBairro
            // 
            this.textoBairro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoBairro.Location = new System.Drawing.Point(13, 121);
            this.textoBairro.Name = "textoBairro";
            this.textoBairro.Size = new System.Drawing.Size(73, 22);
            this.textoBairro.TabIndex = 104;
            this.textoBairro.Text = "Bairro";
            this.textoBairro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoCidade
            // 
            this.textoCidade.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCidade.Location = new System.Drawing.Point(9, 91);
            this.textoCidade.Name = "textoCidade";
            this.textoCidade.Size = new System.Drawing.Size(79, 22);
            this.textoCidade.TabIndex = 102;
            this.textoCidade.Text = "Cidade";
            this.textoCidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mk_numero
            // 
            this.mk_numero.Location = new System.Drawing.Point(471, 30);
            this.mk_numero.Mask = "900000";
            this.mk_numero.Name = "mk_numero";
            this.mk_numero.Size = new System.Drawing.Size(65, 22);
            this.mk_numero.TabIndex = 5;
            this.mk_numero.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mk_numero.ValidatingType = typeof(int);
            // 
            // textoCep
            // 
            this.textoCep.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCep.Location = new System.Drawing.Point(38, 28);
            this.textoCep.Name = "textoCep";
            this.textoCep.Size = new System.Drawing.Size(48, 22);
            this.textoCep.TabIndex = 101;
            this.textoCep.Text = "Cep";
            this.textoCep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // campoComplemento
            // 
            this.campoComplemento.Location = new System.Drawing.Point(471, 88);
            this.campoComplemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.campoComplemento.Multiline = true;
            this.campoComplemento.Name = "campoComplemento";
            this.campoComplemento.Size = new System.Drawing.Size(231, 58);
            this.campoComplemento.TabIndex = 7;
            // 
            // textoNumero
            // 
            this.textoNumero.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNumero.Location = new System.Drawing.Point(376, 28);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(89, 22);
            this.textoNumero.TabIndex = 99;
            this.textoNumero.Text = "Número";
            this.textoNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoComplemento
            // 
            this.textoComplemento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoComplemento.Location = new System.Drawing.Point(336, 88);
            this.textoComplemento.Name = "textoComplemento";
            this.textoComplemento.Size = new System.Drawing.Size(129, 22);
            this.textoComplemento.TabIndex = 100;
            this.textoComplemento.Text = "Complemento";
            this.textoComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoPais
            // 
            this.textoPais.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoPais.Location = new System.Drawing.Point(412, 56);
            this.textoPais.Name = "textoPais";
            this.textoPais.Size = new System.Drawing.Size(53, 22);
            this.textoPais.TabIndex = 103;
            this.textoPais.Text = "Pais";
            this.textoPais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mk_bairro
            // 
            this.mk_bairro.Location = new System.Drawing.Point(113, 121);
            this.mk_bairro.Name = "mk_bairro";
            this.mk_bairro.Size = new System.Drawing.Size(212, 22);
            this.mk_bairro.TabIndex = 4;
            this.mk_bairro.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mk_cep
            // 
            this.mk_cep.Location = new System.Drawing.Point(113, 28);
            this.mk_cep.Mask = "00000000";
            this.mk_cep.Name = "mk_cep";
            this.mk_cep.Size = new System.Drawing.Size(77, 22);
            this.mk_cep.TabIndex = 1;
            this.mk_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mk_cidade
            // 
            this.mk_cidade.Location = new System.Drawing.Point(113, 90);
            this.mk_cidade.Name = "mk_cidade";
            this.mk_cidade.Size = new System.Drawing.Size(212, 22);
            this.mk_cidade.TabIndex = 3;
            this.mk_cidade.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // ControleEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grupEndereco);
            this.Name = "ControleEndereco";
            this.Size = new System.Drawing.Size(740, 204);
            this.grupEndereco.ResumeLayout(false);
            this.grupEndereco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupEndereco;
        public System.Windows.Forms.MaskedTextBox mk_logradouro;
        private System.Windows.Forms.Label textLogradouro;
        private System.Windows.Forms.Label textoEstado;
        public System.Windows.Forms.ComboBox comboBoxEstado;
        public System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.Label textoBairro;
        private System.Windows.Forms.Label textoCidade;
        public System.Windows.Forms.MaskedTextBox mk_numero;
        private System.Windows.Forms.Label textoCep;
        public System.Windows.Forms.TextBox campoComplemento;
        private System.Windows.Forms.Label textoNumero;
        private System.Windows.Forms.Label textoComplemento;
        private System.Windows.Forms.Label textoPais;
        public System.Windows.Forms.MaskedTextBox mk_bairro;
        public System.Windows.Forms.MaskedTextBox mk_cep;
        public System.Windows.Forms.MaskedTextBox mk_cidade;
        private System.Windows.Forms.Label textoId;
        public System.Windows.Forms.MaskedTextBox mk_id;
    }
}
