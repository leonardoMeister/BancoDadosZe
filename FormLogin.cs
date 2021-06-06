using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using ControleEstoqueDao.DAO;

namespace BancoDadosZe
{
    /// <summary>
    /// classe form de login
    /// </summary>
    public partial class FormLogin : Form
    {
        private Funcionario funcionario;
        readonly private FuncionarioDAO daoFuncionario;
        readonly string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        readonly string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

        /// <summary>
        /// Inicializando os componentes do formulario login
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            daoFuncionario = new FuncionarioDAO();
        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            Program.logado = false;
            try
            {
                funcionario = new Funcionario
                {
                    Cpf = mk_cpf.Text,
                    Senha = ClassFuncoes.Sha256(mk_senha.Text)
                };
                // chama o metodo para buscar todos os dados da nossa camada model
                DataTable linhas = daoFuncionario.ValidaLogin(provider, strConnection, funcionario);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    Program.logado = true;
                    Program.idLogado = Convert.ToInt32(row["ID"]);
                    Program.nomeLogado = row["Nome"].ToString();
                    Program.cargoLogado = row["Cargo"].ToString();
                    Program.grupoLogado = Convert.ToInt32(row["Grupo"].ToString());
                    Program.lojaLogado = Convert.ToInt32(row["Loja"].ToString());
                    Program.tipoLoja = Convert.ToInt32(row["TipoLoja"].ToString());
                    //MessageBox.Show("Bem vindo " + row["Nome"].ToString());
                    Close();
                    return;
                }
                MessageBox.Show("Erro! Usuário/Senha!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

