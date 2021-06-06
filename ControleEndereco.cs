using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleEstoqueDao.DAO;
using System.Windows.Forms;

namespace BancoDadosZe
{
    /// <summary>
    /// Classe ControleEndereco
    /// </summary>
    public partial class ControleEndereco : UserControl
    {
        /// <summary>
        /// Construtor Classe
        /// </summary>
        public ControleEndereco()
        {
            InitializeComponent();

            this.textLogradouro.Text = Properties.Resources.ResourceManager.GetString("titulo_logradouro");
            this.textoBairro.Text = Properties.Resources.ResourceManager.GetString("titulo_bairro");
            this.textoCep.Text = Properties.Resources.ResourceManager.GetString("titulo_cep");
            this.textoCidade.Text = Properties.Resources.ResourceManager.GetString("titulo_cidade");
            this.textoComplemento.Text = Properties.Resources.ResourceManager.GetString("titulo_complemento");
            this.textoEstado.Text = Properties.Resources.ResourceManager.GetString("titulo_estado");
            this.textoNumero.Text = Properties.Resources.ResourceManager.GetString("titulo_numero");
            this.textoPais.Text = Properties.Resources.ResourceManager.GetString("titulo_pais");
            this.grupEndereco.Text = Properties.Resources.ResourceManager.GetString("titulo_endereco");

            AtualizarTela();
        }
        /// <summary>
        /// Atualiza os campos da tela com base no id, puxando do banco
        /// </summary>
        /// <param name="id"></param>
        /// <param name="auxTabela"></param>
        public void PegaPreencherFormComDadosBanco(int id, DataTable auxTabela)
        {
            AtualizarTela();

            mk_bairro.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_cep.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_cidade.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_logradouro.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            mk_numero.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);
            campoComplemento.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter);


            //leave
            mk_bairro.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_cep.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_cidade.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_logradouro.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            mk_numero.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);
            campoComplemento.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave);

            if (id != 0)
            {
                Endereco auxEndereco = new Endereco();
                foreach (DataRow row in auxTabela.Rows)
                {
                    auxEndereco.Bairro = row[5].ToString();
                    auxEndereco.Cep = row[1].ToString();
                    auxEndereco.Cidade = row[6].ToString();
                    auxEndereco.Complemento = row[4].ToString();
                    auxEndereco.Estado = row[7].ToString();
                    auxEndereco.IdEndereco = Convert.ToInt32(row[0].ToString());
                    auxEndereco.Logradouro = row[2].ToString();
                    auxEndereco.Numero = row[3].ToString();
                    auxEndereco.Pais = row[8].ToString();
                    auxEndereco.IdEndereco = Convert.ToInt32( row[0].ToString());
                    
                }

                
                mk_bairro.Text = auxEndereco.Bairro;
                mk_cep.Text = auxEndereco.Cep;
                mk_cidade.Text = auxEndereco.Cidade;
                mk_logradouro.Text = auxEndereco.Logradouro;
                mk_numero.Text = auxEndereco.Numero;
                campoComplemento.Text = auxEndereco.Complemento;
                mk_id.Text = Convert.ToString( auxEndereco.IdEndereco);
                comboBoxEstado.SelectedItem = auxEndereco.Estado;
                comboBoxPais.SelectedItem = auxEndereco.Pais;
            }
            else
            {
               AtualizarTela();
            }
        }



        /// <summary>
        /// Atualiza os combo box e limpa os campos
        /// </summary>
        private void AtualizarTela()
        {
            comboBoxPais.Items.Clear();

            comboBoxPais.Items.Add("Brasil");

            comboBoxEstado.Items.Clear();

            comboBoxEstado.Items.Add("SP");
            comboBoxEstado.Items.Add("SE");
            comboBoxEstado.Items.Add("TO");
            comboBoxEstado.Items.Add("PE");
            comboBoxEstado.Items.Add("PI");
            comboBoxEstado.Items.Add("RJ");
            comboBoxEstado.Items.Add("RN");
            comboBoxEstado.Items.Add("RS");
            comboBoxEstado.Items.Add("RO");
            comboBoxEstado.Items.Add("RR");
            comboBoxEstado.Items.Add("SC");
            comboBoxEstado.Items.Add("GO");
            comboBoxEstado.Items.Add("MA");
            comboBoxEstado.Items.Add("MT");
            comboBoxEstado.Items.Add("MS");
            comboBoxEstado.Items.Add("MG");
            comboBoxEstado.Items.Add("PA");
            comboBoxEstado.Items.Add("PB");
            comboBoxEstado.Items.Add("PR");
            comboBoxEstado.Items.Add("AC");
            comboBoxEstado.Items.Add("AL");
            comboBoxEstado.Items.Add("AP");
            comboBoxEstado.Items.Add("AM");
            comboBoxEstado.Items.Add("BA");
            comboBoxEstado.Items.Add("CE");
            comboBoxEstado.Items.Add("DF");
            comboBoxEstado.Items.Add("ES");

            mk_bairro.Text = "";
            mk_cep.Text = "";
            mk_cidade.Text = "";
            mk_logradouro.Text = "";
            mk_numero.Text = "";
            campoComplemento.Text = "";
            mk_id.Text = "";

        }
    }
}
