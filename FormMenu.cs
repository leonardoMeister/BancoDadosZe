using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDadosZe
{

    /// <summary>
    /// Classe Principal de menu
    /// </summary>
    public partial class FormMenu : Form
    {
        private Form auxFormSelecionado;
        /// <summary>
        /// Inicializando Componentes
        /// </summary>
        public FormMenu()
        {
            InitializeComponent();

            //Pegando dados para abrir o Form
            this.btn_lojas.Text = Properties.Resources.ResourceManager.GetString("titulo_loja");
            this.btn_entradas.Text = Properties.Resources.ResourceManager.GetString("titulo_entradas");
            this.btn_fornecedor.Text = Properties.Resources.ResourceManager.GetString("titulo_fornecedor");
            this.btn_funcionario.Text = Properties.Resources.ResourceManager.GetString("titulo_funcionario");
            this.btn_produtos.Text = Properties.Resources.ResourceManager.GetString("titulo_produto");
            this.btn_ajustes.Text = Properties.Resources.ResourceManager.GetString("titulo_ajustes");
            this.btn_entrar.Text = Properties.Resources.ResourceManager.GetString("titulo_logar");
            this.btn_buscar.Text = Properties.Resources.ResourceManager.GetString("btn_busca");
            this.texto_escolha.Text = Properties.Resources.ResourceManager.GetString("campo_escolha");
            this.btn_marca.Text = Properties.Resources.ResourceManager.GetString("titulo_marca");
            this.btn_area.Text = Properties.Resources.ResourceManager.GetString("titulo_atuacao");
            this.btn_adicionar.Text = Properties.Resources.ResourceManager.GetString("titulo_adicionar");
            //evento de teclado para tab no enter e Esc
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);

            //evento de menu de contexto para Form
            this.lojasToolStripMenuItem.Click += new EventHandler(Btn_lojas_clic);
            this.ajustesToolStripMenuItem.Click += new EventHandler(Btn_ajustes_Click);
            this.produtosToolStripMenuItem.Click += new EventHandler(Btn_produtos_Click);
            this.entradasToolStripMenuItem.Click += new EventHandler(Btn_entradas_Click);
            this.fornecedorToolStripMenuItem.Click += new EventHandler(Btn_fornecedor_Click);
            this.funcionáriosToolStripMenuItem.Click += new EventHandler(Btn_funcionario_Click);
            this.sairToolStripMenuItem.Click += new EventHandler(Sair);


            //evento de menu de contexto Icone
            this.abrirAplicaçãoToolStripMenuItem.Click += new EventHandler(Abrir);
            this.encerrarToolStripMenuItem.Click += new EventHandler(Sair);
            this.sobreToolStripMenuItem.Click += new EventHandler(ExibirMensagem);

            //tradução do menu de contexto principal menu
            this.lojasToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("titulo_loja");
            this.ajustesToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("titulo_ajustes");
            this.produtosToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("titulo_produto");
            this.entradasToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("titulo_entradas");
            this.fornecedorToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("titulo_fornecedor");
            this.funcionáriosToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("titulo_funcionario");
            this.sairToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("titulo_sair");
            this.logarToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("titulo_logar");

            //tradução do menu de contexto da caixa de ferramentas
            this.abrirAplicaçãoToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("titulo_abrir");
            this.encerrarToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("titulo_sair");
            this.sobreToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("titulo_sobre");

            //Tradução das notificações do notifyIconSystemTray
            this.notifyIconSystemTray.BalloonTipText = Properties.Resources.ResourceManager.GetString("titulo_ballonText");
            this.notifyIconSystemTray.BalloonTipTitle = Properties.Resources.ResourceManager.GetString("titulo_ballonTitulo");

            //AjustaTelaLogin();
        }

        //Métodos para funcionalidades privados do sistema  
        #region

        private void AjustaTelaLogin()
        {
            if (!Program.logado)
            {
                //desabilita os botões
                btn_marca.Enabled = false; btn_area.Enabled = false; btn_lojas.Enabled = false;
                btn_funcionario.Enabled = false; btn_fornecedor.Enabled = false; btn_produtos.Enabled = false;
                btn_entradas.Enabled = false; btn_ajustes.Enabled = false;
                btn_adicionar.Enabled = false; btn_buscar.Enabled = false;


                //ajusta o texto do botão entrar/sair e label
                pictureBoxUsuario.Image = Properties.Resources.cadeado100;
                labelLoginLogoff.Text = "Login";
                labelUsuario.Text = "Usuário: ";
                labelCargo.Text = "Cargo: ";
                labelGrupo.Text = "Grupo: ";
                labelLoja.Text = "Loja:";
                labelTipoLoja.Text = "Tipo:";
            }
            else
            {
                //ajusta o texto do botão
                pictureBoxUsuario.Image = Properties.Resources.funcionariosq100;
                labelLoginLogoff.Text = "Logoff";
                labelUsuario.Text = "Usuário: " + Program.nomeLogado;
                labelCargo.Text = "Cargo: " + Program.cargoLogado;
                labelGrupo.Text = "Grupo: " + Program.grupoLogado;
                labelLoja.Text = "Loja: " + Program.lojaLogado;
                labelTipoLoja.Text = "Tipo: " + Program.tipoLoja;

                //desabilita todos os menus
                btn_marca.Enabled = false; btn_area.Enabled = false; btn_lojas.Enabled = false;
                btn_funcionario.Enabled = false; btn_fornecedor.Enabled = false; btn_produtos.Enabled = false;
                btn_entradas.Enabled = false; btn_ajustes.Enabled = false;
                btn_adicionar.Enabled = false; btn_buscar.Enabled = false;
                if (Program.grupoLogado == 0)
                {
                    btn_marca.Enabled = true; btn_area.Enabled = true; btn_lojas.Enabled = true;
                    btn_funcionario.Enabled = true; btn_fornecedor.Enabled = true; btn_produtos.Enabled = true;
                    btn_entradas.Enabled = true; btn_ajustes.Enabled = true;
                    btn_adicionar.Enabled = true; btn_buscar.Enabled = true;
                }
                else if (Program.grupoLogado == 1)
                {
                    btn_marca.Enabled = true; btn_area.Enabled = true; btn_lojas.Enabled = true;
                    btn_funcionario.Enabled = true; btn_fornecedor.Enabled = true; btn_produtos.Enabled = true;
                    btn_entradas.Enabled = true; btn_ajustes.Enabled = true;
                    btn_adicionar.Enabled = true; btn_buscar.Enabled = true;

                }
                else if (Program.grupoLogado == 2)
                {
                    btn_funcionario.Enabled = true; btn_adicionar.Enabled = true; btn_buscar.Enabled = true;

                }
                else if (Program.grupoLogado == 3)
                {
                    btn_marca.Enabled = true; btn_area.Enabled = true; btn_fornecedor.Enabled = true;
                    btn_produtos.Enabled = true; btn_entradas.Enabled = true; btn_adicionar.Enabled = true; btn_buscar.Enabled = true;

                }
                else if (Program.grupoLogado == 4)
                {
                    btn_funcionario.Enabled = true; btn_adicionar.Enabled = true; btn_buscar.Enabled = true;

                }
            }
        }

        /// <summary>
        /// Exibindo mensagem na tela sobre a aplicação
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void ExibirMensagem(object sender, EventArgs e)
        {
            MessageBox.Show("titulo_sobre");
        }
        /// <summary>
        /// Abrindo a aplicação da bandeja
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void Abrir(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }
        /// <summary>
        /// Redimencionando o menu principal 
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void FormMenu_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;
                notifyIconSystemTray.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconSystemTray.Visible = false;
            }
        }
        /// <summary>
        /// Fechando a aplicação
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void Sair(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Abrindo o app da bandeja com duplo click no icone
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void NotifyIconSystemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }
        #endregion 

        /// <summary>
        /// Abrindo form entradas
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void Btn_entradas_Click(object sender, EventArgs e)
        {
            FormEntradas ent = new FormEntradas();
            ent.ShowDialog();
        }


        /// <summary>
        /// abrindo form ajustes
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void Btn_ajustes_Click(object sender, EventArgs e)
        {
            FormConfig conf = new FormConfig();
            conf.ShowDialog();
        }

        /// <summary>
        /// Atualizar tela
        /// </summary>
        public void AtualizarTela(DataTable tb)
        {
            dataGridViewDados.Columns.Clear();
            dataGridViewDados.AutoGenerateColumns = true;
            if (tb.Rows.Count == 0)
            {
                MessageBox.Show("Busca Sem Valores");
            }
            dataGridViewDados.DataSource = tb;
            dataGridViewDados.Refresh();
        }

        /// <summary>
        /// abrindo form de login
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void Btn_entrar_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.ShowDialog();
        }

        /// <summary>
        /// Pegando o form desejado e carregando no grid
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void Btn_produtos_Click(object sender, EventArgs e)
        {
            auxFormSelecionado = new FormProduto();
            buscar_campo.Text = "";
            PesquisaParaAtualizarGrid();
            this.texto_escolha.Text = Properties.Resources.ResourceManager.GetString("titulo_produto");
        }

        /// <summary>
        /// Pegando o form desejado e carregando no grid
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void Btn_fornecedor_Click(object sender, EventArgs e)
        {
            auxFormSelecionado = new FormFornecedor();
            buscar_campo.Text = "";
            PesquisaParaAtualizarGrid();
            this.texto_escolha.Text = Properties.Resources.ResourceManager.GetString("titulo_fornecedor");
        }

        /// <summary>
        /// Pegando o form desejado e carregando no grid
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void Btn_funcionario_Click(object sender, EventArgs e)
        {
            auxFormSelecionado = new FormFuncionario();
            buscar_campo.Text = "";
            PesquisaParaAtualizarGrid();
            this.texto_escolha.Text = Properties.Resources.ResourceManager.GetString("titulo_funcionario");
        }
        /// <summary>
        /// Pegando o form desejado e carregando no grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_marca_Click(object sender, EventArgs e)
        {
            auxFormSelecionado = new FormMarca();
            buscar_campo.Text = "";
            PesquisaParaAtualizarGrid();
            this.texto_escolha.Text = Properties.Resources.ResourceManager.GetString("titulo_marca");
        }
        /// <summary>
        /// Pegando o form desejado e carregando no grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_area_atuacao(object sender, EventArgs e)
        {
            auxFormSelecionado = new FormAreaAtuacao();
            buscar_campo.Text = "";
            PesquisaParaAtualizarGrid();
            this.texto_escolha.Text = Properties.Resources.ResourceManager.GetString("titulo_atuacao");
        }

        /// <summary>
        /// Pegando o form desejado e carregando no grid
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void Btn_lojas_clic(object sender, EventArgs e)
        {
            auxFormSelecionado = new FormLoja();
            buscar_campo.Text = "";
            PesquisaParaAtualizarGrid();
            this.texto_escolha.Text = Properties.Resources.ResourceManager.GetString("titulo_loja");
        }
        /// <summary>
        /// Evento de clicar na linha do dataGrid 
        /// Usa polimorfismo para mostrar form desejado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewDados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = 0;
            if (dataGridViewDados.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = dataGridViewDados.Rows[dataGridViewDados.SelectedCells[0].RowIndex];
                id = Convert.ToInt32(selectedRow.Cells[0].Value);
            }

            //AtualizarTelaONE(id);
            ExibirForm(id);

        }

        /// <summary>
        /// Pesquisar no banco
        /// </summary>
        public void PesquisaParaAtualizarGrid()
        {
            if (auxFormSelecionado is FormMarca)
            {
                AtualizarTela(((FormMarca)auxFormSelecionado).PegarGrid(buscar_campo.Text));
            }
            else if (auxFormSelecionado is FormProduto)
            {
                AtualizarTela(((FormProduto)auxFormSelecionado).PegarGrid(buscar_campo.Text));
            }
            else if (auxFormSelecionado is FormLoja)
            {
                AtualizarTela(((FormLoja)auxFormSelecionado).PegarGrid(buscar_campo.Text));
            }
            else if (auxFormSelecionado is FormFuncionario)
            {
                AtualizarTela(((FormFuncionario)auxFormSelecionado).PegarGrid(buscar_campo.Text));
            }
            else if (auxFormSelecionado is FormFornecedor)
            {
                AtualizarTela(((FormFornecedor)auxFormSelecionado).PegarGrid(buscar_campo.Text));
            }
            else if (auxFormSelecionado is FormEntradas)
            {
                // ((FormEntradas)auxFormSelecionado).AtualizarTela(id);
            }
            else if (auxFormSelecionado is FormAreaAtuacao)
            {
                AtualizarTela(((FormAreaAtuacao)auxFormSelecionado).PegarGrid(buscar_campo.Text));
            }
            else
            {
                MessageBox.Show("Escolha um Formulario!");
            }
            

        }

        /// <summary>
        /// Exibe o formulario selecionado
        /// </summary>
        /// <param name="id">Define se vai puxar um dado do banco ou não</param>
        private void ExibirForm(int id)
        {
            if (auxFormSelecionado is FormMarca)
            {
                ((FormMarca)auxFormSelecionado).PegaPreencherFormComDadosBanco(id);
                PesquisaParaAtualizarGrid();
            }
            else if (auxFormSelecionado is FormProduto)
            {
                ((FormProduto)auxFormSelecionado).PegaPreencherFormComDadosBanco(id);
                PesquisaParaAtualizarGrid();
            }
            else if (auxFormSelecionado is FormLoja)
            {
                ((FormLoja)auxFormSelecionado).PegaPreencherFormComDadosBanco(id);
                PesquisaParaAtualizarGrid();
            }
            else if (auxFormSelecionado is FormFuncionario)
            {
                ((FormFuncionario)auxFormSelecionado).PegaPreencherFormComDadosBanco(id);
                PesquisaParaAtualizarGrid();
            }
            else if (auxFormSelecionado is FormFornecedor)
            {
                ((FormFornecedor)auxFormSelecionado).PegaPreencherFormComDadosBanco(id);
                PesquisaParaAtualizarGrid();
            }
            else if (auxFormSelecionado is FormEntradas)
            {
                // ((FormEntradas)auxFormSelecionado).AtualizarTela(id);
            }
            else if (auxFormSelecionado is FormAreaAtuacao)
            {
                ((FormAreaAtuacao)auxFormSelecionado).PegaPreencherFormComDadosBanco(id);
                PesquisaParaAtualizarGrid();
            }
        }

        /// <summary>
        /// Abrindo Form para cadastro de um novo dado desejado
        /// De acordo com o Form do menu selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            if (!(auxFormSelecionado is null))
            {
                ExibirForm(0);
            }
            else MessageBox.Show("Selecione um menu primeiro");
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {          
                PesquisaParaAtualizarGrid();
        }

        private void pictureBoxUsuario_Click(object sender, EventArgs e)
        {
            if (Program.logado)
            {
                Program.logado = false;
                AjustaTelaLogin();
            }
            else
            {
                FormLogin x = new FormLogin();
                x.ShowDialog();
                AjustaTelaLogin();
            }
        }

    }
}
