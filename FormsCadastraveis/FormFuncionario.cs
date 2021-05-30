using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using ControleEstoqueDao.DAO;

namespace BancoDadosZe
{
    /// <summary>
    /// classe fomr para cadastro de funcionarios
    /// </summary>
    public partial class FormFuncionario : Form
    {
        //criando os objetos necessarios
        string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        private readonly FuncionarioDAO dao;
        private Funcionario funcionario;
        private Endereco endereco;
        private EnderecoDAO daoEndereco;
        ControleUsBTN userControl;
        /// <summary>
        /// inicializando os componentes
        /// </summary>
        public FormFuncionario()
        {
            InitializeComponent();

            //Objetos para Banco
            dao = new FuncionarioDAO();
            daoEndereco = new EnderecoDAO();

            //evento de destaque de campo
            mk_cpf.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_dataNascimento.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_matricula.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_nome.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_telefone.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_email.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            //leave 
            mk_cpf.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_dataNascimento.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_matricula.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_nome.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_telefone.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_email.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);

            //tradução
            this.textoCargo.Text = Properties.Resources.ResourceManager.GetString("titulo_cargo");
            this.textoMatricula.Text = Properties.Resources.ResourceManager.GetString("titulo_matricula");
            this.textoCpf.Text = Properties.Resources.ResourceManager.GetString("titulo_cpf");
            this.textoDataNascimento.Text = Properties.Resources.ResourceManager.GetString("titulo_dataNascimento");
            this.textoEmail.Text = Properties.Resources.ResourceManager.GetString("titulo_email");
            this.textoGrupo.Text = Properties.Resources.ResourceManager.GetString("titulo_grupo");
            this.textoNome.Text = Properties.Resources.ResourceManager.GetString("titulo_nome");
            this.textoSexo.Text = Properties.Resources.ResourceManager.GetString("titulo_sexo");
            this.textoTelefone.Text = Properties.Resources.ResourceManager.GetString("titulo_telefone");
            this.radioButtonFeminino.Text = Properties.Resources.ResourceManager.GetString("radio_feminino");
            this.radioButtonMasculino.Text = Properties.Resources.ResourceManager.GetString("radio_masculino");

            //evento de teclado para tab no enter e Esc
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);

            //controle de botoes
            userControl = new ControleUsBTN();
            userControl.Dock = DockStyle.Bottom;
            panelFormulario.Controls.Add(userControl);

            //EVENTOS do user control
            userControl.btnAdicionar.Click += BtnAdicionar_Click;
            userControl.btnRemover.Click += BtnRemover_Click;
            userControl.btnSalvar.Click += BtnSalvar_Click;

