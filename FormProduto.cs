using System;
using System.Windows.Forms;
using ControleEstoqueDao.DAO;
using System.Configuration;
using System.Data;

namespace BancoDadosZe
{
    /// <summary>
    /// Classe formulario de produtos
    /// </summary>
    public partial class FormProduto : Form
    {
        string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        private readonly ProdutosDAO dao;
        private Produtos produtos;

        /// <summary>
        /// inicializando os componentes
        /// </summary>
        public FormProduto()
        {
            InitializeComponent();

            dao = new ProdutosDAO();



            //eventos de destaque de campo
            mk_Valor.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoDescricao.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_nome.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            //leave
            mk_Valor.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoDescricao.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_nome.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);

            //tradução
            this.textoMarca.Text = Properties.Resources.ResourceManager.GetString("titulo_categoria");
            this.textoValor.Text = Properties.Resources.ResourceManager.GetString("titulo_codigo");
            this.textoDescrição.Text = Properties.Resources.ResourceManager.GetString("titulo_descricao");
            this.textoNome.Text = Properties.Resources.ResourceManager.GetString("titulo_nome");
            this.textoStatus.Text = Properties.Resources.ResourceManager.GetString("titulo_status");
            this.radioButtonAtivo.Text = Properties.Resources.ResourceManager.GetString("radio_ativo");
            this.radioButtonInativo.Text = Properties.Resources.ResourceManager.GetString("radio_inativo");

            //evento de teclado para tab no enter e Esc
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);

            //eventos do controle de usuario
            controleUs1.btnAdicionar.Click += BtnAdicionar_Click;
            controleUs1.btnRemover.Click += BtnRemover_Click;
            controleUs1.btnSalvar.Click += BtnSalvar_Click;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable AtualizarTela()
        {
            produtos = new Produtos();
            //Preenche objeto
            produtos.AreaId = 0;
            produtos.IdProduto = 0;
            produtos.MarcaId = 0;
            byte[] x = new byte[2];
            produtos.Foto = x;
            produtos.Modelo = "";
            produtos.QuantidadeEstoque = 0;
            produtos.Nome = "";
            produtos.Descricao = "";
            if (radioButtonAtivo.Checked is true)
            {
                produtos.Status = "Ativo";
            }
            else produtos.Status = "Inativo";
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(provider, strConnection, produtos);
                // seta o datasouce do dataGridView com os dados retornados

                return linhas;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Inserindo no banco
        /// </summary>
        public void InsertDbProvider()
        {
            //Instância objeto
            produtos = new Produtos();

            //Preenche objeto com os dados da view
            produtos.AreaId = comboArea.SelectedIndex;
            produtos.IdProduto = 0;
            produtos.MarcaId = comboBoxMarca.SelectedIndex;
            produtos.Foto = null;
            produtos.Modelo = maskedTextBoxModelo.Text;
            produtos.QuantidadeEstoque = 0;
            produtos.Nome = textoNome.Text;
            produtos.Descricao = textoDescrição.Text;
            produtos.Valor = Convert.ToDecimal( mk_Valor.Text);
            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(provider, strConnection, produtos);
                MessageBox.Show("Dados inseridos com sucesso!", provider);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// evento salvar
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou algo dentro da tela produtos");
        }

        /// <summary>
        /// evento remover
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou algo dentro da tela produtos");
        }

        /// <summary>
        /// evento adicionar
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            InsertDbProvider();
        }
    }
}
