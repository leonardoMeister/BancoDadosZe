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
    /// Classe form de cadastro de fornecedores
    /// </summary>
    public partial class FormFornecedor : Form
    {
        /// <summary>
        /// inicializando os componentes
        /// </summary>
        public FormFornecedor()
        {
            InitializeComponent();
            //eventos de destaque de campos
            mk_cnpj.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_contato.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_email.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_enderecoFisico.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_nomeFantasia.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_razaoSocial.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_telefone.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            //leave
            mk_cnpj.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_contato.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_email.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_enderecoFisico.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_nomeFantasia.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_razaoSocial.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_telefone.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            //tradução
            this.textoAtuacao.Text = Properties.Resources.ResourceManager.GetString("titulo_atuacao");
            this.textoCnpj.Text = Properties.Resources.ResourceManager.GetString("titulo_cnpj");
            this.textoContato.Text = Properties.Resources.ResourceManager.GetString("titulo_contato");
            this.textoEmail.Text = Properties.Resources.ResourceManager.GetString("titulo_email");
            this.textoEndereco.Text = Properties.Resources.ResourceManager.GetString("titulo_endereco");
            this.textoNomeFantasia.Text = Properties.Resources.ResourceManager.GetString("titulo_nomeFantasia");
            this.textoRazaoSocial.Text = Properties.Resources.ResourceManager.GetString("titulo_social");
            this.textoTelefone.Text = Properties.Resources.ResourceManager.GetString("titulo_telefone");

            //evento de teclado para tab no enter e Esc
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);


            ControleUs userControl = new ControleUs();
            userControl.Dock = DockStyle.Bottom;
            panelFormulario.Controls.Add(userControl);

            //EVENTOS dos botões
            userControl.btnAdicionar.Click += BtnAdicionar_Click;
            userControl.btnRemover.Click += BtnRemover_Click;
            userControl.btnSalvar.Click += BtnSalvar_Click;
        }

        /// <summary>
        /// evento salvar
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou em algo tela fornecedor");
        }

        /// <summary>
        /// evento Remover
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou em algo tela fornecedor");
        }

        /// <summary>
        /// evento adicionar
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou em algo tela fornecedor");
        }

    }
}
