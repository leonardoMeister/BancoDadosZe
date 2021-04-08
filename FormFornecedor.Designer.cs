
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
            this.campoEndereco = new System.Windows.Forms.TextBox();
            this.textoEndereco = new System.Windows.Forms.Label();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.textoEmail = new System.Windows.Forms.Label();
            this.textoAtuacao = new System.Windows.Forms.Label();
            this.campoContato = new System.Windows.Forms.TextBox();
            this.textoContato = new System.Windows.Forms.Label();
            this.campoTelefone = new System.Windows.Forms.TextBox();
            this.textoTelefone = new System.Windows.Forms.Label();
            this.campoCnpj = new System.Windows.Forms.TextBox();
            this.campoRazaoSocial = new System.Windows.Forms.TextBox();
            this.textoRazaoSocial = new System.Windows.Forms.Label();
            this.textoCnpj = new System.Windows.Forms.Label();
            this.campoNomeFantasia = new System.Windows.Forms.TextBox();
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
            this.panelFundo.Size = new System.Drawing.Size(816, 268);
            this.panelFundo.TabIndex = 1;
            // 
            // panelFormulario
            // 
            this.panelFormulario.Controls.Add(this.combobox1);
            this.panelFormulario.Controls.Add(this.campoEndereco);
            this.panelFormulario.Controls.Add(this.textoEndereco);
            this.panelFormulario.Controls.Add(this.campoEmail);
            this.panelFormulario.Controls.Add(this.textoEmail);
            this.panelFormulario.Controls.Add(this.textoAtuacao);
            this.panelFormulario.Controls.Add(this.campoContato);
            this.panelFormulario.Controls.Add(this.textoContato);
            this.panelFormulario.Controls.Add(this.campoTelefone);
            this.panelFormulario.Controls.Add(this.textoTelefone);
            this.panelFormulario.Controls.Add(this.campoCnpj);
            this.panelFormulario.Controls.Add(this.campoRazaoSocial);
            this.panelFormulario.Controls.Add(this.textoRazaoSocial);
            this.panelFormulario.Controls.Add(this.textoCnpj);
            this.panelFormulario.Controls.Add(this.campoNomeFantasia);
            this.panelFormulario.Controls.Add(this.textoNomeFantasia);
            this.panelFormulario.Location = new System.Drawing.Point(8, 14);
            this.panelFormulario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(797, 250);
            this.panelFormulario.TabIndex = 2;
            this.panelFormulario.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormulario_Paint);
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
            // campoEndereco
            // 
            this.campoEndereco.Location = new System.Drawing.Point(199, 151);
            this.campoEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.campoEndereco.Name = "campoEndereco";
            this.campoEndereco.Size = new System.Drawing.Size(353, 22);
            this.campoEndereco.TabIndex = 6;
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
            // campoEmail
            // 
            this.campoEmail.Location = new System.Drawing.Point(507, 117);
            this.campoEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(243, 22);
            this.campoEmail.TabIndex = 9;
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
            // campoContato
            // 
            this.campoContato.Location = new System.Drawing.Point(584, 9);
            this.campoContato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.campoContato.Name = "campoContato";
            this.campoContato.Size = new System.Drawing.Size(170, 22);
            this.campoContato.TabIndex = 7;
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
            // campoTelefone
            // 
            this.campoTelefone.Location = new System.Drawing.Point(584, 46);
            this.campoTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.campoTelefone.Name = "campoTelefone";
            this.campoTelefone.Size = new System.Drawing.Size(203, 22);
            this.campoTelefone.TabIndex = 8;
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
            // campoCnpj
            // 
            this.campoCnpj.Location = new System.Drawing.Point(179, 46);
            this.campoCnpj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.campoCnpj.Name = "campoCnpj";
            this.campoCnpj.Size = new System.Drawing.Size(247, 22);
            this.campoCnpj.TabIndex = 4;
            // 
            // campoRazaoSocial
            // 
            this.campoRazaoSocial.Location = new System.Drawing.Point(199, 81);
            this.campoRazaoSocial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.campoRazaoSocial.Name = "campoRazaoSocial";
            this.campoRazaoSocial.Size = new System.Drawing.Size(281, 22);
            this.campoRazaoSocial.TabIndex = 5;
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
            // campoNomeFantasia
            // 
            this.campoNomeFantasia.Location = new System.Drawing.Point(179, 9);
            this.campoNomeFantasia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.campoNomeFantasia.Name = "campoNomeFantasia";
            this.campoNomeFantasia.Size = new System.Drawing.Size(247, 22);
            this.campoNomeFantasia.TabIndex = 3;
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
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.Label textoEmail;
        private System.Windows.Forms.Label textoAtuacao;
        private System.Windows.Forms.TextBox campoContato;
        private System.Windows.Forms.Label textoContato;
        private System.Windows.Forms.TextBox campoTelefone;
        private System.Windows.Forms.Label textoTelefone;
        private System.Windows.Forms.TextBox campoCnpj;
        private System.Windows.Forms.TextBox campoRazaoSocial;
        private System.Windows.Forms.Label textoRazaoSocial;
        private System.Windows.Forms.Label textoCnpj;
        private System.Windows.Forms.TextBox campoNomeFantasia;
        private System.Windows.Forms.Label textoNomeFantasia;
        private System.Windows.Forms.TextBox campoEndereco;
        private System.Windows.Forms.Label textoEndereco;
        private System.Windows.Forms.ComboBox combobox1;
    }
}