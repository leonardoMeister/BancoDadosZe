using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace BancoDadosZe
{
    /// <summary>
    /// Classe de controle de usuario
    /// </summary>
    public partial class ControleUsBTN : UserControl
    {
        /// <summary>
        /// Inicializado os componentes do controle de usuario
        /// </summary>
        public ControleUsBTN()
        {
            InitializeComponent();
            this.btnAdicionar.Text = Properties.Resources.ResourceManager.GetString("btn_adicionar");
            this.btnRemover.Text = Properties.Resources.ResourceManager.GetString("btn_remover");
            this.btnSalvar.Text = Properties.Resources.ResourceManager.GetString("btn_salvar");
        }


    }
}
