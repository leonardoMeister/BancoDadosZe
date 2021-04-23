
namespace BancoDadosZe
{
    partial class FormEntradas
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
            this.textoTransportadora = new System.Windows.Forms.Label();
            this.textoValidade = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textoFornecedor = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textoModelo = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textoLoja = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textoProduto = new System.Windows.Forms.Label();
            this.textoValor = new System.Windows.Forms.Label();
            this.btnImportarXml = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.textoMarca = new System.Windows.Forms.Label();
            this.textoQuantidade = new System.Windows.Forms.Label();
            this.textoDataEntrada = new System.Windows.Forms.Label();
            this.campoLaranja = new System.Windows.Forms.TextBox();
            this.textoNotaFiscal = new System.Windows.Forms.Label();
            this.textoLote = new System.Windows.Forms.Label();
            this.mk_validade = new System.Windows.Forms.MaskedTextBox();
            this.mk_marca = new System.Windows.Forms.MaskedTextBox();
            this.mk_valor = new System.Windows.Forms.MaskedTextBox();
            this.mk_lote = new System.Windows.Forms.MaskedTextBox();
            this.mk_transportadora = new System.Windows.Forms.MaskedTextBox();
            this.mk_quantidade = new System.Windows.Forms.MaskedTextBox();
            this.mk_dataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.panelFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.SystemColors.Info;
            this.panelFundo.Controls.Add(this.mk_dataEntrada);
            this.panelFundo.Controls.Add(this.mk_quantidade);
            this.panelFundo.Controls.Add(this.mk_transportadora);
            this.panelFundo.Controls.Add(this.mk_lote);
            this.panelFundo.Controls.Add(this.mk_valor);
            this.panelFundo.Controls.Add(this.mk_marca);
            this.panelFundo.Controls.Add(this.mk_validade);
            this.panelFundo.Controls.Add(this.textoTransportadora);
            this.panelFundo.Controls.Add(this.textoValidade);
            this.panelFundo.Controls.Add(this.comboBox3);
            this.panelFundo.Controls.Add(this.textoFornecedor);
            this.panelFundo.Controls.Add(this.comboBox4);
            this.panelFundo.Controls.Add(this.textoModelo);
            this.panelFundo.Controls.Add(this.comboBox2);
            this.panelFundo.Controls.Add(this.textoLoja);
            this.panelFundo.Controls.Add(this.comboBox1);
            this.panelFundo.Controls.Add(this.textoProduto);
            this.panelFundo.Controls.Add(this.textoValor);
            this.panelFundo.Controls.Add(this.btnImportarXml);
            this.panelFundo.Controls.Add(this.btnAdicionar);
            this.panelFundo.Controls.Add(this.textoMarca);
            this.panelFundo.Controls.Add(this.textoQuantidade);
            this.panelFundo.Controls.Add(this.textoDataEntrada);
            this.panelFundo.Controls.Add(this.campoLaranja);
            this.panelFundo.Controls.Add(this.textoNotaFiscal);
            this.panelFundo.Controls.Add(this.textoLote);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(647, 300);
            this.panelFundo.TabIndex = 1;
            // 
            // textoTransportadora
            // 
            this.textoTransportadora.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTransportadora.Location = new System.Drawing.Point(247, 131);
            this.textoTransportadora.Name = "textoTransportadora";
            this.textoTransportadora.Size = new System.Drawing.Size(190, 18);
            this.textoTransportadora.TabIndex = 129;
            this.textoTransportadora.Text = "Transportadora";
            this.textoTransportadora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoValidade
            // 
            this.textoValidade.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoValidade.Location = new System.Drawing.Point(362, 20);
            this.textoValidade.Name = "textoValidade";
            this.textoValidade.Size = new System.Drawing.Size(104, 21);
            this.textoValidade.TabIndex = 127;
            this.textoValidade.Text = "Validade";
            this.textoValidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Fornecedor 1",
            "Fornecedor 2",
            "Fornecedor 3"});
            this.comboBox3.Location = new System.Drawing.Point(121, 57);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(222, 24);
            this.comboBox3.TabIndex = 126;
            this.comboBox3.TabStop = false;
            // 
            // textoFornecedor
            // 
            this.textoFornecedor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoFornecedor.Location = new System.Drawing.Point(21, 58);
            this.textoFornecedor.Name = "textoFornecedor";
            this.textoFornecedor.Size = new System.Drawing.Size(93, 18);
            this.textoFornecedor.TabIndex = 125;
            this.textoFornecedor.Text = "Fornecedor";
            this.textoFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Generos Alimentos",
            "Ropas",
            "Tecnologia"});
            this.comboBox4.Location = new System.Drawing.Point(121, 94);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(204, 24);
            this.comboBox4.TabIndex = 124;
            this.comboBox4.TabStop = false;
            // 
            // textoModelo
            // 
            this.textoModelo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoModelo.Location = new System.Drawing.Point(30, 95);
            this.textoModelo.Name = "textoModelo";
            this.textoModelo.Size = new System.Drawing.Size(85, 23);
            this.textoModelo.TabIndex = 123;
            this.textoModelo.Text = "Modelo";
            this.textoModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Loja 1",
            "Loja 2",
            "Loja 3",
            "Loja 4"});
            this.comboBox2.Location = new System.Drawing.Point(121, 163);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(212, 24);
            this.comboBox2.TabIndex = 122;
            this.comboBox2.TabStop = false;
            // 
            // textoLoja
            // 
            this.textoLoja.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLoja.Location = new System.Drawing.Point(24, 164);
            this.textoLoja.Name = "textoLoja";
            this.textoLoja.Size = new System.Drawing.Size(91, 21);
            this.textoLoja.TabIndex = 121;
            this.textoLoja.Text = "Loja";
            this.textoLoja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Produto 1",
            "Produto 2",
            "Produto 3",
            "Produto 4"});
            this.comboBox1.Location = new System.Drawing.Point(121, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 24);
            this.comboBox1.TabIndex = 120;
            this.comboBox1.TabStop = false;
            // 
            // textoProduto
            // 
            this.textoProduto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoProduto.Location = new System.Drawing.Point(24, 20);
            this.textoProduto.Name = "textoProduto";
            this.textoProduto.Size = new System.Drawing.Size(91, 21);
            this.textoProduto.TabIndex = 119;
            this.textoProduto.Text = "Produto";
            this.textoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoValor
            // 
            this.textoValor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoValor.Location = new System.Drawing.Point(27, 131);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(88, 21);
            this.textoValor.TabIndex = 117;
            this.textoValor.Text = "Valor";
            this.textoValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnImportarXml
            // 
            this.btnImportarXml.BackColor = System.Drawing.Color.DarkGreen;
            this.btnImportarXml.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarXml.ForeColor = System.Drawing.Color.White;
            this.btnImportarXml.Location = new System.Drawing.Point(173, 238);
            this.btnImportarXml.Name = "btnImportarXml";
            this.btnImportarXml.Size = new System.Drawing.Size(166, 46);
            this.btnImportarXml.TabIndex = 8;
            this.btnImportarXml.Text = "Importar XML";
            this.btnImportarXml.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAdicionar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(345, 238);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(121, 46);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // textoMarca
            // 
            this.textoMarca.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoMarca.Location = new System.Drawing.Point(365, 58);
            this.textoMarca.Name = "textoMarca";
            this.textoMarca.Size = new System.Drawing.Size(101, 23);
            this.textoMarca.TabIndex = 113;
            this.textoMarca.Text = "Marca";
            this.textoMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoQuantidade
            // 
            this.textoQuantidade.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoQuantidade.Location = new System.Drawing.Point(20, 199);
            this.textoQuantidade.Name = "textoQuantidade";
            this.textoQuantidade.Size = new System.Drawing.Size(94, 18);
            this.textoQuantidade.TabIndex = 111;
            this.textoQuantidade.Text = "Quantidade";
            this.textoQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoDataEntrada
            // 
            this.textoDataEntrada.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDataEntrada.Location = new System.Drawing.Point(266, 199);
            this.textoDataEntrada.Name = "textoDataEntrada";
            this.textoDataEntrada.Size = new System.Drawing.Size(171, 21);
            this.textoDataEntrada.TabIndex = 109;
            this.textoDataEntrada.Text = "Data Entrada";
            this.textoDataEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // campoLaranja
            // 
            this.campoLaranja.BackColor = System.Drawing.Color.Coral;
            this.campoLaranja.Location = new System.Drawing.Point(527, 163);
            this.campoLaranja.Name = "campoLaranja";
            this.campoLaranja.Size = new System.Drawing.Size(30, 22);
            this.campoLaranja.TabIndex = 108;
            // 
            // textoNotaFiscal
            // 
            this.textoNotaFiscal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNotaFiscal.Location = new System.Drawing.Point(386, 165);
            this.textoNotaFiscal.Name = "textoNotaFiscal";
            this.textoNotaFiscal.Size = new System.Drawing.Size(135, 20);
            this.textoNotaFiscal.TabIndex = 107;
            this.textoNotaFiscal.Text = "Nota Fiscal";
            this.textoNotaFiscal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoLote
            // 
            this.textoLote.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLote.Location = new System.Drawing.Point(368, 95);
            this.textoLote.Name = "textoLote";
            this.textoLote.Size = new System.Drawing.Size(98, 23);
            this.textoLote.TabIndex = 105;
            this.textoLote.Text = "Lote";
            this.textoLote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mk_validade
            // 
            this.mk_validade.Location = new System.Drawing.Point(472, 20);
            this.mk_validade.Mask = "00/00/0000";
            this.mk_validade.Name = "mk_validade";
            this.mk_validade.Size = new System.Drawing.Size(97, 22);
            this.mk_validade.TabIndex = 130;
            this.mk_validade.ValidatingType = typeof(System.DateTime);
            // 
            // mk_marca
            // 
            this.mk_marca.Location = new System.Drawing.Point(472, 59);
            this.mk_marca.Name = "mk_marca";
            this.mk_marca.Size = new System.Drawing.Size(126, 22);
            this.mk_marca.TabIndex = 131;
            // 
            // mk_valor
            // 
            this.mk_valor.Location = new System.Drawing.Point(121, 131);
            this.mk_valor.Name = "mk_valor";
            this.mk_valor.Size = new System.Drawing.Size(126, 22);
            this.mk_valor.TabIndex = 132;
            // 
            // mk_lote
            // 
            this.mk_lote.Location = new System.Drawing.Point(472, 94);
            this.mk_lote.Mask = "00000";
            this.mk_lote.Name = "mk_lote";
            this.mk_lote.Size = new System.Drawing.Size(60, 22);
            this.mk_lote.TabIndex = 133;
            this.mk_lote.ValidatingType = typeof(int);
            // 
            // mk_transportadora
            // 
            this.mk_transportadora.Location = new System.Drawing.Point(442, 130);
            this.mk_transportadora.Name = "mk_transportadora";
            this.mk_transportadora.Size = new System.Drawing.Size(193, 22);
            this.mk_transportadora.TabIndex = 134;
            // 
            // mk_quantidade
            // 
            this.mk_quantidade.Location = new System.Drawing.Point(121, 199);
            this.mk_quantidade.Mask = "000000";
            this.mk_quantidade.Name = "mk_quantidade";
            this.mk_quantidade.Size = new System.Drawing.Size(67, 22);
            this.mk_quantidade.TabIndex = 135;
            this.mk_quantidade.ValidatingType = typeof(int);
            // 
            // mk_dataEntrada
            // 
            this.mk_dataEntrada.Location = new System.Drawing.Point(443, 199);
            this.mk_dataEntrada.Mask = "00/00/0000";
            this.mk_dataEntrada.Name = "mk_dataEntrada";
            this.mk_dataEntrada.Size = new System.Drawing.Size(89, 22);
            this.mk_dataEntrada.TabIndex = 136;
            this.mk_dataEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // FormEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 300);
            this.Controls.Add(this.panelFundo);
            this.KeyPreview = true;
            this.Name = "FormEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada Produtos";
            this.panelFundo.ResumeLayout(false);
            this.panelFundo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Label textoTransportadora;
        private System.Windows.Forms.Label textoValidade;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label textoFornecedor;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label textoModelo;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label textoLoja;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label textoProduto;
        private System.Windows.Forms.Label textoValor;
        private System.Windows.Forms.Button btnImportarXml;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label textoMarca;
        private System.Windows.Forms.Label textoQuantidade;
        private System.Windows.Forms.Label textoDataEntrada;
        private System.Windows.Forms.TextBox campoLaranja;
        private System.Windows.Forms.Label textoNotaFiscal;
        private System.Windows.Forms.Label textoLote;
        private System.Windows.Forms.MaskedTextBox mk_validade;
        private System.Windows.Forms.MaskedTextBox mk_marca;
        private System.Windows.Forms.MaskedTextBox mk_valor;
        private System.Windows.Forms.MaskedTextBox mk_lote;
        private System.Windows.Forms.MaskedTextBox mk_transportadora;
        private System.Windows.Forms.MaskedTextBox mk_quantidade;
        private System.Windows.Forms.MaskedTextBox mk_dataEntrada;
    }
}