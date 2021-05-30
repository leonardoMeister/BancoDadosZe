
namespace BancoDadosZe
{
    partial class FormMarca
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
            this.text_marca = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.mk_id = new System.Windows.Forms.TextBox();
            this.text_id = new System.Windows.Forms.Label();
            this.panelFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_marca
            // 
            this.text_marca.AutoSize = true;
            this.text_marca.Location = new System.Drawing.Point(418, 27);
            this.text_marca.Name = "text_marca";
            this.text_marca.Size = new System.Drawing.Size(47, 17);
            this.text_marca.TabIndex = 1;
            this.text_marca.Text = "Marca";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(504, 27);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(156, 22);
            this.textBoxMarca.TabIndex = 2;
            // 
            // panelFormulario
            // 
            this.panelFormulario.Controls.Add(this.mk_id);
            this.panelFormulario.Controls.Add(this.text_id);
            this.panelFormulario.Controls.Add(this.textBoxMarca);
            this.panelFormulario.Controls.Add(this.text_marca);
            this.panelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormulario.Location = new System.Drawing.Point(0, 0);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(732, 115);
            this.panelFormulario.TabIndex = 3;
            // 
            // mk_id
            // 
            this.mk_id.Enabled = false;
            this.mk_id.Location = new System.Drawing.Point(179, 27);
            this.mk_id.Name = "mk_id";
            this.mk_id.ReadOnly = true;
            this.mk_id.Size = new System.Drawing.Size(71, 22);
            this.mk_id.TabIndex = 4;
            // 
            // text_id
            // 
            this.text_id.AutoSize = true;
            this.text_id.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.text_id.Location = new System.Drawing.Point(101, 29);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(19, 17);
            this.text_id.TabIndex = 3;
            this.text_id.Text = "Id";
            // 
            // FormMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 115);
            this.Controls.Add(this.panelFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FormMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMarca";
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label text_marca;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.TextBox mk_id;
        private System.Windows.Forms.Label text_id;
    }
}