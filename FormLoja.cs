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
    public partial class FormLoja : Form
    {
        public FormLoja()
        {
            InitializeComponent();
            //eventos de destaque de campos de texto
            campoNomeFantasia.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoCnpj.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoTelefone.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoBairro.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoCep.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoCidade.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoComplemento.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoData.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoEmail.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoGerente.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoNumero.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoPais.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoRazaoSocial.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoRua.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            //leave
            campoNomeFantasia.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoCnpj.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoTelefone.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoBairro.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoCep.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoCidade.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoComplemento.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoData.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoEmail.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoGerente.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoNumero.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoPais.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoRazaoSocial.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoRua.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);

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

        //evento de salvar
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou em algo na tela de lojas");
        }

        //evento de remover
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou em algo na tela de lojas");
        }


        //evento de adicionar
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou em algo na tela de lojas");
        }

    }
}
