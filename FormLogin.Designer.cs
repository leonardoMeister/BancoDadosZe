
namespace BancoDadosZe
{
    partial class FormLogin
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
            this.painelFundo = new System.Windows.Forms.Panel();
            this.btnAcesso = new System.Windows.Forms.Button();
            this.textoBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.painelSuperior = new System.Windows.Forms.Panel();
            this.textoLogin = new System.Windows.Forms.Label();
            this.painelFundo.SuspendLayout();
            this.painelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelFundo
            // 
            this.painelFundo.BackColor = System.Drawing.Color.Moccasin;
            this.painelFundo.Controls.Add(this.btnAcesso);
            this.painelFundo.Controls.Add(this.textoBoxNome);
            this.painelFundo.Controls.Add(this.textBoxSenha);
            this.painelFundo.Controls.Add(this.painelSuperior);
            this.painelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelFundo.Location = new System.Drawing.Point(0, 0);
            this.painelFundo.Name = "painelFundo";
            this.painelFundo.Size = new System.Drawing.Size(377, 381);
            this.painelFundo.TabIndex = 0;
            // 
            // btnAcesso
            // 
            this.btnAcesso.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAcesso.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcesso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAcesso.Location = new System.Drawing.Point(160, 307);
            this.btnAcesso.Name = "btnAcesso";
            this.btnAcesso.Size = new System.Drawing.Size(147, 43);
            this.btnAcesso.TabIndex = 1;
            this.btnAcesso.Text = "Acessar";
            this.btnAcesso.UseVisualStyleBackColor = false;
            // 
            // textoBoxNome
            // 
            this.textoBoxNome.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textoBoxNome.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoBoxNome.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textoBoxNome.Location = new System.Drawing.Point(83, 152);
            this.textoBoxNome.Name = "textoBoxNome";
            this.textoBoxNome.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textoBoxNome.Size = new System.Drawing.Size(205, 44);
            this.textoBoxNome.TabIndex = 0;
            this.textoBoxNome.TabStop = false;
            this.textoBoxNome.Text = "Matrícula";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxSenha.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxSenha.Location = new System.Drawing.Point(83, 212);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxSenha.Size = new System.Drawing.Size(205, 44);
            this.textBoxSenha.TabIndex = 0;
            this.textBoxSenha.TabStop = false;
            this.textBoxSenha.Text = "Senha";
            // 
            // painelSuperior
            // 
            this.painelSuperior.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.painelSuperior.Controls.Add(this.textoLogin);
            this.painelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelSuperior.Location = new System.Drawing.Point(0, 0);
            this.painelSuperior.Name = "painelSuperior";
            this.painelSuperior.Size = new System.Drawing.Size(377, 133);
            this.painelSuperior.TabIndex = 0;
            // 
            // textoLogin
            // 
            this.textoLogin.BackColor = System.Drawing.Color.DarkOrange;
            this.textoLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textoLogin.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textoLogin.Location = new System.Drawing.Point(0, 0);
            this.textoLogin.Name = "textoLogin";
            this.textoLogin.Size = new System.Drawing.Size(377, 133);
            this.textoLogin.TabIndex = 0;
            this.textoLogin.Text = "Login";
            this.textoLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 381);
            this.Controls.Add(this.painelFundo);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.painelFundo.ResumeLayout(false);
            this.painelFundo.PerformLayout();
            this.painelSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelFundo;
        private System.Windows.Forms.Panel painelSuperior;
        private System.Windows.Forms.Label textoLogin;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textoBoxNome;
        private System.Windows.Forms.Button btnAcesso;
    }
}