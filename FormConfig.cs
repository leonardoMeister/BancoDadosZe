using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Common;

namespace BancoDadosZe
{   
    /// <summary>
    /// classe de form de configurações da app para linguagem
    /// </summary>
    public partial class FormConfig : Form
    {

        /// <summary>
        /// Configurações para configurar as linguagens 
        /// </summary>
        public FormConfig()
        {
            InitializeComponent();

            //configurações para usar arquivos de linguagem resources
            grupBoxLingua.Text = Properties.Resources.ResourceManager.GetString("titulo_idioma");
            btn_salvar.Text = Properties.Resources.ResourceManager.GetString("btn_salvar");
            //Tradução grupo box
                    //grupBoxBanco.Text = Properties.Resources.ResourceManager.GetString("");

            // config para alterar idioma
            comboBox_idioma.SelectedItem = ConfigurationManager.AppSettings.Get("Cultura");

            // busca os dados com nome BD
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["BD"];
            // obtém o providerName e atualiza em tela
            comboBoxBanco.Text = connectionStringSettings.ProviderName;
            // obtém a connectionString e atualiza em tela
            textBoxStringConexao.Text = connectionStringSettings.ConnectionString;


            //evento de teclado para tab no enter e Esc
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);
        }
        /// <summary>
        /// Botão para salvar as configurações alteradas no sistema
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            //abre o arquivo local como leitura/escrita - ControleEstoqueDoZe.exe.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //altera os valores referentes a cultura
            config.AppSettings.Settings.Remove("Cultura");
            config.AppSettings.Settings.Add("Cultura", comboBox_idioma.Text);
            //altera os valores de provider e da connectionStrings com nome BD
            config.ConnectionStrings.ConnectionStrings["BD"].ProviderName = comboBoxBanco.Text;                    
            config.ConnectionStrings.ConnectionStrings["BD"].ConnectionString =     textBoxStringConexao.Text;
            //salva as alterações
            config.Save(ConfigurationSaveMode.Modified, true);
            //recarrega os dados da seção especificada
            ConfigurationManager.RefreshSection("appSettings");
            ConfigurationManager.RefreshSection("connectionStrings");
            //fecha a tela
            Close();
            //dispara msg para usuário
            MessageBox.Show("Dados alterados com sucesso!");

            ValidaConexaoDB();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ValidaConexaoDB()
        {
            DbProviderFactory factory;
            try
            {
                factory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["BD"].ProviderName);
                using (var conexao = factory.CreateConnection())
                {
                    conexao.ConnectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
                    using (var comando = factory.CreateCommand())
                    {
                        comando.Connection = conexao;
                        conexao.Open();
                        MessageBox.Show("Conexão Válida!");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                new FormConfig().ShowDialog();
                ValidaConexaoDB();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            if (combo.SelectedItem.ToString().Equals("MySql.Data.MySqlClient") )
            {
                textBoxStringConexao.Text = "Server = localhost; port = 3306; Database = estoque_ze_db; Uid = root; Pwd = 12leonardo12;";

            }else if (combo.SelectedItem.ToString().Equals("System.Data.SqlClient"))
            {
                textBoxStringConexao.Text = @"Server=LOCALHOST\SQLEXPRESS;Database=estoque_ze;Uid=leonardo;Pwd=leonardo12;";
            }
        }
    }
}
