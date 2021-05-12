using System;
using System.Windows.Forms;
using ControleEstoqueDao.DAO;
using System.Configuration;
using System.Data;

namespace BancoDadosZe
{
    public partial class FormAreaAtuacao : Form
    {
        string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        private readonly AreaAtuacaoDAO dao;
        private AreaAtuacao areaAtuacao;

        /// <summary>
        /// 
        /// </summary>
        public FormAreaAtuacao()
        {
            //inicializando componentes
            InitializeComponent();
            //criando objeto DAO
            dao = new AreaAtuacaoDAO();

            //atualizando tela depois de criar os campos necessarios
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
            areaAtuacao = new AreaAtuacao();
            //Preenche objeto
            areaAtuacao.IdArea = 0;
            areaAtuacao.Area = "";
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(provider, strConnection, areaAtuacao);
                // seta o datasouce do dataGridView com os dados retornados

                dataGridViewAreaAtuazao.Columns.Clear();
                dataGridViewAreaAtuazao.AutoGenerateColumns = true;
                dataGridViewAreaAtuazao.DataSource = linhas;
                dataGridViewAreaAtuazao.Refresh();

                return linhas;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
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
        /// 
        /// </summary>
        public void InsertDbProvider()
        {
            //Instância objeto
            areaAtuacao = new AreaAtuacao();
            //Preenche objeto com os dados da view
            areaAtuacao.IdArea = 0;
            areaAtuacao.Area = textBoxArea.Text;
            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(provider, strConnection, areaAtuacao);
                MessageBox.Show("Dados inseridos com sucesso!", provider);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
