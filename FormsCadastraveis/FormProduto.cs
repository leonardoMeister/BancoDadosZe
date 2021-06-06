using System;
using System.Windows.Forms;
using ControleEstoqueDao.DAO;
using System.Configuration;
using System.Data;
using System.Drawing;

namespace BancoDadosZe
{
    /// <summary>
    /// Classe formulario de produtos
    /// </summary> 
    public partial class FormProduto : Form
    {
        readonly string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        readonly string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        private readonly ProdutosDAO dao;
        private readonly MarcaDAO daoMarca;
        private readonly AreaAtuacaoDAO daoArea;
        private Produtos produtos;

        /// <summary>
        /// inicializando os componentes
        /// </summary>
        public FormProduto()
        {
            InitializeComponent();

            dao = new ProdutosDAO();
            daoArea = new AreaAtuacaoDAO();
            daoMarca = new MarcaDAO();

            //eventos de destaque de campo
            mk_Valor.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoDescricao.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_nome.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_modelo.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_quantidade.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            //leave
            mk_Valor.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoDescricao.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_nome.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_modelo.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_quantidade.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);

            //tradução
            this.Text = Properties.Resources.ResourceManager.GetString("titulo_produto1");
            this.textoDescrição.Text = Properties.Resources.ResourceManager.GetString("titulo_descricao");
            this.texto_modelo.Text = Properties.Resources.ResourceManager.GetString("titulo_modelo");
            this.textoQuantidadeEstoque.Text = Properties.Resources.ResourceManager.GetString("titulo_quantidade");

            this.textoMarca.Text = Properties.Resources.ResourceManager.GetString("titulo_categoria");
            this.textoDescrição.Text = Properties.Resources.ResourceManager.GetString("titulo_descricao");
            this.textoNome.Text = Properties.Resources.ResourceManager.GetString("titulo_nome");
            this.textoStatus.Text = Properties.Resources.ResourceManager.GetString("titulo_status");
            this.radioButtonAtivo.Text = Properties.Resources.ResourceManager.GetString("radio_ativo");
            this.radioButtonInativo.Text = Properties.Resources.ResourceManager.GetString("radio_inativo");

            //evento de teclado para tab no enter e Esc
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);

            //eventos do controle de usuario
            userControl.btnAdicionar.Click += BtnAdicionar_Click;
            userControl.btnRemover.Click += BtnRemover_Click;
            userControl.btnSalvar.Click += BtnSalvar_Click;

            //atualizando tela
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
                mk_Valor.Text = "";
                mk_nome.Text = "";
                mk_quantidade.Text = "";
                mk_modelo.Text = "";
                campoDescricao.Text = "";
                mk_id.Text = "";
                radioButtonAtivo.Checked = true;
                //colocar a imagem padrao

