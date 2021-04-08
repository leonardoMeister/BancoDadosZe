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
    public partial class FormFornecedor : Form
    {
        public FormFornecedor()
        {
            InitializeComponent();
            //eventos de destaque de campos
            campoCnpj.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoContato.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoEmail.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoEndereco.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoNomeFantasia.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoRazaoSocial.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoTelefone.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            //leave
            campoCnpj.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoContato.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoEmail.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoEndereco.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoNomeFantasia.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoRazaoSocial.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoTelefone.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
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

        //evento salvar
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou em algo tela fornecedor");
        }

        //evento remover
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou em algo tela fornecedor");
        }

        //evento adicionar
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou em algo tela fornecedor");
        }

        private void panelFormulario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
