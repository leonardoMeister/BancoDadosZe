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
    /// <summary>
    /// classe de form para entradas de produtos
    /// </summary>
    public partial class FormEntradas : Form
    {
        /// <summary>
        /// inicializando os componentes
        /// </summary>
        public FormEntradas()
        {
            InitializeComponent();
            //evento de destaque de campos
            mk_transportadora.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_marca.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_valor.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoLaranja.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_lote.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_quantidade.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_dataEntrada.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_validade.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            //leave
            mk_transportadora.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_marca.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_valor.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoLaranja.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_lote.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_quantidade.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_dataEntrada.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_validade.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);


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

            //evento de campo mascarado
            ClassFuncoes.AplicaMascaraMoeda(mk_valor);

        }
    }
}
