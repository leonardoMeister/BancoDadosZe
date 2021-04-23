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
    /// classe form para cadastro de lojas
    /// </summary>
    public partial class FormLoja : Form
    {
        /// <summary>
        /// Inicializando os componentes do formulario loja
        /// </summary>
        public FormLoja()
        {
            InitializeComponent();
            //eventos de destaque de campos de texto
            mk_nomeFantasia.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_cnpj.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_telefone.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_bairro.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_cep.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_cidade.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoComplemento.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_data.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_email.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_gerente.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_numero.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_pais.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_razaoSocial.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_rua.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            //leave
            mk_nomeFantasia.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_cnpj.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_telefone.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_bairro.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_cep.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_cidade.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoComplemento.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_data.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_email.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_gerente.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_numero.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_pais.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_razaoSocial.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_rua.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);

            //tradução
            this.textoBairro.Text = Properties.Resources.ResourceManager.GetString("titulo_bairro");
            this.textoCep.Text = Properties.Resources.ResourceManager.GetString("titulo_cep");
            this.textoCidade.Text = Properties.Resources.ResourceManager.GetString("titulo_cidade");
            this.textoCnpj.Text =  Properties.Resources.ResourceManager.GetString("titulo_cnpj");
            this.textoComplemento.Text = Properties.Resources.ResourceManager.GetString("titulo_complemento");
            this.textoData.Text = Properties.Resources.ResourceManager.GetString("titulo_data");
            this.textoEmail.Text = Properties.Resources.ResourceManager.GetString("titulo_email");
            this.textoEndereco.Text = Properties.Resources.ResourceManager.GetString("titulo_endereco");
            this.textoGerente.Text = Properties.Resources.ResourceManager.GetString("titulo_gerente");
            this.textoNomeFantasia.Text = Properties.Resources.ResourceManager.GetString("titulo_nomeFantasia");
            this.textoNumero.Text = Properties.Resources.ResourceManager.GetString("titulo_numero");
            this.textoPais.Text = Properties.Resources.ResourceManager.GetString("titulo_pais");
            this.textoRazaoSocial.Text = Properties.Resources.ResourceManager.GetString("titulo_social");
            this.textoRua.Text = Properties.Resources.ResourceManager.GetString("titulo_rua");
            this.textoTelefone.Text = Properties.Resources.ResourceManager.GetString("titulo_telefone");
            this.textoTipo.Text = Properties.Resources.ResourceManager.GetString("titulo_tipo");
            this.radioButtonFilial.Text = Properties.Resources.ResourceManager.GetString("radio_filial");
            this.radioButtonMatriz.Text = Properties.Resources.ResourceManager.GetString("radio_matriz");

            //evento de teclado para tab no enter e Esc
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);


            ControleUs userControl = new ControleUs();
            userControl.Dock = DockStyle.Bottom;
            panelFormulario.Controls.Add(userControl);

            //eventos do user control
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
            MessageBox.Show("Você clicou em algo na tela de lojas");
        }

    }
}
