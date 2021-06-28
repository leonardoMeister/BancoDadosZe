using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BancoDadosZe.FormsCadastraveis;
using ControleEstoqueDao.DAO;
using System.Xml;

namespace BancoDadosZe
{
    /// <summary>
    /// classe de form para entradas de produtos
    /// </summary>
    public partial class FormEntradas : Form
    {
        List<string[]> listaProdutos;
        //declarando os objetos necessarios

        readonly string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        readonly string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

        private readonly EntradaEstoqueDAO daoEntrada;
        private readonly ItensEntradaDAO daoItens;
        private readonly FornecedorDAO daoFornecedor;
        private readonly LojaDAO daoLoja;
        private readonly ProdutosDAO daoProduto;
        private readonly EnderecoDAO daoEndereco;
        private Fornecedor fornecedor;
        private EntradaEstoque entradaEstoque;
        private Loja loja;
        private Endereco endereco;
        private FormItens formItens;
        private Produtos produtos;

        /// <summary>
        /// inicializando os componentes
        /// </summary>
        public FormEntradas()
        {
            InitializeComponent();
            daoEndereco = new EnderecoDAO();
            daoEntrada = new EntradaEstoqueDAO();
            daoFornecedor = new FornecedorDAO();
            daoLoja = new LojaDAO();
            daoItens = new ItensEntradaDAO();
            daoProduto = new ProdutosDAO();

            userControleUsBTN.btnRemover.Visible = false;

            //evento de destaque de campos
            mk_serie.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_dataEntrada.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_dataNf.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            //leave
            mk_serie.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_dataEntrada.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_dataNf.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);

            //eventos do controle de usuario
            userControleUsBTN.btnAdicionar.Click += BtnAdicionar_Click;
            userControleUsBTN.btnSalvar.Click += BtnSalvar_Click;

            //evento de teclado para tab no enter e Esc
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);

