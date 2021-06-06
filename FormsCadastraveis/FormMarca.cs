using System;
using System.Windows.Forms;
using ControleEstoqueDao.DAO;
using System.Configuration;
using System.Data;

namespace BancoDadosZe
{
    /// <summary>
    /// Classe Marca
    /// </summary>
    public partial class FormMarca : Form
    {

        readonly string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        readonly string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        private readonly MarcaDAO dao;
        private Marca marca;
        readonly ControleUsBTN userControl;

        /// <summary>
        /// Construtor
        /// </summary>
        public FormMarca()
        {
            //inicializando componentes
            InitializeComponent();

            this.text_marca.Text = Properties.Resources.ResourceManager.GetString("titulo_marca");
            this.Text = Properties.Resources.ResourceManager.GetString("titulo_marca");
            //Enter
            textBoxMarca.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            //leave
            textBoxMarca.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);

            //criando objeto DAO
            dao = new MarcaDAO();

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
        }

        /// <summary>
        /// Pegar DataTable para grid
        /// </summary>
        /// <returns></returns>
        public DataTable PegarGrid(string aux)
        {
            DataTable auxTable = dao.SelectDbProvider(provider, strConnection, new Marca(0, aux));
            return auxTable;
        }


        /// <summary>
        /// Atualizar tela
        /// </summary>
        public void PegaPreencherFormComDadosBanco(int id)
        {
            marca = new Marca();
            //Preenche objeto
            marca.IdMarca = id;
            try
            {
                if (marca.IdMarca != 0)
                {
                    //Pegando o item do select e retornando ele 
                    DataTable tabela = dao.SelectDbProvider(provider, strConnection, marca);
                    foreach (DataRow row in tabela.Rows)
                    {
                        mk_id.Text = row[0].ToString();
                        textBoxMarca.Text = row[1].ToString();                     
                    }

                    userControl.btnAdicionar.Enabled = false;
                    this.ShowDialog();
                    userControl.btnAdicionar.Enabled = true;
                    return;
                }
                else
                {
                    mk_id.Text = "";
                    textBoxMarca.Text = "";
                    userControl.btnRemover.Enabled = false;
                    userControl.btnSalvar.Enabled = false;
                    this.ShowDialog();
                    userControl.btnRemover.Enabled = true;
                    userControl.btnSalvar.Enabled = true;
                    
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Removendo dados do banco
        /// </summary>
        private void RemoveDbProvider()
        {
            try 
            {
                //pegando o id selecionado
                int id = Convert.ToInt32(mk_id.Text);
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
            marca = new Marca();
            //Preenche objeto com os dados da view

            //Definindo se vai para edição ou adição
            if (mk_id.Text != "" && mk_id.Text != null)
            {
                marca.IdMarca = Convert.ToInt32(mk_id.Text);
            }
            else marca.IdMarca = 0;

            marca.Nome = textBoxMarca.Text;
            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(provider, strConnection, marca);
                if (marca.IdMarca != 0)
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
