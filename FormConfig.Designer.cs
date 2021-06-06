
namespace BancoDadosZe
{
    partial class FormConfig
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
            this.grupBoxLingua = new System.Windows.Forms.GroupBox();
            this.comboBox_idioma = new System.Windows.Forms.ComboBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.grupBoxBanco = new System.Windows.Forms.GroupBox();
            this.textBoxStringConexao = new System.Windows.Forms.TextBox();
            this.comboBoxBanco = new System.Windows.Forms.ComboBox();
            this.grupBoxLingua.SuspendLayout();
            this.grupBoxBanco.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupBoxLingua
            // 
            this.grupBoxLingua.Controls.Add(this.comboBox_idioma);
            this.grupBoxLingua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grupBoxLingua.Location = new System.Drawing.Point(12, 12);
            this.grupBoxLingua.Name = "grupBoxLingua";
            this.grupBoxLingua.Size = new System.Drawing.Size(200, 73);
            this.grupBoxLingua.TabIndex = 2;
            this.grupBoxLingua.TabStop = false;
            this.grupBoxLingua.Text = "Escolha Idioma";
            // 
            // comboBox_idioma
            // 
            this.comboBox_idioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_idioma.FormattingEnabled = true;
            this.comboBox_idioma.IntegralHeight = false;
            this.comboBox_idioma.Items.AddRange(new object[] {
            "pt",
            "en",
            "es"});
            this.comboBox_idioma.Location = new System.Drawing.Point(32, 34);
            this.comboBox_idioma.Name = "comboBox_idioma";
            this.comboBox_idioma.Size = new System.Drawing.Size(121, 24);
            this.comboBox_idioma.TabIndex = 3;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(545, 232);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(93, 37);
            this.btn_salvar.TabIndex = 7;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // grupBoxBanco
            // 
            this.grupBoxBanco.Controls.Add(this.textBoxStringConexao);
            this.grupBoxBanco.Controls.Add(this.comboBoxBanco);
            this.grupBoxBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grupBoxBanco.Location = new System.Drawing.Point(12, 91);
            this.grupBoxBanco.Name = "grupBoxBanco";
            this.grupBoxBanco.Size = new System.Drawing.Size(626, 130);
            this.grupBoxBanco.TabIndex = 4;
            this.grupBoxBanco.TabStop = false;
            this.grupBoxBanco.Text = "Escolha Banco Dados";
            // 
            // textBoxStringConexao
            // 
            this.textBoxStringConexao.Enabled = false;
            this.textBoxStringConexao.Location = new System.Drawing.Point(6, 87);
            this.textBoxStringConexao.Name = "textBoxStringConexao";
            this.textBoxStringConexao.ReadOnly = true;
            this.textBoxStringConexao.Size = new System.Drawing.Size(614, 22);
            this.textBoxStringConexao.TabIndex = 6;
            this.textBoxStringConexao.TabStop = false;
            // 
            // comboBoxBanco
            // 
            this.comboBoxBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBanco.FormattingEnabled = true;
            this.comboBoxBanco.IntegralHeight = false;
            this.comboBoxBanco.Items.AddRange(new object[] {
            "System.Data.SqlClient",
            "MySql.Data.MySqlClient"});
            this.comboBoxBanco.Location = new System.Drawing.Point(6, 34);
            this.comboBoxBanco.Name = "comboBoxBanco";
            this.comboBoxBanco.Size = new System.Drawing.Size(392, 24);
            this.comboBoxBanco.TabIndex = 5;
            this.comboBoxBanco.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBanco_SelectedIndexChanged);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 281);
            this.Controls.Add(this.grupBoxBanco);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.grupBoxLingua);
            this.KeyPreview = true;
            this.Name = "FormConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.grupBoxLingua.ResumeLayout(false);
            this.grupBoxBanco.ResumeLayout(false);
            this.grupBoxBanco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupBoxLingua;
        private System.Windows.Forms.ComboBox comboBox_idioma;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.GroupBox grupBoxBanco;
        private System.Windows.Forms.ComboBox comboBoxBanco;
        private System.Windows.Forms.TextBox textBoxStringConexao;
    }
}