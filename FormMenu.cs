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
        /// <summary>
        /// Inicializando Componentes
        /// </summary>
        public FormMenu()
        {
            InitializeComponent();

            //eventos
            // texto_loja.Enter += Texto_loja_Enter;
            //textoProdutos.Enter += new EventHandler(Funcoes.CampoEventoEnter);

            //Pegando dados para abrir o Form
            this.btn_lojas.Text = Properties.Resources.ResourceManager.GetString("titulo_loja");
            this.btn_entradas.Text = Properties.Resources.ResourceManager.GetString("titulo_entradas");
            this.btn_fornecedor.Text = Properties.Resources.ResourceManager.GetString("titulo_fornecedor");
            this.btn_funcionario.Text = Properties.Resources.ResourceManager.GetString("titulo_funcionario");
            this.btn_produtos.Text = Properties.Resources.ResourceManager.GetString("titulo_produto");
            this.btn_ajustes.Text = Properties.Resources.ResourceManager.GetString("titulo_ajustes");
            this.btn_entrar.Text = Properties.Resources.ResourceManager.GetString("titulo_logar");
            this.btn_adicionar.Text = Properties.Resources.ResourceManager.GetString("btn_adicionar");
            this.btn_buscar.Text = Properties.Resources.ResourceManager.GetString("btn_busca");
            this.btn_editar.Text = Properties.Resources.ResourceManager.GetString("btn_editar");
            this.texto_escolha.Text = Properties.Resources.ResourceManager.GetString("campo_escolha");

            //evento de teclado para tab no enter e Esc
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);

            //evento de menu de contexto para Form
            this.lojasToolStripMenuItem.Click += new EventHandler(textoLojas_Click);
            this.ajustesToolStripMenuItem.Click += new EventHandler(btn_ajustes_Click);
            this.produtosToolStripMenuItem.Click += new EventHandler(btn_produtos_Click);
            this.entradasToolStripMenuItem.Click += new EventHandler(btn_entradas_Click);
            this.fornecedorToolStripMenuItem.Click += new EventHandler(btn_fornecedor_Click);
            this.funcionáriosToolStripMenuItem.Click += new EventHandler(btn_funcionario_Click);
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
        /// Abrindo Loja
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void textoLojas_Click(object sender, EventArgs e)
        {
            FormLoja loja = new FormLoja();
            loja.ShowDialog();
        }
        /// <summary>
        /// Abrindo loja
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void button1_Click(object sender, EventArgs e)
        {
            FormLoja loja = new FormLoja();
            loja.ShowDialog();
        }
        /// <summary>
        /// Abrindo form produtos
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void btn_produtos_Click(object sender, EventArgs e)
        {
            FormProduto prod = new FormProduto();
            prod.ShowDialog();
        }
        /// <summary>
        /// Abrindo form entradas
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void btn_entradas_Click(object sender, EventArgs e)
        {
            FormEntradas ent = new FormEntradas();
            ent.ShowDialog();
        }
        /// <summary>
        /// abrindo form fornecedor
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void btn_fornecedor_Click(object sender, EventArgs e)
        {
            FormFornecedor forn = new FormFornecedor();
            forn.ShowDialog();
        }
        /// <summary>
        /// abrindo form funcionario
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void btn_funcionario_Click(object sender, EventArgs e)
        {
            FormFuncionario fun = new FormFuncionario();
            fun.ShowDialog();
        }
        /// <summary>
        /// abrindo form ajustes
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void btn_ajustes_Click(object sender, EventArgs e)
        {
            FormConfig conf = new FormConfig();
            conf.ShowDialog();
        }

        /// <summary>
        /// abrindo form de login
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void btn_entrar_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Abrindo o app da bandeja com duplo click no icone
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void notifyIconSystemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }


    }
}