            AtualizarTela();
        }
        /// <summary>
        /// Preenchendo dados com base no id na tela
        /// </summary>
        /// <param name="id"></param>
        public void PegaPreencherFormComDadosBanco(int id)
        {
            AtualizarTela();


            if (id == 0)
            {
                //Preenche objeto
                mk_id.Text = "";
                mk_telefone.Text = "";
                mk_senha.Text = "";
                mk_nome.Text = "";
                mk_cpf.Text = "";
                mk_dataNascimento.Text = "";
                mk_email.Text = "";
                mk_matricula.Text = "";

                //inicializa o endereço sem valores na tela
                controleUsEndereco.PegaPreencherFormComDadosBanco(0, new DataTable());
                this.ShowDialog();
                return;
            }
            else
            {
                DataTable tabela = dao.SelectDbProvider(provider, strConnection, new Funcionario(id ,""));
                int idEndereco = 0;
                foreach (DataRow row in tabela.Rows)
                {
                    mk_id.Text = row[0].ToString();
                    mk_telefone.Text = row[9].ToString();
                    mk_nome.Text = row[1].ToString();
                    mk_cpf.Text = row[2].ToString();
                    string dia, mes, ano;
                    dia = row[7].ToString().Substring(0, 2);
                    mes = row[7].ToString().Substring(3, 2);
                    ano = row[7].ToString().Substring(6, 4);
                    mk_dataNascimento.Text = ano + "/" + mes + "/" + dia;
                    mk_email.Text = row[10].ToString();
                    mk_matricula.Text = row[3].ToString();
                    radioButtonFeminino.Checked = (row[8].ToString() == "F") ? true : false;
                    radioButtonMasculino.Checked = (row[8].ToString() == "M") ? true : false;
                    comboBoxCargo.SelectedItem = row[6].ToString();
                    comboBoxGrupo.SelectedIndex = Convert.ToInt32(row[5].ToString());
                    //pegando o id do endereço
                    idEndereco = Convert.ToInt32(row[11].ToString());
                }

                //pegando endereco
                DataTable auxTabela = daoEndereco.SelectDbProvider(provider, strConnection, idEndereco);
                //inicializando com os dados de endereço na tela
                controleUsEndereco.PegaPreencherFormComDadosBanco(idEndereco, auxTabela);


                userControl.btnAdicionar.Visible = false;
                mk_senha.Visible = false;
                textoSenha.Visible = false;
                this.ShowDialog();
                userControl.btnAdicionar.Visible = true;
                textoSenha.Visible = true;
                mk_senha.Visible = true;

                return;
            }
        }

        /// <summary>
        /// Atualizar Tela
        /// </summary>
        public void AtualizarTela()
        {
            //atualizando ou preenchendo os comboBox com os dados para selecionar
            try
            {
                //Combo Box Cargo Funcionario
                comboBoxCargo.Items.Clear();
                comboBoxCargo.Items.Add("Administrador");
                comboBoxCargo.Items.Add("Gerente");
                comboBoxCargo.Items.Add("Operador");
                comboBoxCargo.Items.Add("Sócio");
                comboBoxCargo.Items.Add("Atendente");
                comboBoxCargo.Items.Add("Almoxarife");
                //combo Box Grupo Funcionario
                comboBoxGrupo.Items.Clear();
                comboBoxGrupo.Items.Add("Administração");
                comboBoxGrupo.Items.Add("Gerencional");
                comboBoxGrupo.Items.Add("RH");
                comboBoxGrupo.Items.Add("Almoxarifado");
                comboBoxGrupo.Items.Add("Social");
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
                MessageBox.Show("Dados Removidos com sucesso!", provider);
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
            funcionario = new Funcionario();
            endereco = new Endereco();

            if (mk_id.Text != "" && mk_id.Text != null)
            {
                funcionario.IdFuncionario = Convert.ToInt32(mk_id.Text);
                funcionario.EnderecoId = Convert.ToInt32(controleUsEndereco.mk_id.Text);
                endereco.IdEndereco = Convert.ToInt32(controleUsEndereco.mk_id.Text);
            }
            else
            {
                funcionario.IdFuncionario = 0;
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
            catch (Exception ex)
            {
                throw;
            }

            //Preenchendo Funcionario com os dados da view
            try
            {
                funcionario.Cargo = comboBoxCargo.Text;
                funcionario.Cpf = mk_cpf.Text;
                //pegando a data
                int ano = Convert.ToInt32(mk_dataNascimento.Text.Substring(0, 4));
                int mes = Convert.ToInt32(mk_dataNascimento.Text.Substring(4, 2));
                int dia = Convert.ToInt32(mk_dataNascimento.Text.Substring(6, 2));
                DateTime data = new DateTime(ano, mes, dia);
                funcionario.DataNascimento = data;
                funcionario.Email = mk_email.Text;
                funcionario.Grupo = comboBoxGrupo.SelectedIndex;
                funcionario.Matricula = mk_matricula.Text;
                funcionario.Nome = mk_nome.Text;
                funcionario.Senha = ClassFuncoes.sha256(mk_senha.Text);
                funcionario.Sexo = (radioButtonFeminino.Checked) ? 'F' : 'M';
                funcionario.Telefone = mk_telefone.Text;

            }
            catch (Exception ex)
            {
                throw;
            }

            try
            {
                //Salvando ou alterando o endereco
                if (mk_id.Text == "" || mk_id.Text == null)
                {
                    endereco.IdEndereco = daoEndereco.InserirDbProvider(provider, strConnection, endereco);
                    funcionario.EnderecoId = endereco.IdEndereco;
                }
                else daoEndereco.InserirDbProvider(provider,strConnection,endereco);
                
                

                 dao.InserirDbProvider(provider, strConnection, funcionario);


                if (funcionario.IdFuncionario != 0)
                {
                    MessageBox.Show("Dados Salvos com sucesso", provider);
                }
                else MessageBox.Show("Dados inseridos com sucesso", provider);


                ClassFuncoes.FecharTela(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Pegar Grid
        /// </summary>
        /// <returns></returns>
        public DataTable PegarGrid(string nome)
        {
            DataTable auxTable = dao.SelectDbProvider(provider, strConnection, new Funcionario(0, nome));
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
        /// evento remover
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            RemoveDbProvider();
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
