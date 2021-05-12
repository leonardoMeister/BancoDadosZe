
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
            this.labelArea = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.dataGridViewAreaAtuazao = new System.Windows.Forms.DataGridView();
            this.panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAreaAtuazao)).BeginInit();
            this.SuspendLayout();
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(232, 117);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(94, 17);
            this.labelArea.TabIndex = 0;
            this.labelArea.Text = "Area Atuação";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(349, 117);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(100, 22);
            this.textBoxArea.TabIndex = 1;
            // 
            // panelFormulario
            // 
            this.panelFormulario.Controls.Add(this.dataGridViewAreaAtuazao);
            this.panelFormulario.Controls.Add(this.textBoxArea);
            this.panelFormulario.Controls.Add(this.labelArea);
            this.panelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormulario.Location = new System.Drawing.Point(0, 0);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(800, 450);
            this.panelFormulario.TabIndex = 2;
            // 
            // dataGridViewAreaAtuazao
            // 
            this.dataGridViewAreaAtuazao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAreaAtuazao.Location = new System.Drawing.Point(142, 184);
            this.dataGridViewAreaAtuazao.Name = "dataGridViewAreaAtuazao";
            this.dataGridViewAreaAtuazao.RowHeadersWidth = 51;
            this.dataGridViewAreaAtuazao.RowTemplate.Height = 24;
            this.dataGridViewAreaAtuazao.Size = new System.Drawing.Size(477, 222);
            this.dataGridViewAreaAtuazao.TabIndex = 2;
            // 
            // FormAreaAtuacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFormulario);
            this.Name = "FormAreaAtuacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAreaAtuacao";
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAreaAtuazao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.DataGridView dataGridViewAreaAtuazao;
    }
}