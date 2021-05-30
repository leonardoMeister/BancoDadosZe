
namespace BancoDadosZe
{
    partial class ControleUsBTN
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.painelFundo = new System.Windows.Forms.Panel();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.painelFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelFundo
            // 
            this.painelFundo.Controls.Add(this.btnRemover);
            this.painelFundo.Controls.Add(this.btnSalvar);
            this.painelFundo.Controls.Add(this.btnAdicionar);
            this.painelFundo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.painelFundo.Location = new System.Drawing.Point(0, 0);
            this.painelFundo.Margin = new System.Windows.Forms.Padding(4);
            this.painelFundo.Name = "painelFundo";
            this.painelFundo.Size = new System.Drawing.Size(743, 53);
            this.painelFundo.TabIndex = 0;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRemover.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(469, 10);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(159, 41);
            this.btnRemover.TabIndex = 92;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(320, 9);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(143, 41);
            this.btnSalvar.TabIndex = 91;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAdicionar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(150, 10);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(164, 41);
            this.btnAdicionar.TabIndex = 90;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // ControleUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.painelFundo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ControleUs";
            this.Size = new System.Drawing.Size(743, 53);
            this.painelFundo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnRemover;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Button btnAdicionar;
        public System.Windows.Forms.Panel painelFundo;
    }
}
