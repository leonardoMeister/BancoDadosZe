
namespace BancoDadosZe
{
    partial class FormFuncionario
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
            this.textId = new System.Windows.Forms.Label();
            this.mk_senha = new System.Windows.Forms.MaskedTextBox();
            this.textoSenha = new System.Windows.Forms.Label();
            this.mk_email = new System.Windows.Forms.MaskedTextBox();
            this.mk_matricula = new System.Windows.Forms.MaskedTextBox();
            this.mk_telefone = new System.Windows.Forms.MaskedTextBox();
            this.mk_dataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.mk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.mk_nome = new System.Windows.Forms.MaskedTextBox();
            this.textoEmail = new System.Windows.Forms.Label();
            this.comboBoxCargo = new System.Windows.Forms.ComboBox();
            this.comboBoxGrupo = new System.Windows.Forms.ComboBox();
            this.textoGrupo = new System.Windows.Forms.Label();
            this.textoCargo = new System.Windows.Forms.Label();
            this.textoMatricula = new System.Windows.Forms.Label();
            this.textoTelefone = new System.Windows.Forms.Label();
            this.textoDataNascimento = new System.Windows.Forms.Label();
            this.textoCpf = new System.Windows.Forms.Label();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.textoSexo = new System.Windows.Forms.Label();
            this.textoNome = new System.Windows.Forms.Label();
            this.controleUsEndereco = new BancoDadosZe.ControleEndereco();
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
            this.panelFundo.Size = new System.Drawing.Size(823, 431);
            this.panelFundo.TabIndex = 1;
            // 
            // panelFormulario
            // 
            this.panelFormulario.Controls.Add(this.mk_id);
            this.panelFormulario.Controls.Add(this.textId);
            this.panelFormulario.Controls.Add(this.controleUsEndereco);
            this.panelFormulario.Controls.Add(this.mk_senha);
            this.panelFormulario.Controls.Add(this.textoSenha);
            this.panelFormulario.Controls.Add(this.mk_email);
            this.panelFormulario.Controls.Add(this.mk_matricula);
            this.panelFormulario.Controls.Add(this.mk_telefone);
            this.panelFormulario.Controls.Add(this.mk_dataNascimento);
            this.panelFormulario.Controls.Add(this.mk_cpf);
            this.panelFormulario.Controls.Add(this.mk_nome);
            this.panelFormulario.Controls.Add(this.textoEmail);
            this.panelFormulario.Controls.Add(this.comboBoxCargo);
            this.panelFormulario.Controls.Add(this.comboBoxGrupo);
            this.panelFormulario.Controls.Add(this.textoGrupo);
            this.panelFormulario.Controls.Add(this.textoCargo);
            this.panelFormulario.Controls.Add(this.textoMatricula);
            this.panelFormulario.Controls.Add(this.textoTelefone);
            this.panelFormulario.Controls.Add(this.textoDataNascimento);
            this.panelFormulario.Controls.Add(this.textoCpf);
            this.panelFormulario.Controls.Add(this.radioButtonMasculino);
            this.panelFormulario.Controls.Add(this.radioButtonFeminino);
            this.panelFormulario.Controls.Add(this.textoSexo);
            this.panelFormulario.Controls.Add(this.textoNome);
            this.panelFormulario.Location = new System.Drawing.Point(11, 14);
            this.panelFormulario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(797, 406);
            this.panelFormulario.TabIndex = 2;
            // 
            // mk_id
            // 
            this.mk_id.Enabled = false;
            this.mk_id.Location = new System.Drawing.Point(410, 51);
            this.mk_id.Name = "mk_id";
            this.mk_id.Size = new System.Drawing.Size(55, 22);
            this.mk_id.TabIndex = 109;
            this.mk_id.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textId
            // 
            this.textId.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textId.Location = new System.Drawing.Point(341, 51);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(63, 22);
            this.textId.TabIndex = 108;
            this.textId.Text = "Id";
            this.textId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mk_senha
            // 
            this.mk_senha.Location = new System.Drawing.Point(344, 17);
            this.mk_senha.Name = "mk_senha";
            this.mk_senha.Size = new System.Drawing.Size(110, 22);
            this.mk_senha.TabIndex = 102;
            this.mk_senha.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textoSenha
            // 
            this.textoSenha.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoSenha.Location = new System.Drawing.Point(281, 17);
            this.textoSenha.Name = "textoSenha";
            this.textoSenha.Size = new System.Drawing.Size(57, 22);
            this.textoSenha.TabIndex = 105;
            this.textoSenha.Text = "Senha";
            this.textoSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mk_email
            // 
            this.mk_email.Location = new System.Drawing.Point(575, 116);
            this.mk_email.Name = "mk_email";
            this.mk_email.Size = new System.Drawing.Size(170, 22);
            this.mk_email.TabIndex = 106;
            this.mk_email.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mk_matricula
            // 
            this.mk_matricula.Location = new System.Drawing.Point(575, 81);
            this.mk_matricula.Mask = "9990000";
            this.mk_matricula.Name = "mk_matricula";
            this.mk_matricula.Size = new System.Drawing.Size(76, 22);
            this.mk_matricula.TabIndex = 105;
            this.mk_matricula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mk_matricula.ValidatingType = typeof(int);
            // 
            // mk_telefone
            // 
            this.mk_telefone.Location = new System.Drawing.Point(575, 48);
            this.mk_telefone.Mask = "(999) 9000-0000";
            this.mk_telefone.Name = "mk_telefone";
            this.mk_telefone.Size = new System.Drawing.Size(118, 22);
            this.mk_telefone.TabIndex = 104;
            this.mk_telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mk_dataNascimento
            // 
            this.mk_dataNascimento.Location = new System.Drawing.Point(179, 86);
            this.mk_dataNascimento.Mask = "0000/00/00";
            this.mk_dataNascimento.Name = "mk_dataNascimento";
            this.mk_dataNascimento.Size = new System.Drawing.Size(139, 22);
            this.mk_dataNascimento.TabIndex = 100;
            this.mk_dataNascimento.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mk_dataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // mk_cpf
            // 
            this.mk_cpf.Location = new System.Drawing.Point(179, 51);
            this.mk_cpf.Mask = "000.000.000-00";
            this.mk_cpf.Name = "mk_cpf";
            this.mk_cpf.Size = new System.Drawing.Size(120, 22);
            this.mk_cpf.TabIndex = 99;
            this.mk_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mk_nome
            // 
            this.mk_nome.Location = new System.Drawing.Point(105, 16);
            this.mk_nome.Name = "mk_nome";
            this.mk_nome.Size = new System.Drawing.Size(139, 22);
            this.mk_nome.TabIndex = 98;
            this.mk_nome.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textoEmail
            // 
            this.textoEmail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoEmail.Location = new System.Drawing.Point(486, 116);
            this.textoEmail.Name = "textoEmail";
            this.textoEmail.Size = new System.Drawing.Size(80, 20);
            this.textoEmail.TabIndex = 97;
            this.textoEmail.Text = "Email";
            this.textoEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxCargo
            // 
            this.comboBoxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Items.AddRange(new object[] {
            "Socio",
            "Gerente",
            "Atendente",
            "Almoxarife"});
            this.comboBoxCargo.Location = new System.Drawing.Point(111, 120);
            this.comboBoxCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.Size = new System.Drawing.Size(127, 24);
            this.comboBoxCargo.TabIndex = 101;
            // 
            // comboBoxGrupo
            // 
            this.comboBoxGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrupo.Items.AddRange(new object[] {
            "Tipo 1",
            "Tipo 2",
            "Tipo 3",
            "Tipo 4",
            "Tipo 5"});
            this.comboBoxGrupo.Location = new System.Drawing.Point(342, 120);
            this.comboBoxGrupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGrupo.Name = "comboBoxGrupo";
            this.comboBoxGrupo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGrupo.TabIndex = 103;
            // 
            // textoGrupo
            // 
            this.textoGrupo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoGrupo.Location = new System.Drawing.Point(244, 121);
            this.textoGrupo.Name = "textoGrupo";
            this.textoGrupo.Size = new System.Drawing.Size(92, 23);
            this.textoGrupo.TabIndex = 61;
            this.textoGrupo.Text = "Grupo";
            this.textoGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoCargo
            // 
            this.textoCargo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCargo.Location = new System.Drawing.Point(23, 120);
            this.textoCargo.Name = "textoCargo";
            this.textoCargo.Size = new System.Drawing.Size(82, 20);
            this.textoCargo.TabIndex = 59;
            this.textoCargo.Text = "Cargo";
            this.textoCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoMatricula
            // 
            this.textoMatricula.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoMatricula.Location = new System.Drawing.Point(429, 81);
            this.textoMatricula.Name = "textoMatricula";
            this.textoMatricula.Size = new System.Drawing.Size(140, 22);
            this.textoMatricula.TabIndex = 57;
            this.textoMatricula.Text = "Matricula";
            this.textoMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoTelefone
            // 
            this.textoTelefone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTelefone.Location = new System.Drawing.Point(447, 47);
            this.textoTelefone.Name = "textoTelefone";
            this.textoTelefone.Size = new System.Drawing.Size(122, 22);
            this.textoTelefone.TabIndex = 55;
            this.textoTelefone.Text = "Telefone";
            this.textoTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoDataNascimento
            // 
            this.textoDataNascimento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDataNascimento.Location = new System.Drawing.Point(0, 85);
            this.textoDataNascimento.Name = "textoDataNascimento";
            this.textoDataNascimento.Size = new System.Drawing.Size(173, 22);
            this.textoDataNascimento.TabIndex = 52;
            this.textoDataNascimento.Text = "Data Nascimento";
            this.textoDataNascimento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoCpf
            // 
            this.textoCpf.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCpf.Location = new System.Drawing.Point(36, 50);
            this.textoCpf.Name = "textoCpf";
            this.textoCpf.Size = new System.Drawing.Size(137, 23);
            this.textoCpf.TabIndex = 50;
            this.textoCpf.Text = "CPF";
            this.textoCpf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMasculino.Location = new System.Drawing.Point(670, 10);
            this.radioButtonMasculino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(106, 22);
            this.radioButtonMasculino.TabIndex = 49;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.Checked = true;
            this.radioButtonFeminino.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFeminino.Location = new System.Drawing.Point(556, 10);
            this.radioButtonFeminino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(108, 22);
            this.radioButtonFeminino.TabIndex = 47;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // textoSexo
            // 
            this.textoSexo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoSexo.Location = new System.Drawing.Point(450, 10);
            this.textoSexo.Name = "textoSexo";
            this.textoSexo.Size = new System.Drawing.Size(88, 20);
            this.textoSexo.TabIndex = 48;
            this.textoSexo.Text = "Sexo:";
            this.textoSexo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoNome
            // 
            this.textoNome.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNome.Location = new System.Drawing.Point(4, 16);
            this.textoNome.Name = "textoNome";
            this.textoNome.Size = new System.Drawing.Size(95, 22);
            this.textoNome.TabIndex = 46;
            this.textoNome.Text = "Nome";
            this.textoNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // controleUsEndereco
            // 
            this.controleUsEndereco.Location = new System.Drawing.Point(26, 149);
            this.controleUsEndereco.Name = "controleUsEndereco";
            this.controleUsEndereco.Size = new System.Drawing.Size(740, 204);
            this.controleUsEndereco.TabIndex = 107;
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 431);
            this.Controls.Add(this.panelFundo);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Funcionários";
            this.panelFundo.ResumeLayout(false);
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Panel panelFormulario;
        private ControleEndereco controleUsEndereco;
        private System.Windows.Forms.MaskedTextBox mk_senha;
        private System.Windows.Forms.Label textoSenha;
        private System.Windows.Forms.MaskedTextBox mk_email;
        private System.Windows.Forms.MaskedTextBox mk_matricula;
        private System.Windows.Forms.MaskedTextBox mk_telefone;
        private System.Windows.Forms.MaskedTextBox mk_dataNascimento;
        private System.Windows.Forms.MaskedTextBox mk_cpf;
        private System.Windows.Forms.MaskedTextBox mk_nome;
        private System.Windows.Forms.Label textoEmail;
        private System.Windows.Forms.ComboBox comboBoxCargo;
        private System.Windows.Forms.ComboBox comboBoxGrupo;
        private System.Windows.Forms.Label textoGrupo;
        private System.Windows.Forms.Label textoCargo;
        private System.Windows.Forms.Label textoMatricula;
        private System.Windows.Forms.Label textoTelefone;
        private System.Windows.Forms.Label textoDataNascimento;
        private System.Windows.Forms.Label textoCpf;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.Label textoSexo;
        private System.Windows.Forms.Label textoNome;
        private System.Windows.Forms.MaskedTextBox mk_id;
        private System.Windows.Forms.Label textId;
    }
}