            AtualizarTela();
        }
        public void PegaPreencherFormComDadosBanco(int id)
        {
            AtualizarTela();
            if (id == 0)
            {
                userControleUsBTN.btnRemover.Enabled = false;
                userControleUsBTN.btnSalvar.Enabled = false;
                btn_pdf.Enabled = false;
                this.ShowDialog();
                userControleUsBTN.btnRemover.Enabled = true;
                userControleUsBTN.btnSalvar.Enabled = true;
                btn_pdf.Enabled = true;
            }
            else
            {
                DataTable lista = daoEntrada.SelectDbProvider(provider, strConnection, new EntradaEstoque(id, ""));
                DataTable listaItens = daoItens.SelectDbProvider(provider, strConnection, new ItensEntrada(id));

                foreach (DataRow row in listaItens.Rows)
                {
                    ItensEntrada itens = new ItensEntrada
                    {

                        EntradasEstoqueId = Convert.ToInt32(row[0].ToString()),
                        Quantidade = Convert.ToInt32(row[1].ToString()),
                        ValorUnitario = Convert.ToDecimal(row[2].ToString()),
                        Modelo = row[3].ToString(),
                        Lote = Convert.ToInt32(row[4].ToString()),
                        DataValidade = Convert.ToDateTime(row[5].ToString()),
                        ProdutoId = Convert.ToInt32(row[6].ToString()),
                        MarcaId = Convert.ToInt32(row[7].ToString()),
                    };
                    listBoxEntradasCadastradas.Items.Add(itens);

                }

                foreach (DataRow row in lista.Rows)
                {
                    mk_id.Text = row[0].ToString();
                    mk_notaFiscal.Text = row[1].ToString();
                    mk_serie.Text = row[2].ToString();
                    mk_dataNf.Value = Convert.ToDateTime(row[3].ToString());
                    mk_Chave.Text = row[4].ToString();
                    mk_dataEntrada.Value = Convert.ToDateTime(row[5].ToString());
                    mk_observacao.Text = row[6].ToString();
                    mk_total.Text = row[7].ToString();
                    foreach (Fornecedor fornecedor in comboBoxFornecedor.Items)
                    {
                        if (fornecedor.IdFornecedor == Convert.ToInt32(row[8].ToString()))
                        {
                            comboBoxFornecedor.SelectedItem = fornecedor;
                        }
                    }
                    foreach (Loja loja in comboBoxLoja.Items)
                    {
                        if (loja.IdLoja == Convert.ToInt32(row[9].ToString()))
                        {
                            comboBoxLoja.SelectedItem = loja;
                        }
                    }
                }
                userControleUsBTN.btnRemover.Enabled = false;
                btnImportarXml.Enabled = false;
                userControleUsBTN.btnAdicionar.Enabled = false;
                groupBoxEntrada.Enabled = false;
                listBoxProdutos.Enabled = false;
                AtualizarValorNota();
                this.ShowDialog();
                btnImportarXml.Enabled = true;
                listBoxProdutos.Enabled = true;
                userControleUsBTN.btnRemover.Enabled = true;
                groupBoxEntrada.Enabled = true;
                userControleUsBTN.btnAdicionar.Enabled = true;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            entradaEstoque = new EntradaEstoque
            {
                IdEntradaEstoque = Convert.ToInt32(mk_id.Text),
                ValorTotal = Convert.ToDecimal(mk_total.Text),
            };

            daoEntrada.InserirDbProvider(provider, strConnection, entradaEstoque);

            foreach (ItensEntrada item in listBoxParaCadastrar.Items)
            {
                item.EntradasEstoqueId = Convert.ToInt32(mk_id.Text);
                daoItens.InserirDbProvider(provider, strConnection, item);
            }


            ClassFuncoes.FecharTela(this);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (comboBoxLoja.SelectedIndex != -1)
            {
                InserirDbProvider();
                ClassFuncoes.FecharTela(this);
            }
            else MessageBox.Show("Selecione Uma Loja");

        }

        private void InserirDbProvider()
        {
            entradaEstoque = new EntradaEstoque();

            entradaEstoque.IdEntradaEstoque = Convert.ToInt32(mk_id.Text);
            entradaEstoque.ChaveNf = mk_Chave.Text;
            entradaEstoque.ValorTotal = Convert.ToDecimal(mk_total.Text);
            entradaEstoque.NumeroNf = mk_notaFiscal.Text;
            entradaEstoque.DataEntrada = Convert.ToDateTime(mk_dataEntrada.Text);
            entradaEstoque.Observacao = mk_observacao.Text;
            entradaEstoque.SerieNf = mk_serie.Text;
            entradaEstoque.DataNf = Convert.ToDateTime(mk_dataNf.Text);
            entradaEstoque.FornecedorId = ((Fornecedor)comboBoxFornecedor.SelectedItem).IdFornecedor;
            entradaEstoque.LojaId = ((Loja)comboBoxLoja.SelectedItem).IdLoja;

            int idEntrada = daoEntrada.InserirDbProvider(provider, strConnection, entradaEstoque);

            foreach (ItensEntrada item in listBoxParaCadastrar.Items)
            {
                item.EntradasEstoqueId = idEntrada;
                daoItens.InserirDbProvider(provider, strConnection, item);
            }



        }

        private void AtualizarValorNota()
        {
            decimal valor = 0;
            foreach (ItensEntrada item in listBoxParaCadastrar.Items)
            {
                valor += item.Quantidade * item.ValorUnitario;
            }
            foreach (ItensEntrada item in listBoxEntradasCadastradas.Items)
            {
                valor += item.Quantidade * item.ValorUnitario;
            }
            mk_total.Text = valor.ToString();
        }

        private void AtualizarTela()
        {
            try
            {
                //limpando campos
                mk_total.Text = "0";
                mk_id.Text = "0";
                mk_Chave.Text = "";
                mk_notaFiscal.Text = "";
                mk_observacao.Text = "";
                mk_serie.Text = "";

                listBoxEntradasCadastradas.Items.Clear();
                listBoxParaCadastrar.Items.Clear();
                listBoxProdutos.Items.Clear();
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhasProduto = daoProduto.SelectDbProvider(provider, strConnection, new Produtos(0, ""));
                DataTable linhasLojas = daoLoja.SelectDbProvider(provider, strConnection, new Loja(0, ""));
                DataTable linhasFornecedor = daoFornecedor.SelectDbProvider(provider, strConnection, new Fornecedor(0, ""));
                //limpando o nosso combo box
                listBoxParaCadastrar.Items.Clear();
                listBoxProdutos.Items.Clear();
                comboBoxLoja.Items.Clear();
                comboBoxFornecedor.Items.Clear();
                //atualizando o nosso combo box
                foreach (DataRow row in linhasFornecedor.Rows)
                {
                    fornecedor = new Fornecedor
                    {
                        IdFornecedor = Convert.ToInt32(row[0].ToString()),
                        Cnpj = row[1].ToString(),
                        NomeFantasia = row[4].ToString()
                    };
                    comboBoxFornecedor.Items.Add(fornecedor);
                }

                foreach (DataRow row in linhasLojas.Rows)
                {
                    loja = new Loja
                    {
                        IdLoja = Convert.ToInt32(row[0].ToString()),
                        Cnpj = row[1].ToString(),
                        NomeFantasia = row[4].ToString()
                    };
                    comboBoxLoja.Items.Add(loja);
                }
                foreach (DataRow row in linhasProduto.Rows)
                {
                    produtos = new Produtos
                    {

                        IdProduto = Convert.ToInt32(row[0].ToString()),
                        Nome = row[1].ToString(),
                        Status = Convert.ToInt32(row[2].ToString()),
                        AreaId = Convert.ToInt32(row[10].ToString()),
                        Valor = Convert.ToDecimal(row[4].ToString()),
                        MarcaId = Convert.ToInt32(row[11].ToString()),
                        Modelo = row[6].ToString(),
                        Descricao = row[7].ToString(),
                        QuantidadeEstoque = Convert.ToInt32(row[8].ToString())
                    };
                    listBoxProdutos.Items.Add(produtos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void VerificarItensEPreencher()
        {
            MessageBox.Show("Verificando Itens Para Inserção!");

            foreach (ItensEntrada item in listBoxParaCadastrar.Items)
            {
                if (item.MarcaId == 999999)
                {
                    item.MarcaId = 0;
                    item.Modelo = "";
                    formItens = new FormItens(item);
                    formItens.mk_quantidade.Enabled = false;
                    formItens.ShowDialog();
                }
            }
        }
        private void listBoxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox aux = ((ListBox)sender);

            if (!(aux.SelectedItem is null))
            {
                produtos = (Produtos)aux.SelectedItem;

                ItensEntrada itens = new ItensEntrada();
                itens.ProdutoId = produtos.IdProduto;
                itens.MarcaId = produtos.MarcaId;
                itens.ValorUnitario = produtos.Valor;
                itens.Modelo = produtos.Modelo;
                itens.Quantidade = 0;
                itens.Lote = 0;
                itens.EntradasEstoqueId = 0;

                formItens = new FormItens(itens);
                formItens.ShowDialog();

                if (formItens.itemParaCadastro.DataValidade != DateTime.MinValue)
                {
                    listBoxParaCadastrar.Items.Add(formItens.itemParaCadastro);
                }
                AtualizarValorNota();
            }
        }

        internal DataTable PegarGrid(string numeroNf)
        {
            DataTable auxTable = daoEntrada.SelectDbProvider(provider, strConnection, new EntradaEstoque(0, numeroNf));
            return auxTable;
        }

        #region Região de XML Da Nota Fiscal

        /// <summary>
        /// Abrindo Dialogo para pegar nota.xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportarXml_Click(object sender, EventArgs e)
        {
            listBoxParaCadastrar.Items.Clear();
            if (openFileXml.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CarregarDadosNotaTela(openFileXml.FileName);
                PegarItensXML(openFileXml.FileName);
                CarregarFornecedor(openFileXml.FileName);

                if (openFileXml.FileName == null || openFileXml.FileName == "")
                {
                    MessageBox.Show("Falha ao ler o arquivo xml. Verifique se o arquivo é de uma NF-e/NFC-e autorizada!", "Aviso - Leitura do Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Arquivo xml da Nota Fiscal lido com Sucesso!", "Aviso - Leitura do Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                VerificarItensEPreencher();
            }
        }

        private void CarregarFornecedor(string caminho)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(caminho);

            string Cnpj = "";
            foreach (XmlElement linhasXml in doc.GetElementsByTagName("emit"))
            {
                Cnpj = linhasXml.GetElementsByTagName("CNPJ")[0].InnerText.Trim();
            }

            bool achouFornecedor = true;
            if (Cnpj != "" && Cnpj != null && Cnpj.Length >= 11)
            {
                achouFornecedor = SelecionarFornecedorNoComboBox(Cnpj);
            }

            if (achouFornecedor)
            {
                endereco = new Endereco();
                fornecedor = new Fornecedor();

                foreach (XmlElement linhasXml in doc.GetElementsByTagName("emit"))
                {
                    //Endereço
                    endereco.IdEndereco = 0;
                    endereco.Cep = linhasXml.GetElementsByTagName("CEP")[0].InnerText.Trim();
                    endereco.Logradouro = linhasXml.GetElementsByTagName("xLgr")[0].InnerText.Trim();
                    endereco.Numero = linhasXml.GetElementsByTagName("nro")[0].InnerText.Trim();
                    endereco.Bairro = linhasXml.GetElementsByTagName("xBairro")[0].InnerText.Trim();
                    endereco.Cidade = linhasXml.GetElementsByTagName("xMun")[0].InnerText.Trim();
                    endereco.Estado = linhasXml.GetElementsByTagName("UF")[0].InnerText.Trim();
                    endereco.Pais = linhasXml.GetElementsByTagName("xPais")[0].InnerText.Trim();
                    endereco.Complemento = "";
                    //Fornecedor
                    fornecedor.Cnpj = Cnpj;
                    fornecedor.Ie = linhasXml.GetElementsByTagName("IE")[0].InnerText.Trim();
                    fornecedor.Contato = "";
                    fornecedor.RazaoSocial = (linhasXml.GetElementsByTagName("xFant").Count > 0) ? linhasXml.GetElementsByTagName("xFant")[0].InnerText.Trim() : "Sem Razao";
                    fornecedor.NomeFantasia = (linhasXml.GetElementsByTagName("xNome").Count > 0) ? linhasXml.GetElementsByTagName("xNome")[0].InnerText.Trim() : "";
                    fornecedor.Telefone = linhasXml.GetElementsByTagName("fone")[0].InnerText.Trim();
                    fornecedor.Email = "";
                }

                fornecedor.EnderecoId = daoEndereco.InserirDbProvider(provider, strConnection, endereco);
                daoFornecedor.InserirDbProvider(provider, strConnection, fornecedor);

                fornecedor = new Fornecedor { Cnpj = Cnpj };
                DataTable lista = daoFornecedor.SelectDbProvider(provider, strConnection, fornecedor);
                foreach (DataRow row in lista.Rows)
                {
                    fornecedor.IdFornecedor = Convert.ToInt32(row[0].ToString());
                }
                comboBoxFornecedor.Items.Add(fornecedor);
                comboBoxFornecedor.SelectedItem = fornecedor;
            }
        }

        private bool SelecionarFornecedorNoComboBox(string cnpj)
        {
            fornecedor = new Fornecedor { Cnpj = cnpj };
            DataTable lista = daoFornecedor.SelectDbProvider(provider, strConnection, fornecedor);

            foreach (DataRow row in lista.Rows)
            {
                foreach (Fornecedor fornecedor in comboBoxFornecedor.Items)
                {
                    if (fornecedor.Cnpj == row[1].ToString())
                    {
                        comboBoxFornecedor.SelectedItem = fornecedor;
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Pegando os itens da nota
        /// </summary>
        /// <param name="caminho"></param>
        public void PegarItensXML(string caminho)
        {
            listaProdutos = new List<string[]>();
            using (XmlReader meuXml = XmlReader.Create(caminho))
            {
                var item = "";
                var cProd = "";
                var xProd = "";
                var qCom = "";
                var vUnCom = "";
                var vProd = "";
                var fimItens = false;

                while (meuXml.Read())
                {
                    //itens
                    if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "det")
                    {
                        //lendo atributo da tag <det>
                        item = meuXml.GetAttribute("nItem");

                        cProd = "";
                        xProd = "";
                        qCom = "";
                        vUnCom = "";
                        vProd = "";
                    }
                    else if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "total") fimItens = true;

                    if (!fimItens)
                    {

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "cProd") cProd = meuXml.ReadElementString();

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xProd") xProd = meuXml.ReadElementString();

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "qCom") qCom = meuXml.ReadElementString();

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vUnCom") vUnCom = meuXml.ReadElementString();

                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vProd")
                            listaProdutos.Add(new string[] { item, cProd, xProd, qCom, vUnCom.ToString(), vProd.ToString().Replace(".", ",") });
                    }
                }
            }

            CarregarEntradasNaTela(listaProdutos);
        }

        private void CarregarEntradasNaTela(List<string[]> listaProdutos)
        {
            for (int i = 0; i < listaProdutos.Count; i++)
            {
                ItensEntrada item = new ItensEntrada();

                item.Lote = Convert.ToInt32(listaProdutos[i][0]);
                string aux = Convert.ToString(listaProdutos[i][3]);
                aux = aux.Replace(".", ",");
                decimal x = Convert.ToDecimal(aux);
                item.Quantidade = Convert.ToInt32(Math.Truncate(x));

                aux = listaProdutos[i][4];
                aux = aux.Replace(".", ",");
                x = Convert.ToDecimal(aux);
                item.ValorUnitario = Convert.ToInt32(Math.Truncate(x));
                item.MarcaId = 999999;
                listBoxParaCadastrar.Items.Add(item);

            }
        }

        private void CarregarDadosNotaTela(string caminho)
        {
            using (XmlReader meuXml = XmlReader.Create(caminho))
            {
                while (meuXml.Read())
                {
                    if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "chNFe")
                        mk_Chave.Text = meuXml.ReadElementString();
                    if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vNF")
                        mk_total.Text = meuXml.ReadElementString();
                    if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "serie")
                        mk_serie.Text = meuXml.ReadElementString();
                    if (meuXml.NodeType == XmlNodeType.Element && (meuXml.Name == "nNF"))
                        mk_notaFiscal.Text = meuXml.ReadElementString();
                    if (meuXml.NodeType == XmlNodeType.Element && (meuXml.Name == "dhEmi"))
                        mk_dataNf.Text = meuXml.ReadElementString();
                    if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "natOp")
                        mk_observacao.Text = meuXml.ReadElementString();

                }
            }
        }

        #endregion

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            string pathArquivo = GeraPdf.pathArquivo("RelProdutos");
            GeraPdf.PdfEntradas(pathArquivo, Convert.ToInt32(mk_id.Text));
        }

        private void userControleUsBTN_Load(object sender, EventArgs e)
        {

        }
    }
}
