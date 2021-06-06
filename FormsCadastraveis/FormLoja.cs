using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using ControleEstoqueDao.DAO;

namespace BancoDadosZe
{
    /// <summary>
    /// classe form para cadastro de lojas
    /// </summary>
    public partial class FormLoja : Form
    {

        //Criando objetos para usar
        readonly string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        readonly string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        private readonly LojaDAO dao;
        private readonly FuncionarioDAO daoFuncionario;
        private readonly EnderecoDAO daoEndereco;
        private Loja loja;
        private Endereco endereco;
        readonly ControleUsBTN userControl;


        /// <summary>
        /// Inicializando os componentes do formulario loja
        /// </summary>
        public FormLoja()
        {
            InitializeComponent();

            //inicializando os objetos
            dao = new LojaDAO();
            daoFuncionario = new FuncionarioDAO();
            daoEndereco = new EnderecoDAO();

            //eventos de destaque de campos de texto
            mk_nomeFantasia.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_cnpj.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_telefone.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_email.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_razaoSocial.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_IE.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            //leave
            mk_nomeFantasia.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_cnpj.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_telefone.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_email.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_razaoSocial.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_IE.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);

            //tradução
            this.textoCnpj.Text = Properties.Resources.ResourceManager.GetString("titulo_cnpj");
            this.textoEmail.Text = Properties.Resources.ResourceManager.GetString("titulo_email");
            this.textoNomeFantasia.Text = Properties.Resources.ResourceManager.GetString("titulo_nomeFantasia");
            this.textoRazaoSocial.Text = Properties.Resources.ResourceManager.GetString("titulo_social");
            this.textoTelefone.Text = Properties.Resources.ResourceManager.GetString("titulo_telefone");
            this.textoTipo.Text = Properties.Resources.ResourceManager.GetString("titulo_tipo");
            this.Text = Properties.Resources.ResourceManager.GetString("titulo_loja1");
            this.radioButtonFilial.Text = Properties.Resources.ResourceManager.GetString("radio_filial");
            this.radioButtonMatriz.Text = Properties.Resources.ResourceManager.GetString("radio_matriz");

            //evento de teclado para tab no enter e Esc
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);

            //controle de botoes
            userControl = new ControleUsBTN();
            userControl.Dock = DockStyle.Bottom;
            panelFormulario.Controls.Add(userControl);
            //eventos do user control
            userControl.btnAdicionar.Click += BtnAdicionar_Click;
            userControl.btnRemover.Click += BtnRemover_Click;
            userControl.btnSalvar.Click += BtnSalvar_Click;


            AtualizarTela();
        }

        /// <summary>
        /// atualizando a tela
        /// </summary>
        public void PegaPreencherFormComDadosBanco(int id)
        {
            AtualizarTela();

            if (id == 0)
            {
                mk_cnpj.Text = "";
                mk_email.Text = "";
                mk_IE.Text = "";
                mk_nomeFantasia.Text = "";
                mk_razaoSocial.Text = "";
                mk_telefone.Text = "";
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
                DataTable tabela = dao.SelectDbProvider(provider, strConnection, new Loja(id, "")); // tirar gerente do Select;
                int idEndereco = 0;
                foreach (DataRow row in tabela.Rows)
                {
                    mk_cnpj.Text = row[1].ToString();
                    mk_email.Text = row[6].ToString();
                    mk_IE.Text = row[2].ToString();
                    mk_nomeFantasia.Text = row[4].ToString();
                    mk_razaoSocial.Text = row[3].ToString();
                    mk_telefone.Text = row[5].ToString();
                    mk_id.Text = row[0].ToString();

                    radioButtonMatriz.Checked = (Convert.ToInt32(row[9].ToString()) == 1) ? true : false;
                    radioButtonFilial.Checked = (Convert.ToInt32(row[9].ToString()) == 0) ? true : false;

                    //Preenchendo o combo box com os dados certos do banco
                   

                    //pegando o id do endereço
                    idEndereco = Convert.ToInt32(row[9].ToString());
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
                DataTable linhasFornecedor = daoFuncionario.SelectDbProviderFuncionarioID(provider, strConnection);
                //limpa o nosso combo box
                radioButtonFilial.Select();               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Pegar DataTable para grid
        /// </summary>
        /// <returns></returns>
        public DataTable PegarGrid(string nome)
        {
            DataTable auxTable = dao.SelectDbProvider(provider, strConnection, new Loja(0, nome));
            return auxTable;
        }

        /// <summary>
        /// Remover lojas do banco
        /// </summary>
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
            loja = new Loja();
            endereco = new Endereco();

            if (mk_id.Text != "" && mk_id.Text != null)
            {
                loja.IdLoja = Convert.ToInt32(mk_id.Text);
                loja.EnderecoId = Convert.ToInt32(controleUsEndereco.mk_id.Text);
                endereco.IdEndereco = Convert.ToInt32(controleUsEndereco.mk_id.Text);
            }
            else
            {
                loja.EnderecoId = 0;
                endereco.IdEndereco = 0;
            }

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

            //Preenchendo Loja com os dados da view
            try
            {
                loja.Cnpj = mk_cnpj.Text;
                loja.Email = mk_email.Text;

                loja.Tipo = (radioButtonFilial.Checked) ? 0 : 1;
                loja.Ie = mk_IE.Text;
                loja.NomeFantasia = mk_nomeFantasia.Text;
                loja.RazaoSocial = mk_razaoSocial.Text;
                loja.Telefone = mk_telefone.Text;
                loja.Telefone = mk_telefone.Text;
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
                    loja.EnderecoId = endereco.IdEndereco;
                }
                else daoEndereco.InserirDbProvider(provider, strConnection, endereco);

                //salvando ou alterando a loja
                dao.InserirDbProvider(provider, strConnection, loja);
                if (loja.IdLoja == 0)
                {
                    MessageBox.Show(Properties.Resources.ResourceManager.GetString("titulo_dadosAdicionados"), provider);
                }
                else MessageBox.Show(Properties.Resources.ResourceManager.GetString("titulo_dadosSalvos"), provider);


                ClassFuncoes.FecharTela(this);
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
            InsertDbProvider();
        }

        /// <summary>
        /// evento remover
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
            InsertDbProvider();
        }


    }
}
