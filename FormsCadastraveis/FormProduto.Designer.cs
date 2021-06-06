
namespace BancoDadosZe
{
    partial class FormProduto
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
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.mk_quantidade = new System.Windows.Forms.MaskedTextBox();
            this.textoQuantidadeEstoque = new System.Windows.Forms.Label();
            this.mk_modelo = new System.Windows.Forms.MaskedTextBox();
            this.texto_modelo = new System.Windows.Forms.Label();
            this.comboArea = new System.Windows.Forms.ComboBox();
            this.textoArea = new System.Windows.Forms.Label();
            this.mk_nome = new System.Windows.Forms.MaskedTextBox();
            this.mk_Valor = new System.Windows.Forms.MaskedTextBox();
            this.userControl = new BancoDadosZe.ControleUsBTN();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.radioButtonInativo = new System.Windows.Forms.RadioButton();
            this.radioButtonAtivo = new System.Windows.Forms.RadioButton();
            this.textoStatus = new System.Windows.Forms.Label();
            this.textoMarca = new System.Windows.Forms.Label();
            this.campoDescricao = new System.Windows.Forms.TextBox();
            this.textoDescrição = new System.Windows.Forms.Label();
            this.textoNome = new System.Windows.Forms.Label();
            this.textoValor = new System.Windows.Forms.Label();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.panelFundo.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
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
            this.panelFundo.Size = new System.Drawing.Size(684, 357);
            this.panelFundo.TabIndex = 1;
            // 
            // panelFormulario
            // 
            this.panelFormulario.Controls.Add(this.mk_id);
            this.panelFormulario.Controls.Add(this.texto_id);
            this.panelFormulario.Controls.Add(this.pictureBoxImage);
            this.panelFormulario.Controls.Add(this.mk_quantidade);
            this.panelFormulario.Controls.Add(this.textoQuantidadeEstoque);
            this.panelFormulario.Controls.Add(this.mk_modelo);
            this.panelFormulario.Controls.Add(this.texto_modelo);
            this.panelFormulario.Controls.Add(this.comboArea);
            this.panelFormulario.Controls.Add(this.textoArea);
            this.panelFormulario.Controls.Add(this.mk_nome);
            this.panelFormulario.Controls.Add(this.mk_Valor);
            this.panelFormulario.Controls.Add(this.userControl);
            this.panelFormulario.Controls.Add(this.comboBoxMarca);
            this.panelFormulario.Controls.Add(this.radioButtonInativo);
            this.panelFormulario.Controls.Add(this.radioButtonAtivo);
            this.panelFormulario.Controls.Add(this.textoStatus);
            this.panelFormulario.Controls.Add(this.textoMarca);
            this.panelFormulario.Controls.Add(this.campoDescricao);
            this.panelFormulario.Controls.Add(this.textoDescrição);
            this.panelFormulario.Controls.Add(this.textoNome);
            this.panelFormulario.Controls.Add(this.textoValor);
            this.panelFormulario.Location = new System.Drawing.Point(7, 14);
            this.panelFormulario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(663, 332);
            this.panelFormulario.TabIndex = 2;
            // 
            // mk_id
            // 
            this.mk_id.Enabled = false;
            this.mk_id.Location = new System.Drawing.Point(471, 135);
            this.mk_id.Name = "mk_id";
            this.mk_id.Size = new System.Drawing.Size(67, 22);
            this.mk_id.TabIndex = 110;
            this.mk_id.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mk_id.ValidatingType = typeof(int);
            // 
            // texto_id
            // 
            this.texto_id.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_id.Location = new System.Drawing.Point(372, 133);
            this.texto_id.Name = "texto_id";
            this.texto_id.Size = new System.Drawing.Size(93, 24);
            this.texto_id.TabIndex = 109;
            this.texto_id.Text = "Id";
            this.texto_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImage.Image = global::BancoDadosZe.Properties.Resources.imagemApp;
            this.pictureBoxImage.Location = new System.Drawing.Point(433, 168);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(130, 98);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 108;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Click += new System.EventHandler(this.PictureBoxImage_Click);
            // 
            // mk_quantidade
            // 
            this.mk_quantidade.Location = new System.Drawing.Point(208, 215);
            this.mk_quantidade.Mask = "9990000";
            this.mk_quantidade.Name = "mk_quantidade";
            this.mk_quantidade.Size = new System.Drawing.Size(67, 22);
            this.mk_quantidade.TabIndex = 7;
            this.mk_quantidade.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mk_quantidade.ValidatingType = typeof(int);
            // 
            // textoQuantidadeEstoque
            // 
            this.textoQuantidadeEstoque.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoQuantidadeEstoque.Location = new System.Drawing.Point(8, 213);
            this.textoQuantidadeEstoque.Name = "textoQuantidadeEstoque";
            this.textoQuantidadeEstoque.Size = new System.Drawing.Size(194, 24);
            this.textoQuantidadeEstoque.TabIndex = 106;
            this.textoQuantidadeEstoque.Text = "Quantidade estoque";
            this.textoQuantidadeEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mk_modelo
            // 
            this.mk_modelo.Location = new System.Drawing.Point(104, 178);
            this.mk_modelo.Name = "mk_modelo";
            this.mk_modelo.Size = new System.Drawing.Size(200, 22);
            this.mk_modelo.TabIndex = 6;
            this.mk_modelo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // texto_modelo
            // 
            this.texto_modelo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_modelo.Location = new System.Drawing.Point(8, 176);
            this.texto_modelo.Name = "texto_modelo";
            this.texto_modelo.Size = new System.Drawing.Size(90, 24);
            this.texto_modelo.TabIndex = 104;
            this.texto_modelo.Text = "Modelo";
            this.texto_modelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboArea
            // 
            this.comboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboArea.FormattingEnabled = true;
            this.comboArea.Items.AddRange(new object[] {
            "Categoria 1",
            "Categoria 2",
            "Categoria 3",
            "Categoria 4"});
            this.comboArea.Location = new System.Drawing.Point(471, 94);
            this.comboArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboArea.Name = "comboArea";
            this.comboArea.Size = new System.Drawing.Size(180, 24);
            this.comboArea.TabIndex = 9;
            // 
            // textoArea
            // 
            this.textoArea.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoArea.Location = new System.Drawing.Point(382, 94);
            this.textoArea.Name = "textoArea";
            this.textoArea.Size = new System.Drawing.Size(83, 24);
            this.textoArea.TabIndex = 102;
            this.textoArea.Text = "Area";
            this.textoArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mk_nome
            // 
            this.mk_nome.Location = new System.Drawing.Point(104, 48);
            this.mk_nome.Name = "mk_nome";
            this.mk_nome.Size = new System.Drawing.Size(200, 22);
            this.mk_nome.TabIndex = 4;
            this.mk_nome.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mk_Valor
            // 
            this.mk_Valor.Location = new System.Drawing.Point(104, 6);
            this.mk_Valor.Mask = "9990000";
            this.mk_Valor.Name = "mk_Valor";
            this.mk_Valor.Size = new System.Drawing.Size(67, 22);
            this.mk_Valor.TabIndex = 3;
            this.mk_Valor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mk_Valor.ValidatingType = typeof(int);
            // 
            // userControl
            // 
            this.userControl.Location = new System.Drawing.Point(-51, 274);
            this.userControl.Margin = new System.Windows.Forms.Padding(5);
            this.userControl.Name = "userControl";
            this.userControl.Size = new System.Drawing.Size(702, 53);
            this.userControl.TabIndex = 12;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Items.AddRange(new object[] {
            "Categoria 1",
            "Categoria 2",
            "Categoria 3",
            "Categoria 4"});
            this.comboBoxMarca.Location = new System.Drawing.Point(471, 46);
            this.comboBoxMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(180, 24);
            this.comboBoxMarca.TabIndex = 8;
            // 
            // radioButtonInativo
            // 
            this.radioButtonInativo.AutoSize = true;
            this.radioButtonInativo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInativo.Location = new System.Drawing.Point(471, 6);
            this.radioButtonInativo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonInativo.Name = "radioButtonInativo";
            this.radioButtonInativo.Size = new System.Drawing.Size(74, 22);
            this.radioButtonInativo.TabIndex = 100;
            this.radioButtonInativo.Text = "Inativo";
            this.radioButtonInativo.UseVisualStyleBackColor = true;
            // 
            // radioButtonAtivo
            // 
            this.radioButtonAtivo.AutoSize = true;
            this.radioButtonAtivo.Checked = true;
            this.radioButtonAtivo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAtivo.Location = new System.Drawing.Point(387, 6);
            this.radioButtonAtivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonAtivo.Name = "radioButtonAtivo";
            this.radioButtonAtivo.Size = new System.Drawing.Size(61, 22);
            this.radioButtonAtivo.TabIndex = 100;
            this.radioButtonAtivo.TabStop = true;
            this.radioButtonAtivo.Text = "Ativo";
            this.radioButtonAtivo.UseVisualStyleBackColor = true;
            // 
            // textoStatus
            // 
            this.textoStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoStatus.Location = new System.Drawing.Point(293, 5);
            this.textoStatus.Name = "textoStatus";
            this.textoStatus.Size = new System.Drawing.Size(83, 24);
            this.textoStatus.TabIndex = 57;
            this.textoStatus.Text = "Status";
            this.textoStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoMarca
            // 
            this.textoMarca.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoMarca.Location = new System.Drawing.Point(352, 46);
            this.textoMarca.Name = "textoMarca";
            this.textoMarca.Size = new System.Drawing.Size(113, 24);
            this.textoMarca.TabIndex = 55;
            this.textoMarca.Text = "Marca";
            this.textoMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // campoDescricao
            // 
            this.campoDescricao.Location = new System.Drawing.Point(104, 82);
            this.campoDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.campoDescricao.Multiline = true;
            this.campoDescricao.Name = "campoDescricao";
            this.campoDescricao.Size = new System.Drawing.Size(260, 68);
            this.campoDescricao.TabIndex = 5;
            // 
            // textoDescrição
            // 
            this.textoDescrição.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDescrição.Location = new System.Drawing.Point(3, 80);
            this.textoDescrição.Name = "textoDescrição";
            this.textoDescrição.Size = new System.Drawing.Size(102, 24);
            this.textoDescrição.TabIndex = 52;
            this.textoDescrição.Text = "Descrição";
            this.textoDescrição.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoNome
            // 
            this.textoNome.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNome.Location = new System.Drawing.Point(8, 46);
            this.textoNome.Name = "textoNome";
            this.textoNome.Size = new System.Drawing.Size(90, 24);
            this.textoNome.TabIndex = 50;
            this.textoNome.Text = "Nome";
            this.textoNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoValor
            // 
            this.textoValor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoValor.Location = new System.Drawing.Point(5, 5);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(93, 24);
            this.textoValor.TabIndex = 46;
            this.textoValor.Text = "Valor";
            this.textoValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialog1";
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 357);
            this.Controls.Add(this.panelFundo);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Produtos";
            this.panelFundo.ResumeLayout(false);
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Label textoStatus;
        private System.Windows.Forms.Label textoMarca;
        private System.Windows.Forms.TextBox campoDescricao;
        private System.Windows.Forms.Label textoDescrição;
        private System.Windows.Forms.Label textoNome;
        private System.Windows.Forms.Label textoValor;
        private System.Windows.Forms.RadioButton radioButtonInativo;
        private System.Windows.Forms.RadioButton radioButtonAtivo;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private ControleUsBTN userControl;
        private System.Windows.Forms.MaskedTextBox mk_Valor;
        private System.Windows.Forms.MaskedTextBox mk_nome;
        private System.Windows.Forms.ComboBox comboArea;
        private System.Windows.Forms.Label textoArea;
        private System.Windows.Forms.MaskedTextBox mk_modelo;
        private System.Windows.Forms.Label texto_modelo;
        private System.Windows.Forms.Label textoQuantidadeEstoque;
        private System.Windows.Forms.MaskedTextBox mk_quantidade;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.MaskedTextBox mk_id;
        private System.Windows.Forms.Label texto_id;
    }
}