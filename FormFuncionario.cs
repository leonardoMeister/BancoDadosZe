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
    /// classe fomr para cadastro de funcionarios
    /// </summary>
    public partial class FormFuncionario : Form
    {
        /// <summary>
        /// inicializando os componentes
        /// </summary>
        public FormFuncionario()
        {
            InitializeComponent();
            //evento de destaque de campo
            mk_bairro.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_cep.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_cidade.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoComplemento.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_cpf.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_dataNascimento.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_matricula.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_nome.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_numero.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_pais.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_rua.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_telefone.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_email.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            //leave 
            mk_bairro.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_cep.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_cidade.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoComplemento.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_cpf.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_dataNascimento.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_matricula.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_nome.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_numero.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_pais.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_rua.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_telefone.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_email.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);

            //tradução
            this.textoBairro.Text = Properties.Resources.ResourceManager.GetString("titulo_bairro");
            this.textoCargo.Text = Properties.Resources.ResourceManager.GetString("titulo_cargo");
            this.textoMatricula.Text = Properties.Resources.ResourceManager.GetString("titulo_matricula");
            this.textoCep.Text = Properties.Resources.ResourceManager.GetString("titulo_cep");
            this.textoCidade.Text = Properties.Resources.ResourceManager.GetString("titulo_cidade");
            this.textoComplemento.Text = Properties.Resources.ResourceManager.GetString("titulo_complemento");
            this.textoCpf.Text = Properties.Resources.ResourceManager.GetString("titulo_cpf");
            this.textoDataNascimento.Text = Properties.Resources.ResourceManager.GetString("titulo_dataNascimento");
            this.textoEmail.Text = Properties.Resources.ResourceManager.GetString("titulo_email");
            this.textoEndereco.Text = Properties.Resources.ResourceManager.GetString("titulo_endereco");
            this.textoGrupo.Text = Properties.Resources.ResourceManager.GetString("titulo_grupo");
            this.textoNome.Text = Properties.Resources.ResourceManager.GetString("titulo_nome");
            this.textoNumero.Text = Properties.Resources.ResourceManager.GetString("titulo_numero");
            this.textoPais.Text = Properties.Resources.ResourceManager.GetString("titulo_pais");
            this.textoRua.Text = Properties.Resources.ResourceManager.GetString("titulo_rua");
            this.textoSexo.Text = Properties.Resources.ResourceManager.GetString("titulo_sexo");
            this.textoTelefone.Text = Properties.Resources.ResourceManager.GetString("titulo_telefone");
            this.radioButtonFeminino.Text = Properties.Resources.ResourceManager.GetString("radio_feminino");
            this.radioButtonMasculino.Text = Properties.Resources.ResourceManager.GetString("radio_masculino");

            //evento de teclado para tab no enter e Esc
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);
            
            
            ControleUs userControl = new ControleUs();
            userControl.Dock = DockStyle.Bottom;
            panelFormulario.Controls.Add(userControl);

            //EVENTOS do user control

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
            MessageBox.Show("Você clicou em algo na tela de funcionário");
        }

        /// <summary>
        /// evento remover
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou em algo na tela de funcionário");
        }

        /// <summary>
        /// evento adicionar
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou em algo na tela de funcionário");
        }

    }
}
