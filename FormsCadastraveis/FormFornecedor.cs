using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ControleEstoqueDao.DAO;

namespace BancoDadosZe
{
    /// <summary>
    /// Classe form de cadastro de fornecedores
    /// </summary>
    public partial class FormFornecedor : Form
    {
        //declarando os objetos necessarios
        readonly string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        readonly string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        private readonly FornecedorDAO dao;
        private readonly AreaAtuacaoDAO daoAreaAtuacao;
        private readonly FornecedorAreasAtuacaoDAO daoFornecedorAreaAtuacao;
        private readonly EnderecoDAO daoEndereco;
        readonly ControleUsBTN userControl;
        private List<AreaAtuacao> listaArea;
        private Fornecedor fornecedor;
        private Endereco endereco;


        /// <summary>
        /// inicializando os componentes
        /// </summary>
        public FormFornecedor()
        {
            InitializeComponent();

            //Inicializando os objetos necessarios
            dao = new FornecedorDAO();
            daoFornecedorAreaAtuacao = new FornecedorAreasAtuacaoDAO();
            daoAreaAtuacao = new AreaAtuacaoDAO();
            daoEndereco = new EnderecoDAO();
            listaArea = new List<AreaAtuacao>();
            //eventos de destaque de campos
            mk_cnpj.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_contato.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_email.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_Ie.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_nomeFantasia.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_razaoSocial.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_telefone.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            //leave
            mk_cnpj.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_contato.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_email.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_Ie.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_nomeFantasia.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_razaoSocial.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_telefone.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            //tradução
            this.Text = Properties.Resources.ResourceManager.GetString("titulo_fornecedor1");
            this.textoCnpj.Text = Properties.Resources.ResourceManager.GetString("titulo_cnpj");
            this.textoContato.Text = Properties.Resources.ResourceManager.GetString("titulo_contato");
            this.textoEmail.Text = Properties.Resources.ResourceManager.GetString("titulo_email");
            this.textoListaAreaAtuacaoFinal.Text = Properties.Resources.ResourceManager.GetString("titulo_areaFornecedor");
            this.textoListaAreaAtuacaoInicio.Text = Properties.Resources.ResourceManager.GetString("titulo_areaCadastrada");
            this.textoNomeFantasia.Text = Properties.Resources.ResourceManager.GetString("titulo_nomeFantasia");
            this.textoRazaoSocial.Text = Properties.Resources.ResourceManager.GetString("titulo_social");
            this.textoTelefone.Text = Properties.Resources.ResourceManager.GetString("titulo_telefone");

            //evento de teclado para tab no enter e Esc
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);


            //Controle user
            userControl = new ControleUsBTN();
            userControl.Dock = DockStyle.Bottom;
            panelFormulario.Controls.Add(userControl);

            //EVENTOS dos botões
            userControl.btnAdicionar.Click += BtnAdicionar_Click;
            userControl.btnRemover.Click += BtnRemover_Click;
            userControl.btnSalvar.Click += BtnSalvar_Click;

