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
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
            //evento de destaque de campo
            campoBairro.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoCep.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoCidade.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoComplemento.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoCpf.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoDataNascimento.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoMatricula.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoNome.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoNumero.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoPais.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoRua.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoTelefone.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            CampoEmail.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            //leave 
            campoBairro.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoCep.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoCidade.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoComplemento.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoCpf.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoDataNascimento.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoMatricula.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoNome.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoNumero.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoPais.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoRua.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoTelefone.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            CampoEmail.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);

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

        //evento salvar
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou em algo na tela de funcionário");
        }

        //evento remover
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou em algo na tela de funcionário");
        }

        //evento de adicionar
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou em algo na tela de funcionário");
        }

        private void panelFormulario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
