﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

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

            // config para alterar idioma
            comboBox_idioma.SelectedItem = ConfigurationManager.AppSettings.Get("Cultura");

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
            //abre o arquivo local como leitura/escrita e salva as alterações em ControleEstoqueDoZe.exe.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("Cultura");
            config.AppSettings.Settings.Add("Cultura", comboBox_idioma.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            //fecha a tela
            Close();

        }
    }
}
