using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleEstoqueDao.DAO;

namespace BancoDadosZe.FormsCadastraveis
{
    public partial class FormItens : Form
    {
        private readonly ProdutosDAO daoProduto;
        public ItensEntrada itemParaCadastro;
        readonly string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        readonly string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        public FormItens(ItensEntrada obj)
        {
            daoProduto = new ProdutosDAO();
            InitializeComponent();
            itemParaCadastro = obj;
            AtualizarTela();
        }

        private void AtualizarTela()
        {
            DataTable tabela = daoProduto.SelectDbProvider(provider,strConnection, new Produtos(0, ""));
            comboBoxProduto.Items.Clear();
            foreach (DataRow row in tabela.Rows)
            {
                Produtos produtos = new Produtos
                {
                    IdProduto = Convert.ToInt32(row[0].ToString()),
                    Nome = row[1].ToString(),
                    Status = Convert.ToInt32(row[2].ToString()),
                    AreaId = Convert.ToInt32(row[10].ToString()),
                    Valor = Convert.ToDecimal(row[4].ToString()),
                    MarcaId = Convert.ToInt32(row[11].ToString()),
                    Modelo = row[6].ToString(),
                    Descricao = row[7].ToString(),
                    QuantidadeEstoque = Convert.ToInt32(row[8].ToString())
                };
                comboBoxProduto.Items.Add(produtos);
            }

            mk_idMarca.Text = itemParaCadastro.MarcaId.ToString();
            mk_idProduto.Text = itemParaCadastro.ProdutoId.ToString();
            mk_modelo.Text = itemParaCadastro.Modelo.ToString();
            mk_quantidade.Text = itemParaCadastro.Quantidade.ToString();
            mk_valorUnitario.Text = itemParaCadastro.ValorUnitario.ToString();
        }

        private void btn_avancar_Click(object sender, EventArgs e)
        {
            if (mk_lote.Text != "" && mk_quantidade.Text != "" && comboBoxProduto.SelectedIndex != -1)
            {
                itemParaCadastro.DataValidade = mk_data_validade.Value;
                itemParaCadastro.Quantidade = Convert.ToInt32(mk_quantidade.Text);
                itemParaCadastro.Lote = Convert.ToInt32(mk_lote.Text);
                itemParaCadastro.MarcaId = Convert.ToInt32(mk_idMarca.Text);
                itemParaCadastro.Modelo = mk_modelo.Text;
                itemParaCadastro.ProdutoId = Convert.ToInt32(mk_idProduto.Text);
                itemParaCadastro.ValorUnitario = Convert.ToDecimal(mk_valorUnitario.Text);

                this.Close();
            }
            else MessageBox.Show("Preencha os campos Obrigatorios.");
        }

        private void comboBoxProduto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Produtos produtos = (Produtos)comboBoxProduto.SelectedItem;
            mk_idMarca.Text = Convert.ToString( produtos.MarcaId);
            mk_idProduto.Text = Convert.ToString(produtos.IdProduto);
            mk_modelo.Text = Convert.ToString(produtos.Modelo);
        }
    }
}
