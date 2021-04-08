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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

            //eventos
            // texto_loja.Enter += Texto_loja_Enter;
            //textoProdutos.Enter += new EventHandler(Funcoes.CampoEventoEnter);

            //Pegando dados para abrir o Form

            this.texto_loja.Text = Properties.Resources.ResourceManager.GetString("titulo_loja");
            this.textoEntradas.Text = Properties.Resources.ResourceManager.GetString("titulo_entradas");
            this.textoFornecedor.Text = Properties.Resources.ResourceManager.GetString("titulo_fornecedor");
            this.textoFuncionarios.Text = Properties.Resources.ResourceManager.GetString("titulo_funcionario");
            this.textoProdutos.Text = Properties.Resources.ResourceManager.GetString("titulo_produto");
            this.texto_ajustes.Text = Properties.Resources.ResourceManager.GetString("titulo_ajustes");
            this.texto_logar.Text = Properties.Resources.ResourceManager.GetString("titulo_logar");
            this.btn_adicionar.Text = Properties.Resources.ResourceManager.GetString("btn_adicionar");
            this.btn_buscar.Text = Properties.Resources.ResourceManager.GetString("btn_busca");
            this.btn_editar.Text = Properties.Resources.ResourceManager.GetString("btn_editar");
            this.texto_escolha.Text = Properties.Resources.ResourceManager.GetString("campo_escolha");

            //evento de teclado para tab no enter e Esc
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);

        }

        private void Texto_loja_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textoFornecedor_Click(object sender, EventArgs e)
        {
            FormFornecedor forn = new FormFornecedor();
            forn.ShowDialog();
        }

        private void textoFuncionarios_Click(object sender, EventArgs e)
        {
            FormFuncionario fun = new FormFuncionario();
            fun.ShowDialog();
        }

        private void textoLojas_Click(object sender, EventArgs e)
        {
            FormLoja loja = new FormLoja();
            loja.ShowDialog();
        }

        private void textoProdutos_Click(object sender, EventArgs e)
        {
            FormProduto prod = new FormProduto();
            prod.ShowDialog();
        }

        private void textoEntradas_Click(object sender, EventArgs e)
        {
            FormEntradas ent = new FormEntradas();
            ent.ShowDialog();
        }

        private void texto_ajustes_Click(object sender, EventArgs e)
        {
            FormConfig conf = new FormConfig();
            conf.ShowDialog();
        }
    }
}
