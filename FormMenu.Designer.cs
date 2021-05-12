
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_marca = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.btn_ajustes = new System.Windows.Forms.Button();
            this.btn_funcionario = new System.Windows.Forms.Button();
            this.btn_fornecedor = new System.Windows.Forms.Button();
            this.btn_entradas = new System.Windows.Forms.Button();
            this.btn_produtos = new System.Windows.Forms.Button();
            this.btn_lojas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.texto_escolha = new System.Windows.Forms.Label();
            this.buscar_campo = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.contextMenuStripPrincipal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lojasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripIcone = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirAplicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLateral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.contextMenuStripPrincipal.SuspendLayout();
            this.contextMenuStripIcone.SuspendLayout();
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
            this.panelLateral.Controls.Add(this.button1);
            this.panelLateral.Controls.Add(this.btn_marca);
            this.panelLateral.Controls.Add(this.btn_entrar);
            this.panelLateral.Controls.Add(this.btn_ajustes);
            this.panelLateral.Controls.Add(this.btn_funcionario);
            this.panelLateral.Controls.Add(this.btn_fornecedor);
            this.panelLateral.Controls.Add(this.btn_entradas);
            this.panelLateral.Controls.Add(this.btn_produtos);
            this.panelLateral.Controls.Add(this.btn_lojas);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(372, 711);
            this.panelLateral.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::BancoDadosZe.Properties.Resources.funcionarios;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(372, 70);
            this.button1.TabIndex = 16;
            this.button1.Text = "Área de Atuação";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_area_atuacao);
            // 
            // btn_marca
            // 
            this.btn_marca.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_marca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_marca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_marca.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_marca.ForeColor = System.Drawing.Color.White;
            this.btn_marca.Image = global::BancoDadosZe.Properties.Resources.funcionarios;
            this.btn_marca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_marca.Location = new System.Drawing.Point(0, 349);
            this.btn_marca.Name = "btn_marca";
            this.btn_marca.Size = new System.Drawing.Size(372, 69);
            this.btn_marca.TabIndex = 15;
            this.btn_marca.Text = "Marcas";
            this.btn_marca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_marca.UseVisualStyleBackColor = false;
            this.btn_marca.Click += new System.EventHandler(this.btn_marca_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_entrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_entrar.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.Color.White;
            this.btn_entrar.Image = global::BancoDadosZe.Properties.Resources.enter_42;
            this.btn_entrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_entrar.Location = new System.Drawing.Point(0, 583);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(372, 64);
            this.btn_entrar.TabIndex = 14;
            this.btn_entrar.Text = "Entrar Banco";
            this.btn_entrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // btn_ajustes
            // 
            this.btn_ajustes.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_ajustes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ajustes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ajustes.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajustes.ForeColor = System.Drawing.Color.White;
            this.btn_ajustes.Image = global::BancoDadosZe.Properties.Resources.settings_42;
            this.btn_ajustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ajustes.Location = new System.Drawing.Point(0, 647);
            this.btn_ajustes.Name = "btn_ajustes";
            this.btn_ajustes.Size = new System.Drawing.Size(372, 64);
            this.btn_ajustes.TabIndex = 13;
            this.btn_ajustes.Text = "Ajustes";
            this.btn_ajustes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ajustes.UseVisualStyleBackColor = false;
            this.btn_ajustes.Click += new System.EventHandler(this.btn_ajustes_Click);
            // 
            // btn_funcionario
            // 
            this.btn_funcionario.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_funcionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_funcionario.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_funcionario.ForeColor = System.Drawing.Color.White;
            this.btn_funcionario.Image = global::BancoDadosZe.Properties.Resources.funcionarios;
            this.btn_funcionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_funcionario.Location = new System.Drawing.Point(0, 278);
            this.btn_funcionario.Name = "btn_funcionario";
            this.btn_funcionario.Size = new System.Drawing.Size(372, 71);
            this.btn_funcionario.TabIndex = 12;
            this.btn_funcionario.Text = "Funcionário";
            this.btn_funcionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_funcionario.UseVisualStyleBackColor = false;
            this.btn_funcionario.Click += new System.EventHandler(this.btn_funcionario_Click);
            // 
            // btn_fornecedor
            // 
            this.btn_fornecedor.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_fornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_fornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fornecedor.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fornecedor.ForeColor = System.Drawing.Color.White;
            this.btn_fornecedor.Image = global::BancoDadosZe.Properties.Resources.fornecedor1;
            this.btn_fornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fornecedor.Location = new System.Drawing.Point(0, 207);
            this.btn_fornecedor.Name = "btn_fornecedor";
            this.btn_fornecedor.Size = new System.Drawing.Size(372, 71);
            this.btn_fornecedor.TabIndex = 11;
            this.btn_fornecedor.Text = "Fornecedor";
            this.btn_fornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_fornecedor.UseVisualStyleBackColor = false;
            this.btn_fornecedor.Click += new System.EventHandler(this.btn_fornecedor_Click);
            // 
            // btn_entradas
            // 
            this.btn_entradas.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_entradas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_entradas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_entradas.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entradas.ForeColor = System.Drawing.Color.White;
            this.btn_entradas.Image = global::BancoDadosZe.Properties.Resources.enter_68;
            this.btn_entradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_entradas.Location = new System.Drawing.Point(0, 136);
            this.btn_entradas.Name = "btn_entradas";
            this.btn_entradas.Size = new System.Drawing.Size(372, 71);
            this.btn_entradas.TabIndex = 10;
            this.btn_entradas.Text = "Entradas Estoque";
            this.btn_entradas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_entradas.UseVisualStyleBackColor = false;
            this.btn_entradas.Click += new System.EventHandler(this.btn_entradas_Click);
            // 
            // btn_produtos
            // 
            this.btn_produtos.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_produtos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_produtos.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produtos.ForeColor = System.Drawing.Color.White;
            this.btn_produtos.Image = global::BancoDadosZe.Properties.Resources.produto_801;
            this.btn_produtos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_produtos.Location = new System.Drawing.Point(0, 71);
            this.btn_produtos.Name = "btn_produtos";
            this.btn_produtos.Size = new System.Drawing.Size(372, 65);
            this.btn_produtos.TabIndex = 9;
            this.btn_produtos.Text = "Produtos";
            this.btn_produtos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_produtos.UseVisualStyleBackColor = false;
            this.btn_produtos.Click += new System.EventHandler(this.btn_produtos_Click);
            // 
            // btn_lojas
            // 
            this.btn_lojas.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_lojas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_lojas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_lojas.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lojas.ForeColor = System.Drawing.Color.White;
            this.btn_lojas.Image = global::BancoDadosZe.Properties.Resources.store_78;
            this.btn_lojas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lojas.Location = new System.Drawing.Point(0, 0);
            this.btn_lojas.Name = "btn_lojas";
            this.btn_lojas.Size = new System.Drawing.Size(372, 71);
            this.btn_lojas.TabIndex = 8;
            this.btn_lojas.Text = "Lojas";
            this.btn_lojas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_lojas.UseVisualStyleBackColor = false;
            this.btn_lojas.Click += new System.EventHandler(this.btn_lojas_clic);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.texto_escolha);
            this.panel1.Controls.Add(this.buscar_campo);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.btn_adicionar);
            this.panel1.Controls.Add(this.dataGridViewDados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(372, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 711);
            this.panel1.TabIndex = 1;
            // 
            // texto_escolha
            // 
            this.texto_escolha.BackColor = System.Drawing.Color.Moccasin;
            this.texto_escolha.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_escolha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.texto_escolha.Location = new System.Drawing.Point(9, 75);
            this.texto_escolha.Name = "texto_escolha";
            this.texto_escolha.Size = new System.Drawing.Size(208, 37);
            this.texto_escolha.TabIndex = 5;
            this.texto_escolha.Text = "Escolha";
            this.texto_escolha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buscar_campo
            // 
            this.buscar_campo.Location = new System.Drawing.Point(350, 64);
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
            this.btn_editar.Location = new System.Drawing.Point(669, 26);
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
            this.btn_buscar.Location = new System.Drawing.Point(532, 26);
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
            this.btn_adicionar.Location = new System.Drawing.Point(760, 26);
            this.btn_adicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(83, 82);
            this.btn_adicionar.TabIndex = 1;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_adicionar.UseVisualStyleBackColor = false;
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.Location = new System.Drawing.Point(14, 116);
            this.dataGridViewDados.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.RowHeadersWidth = 51;
            this.dataGridViewDados.Size = new System.Drawing.Size(832, 541);
            this.dataGridViewDados.TabIndex = 0;
            // 
            // contextMenuStripPrincipal
            // 
            this.contextMenuStripPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lojasToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.entradasToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.ajustesToolStripMenuItem,
            this.logarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.contextMenuStripPrincipal.Name = "contextMenuStripPrincipal";
            this.contextMenuStripPrincipal.Size = new System.Drawing.Size(186, 196);
            // 
            // lojasToolStripMenuItem
            // 
            this.lojasToolStripMenuItem.Name = "lojasToolStripMenuItem";
            this.lojasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.lojasToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.lojasToolStripMenuItem.Text = "Lojas";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.entradasToolStripMenuItem.Text = "Entradas";
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.ajustesToolStripMenuItem.Text = "Ajustes";
            // 
            // logarToolStripMenuItem
            // 
            this.logarToolStripMenuItem.Name = "logarToolStripMenuItem";
            this.logarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.logarToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.logarToolStripMenuItem.Text = "Entrar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // notifyIconSystemTray
            // 
            this.notifyIconSystemTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconSystemTray.BalloonTipText = "Aplicação continua executando na bandeja.";
            this.notifyIconSystemTray.BalloonTipTitle = "Controle Estoque Zé";
            this.notifyIconSystemTray.ContextMenuStrip = this.contextMenuStripIcone;
            this.notifyIconSystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconSystemTray.Icon")));
            this.notifyIconSystemTray.Text = "Controle Estoque";
            this.notifyIconSystemTray.Visible = true;
            this.notifyIconSystemTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconSystemTray_MouseDoubleClick);
            // 
            // contextMenuStripIcone
            // 
            this.contextMenuStripIcone.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripIcone.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirAplicaçãoToolStripMenuItem,
            this.encerrarToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.contextMenuStripIcone.Name = "contextMenuStripIcone";
            this.contextMenuStripIcone.Size = new System.Drawing.Size(182, 76);
            // 
            // abrirAplicaçãoToolStripMenuItem
            // 
            this.abrirAplicaçãoToolStripMenuItem.Name = "abrirAplicaçãoToolStripMenuItem";
            this.abrirAplicaçãoToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.abrirAplicaçãoToolStripMenuItem.Text = "Abrir Aplicação";
            // 
            // encerrarToolStripMenuItem
            // 
            this.encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            this.encerrarToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.encerrarToolStripMenuItem.Text = "Encerrar";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 711);
            this.ContextMenuStrip = this.contextMenuStripPrincipal;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Resize += new System.EventHandler(this.FormMenu_Resize);
            this.panelLateral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            this.contextMenuStripPrincipal.ResumeLayout(false);
            this.contextMenuStripIcone.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.DataGridView dataGridViewDados;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.TextBox buscar_campo;
        private System.Windows.Forms.Label texto_escolha;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem lojasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btn_lojas;
        private System.Windows.Forms.Button btn_produtos;
        private System.Windows.Forms.Button btn_entradas;
        private System.Windows.Forms.Button btn_fornecedor;
        private System.Windows.Forms.Button btn_funcionario;
        private System.Windows.Forms.Button btn_ajustes;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.NotifyIcon notifyIconSystemTray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripIcone;
        private System.Windows.Forms.ToolStripMenuItem abrirAplicaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Button btn_marca;
        private System.Windows.Forms.Button button1;
    }
}

