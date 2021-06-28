
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
            this.btn_pdf = new System.Windows.Forms.Button();
            this.btnImportarXml = new System.Windows.Forms.Button();
            this.groupBoxProdutos = new System.Windows.Forms.GroupBox();
            this.textItensCadastrados = new System.Windows.Forms.Label();
            this.listBoxEntradasCadastradas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxParaCadastrar = new System.Windows.Forms.ListBox();
            this.listBoxProdutos = new System.Windows.Forms.ListBox();
            this.groupBoxEntrada = new System.Windows.Forms.GroupBox();
            this.textoFornecedor = new System.Windows.Forms.Label();
            this.mk_notaFiscal = new System.Windows.Forms.MaskedTextBox();
            this.textoNF = new System.Windows.Forms.Label();
            this.mk_Chave = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxFornecedor = new System.Windows.Forms.ComboBox();
            this.mk_dataEntrada = new System.Windows.Forms.DateTimePicker();
            this.mk_total = new System.Windows.Forms.MaskedTextBox();
            this.textoChave = new System.Windows.Forms.Label();
            this.textoDataEntrada = new System.Windows.Forms.Label();
            this.mk_serie = new System.Windows.Forms.MaskedTextBox();
            this.textoLoja = new System.Windows.Forms.Label();
            this.comboBoxLoja = new System.Windows.Forms.ComboBox();
            this.textoSerie = new System.Windows.Forms.Label();
            this.textoTotaldaNota = new System.Windows.Forms.Label();
            this.mk_observacao = new System.Windows.Forms.TextBox();
            this.mk_id = new System.Windows.Forms.TextBox();
            this.textoObservacao = new System.Windows.Forms.Label();
            this.textoId = new System.Windows.Forms.Label();
            this.textoValidade = new System.Windows.Forms.Label();
            this.mk_dataNf = new System.Windows.Forms.DateTimePicker();
            this.userControleUsBTN = new BancoDadosZe.ControleUsBTN();
            this.openFileXml = new System.Windows.Forms.OpenFileDialog();
            this.panelFundo.SuspendLayout();
            this.groupBoxProdutos.SuspendLayout();
            this.groupBoxEntrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.SystemColors.Info;
            this.panelFundo.Controls.Add(this.btn_pdf);
            this.panelFundo.Controls.Add(this.btnImportarXml);
            this.panelFundo.Controls.Add(this.groupBoxProdutos);
            this.panelFundo.Controls.Add(this.groupBoxEntrada);
            this.panelFundo.Controls.Add(this.userControleUsBTN);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(842, 535);
            this.panelFundo.TabIndex = 1;
            // 
            // btn_pdf
            // 
            this.btn_pdf.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_pdf.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pdf.ForeColor = System.Drawing.Color.White;
            this.btn_pdf.Location = new System.Drawing.Point(762, 486);
            this.btn_pdf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(68, 41);
            this.btn_pdf.TabIndex = 151;
            this.btn_pdf.Text = "PDF";
            this.btn_pdf.UseVisualStyleBackColor = false;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // btnImportarXml
            // 
            this.btnImportarXml.BackColor = System.Drawing.Color.DarkGreen;
            this.btnImportarXml.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarXml.ForeColor = System.Drawing.Color.White;
            this.btnImportarXml.Location = new System.Drawing.Point(483, 486);
            this.btnImportarXml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImportarXml.Name = "btnImportarXml";
            this.btnImportarXml.Size = new System.Drawing.Size(159, 41);
            this.btnImportarXml.TabIndex = 93;
            this.btnImportarXml.Text = "Importar XML";
            this.btnImportarXml.UseVisualStyleBackColor = false;
            this.btnImportarXml.Click += new System.EventHandler(this.btnImportarXml_Click);
            // 
            // groupBoxProdutos
            // 
            this.groupBoxProdutos.Controls.Add(this.textItensCadastrados);
            this.groupBoxProdutos.Controls.Add(this.listBoxEntradasCadastradas);
            this.groupBoxProdutos.Controls.Add(this.label2);
            this.groupBoxProdutos.Controls.Add(this.label1);
            this.groupBoxProdutos.Controls.Add(this.listBoxParaCadastrar);
            this.groupBoxProdutos.Controls.Add(this.listBoxProdutos);
            this.groupBoxProdutos.Location = new System.Drawing.Point(12, 217);
            this.groupBoxProdutos.Name = "groupBoxProdutos";
            this.groupBoxProdutos.Size = new System.Drawing.Size(818, 262);
            this.groupBoxProdutos.TabIndex = 150;
            this.groupBoxProdutos.TabStop = false;
            this.groupBoxProdutos.Text = "Controle Itens";
            // 
            // textItensCadastrados
            // 
            this.textItensCadastrados.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textItensCadastrados.Location = new System.Drawing.Point(556, 38);
            this.textItensCadastrados.Name = "textItensCadastrados";
            this.textItensCadastrados.Size = new System.Drawing.Size(213, 21);
            this.textItensCadastrados.TabIndex = 152;
            this.textItensCadastrados.Text = "Entradas Cadastradas";
            this.textItensCadastrados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxEntradasCadastradas
            // 
            this.listBoxEntradasCadastradas.FormattingEnabled = true;
            this.listBoxEntradasCadastradas.ItemHeight = 16;
            this.listBoxEntradasCadastradas.Location = new System.Drawing.Point(559, 62);
            this.listBoxEntradasCadastradas.Name = "listBoxEntradasCadastradas";
            this.listBoxEntradasCadastradas.Size = new System.Drawing.Size(241, 180);
            this.listBoxEntradasCadastradas.TabIndex = 151;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 21);
            this.label2.TabIndex = 150;
            this.label2.Text = "Entrada Itens";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 21);
            this.label1.TabIndex = 149;
            this.label1.Text = "Produtos Para Entradas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxParaCadastrar
            // 
            this.listBoxParaCadastrar.FormattingEnabled = true;
            this.listBoxParaCadastrar.ItemHeight = 16;
            this.listBoxParaCadastrar.Location = new System.Drawing.Point(287, 62);
            this.listBoxParaCadastrar.Name = "listBoxParaCadastrar";
            this.listBoxParaCadastrar.Size = new System.Drawing.Size(241, 180);
            this.listBoxParaCadastrar.TabIndex = 1;
            // 
            // listBoxProdutos
            // 
            this.listBoxProdutos.FormattingEnabled = true;
            this.listBoxProdutos.ItemHeight = 16;
            this.listBoxProdutos.Location = new System.Drawing.Point(18, 62);
            this.listBoxProdutos.Name = "listBoxProdutos";
            this.listBoxProdutos.Size = new System.Drawing.Size(240, 180);
            this.listBoxProdutos.TabIndex = 0;
            this.listBoxProdutos.SelectedIndexChanged += new System.EventHandler(this.listBoxProdutos_SelectedIndexChanged);
            // 
            // groupBoxEntrada
            // 
            this.groupBoxEntrada.Controls.Add(this.textoFornecedor);
            this.groupBoxEntrada.Controls.Add(this.mk_notaFiscal);
            this.groupBoxEntrada.Controls.Add(this.textoNF);
            this.groupBoxEntrada.Controls.Add(this.mk_Chave);
            this.groupBoxEntrada.Controls.Add(this.comboBoxFornecedor);
            this.groupBoxEntrada.Controls.Add(this.mk_dataEntrada);
            this.groupBoxEntrada.Controls.Add(this.mk_total);
            this.groupBoxEntrada.Controls.Add(this.textoChave);
            this.groupBoxEntrada.Controls.Add(this.textoDataEntrada);
            this.groupBoxEntrada.Controls.Add(this.mk_serie);
            this.groupBoxEntrada.Controls.Add(this.textoLoja);
            this.groupBoxEntrada.Controls.Add(this.comboBoxLoja);
            this.groupBoxEntrada.Controls.Add(this.textoSerie);
            this.groupBoxEntrada.Controls.Add(this.textoTotaldaNota);
            this.groupBoxEntrada.Controls.Add(this.mk_observacao);
            this.groupBoxEntrada.Controls.Add(this.mk_id);
            this.groupBoxEntrada.Controls.Add(this.textoObservacao);
            this.groupBoxEntrada.Controls.Add(this.textoId);
            this.groupBoxEntrada.Controls.Add(this.textoValidade);
            this.groupBoxEntrada.Controls.Add(this.mk_dataNf);
            this.groupBoxEntrada.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEntrada.Name = "groupBoxEntrada";
            this.groupBoxEntrada.Size = new System.Drawing.Size(818, 199);
            this.groupBoxEntrada.TabIndex = 149;
            this.groupBoxEntrada.TabStop = false;
            this.groupBoxEntrada.Text = "Entrada De Estoque";
            // 
            // textoFornecedor
            // 
            this.textoFornecedor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoFornecedor.Location = new System.Drawing.Point(6, 58);
            this.textoFornecedor.Name = "textoFornecedor";
            this.textoFornecedor.Size = new System.Drawing.Size(112, 18);
            this.textoFornecedor.TabIndex = 125;
            this.textoFornecedor.Text = "Fornecedor";
            this.textoFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mk_notaFiscal
            // 
            this.mk_notaFiscal.Location = new System.Drawing.Point(583, 58);
            this.mk_notaFiscal.Mask = "000000000000000";
            this.mk_notaFiscal.Name = "mk_notaFiscal";
            this.mk_notaFiscal.Size = new System.Drawing.Size(135, 22);
            this.mk_notaFiscal.TabIndex = 146;
            this.mk_notaFiscal.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mk_notaFiscal.ValidatingType = typeof(int);
            // 
            // textoNF
            // 
            this.textoNF.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNF.Location = new System.Drawing.Point(440, 59);
            this.textoNF.Name = "textoNF";
            this.textoNF.Size = new System.Drawing.Size(137, 23);
            this.textoNF.TabIndex = 145;
            this.textoNF.Text = "Nota Fiscal";
            this.textoNF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mk_Chave
            // 
            this.mk_Chave.Location = new System.Drawing.Point(261, 27);
            this.mk_Chave.Name = "mk_Chave";
            this.mk_Chave.Size = new System.Drawing.Size(253, 22);
            this.mk_Chave.TabIndex = 148;
            this.mk_Chave.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // comboBoxFornecedor
            // 
            this.comboBoxFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFornecedor.FormattingEnabled = true;
            this.comboBoxFornecedor.Location = new System.Drawing.Point(128, 58);
            this.comboBoxFornecedor.Name = "comboBoxFornecedor";
            this.comboBoxFornecedor.Size = new System.Drawing.Size(258, 24);
            this.comboBoxFornecedor.TabIndex = 126;
            this.comboBoxFornecedor.TabStop = false;
            // 
            // mk_dataEntrada
            // 
            this.mk_dataEntrada.Location = new System.Drawing.Point(455, 94);
            this.mk_dataEntrada.Name = "mk_dataEntrada";
            this.mk_dataEntrada.Size = new System.Drawing.Size(289, 22);
            this.mk_dataEntrada.TabIndex = 139;
            // 
            // mk_total
            // 
            this.mk_total.Enabled = false;
            this.mk_total.Location = new System.Drawing.Point(684, 29);
            this.mk_total.Name = "mk_total";
            this.mk_total.Size = new System.Drawing.Size(106, 22);
            this.mk_total.TabIndex = 140;
            this.mk_total.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mk_total.ValidatingType = typeof(int);
            // 
            // textoChave
            // 
            this.textoChave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoChave.Location = new System.Drawing.Point(179, 27);
            this.textoChave.Name = "textoChave";
            this.textoChave.Size = new System.Drawing.Size(76, 23);
            this.textoChave.TabIndex = 147;
            this.textoChave.Text = "Chave";
            this.textoChave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoDataEntrada
            // 
            this.textoDataEntrada.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDataEntrada.Location = new System.Drawing.Point(279, 94);
            this.textoDataEntrada.Name = "textoDataEntrada";
            this.textoDataEntrada.Size = new System.Drawing.Size(171, 21);
            this.textoDataEntrada.TabIndex = 109;
            this.textoDataEntrada.Text = "Data Entrada";
            this.textoDataEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mk_serie
            // 
            this.mk_serie.Location = new System.Drawing.Point(127, 128);
            this.mk_serie.Mask = "00000";
            this.mk_serie.Name = "mk_serie";
            this.mk_serie.Size = new System.Drawing.Size(60, 22);
            this.mk_serie.TabIndex = 133;
            this.mk_serie.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mk_serie.ValidatingType = typeof(int);
            // 
            // textoLoja
            // 
            this.textoLoja.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLoja.Location = new System.Drawing.Point(15, 90);
            this.textoLoja.Name = "textoLoja";
            this.textoLoja.Size = new System.Drawing.Size(91, 21);
            this.textoLoja.TabIndex = 121;
            this.textoLoja.Text = "Loja";
            this.textoLoja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxLoja
            // 
            this.comboBoxLoja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoja.FormattingEnabled = true;
            this.comboBoxLoja.Location = new System.Drawing.Point(127, 91);
            this.comboBoxLoja.Name = "comboBoxLoja";
            this.comboBoxLoja.Size = new System.Drawing.Size(149, 24);
            this.comboBoxLoja.TabIndex = 122;
            this.comboBoxLoja.TabStop = false;
            // 
            // textoSerie
            // 
            this.textoSerie.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoSerie.Location = new System.Drawing.Point(8, 127);
            this.textoSerie.Name = "textoSerie";
            this.textoSerie.Size = new System.Drawing.Size(98, 23);
            this.textoSerie.TabIndex = 105;
            this.textoSerie.Text = "Série";
            this.textoSerie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoTotaldaNota
            // 
            this.textoTotaldaNota.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTotaldaNota.Location = new System.Drawing.Point(520, 28);
            this.textoTotaldaNota.Name = "textoTotaldaNota";
            this.textoTotaldaNota.Size = new System.Drawing.Size(145, 22);
            this.textoTotaldaNota.TabIndex = 117;
            this.textoTotaldaNota.Text = "Total Da Nota";
            this.textoTotaldaNota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mk_observacao
            // 
            this.mk_observacao.Location = new System.Drawing.Point(418, 125);
            this.mk_observacao.Multiline = true;
            this.mk_observacao.Name = "mk_observacao";
            this.mk_observacao.Size = new System.Drawing.Size(326, 57);
            this.mk_observacao.TabIndex = 142;
            // 
            // mk_id
            // 
            this.mk_id.Enabled = false;
            this.mk_id.Location = new System.Drawing.Point(112, 27);
            this.mk_id.Name = "mk_id";
            this.mk_id.Size = new System.Drawing.Size(55, 22);
            this.mk_id.TabIndex = 144;
            // 
            // textoObservacao
            // 
            this.textoObservacao.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoObservacao.Location = new System.Drawing.Point(282, 124);
            this.textoObservacao.Name = "textoObservacao";
            this.textoObservacao.Size = new System.Drawing.Size(130, 22);
            this.textoObservacao.TabIndex = 141;
            this.textoObservacao.Text = "Observação";
            this.textoObservacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoId
            // 
            this.textoId.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoId.Location = new System.Drawing.Point(46, 27);
            this.textoId.Name = "textoId";
            this.textoId.Size = new System.Drawing.Size(60, 22);
            this.textoId.TabIndex = 143;
            this.textoId.Text = "Id";
            this.textoId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textoValidade
            // 
            this.textoValidade.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoValidade.Location = new System.Drawing.Point(2, 164);
            this.textoValidade.Name = "textoValidade";
            this.textoValidade.Size = new System.Drawing.Size(104, 21);
            this.textoValidade.TabIndex = 127;
            this.textoValidade.Text = "Data Nf";
            this.textoValidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mk_dataNf
            // 
            this.mk_dataNf.Location = new System.Drawing.Point(112, 164);
            this.mk_dataNf.Name = "mk_dataNf";
            this.mk_dataNf.Size = new System.Drawing.Size(289, 22);
            this.mk_dataNf.TabIndex = 138;
            // 
            // userControleUsBTN
            // 
            this.userControleUsBTN.Location = new System.Drawing.Point(15, 478);
            this.userControleUsBTN.Margin = new System.Windows.Forms.Padding(4);
            this.userControleUsBTN.Name = "userControleUsBTN";
            this.userControleUsBTN.Size = new System.Drawing.Size(637, 53);
            this.userControleUsBTN.TabIndex = 137;
            this.userControleUsBTN.Load += new System.EventHandler(this.userControleUsBTN_Load);
            // 
            // openFileXml
            // 
            this.openFileXml.FileName = "openFileDialog1";
            this.openFileXml.Filter = "Arquivo Xml|*.xml";
            // 
            // FormEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 535);
            this.Controls.Add(this.panelFundo);
            this.KeyPreview = true;
            this.Name = "FormEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada Produtos";
            this.panelFundo.ResumeLayout(false);
            this.groupBoxProdutos.ResumeLayout(false);
            this.groupBoxEntrada.ResumeLayout(false);
            this.groupBoxEntrada.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Label textoValidade;
        private System.Windows.Forms.ComboBox comboBoxFornecedor;
        private System.Windows.Forms.Label textoFornecedor;
        private System.Windows.Forms.ComboBox comboBoxLoja;
        private System.Windows.Forms.Label textoLoja;
        private System.Windows.Forms.Label textoTotaldaNota;
        private System.Windows.Forms.Label textoDataEntrada;
        private System.Windows.Forms.Label textoSerie;
        private System.Windows.Forms.MaskedTextBox mk_serie;
        private ControleUsBTN userControleUsBTN;
        private System.Windows.Forms.DateTimePicker mk_dataNf;
        private System.Windows.Forms.DateTimePicker mk_dataEntrada;
        private System.Windows.Forms.MaskedTextBox mk_total;
        private System.Windows.Forms.Label textoObservacao;
        private System.Windows.Forms.MaskedTextBox mk_Chave;
        private System.Windows.Forms.Label textoChave;
        private System.Windows.Forms.MaskedTextBox mk_notaFiscal;
        private System.Windows.Forms.Label textoNF;
        private System.Windows.Forms.TextBox mk_id;
        private System.Windows.Forms.Label textoId;
        private System.Windows.Forms.TextBox mk_observacao;
        private System.Windows.Forms.GroupBox groupBoxEntrada;
        private System.Windows.Forms.GroupBox groupBoxProdutos;
        public System.Windows.Forms.Button btnImportarXml;
        private System.Windows.Forms.ListBox listBoxParaCadastrar;
        private System.Windows.Forms.ListBox listBoxProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textItensCadastrados;
        private System.Windows.Forms.ListBox listBoxEntradasCadastradas;
        private System.Windows.Forms.OpenFileDialog openFileXml;
        public System.Windows.Forms.Button btn_pdf;
    }
}