                userControl.btnRemover.Enabled = false;
                userControl.btnSalvar.Enabled = false;
                this.ShowDialog();
                userControl.btnRemover.Enabled = true;
                userControl.btnSalvar.Enabled = true;
                return;
            }
            else
            {
                DataTable tabela = dao.SelectDbProvider(provider, strConnection, new Produtos(id, ""));
                foreach (DataRow row in tabela.Rows)
                {
                    mk_id.Text = row[0].ToString();
                    mk_Valor.Text = row[4].ToString();
                    mk_nome.Text = row[1].ToString();
                    mk_quantidade.Text = row[8].ToString();
                    mk_modelo.Text = row[6].ToString();
                    campoDescricao.Text = row[7].ToString();

                    radioButtonAtivo.Checked = (Convert.ToInt32(row[2].ToString()) == 1) ? true : false;
                    radioButtonInativo.Checked = (Convert.ToInt32(row[2].ToString()) == 0) ? true : false;
                    //Preenchendo o combo box com os dados certos do banco
                    for (int i = 0; i < comboBoxMarca.Items.Count; i++)
                    {
                        if (((Marca)comboBoxMarca.Items[i]).Nome == row[5].ToString())
                        {
                            comboBoxMarca.SelectedIndex = i;
                            break;
                        }
                    }
                    for (int i = 0; i < comboArea.Items.Count; i++)
                    {
                        if (((AreaAtuacao)comboArea.Items[i]).IdArea == Convert.ToInt32(row[10].ToString()))
                        {
                            comboArea.SelectedIndex = i;
                        }
                    }
                    //comboArea.SelectedItem = 

                    if (row[9].ToString() != "")
                    {
                        pictureBoxImage.Image = ClassFuncoes.ConverteByteArrayParaImagem((byte[])row[9]);
                    }
                    else pictureBoxImage.Image = Properties.Resources.imagemApp;

                }

                userControl.btnAdicionar.Enabled = false;
                this.ShowDialog();
                userControl.btnAdicionar.Enabled = true;


                return;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void AtualizarTela()
        {
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhasArea = daoArea.SelectDbProvider(provider, strConnection, new AreaAtuacao(0, ""));
                DataTable linhasMarca = daoMarca.SelectDbProvider(provider, strConnection, new Marca(0, ""));

                //pegando a imagem padrao
                pictureBoxImage.Image = Properties.Resources.imagemApp;

                //limpa  os combo box
                comboArea.Items.Clear();
                comboBoxMarca.Items.Clear();

                radioButtonAtivo.Select();

                //preenche os combo box
                foreach (DataRow row in linhasArea.Rows)
                {
                    comboArea.Items.Add(new AreaAtuacao(Convert.ToInt32(row["ID"].ToString()), row["Nome"].ToString()));
                }
                foreach (DataRow row in linhasMarca.Rows)
                {
                    comboBoxMarca.Items.Add(new Marca(Convert.ToInt32(row["ID_marca"].ToString()), row["Nome_marca"].ToString()));
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
            DataTable auxTable = dao.SelectDbProvider(provider, strConnection, new Produtos(0, nome));
            return auxTable;
        }
        /// <summary>
        /// Removendo dado do banco com base no id
        /// </summary>
        public void RemoveDbProvider()
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
            produtos = new Produtos();
            Marca auxMarca = comboBoxMarca.SelectedItem as Marca;
            AreaAtuacao auxArea = comboArea.SelectedItem as AreaAtuacao;

            if (mk_id.Text != "" && mk_id.Text != null)
            {
                produtos.IdProduto = Convert.ToInt32(mk_id.Text);
            }
            else produtos.IdProduto = 0;


            //Preenche objeto com os dados da view
            try
            {
                produtos.AreaId = auxArea.IdArea;
                produtos.Status = (radioButtonAtivo.Checked == true) ? 1 : 0;
                //produtos.IdProduto = 0;
                produtos.MarcaId = auxMarca.IdMarca;
                produtos.Foto = ClassFuncoes.ConverteImagemParaByteArray(pictureBoxImage.Image, pictureBoxImage);
                produtos.Modelo = mk_modelo.Text;
                produtos.QuantidadeEstoque = Convert.ToInt32(mk_quantidade.Text);
                produtos.Nome = mk_nome.Text;
                produtos.Descricao = campoDescricao.Text;
                produtos.Valor = Convert.ToDecimal(mk_Valor.Text);
            }
            catch (Exception)
            {
                throw;
            }

            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(provider, strConnection, produtos);
                if (produtos.IdProduto == 0)
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

        private void PictureBoxImage_Click(object sender, EventArgs e)
        {
            openFileDialogImage.Title = "Imagem do produto";
            openFileDialogImage.Filter = @"Images
            (*.JPEG; *.BMP; *.JPG; *.GIF; *.PNG; *.)| *.JPEG; *.BMP; *.JPG; *.GIF; *.PNG; *.icon; *.JFIF";
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                //pega a imagem escolhida e adiciona na tela
                pictureBoxImage.Image = Image.FromFile(openFileDialogImage.FileName);
                //redimensiona a imagem
                pictureBoxImage.Image = (Image)(new Bitmap(pictureBoxImage.Image, new Size(130, 98)));
                //ajusta a visualização no tamanho do pictureBoxImagem na tela
                pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
