
namespace BancoDadosZe
{
    partial class FormMenu
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.texto_ajustes = new System.Windows.Forms.Label();
            this.texto_logar = new System.Windows.Forms.Label();
            this.textoFuncionarios = new System.Windows.Forms.Label();
            this.textoFornecedor = new System.Windows.Forms.Label();
            this.textoEntradas = new System.Windows.Forms.Label();
            this.textoProdutos = new System.Windows.Forms.Label();
            this.texto_loja = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.texto_escolha = new System.Windows.Forms.Label();
            this.buscar_campo = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelLateral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.DarkOrange;
            this.panelLateral.Controls.Add(this.texto_ajustes);
            this.panelLateral.Controls.Add(this.texto_logar);
            this.panelLateral.Controls.Add(this.textoFuncionarios);
            this.panelLateral.Controls.Add(this.textoFornecedor);
            this.panelLateral.Controls.Add(this.textoEntradas);
            this.panelLateral.Controls.Add(this.textoProdutos);
            this.panelLateral.Controls.Add(this.texto_loja);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(274, 624);
            this.panelLateral.TabIndex = 0;
            // 
            // texto_ajustes
            // 
            this.texto_ajustes.BackColor = System.Drawing.Color.DarkOrange;
            this.texto_ajustes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texto_ajustes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.texto_ajustes.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_ajustes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.texto_ajustes.Image = global::BancoDadosZe.Properties.Resources.settings_42;
            this.texto_ajustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.texto_ajustes.Location = new System.Drawing.Point(0, 496);
            this.texto_ajustes.Name = "texto_ajustes";
            this.texto_ajustes.Size = new System.Drawing.Size(274, 64);
            this.texto_ajustes.TabIndex = 7;
            this.texto_ajustes.Text = "Ajustes";
            this.texto_ajustes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.texto_ajustes.Click += new System.EventHandler(this.texto_ajustes_Click);
            // 
            // texto_logar
            // 
            this.texto_logar.BackColor = System.Drawing.Color.DarkOrange;
            this.texto_logar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texto_logar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.texto_logar.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_logar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.texto_logar.Image = global::BancoDadosZe.Properties.Resources.enter_42;
            this.texto_logar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.texto_logar.Location = new System.Drawing.Point(0, 560);
            this.texto_logar.Name = "texto_logar";
            this.texto_logar.Size = new System.Drawing.Size(274, 64);
            this.texto_logar.TabIndex = 6;
            this.texto_logar.Text = "Entrar";
            this.texto_logar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoFuncionarios
            // 
            this.textoFuncionarios.BackColor = System.Drawing.Color.DarkOrange;
            this.textoFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoFuncionarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.textoFuncionarios.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoFuncionarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textoFuncionarios.Image = global::BancoDadosZe.Properties.Resources.funcionarios;
            this.textoFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.textoFuncionarios.Location = new System.Drawing.Point(0, 351);
            this.textoFuncionarios.Name = "textoFuncionarios";
            this.textoFuncionarios.Size = new System.Drawing.Size(274, 82);
            this.textoFuncionarios.TabIndex = 5;
            this.textoFuncionarios.Text = "Funcionário";
            this.textoFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.textoFuncionarios.Click += new System.EventHandler(this.textoFuncionarios_Click);
            // 
            // textoFornecedor
            // 
            this.textoFornecedor.BackColor = System.Drawing.Color.DarkOrange;
            this.textoFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.textoFornecedor.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoFornecedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textoFornecedor.Image = global::BancoDadosZe.Properties.Resources.fornecedor1;
            this.textoFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.textoFornecedor.Location = new System.Drawing.Point(0, 268);
            this.textoFornecedor.Name = "textoFornecedor";
            this.textoFornecedor.Size = new System.Drawing.Size(274, 83);
            this.textoFornecedor.TabIndex = 4;
            this.textoFornecedor.Text = "Fornecedor";
            this.textoFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.textoFornecedor.Click += new System.EventHandler(this.textoFornecedor_Click);
            // 
            // textoEntradas
            // 
            this.textoEntradas.BackColor = System.Drawing.Color.DarkOrange;
            this.textoEntradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoEntradas.Dock = System.Windows.Forms.DockStyle.Top;
            this.textoEntradas.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoEntradas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textoEntradas.Image = global::BancoDadosZe.Properties.Resources.enter_68;
            this.textoEntradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.textoEntradas.Location = new System.Drawing.Point(0, 185);
            this.textoEntradas.Name = "textoEntradas";
            this.textoEntradas.Size = new System.Drawing.Size(274, 83);
            this.textoEntradas.TabIndex = 3;
            this.textoEntradas.Text = "Entradas";
            this.textoEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.textoEntradas.Click += new System.EventHandler(this.textoEntradas_Click);
            // 
            // textoProdutos
            // 
            this.textoProdutos.BackColor = System.Drawing.Color.DarkOrange;
            this.textoProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.textoProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.textoProdutos.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoProdutos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textoProdutos.Image = global::BancoDadosZe.Properties.Resources.produto_801;
            this.textoProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.textoProdutos.Location = new System.Drawing.Point(0, 88);
            this.textoProdutos.Name = "textoProdutos";
            this.textoProdutos.Size = new System.Drawing.Size(274, 97);
            this.textoProdutos.TabIndex = 2;
            this.textoProdutos.Text = "Produtos";
            this.textoProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.textoProdutos.Click += new System.EventHandler(this.textoProdutos_Click);
            // 
            // texto_loja
            // 
            this.texto_loja.BackColor = System.Drawing.Color.DarkOrange;
            this.texto_loja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texto_loja.Dock = System.Windows.Forms.DockStyle.Top;
            this.texto_loja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.texto_loja.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_loja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.texto_loja.Image = global::BancoDadosZe.Properties.Resources.store_78;
            this.texto_loja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.texto_loja.Location = new System.Drawing.Point(0, 0);
            this.texto_loja.Name = "texto_loja";
            this.texto_loja.Size = new System.Drawing.Size(274, 88);
            this.texto_loja.TabIndex = 1;
            this.texto_loja.Text = "Lojas";
            this.texto_loja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.texto_loja.Click += new System.EventHandler(this.textoLojas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.texto_escolha);
            this.panel1.Controls.Add(this.buscar_campo);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.btn_adicionar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(274, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 624);
            this.panel1.TabIndex = 1;
            // 
            // texto_escolha
            // 
            this.texto_escolha.BackColor = System.Drawing.Color.Moccasin;
            this.texto_escolha.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_escolha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.texto_escolha.Location = new System.Drawing.Point(19, 79);
            this.texto_escolha.Name = "texto_escolha";
            this.texto_escolha.Size = new System.Drawing.Size(208, 37);
            this.texto_escolha.TabIndex = 5;
            this.texto_escolha.Text = "Escolha";
            this.texto_escolha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buscar_campo
            // 
            this.buscar_campo.Location = new System.Drawing.Point(461, 64);
            this.buscar_campo.Margin = new System.Windows.Forms.Padding(4);
            this.buscar_campo.Name = "buscar_campo";
            this.buscar_campo.Size = new System.Drawing.Size(173, 22);
            this.buscar_campo.TabIndex = 4;
            this.buscar_campo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Moccasin;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_editar.Image = global::BancoDadosZe.Properties.Resources.editar;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_editar.Location = new System.Drawing.Point(781, 26);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(83, 82);
            this.btn_editar.TabIndex = 3;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Moccasin;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_buscar.Image = global::BancoDadosZe.Properties.Resources.file_42;
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_buscar.Location = new System.Drawing.Point(644, 26);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(83, 82);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.Moccasin;
            this.btn_adicionar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_adicionar.FlatAppearance.BorderSize = 0;
            this.btn_adicionar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_adicionar.Image = global::BancoDadosZe.Properties.Resources.adicionar_42;
            this.btn_adicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_adicionar.Location = new System.Drawing.Point(872, 26);
            this.btn_adicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(83, 82);
            this.btn_adicionar.TabIndex = 1;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_adicionar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 116);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(913, 494);
            this.dataGridView1.TabIndex = 0;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panelLateral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label textoProdutos;
        private System.Windows.Forms.Label texto_loja;
        private System.Windows.Forms.Label textoFuncionarios;
        private System.Windows.Forms.Label textoFornecedor;
        private System.Windows.Forms.Label textoEntradas;
        private System.Windows.Forms.Label texto_logar;
        private System.Windows.Forms.Label texto_ajustes;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.TextBox buscar_campo;
        private System.Windows.Forms.Label texto_escolha;
    }
}

