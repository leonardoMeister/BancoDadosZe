
namespace BancoDadosZe
{
    partial class FormAreaAtuacao
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
            this.textoArea = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.mk_id = new System.Windows.Forms.TextBox();
            this.textoId = new System.Windows.Forms.Label();
            this.panelFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoArea
            // 
            this.textoArea.AutoSize = true;
            this.textoArea.Location = new System.Drawing.Point(72, 28);
            this.textoArea.Name = "textoArea";
            this.textoArea.Size = new System.Drawing.Size(94, 17);
            this.textoArea.TabIndex = 0;
            this.textoArea.Text = "Area Atuação";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(189, 28);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(100, 22);
            this.textBoxArea.TabIndex = 1;
            // 
            // panelFormulario
            // 
            this.panelFormulario.Controls.Add(this.mk_id);
            this.panelFormulario.Controls.Add(this.textoId);
            this.panelFormulario.Controls.Add(this.textBoxArea);
            this.panelFormulario.Controls.Add(this.textoArea);
            this.panelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormulario.Location = new System.Drawing.Point(0, 0);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(734, 111);
            this.panelFormulario.TabIndex = 2;
            // 
            // mk_id
            // 
            this.mk_id.Enabled = false;
            this.mk_id.Location = new System.Drawing.Point(527, 28);
            this.mk_id.Name = "mk_id";
            this.mk_id.Size = new System.Drawing.Size(100, 22);
            this.mk_id.TabIndex = 3;
            // 
            // textoId
            // 
            this.textoId.AutoSize = true;
            this.textoId.Location = new System.Drawing.Point(469, 30);
            this.textoId.Name = "textoId";
            this.textoId.Size = new System.Drawing.Size(19, 17);
            this.textoId.TabIndex = 2;
            this.textoId.Text = "Id";
            // 
            // FormAreaAtuacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 111);
            this.Controls.Add(this.panelFormulario);
            this.KeyPreview = true;
            this.Name = "FormAreaAtuacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAreaAtuacao";
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textoArea;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.TextBox mk_id;
        private System.Windows.Forms.Label textoId;
    }
}