            AtualizarTela();
        }
        /// <summary>
        /// Preenchendo dados com base no id na tela
        /// </summary>
        public void PegaPreencherFormComDadosBanco(int id)
        {
            AtualizarTela();
            if (id == 0)
            {

                mk_cnpj.Text = "";
                mk_email.Text = "";
                mk_contato.Text = "";
                mk_nomeFantasia.Text = "";
                mk_razaoSocial.Text = "";
                mk_telefone.Text = "";
                mk_Ie.Text = "";
                mk_id.Text = "";
                //inicializa o endereço sem valores na tela
                controleUsEndereco.PegaPreencherFormComDadosBanco(0, new DataTable());

                userControl.btnRemover.Enabled = false;
                userControl.btnSalvar.Enabled = false;
                this.ShowDialog();
                userControl.btnRemover.Enabled = true;
                userControl.btnSalvar.Enabled = true;
                return;
            }
            else
            {
                DataTable tabela = dao.SelectDbProvider(provider, strConnection, new Fornecedor(id, ""));
                int idEndereco = 0;
                foreach (DataRow row in tabela.Rows)
                {
                    mk_cnpj.Text = row[1].ToString();
                    mk_email.Text = row[6].ToString();
                    mk_contato.Text = row[9].ToString();
                    mk_nomeFantasia.Text = row[4].ToString();
                    mk_razaoSocial.Text = row[3].ToString();
                    mk_telefone.Text = row[5].ToString();
                    mk_Ie.Text = row[2].ToString();
                    mk_id.Text = row[0].ToString();
                    //pegando o id do endereço
                    idEndereco = Convert.ToInt32(row[10].ToString());
                }

                //Limpando os ListBox
                listBoxAreaFornecedor.Items.Clear();
                listBoxAreasInicio.Items.Clear();
                //atualizando os listBox
                DataTable linhasListBoxInicio = daoAreaAtuacao.PegarAreasParaFornecedor(provider, strConnection, Convert.ToInt32(mk_id.Text), false);
                DataTable linhasListBoxFinal = daoAreaAtuacao.PegarAreasParaFornecedor(provider, strConnection, Convert.ToInt32(mk_id.Text), true);
                //atualizando o nosso combo box
                foreach (DataRow row in linhasListBoxInicio.Rows)
                {
                    listBoxAreasInicio.Items.Add(new AreaAtuacao(Convert.ToInt32(row[0].ToString()), row[1].ToString()));
                }
                foreach (DataRow row in linhasListBoxFinal.Rows)
                {
                    listBoxAreaFornecedor.Items.Add(new AreaAtuacao(Convert.ToInt32(row[0].ToString()), row[1].ToString()));
                }
                
                //pegando endereco
                DataTable auxTabela = daoEndereco.SelectDbProvider(provider, strConnection, idEndereco);
                //inicializando com os dados de endereço na tela
                controleUsEndereco.PegaPreencherFormComDadosBanco(idEndereco, auxTabela);

                userControl.btnAdicionar.Enabled = false;
                this.ShowDialog();
                userControl.btnAdicionar.Enabled = true;
                return;
            }
        }
        private void AtualizarTela()
        {
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhasArea = daoAreaAtuacao.SelectDbProvider(provider, strConnection, new AreaAtuacao(0, ""));
                //limpando o nosso combo box
                listBoxAreaFornecedor.Items.Clear();
                listBoxAreasInicio.Items.Clear();
                //atualizando o nosso combo box
                foreach (DataRow row in linhasArea.Rows)
                {
                    listBoxAreasInicio.Items.Add(new AreaAtuacao(Convert.ToInt32(row["ID"].ToString()), row["Nome"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveDbProvider()
        {
            try
            {
                //pegando o id selecionado
                int id = Convert.ToInt32(controleUsEndereco.mk_id.Text);
                dao.RemoverDbProvider(provider, strConnection, id);
                MessageBox.Show(Properties.Resources.ResourceManager.GetString("titulo_dadosRemovidos"), provider);
                ClassFuncoes.FecharTela(this);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Inserindo no banco
        /// </summary>
        public void InsertDbProvider()
        {
            //Instância objeto
            fornecedor = new Fornecedor();
            endereco = new Endereco();

            if (mk_id.Text != "" && mk_id.Text != null)
            {
                fornecedor.IdFornecedor = Convert.ToInt32(mk_id.Text);
                fornecedor.EnderecoId = Convert.ToInt32(controleUsEndereco.mk_id.Text);
                endereco.IdEndereco = Convert.ToInt32(controleUsEndereco.mk_id.Text);
            }
            else
            {
                fornecedor.IdFornecedor = 0;
                endereco.IdEndereco = 0;
            }

            //pegando do list box a nossa lista de areas
            try
            {
                listaArea = listBoxAreaFornecedor.Items.Cast<AreaAtuacao>().ToList();

                if (listaArea.Count == 0)
                {
                    //lançando erro caso n selecione nada
                    throw new Exception(Properties.Resources.ResourceManager.GetString("titulo_areaSelecionada"));
                }
                
            }
            catch (Exception)
            {
                throw;
            }
            //ints para guardar ids do retorno do banco
            int fornecedorId;

            //Preenchendo Endereço com os dados da view
            try
            {
                endereco.Bairro = controleUsEndereco.mk_bairro.Text;
                endereco.Cep = controleUsEndereco.mk_cep.Text;
                endereco.Cidade = controleUsEndereco.mk_cidade.Text;
                endereco.Complemento = controleUsEndereco.campoComplemento.Text;
                endereco.Estado = controleUsEndereco.comboBoxEstado.Text;
                endereco.Logradouro = controleUsEndereco.mk_logradouro.Text;
                endereco.Numero = controleUsEndereco.mk_numero.Text;
                endereco.Pais = controleUsEndereco.comboBoxPais.Text;
            }
            catch (Exception)
            {
                throw;
            }

            //Preenchendo Funcionario com os dados da view
            try
            {
                fornecedor.Cnpj = mk_cnpj.Text;
                fornecedor.Email = mk_email.Text;
                fornecedor.Contato = mk_contato.Text;
                fornecedor.Ie = mk_Ie.Text;
                fornecedor.NomeFantasia = mk_nomeFantasia.Text;
                fornecedor.RazaoSocial = mk_razaoSocial.Text;
                fornecedor.Telefone = mk_telefone.Text;
            }
            catch (Exception)
            {
                throw;
            }

            try
            {

                //Salvando ou alterando o endereco
                if (mk_id.Text == "" || mk_id.Text == null)
                {
                    endereco.IdEndereco = daoEndereco.InserirDbProvider(provider, strConnection, endereco);
                    fornecedor.EnderecoId = endereco.IdEndereco;

                    //adicionando no banco o fornecedor
                    fornecedorId = dao.InserirDbProvider(provider, strConnection, fornecedor);

                }
                else
                {
                    daoEndereco.InserirDbProvider(provider, strConnection, endereco);
                    dao.InserirDbProvider(provider, strConnection, fornecedor);
                    fornecedorId = fornecedor.IdFornecedor;
                }

                daoFornecedorAreaAtuacao.RemoverDbProvider(provider, strConnection, fornecedorId);

                //inserindo no banco a parte de areas atuação do fornecedor com id fornecedor e id area
                for (int i = 0; i < listaArea.Count; i++)
                {
                    FornecedorAreasAtuacao fornecedorAreasAtuacao = new FornecedorAreasAtuacao(listaArea[i].IdArea, fornecedorId);
                    daoFornecedorAreaAtuacao.InserirDbProvider(provider, strConnection, fornecedorAreasAtuacao);
                    
                }
                if (fornecedor.IdFornecedor != 0)
                {
                    MessageBox.Show(Properties.Resources.ResourceManager.GetString("titulo_dadosSalvos"), provider);
                }
                else MessageBox.Show(Properties.Resources.ResourceManager.GetString("titulo_dadosAdicionados"), provider);

                ClassFuncoes.FecharTela(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Pegar tabela
        /// </summary>
        /// <returns></returns>
        public DataTable PegarGrid(string nome)
        {
            DataTable auxTable = dao.SelectDbProvider(provider, strConnection, new Fornecedor(0, nome));
            return auxTable;
        }

        /// <summary>
        /// evento salvar
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            InsertDbProvider();
        }

        /// <summary>
        /// evento Remover
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if (ClassFuncoes.PerguntaSeDeletarDados())
            {
                RemoveDbProvider();
            }
        }

        /// <summary>
        /// evento adicionar
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                InsertDbProvider();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// evento de clique no form para mudar areas de atuação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxAreasInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox aux = ((ListBox)sender);

            if (!(aux.SelectedItem is null))
            {
                InicioRemoveADD(aux);
            }
        }
        /// <summary>
        /// Tira de um list box e adiciona em outro
        /// </summary>
        /// <param name="aux"></param>
        private void InicioRemoveADD(ListBox aux)
        {
            listBoxAreaFornecedor.Items.Add(aux.SelectedItem);
            aux.Items.Remove(aux.SelectedItem);
        }
        /// <summary>
        /// tira de um list box e adiciona em outro
        /// </summary>
        /// <param name="aux"></param>
        private void AreaFornecedorRemoveADD(ListBox aux)
        {
            listBoxAreasInicio.Items.Add(aux.SelectedItem);
            aux.Items.Remove(aux.SelectedItem);
        }
        /// <summary>
        /// evento de clique no form para mudar areas de atuação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxAreaFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox aux = ((ListBox)sender);

            if (!(aux.SelectedItem is null))
            {
                AreaFornecedorRemoveADD(aux);
            }
        }
    }
}
