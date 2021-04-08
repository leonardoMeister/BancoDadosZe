
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
            this.grupBoxLingua.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupBoxLingua
            // 
            this.grupBoxLingua.Controls.Add(this.comboBox_idioma);
            this.grupBoxLingua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grupBoxLingua.Location = new System.Drawing.Point(12, 12);
            this.grupBoxLingua.Name = "grupBoxLingua";
            this.grupBoxLingua.Size = new System.Drawing.Size(200, 73);
            this.grupBoxLingua.TabIndex = 0;
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
            this.comboBox_idioma.TabIndex = 1;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(84, 109);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(93, 37);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 158);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.grupBoxLingua);
            this.KeyPreview = true;
            this.Name = "FormConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.grupBoxLingua.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupBoxLingua;
        private System.Windows.Forms.ComboBox comboBox_idioma;
        private System.Windows.Forms.Button btn_salvar;
    }
}