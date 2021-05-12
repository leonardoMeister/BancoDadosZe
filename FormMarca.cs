using System;
using System.Windows.Forms;
using ControleEstoqueDao.DAO;
using System.Configuration;
using System.Data;

namespace BancoDadosZe
{
    public partial class FormMarca : Form
    {

        string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        private readonly MarcaDAO dao;
        private Marca marca;

        /// <summary>
        /// Construtor
        /// </summary>
        public FormMarca()
        {
            //inicializando componentes
            InitializeComponent();

            //criando objeto DAO
            dao = new MarcaDAO();

            //atualizando tela
            AtualizarTela();

            //evento de teclado para tab no enter e Esc
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);

            //Controle user
            ControleUs userControl = new ControleUs();
            userControl.Dock = DockStyle.Bottom;
            panelFormulario.Controls.Add(userControl);
            //EVENTOS dos botões
            userControl.btnAdicionar.Click += BtnAdicionar_Click;
            userControl.btnRemover.Click += BtnRemover_Click;
            userControl.btnSalvar.Click += BtnSalvar_Click;
        }
        /// <summary>
        /// Atualizar tela
        /// </summary>
        public DataTable AtualizarTela()
        {
            marca = new Marca();
            //Preenche objeto
            marca.IdMarca = 0;
            marca.Nome = "";
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(provider, strConnection, marca);
                // seta o datasouce do dataGridView com os dados retornados

                
                dataGridViewMarcas.Columns.Clear();
                dataGridViewMarcas.AutoGenerateColumns = true;
                dataGridViewMarcas.DataSource = linhas;
                dataGridViewMarcas.Refresh();
                
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
            marca = new Marca();
            //Preenche objeto com os dados da view
            marca.IdMarca = 0;
            marca.Nome = textBoxMarca.Text;
            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(provider, strConnection, marca);
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
            MessageBox.Show("Você clicou em algo na tela de lojas");
        }

        /// <summary>
        /// evento remover
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou em algo na tela de lojas");
        }


        /// <summary>
        /// evento adicionar
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            InsertDbProvider();
            AtualizarTela();
        }
    }
}
