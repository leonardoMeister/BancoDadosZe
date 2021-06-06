using System;
using System.Windows.Forms;
using ControleEstoqueDao.DAO;
using System.Configuration;
using System.Data;

namespace BancoDadosZe
{
    /// <summary>
    /// Classe Area atuacao
    /// </summary>
    public partial class FormAreaAtuacao : Form
    {
        readonly string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        readonly string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        private readonly AreaAtuacaoDAO dao;
        private AreaAtuacao areaAtuacao;
        readonly ControleUsBTN userControl;

        /// <summary>
        /// 
        /// </summary>
        public FormAreaAtuacao()
        {
            //inicializando componentes
            InitializeComponent();

            this.Text = Properties.Resources.ResourceManager.GetString("titulo_atuacao");
            this.textoArea.Text = Properties.Resources.ResourceManager.GetString("titulo_atuacao");
            //Enter
            textBoxArea.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            //leave
            textBoxArea.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);

            //criando objeto DAO
            dao = new AreaAtuacaoDAO();

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
        /// Atualizar tela
        /// </summary>
        public void PegaPreencherFormComDadosBanco(int id)
        {
            try
            {
                if (id != 0)
                {
                    //Pegando o item do select e retornando ele 
                    DataTable tabela = dao.SelectDbProvider(provider, strConnection, new AreaAtuacao(id, ""));
                    foreach (DataRow row in tabela.Rows)
                    {
                        textBoxArea.Text = row[1].ToString();
                        mk_id.Text = row[0].ToString();

                        userControl.btnAdicionar.Enabled = false;
                        this.ShowDialog();
                        userControl.btnAdicionar.Enabled = true;
                        return;
                    }


                }
                else if (id == 0)
                {
                    textBoxArea.Text = "";
                    mk_id.Text = "";


                    userControl.btnRemover.Enabled = false;
                    userControl.btnSalvar.Enabled = false;
                    this.ShowDialog();
                    userControl.btnRemover.Enabled = true;
                    userControl.btnSalvar.Enabled = true;

                    return;
                }
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
            DataTable auxTable = dao.SelectDbProvider(provider, strConnection, new AreaAtuacao(0, nome));
            return auxTable;
        }

        /// <summary>
        /// 
        /// </summary>
        public void InsertDbProvider()
        {
            //Instância objeto
            areaAtuacao = new AreaAtuacao();
            //Preenche objeto com os dados da view
            if (mk_id.Text != "" && mk_id.Text != null)
            {
                areaAtuacao.IdArea = Convert.ToInt32(mk_id.Text);
            }
            else areaAtuacao.IdArea = 0;

            areaAtuacao.Area = textBoxArea.Text;
            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(provider, strConnection, areaAtuacao);
                if (areaAtuacao.IdArea != 0)
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
