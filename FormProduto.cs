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
    /// Classe formulario de produtos
    /// </summary>
    public partial class FormProduto : Form
    {
        /// <summary>
        /// inicializando os componentes
        /// </summary>
        public FormProduto()
        {
            InitializeComponent();
            //eventos de destaque de campo
            mk_codigo.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoDescricao.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_nome.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            //leave
            mk_codigo.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoDescricao.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_nome.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);

            //tradução
            this.textoCategoria.Text = Properties.Resources.ResourceManager.GetString("titulo_categoria");
            this.textoCodigo.Text = Properties.Resources.ResourceManager.GetString("titulo_codigo");
            this.textoDescrição.Text = Properties.Resources.ResourceManager.GetString("titulo_descricao");
            this.textoNome.Text = Properties.Resources.ResourceManager.GetString("titulo_nome");
            this.textoStatus.Text = Properties.Resources.ResourceManager.GetString("titulo_status");
            this.radioButtonAtivo.Text = Properties.Resources.ResourceManager.GetString("radio_ativo");
            this.radioButtonInativo.Text = Properties.Resources.ResourceManager.GetString("radio_inativo");

            //evento de teclado para tab no enter e Esc
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);

            //eventos do controle de usuario
            controleUs1.btnAdicionar.Click += BtnAdicionar_Click;
            controleUs1.btnRemover.Click += BtnRemover_Click;
            controleUs1.btnSalvar.Click += BtnSalvar_Click;
        }
        /// <summary>
        /// evento salvar
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou algo dentro da tela produtos");
        }

        /// <summary>
        /// evento remover
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou algo dentro da tela produtos");
        }

        /// <summary>
        /// evento adicionar
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou algo dentro da tela produtos");
        }
    }
}
