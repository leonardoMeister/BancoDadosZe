
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
            this.mk_nome = new System.Windows.Forms.MaskedTextBox();
            this.mk_Valor = new System.Windows.Forms.MaskedTextBox();
            this.controleUs1 = new BancoDadosZe.ControleUs();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.radioButtonInativo = new System.Windows.Forms.RadioButton();
            this.radioButtonAtivo = new System.Windows.Forms.RadioButton();
            this.textoStatus = new System.Windows.Forms.Label();
            this.textoMarca = new System.Windows.Forms.Label();
            this.campoDescricao = new System.Windows.Forms.TextBox();
            this.textoDescrição = new System.Windows.Forms.Label();
            this.textoNome = new System.Windows.Forms.Label();
            this.textoValor = new System.Windows.Forms.Label();
            this.comboArea = new System.Windows.Forms.ComboBox();
            this.textoArea = new System.Windows.Forms.Label();
            this.maskedTextBoxModelo = new System.Windows.Forms.MaskedTextBox();
            this.labelModelo = new System.Windows.Forms.Label();
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
            this.panelFundo.Size = new System.Drawing.Size(684, 357);
            this.panelFundo.TabIndex = 1;
            // 
            // panelFormulario
            // 
            this.panelFormulario.Controls.Add(this.maskedTextBoxModelo);
            this.panelFormulario.Controls.Add(this.labelModelo);
            this.panelFormulario.Controls.Add(this.comboArea);
            this.panelFormulario.Controls.Add(this.textoArea);
            this.panelFormulario.Controls.Add(this.mk_nome);
            this.panelFormulario.Controls.Add(this.mk_Valor);
            this.panelFormulario.Controls.Add(this.controleUs1);
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
            // mk_nome
            // 
            this.mk_nome.Location = new System.Drawing.Point(104, 48);
            this.mk_nome.Name = "mk_nome";
            this.mk_nome.Size = new System.Drawing.Size(200, 22);
            this.mk_nome.TabIndex = 101;
            // 
            // mk_Valor
            // 
            this.mk_Valor.Location = new System.Drawing.Point(104, 6);
            this.mk_Valor.Mask = "9990000";
            this.mk_Valor.Name = "mk_Valor";
            this.mk_Valor.Size = new System.Drawing.Size(67, 22);
            this.mk_Valor.TabIndex = 100;
            this.mk_Valor.ValidatingType = typeof(int);
            // 
            // controleUs1
            // 
            this.controleUs1.Location = new System.Drawing.Point(-52, 274);
            this.controleUs1.Margin = new System.Windows.Forms.Padding(5);
            this.controleUs1.Name = "controleUs1";
            this.controleUs1.Size = new System.Drawing.Size(771, 53);
            this.controleUs1.TabIndex = 4;
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
            this.comboBoxMarca.TabIndex = 99;
            this.comboBoxMarca.TabStop = false;
            // 
            // radioButtonInativo
            // 
            this.radioButtonInativo.AutoSize = true;
            this.radioButtonInativo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInativo.Location = new System.Drawing.Point(471, 6);
            this.radioButtonInativo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonInativo.Name = "radioButtonInativo";
            this.radioButtonInativo.Size = new System.Drawing.Size(74, 22);
            this.radioButtonInativo.TabIndex = 94;
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
            this.radioButtonAtivo.TabIndex = 93;
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
            this.campoDescricao.Location = new System.Drawing.Point(116, 80);
            this.campoDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.campoDescricao.Multiline = true;
            this.campoDescricao.Name = "campoDescricao";
            this.campoDescricao.Size = new System.Drawing.Size(260, 68);
            this.campoDescricao.TabIndex = 3;
            // 
            // textoDescrição
            // 
            this.textoDescrição.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDescrição.Location = new System.Drawing.Point(8, 81);
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
            this.comboArea.TabIndex = 103;
            this.comboArea.TabStop = false;
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
            // maskedTextBoxModelo
            // 
            this.maskedTextBoxModelo.Location = new System.Drawing.Point(104, 178);
            this.maskedTextBoxModelo.Name = "maskedTextBoxModelo";
            this.maskedTextBoxModelo.Size = new System.Drawing.Size(200, 22);
            this.maskedTextBoxModelo.TabIndex = 105;
            // 
            // labelModelo
            // 
            this.labelModelo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelo.Location = new System.Drawing.Point(8, 176);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(90, 24);
            this.labelModelo.TabIndex = 104;
            this.labelModelo.Text = "Modelo";
            this.labelModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
        private ControleUs controleUs1;
        private System.Windows.Forms.MaskedTextBox mk_Valor;
        private System.Windows.Forms.MaskedTextBox mk_nome;
        private System.Windows.Forms.ComboBox comboArea;
        private System.Windows.Forms.Label textoArea;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxModelo;
        private System.Windows.Forms.Label labelModelo;
    }
}