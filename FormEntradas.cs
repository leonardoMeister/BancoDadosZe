using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDadosZe
{
    public partial class FormEntradas : Form
    {
        public FormEntradas()
        {
            InitializeComponent();
            //evento de destaque de campos
            campoCnpj.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoEmail.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoEndereco.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoLaranja.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoNomeFantasia.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoQuantidade.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoTelefone.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoValidade.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            //leave
            campoCnpj.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoEmail.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoEndereco.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoLaranja.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoNomeFantasia.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoQuantidade.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoTelefone.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoValidade.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);


            //tradução
            this.textoDataEntrada.Text = Properties.Resources.ResourceManager.GetString("titulo_data");
            this.textoFornecedor.Text = Properties.Resources.ResourceManager.GetString("titulo_fornecedor");
            this.textoLoja.Text = Properties.Resources.ResourceManager.GetString("titulo_loja");
            this.textoLote.Text = Properties.Resources.ResourceManager.GetString("titulo_lote");
            this.textoMarca.Text = Properties.Resources.ResourceManager.GetString("titulo_marca");
            this.textoModelo.Text = Properties.Resources.ResourceManager.GetString("titulo_modelo");
            this.textoNotaFiscal.Text = Properties.Resources.ResourceManager.GetString("titulo_notaFiscal");
            this.textoProduto.Text = Properties.Resources.ResourceManager.GetString("titulo_produto");
            this.textoQuantidade.Text = Properties.Resources.ResourceManager.GetString("titulo_quantidade");
            this.textoTransportadora.Text = Properties.Resources.ResourceManager.GetString("titulo_transportadora");
            this.textoValidade.Text = Properties.Resources.ResourceManager.GetString("titulo_validade");
            this.textoValor.Text = Properties.Resources.ResourceManager.GetString("titulo_valor");
            this.btnAdicionar.Text = Properties.Resources.ResourceManager.GetString("btn_adicionar");
            this.btnImportarXml.Text = Properties.Resources.ResourceManager.GetString("btn_importar");

            //evento de teclado para tab no enter e Esc
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }
    }
}
