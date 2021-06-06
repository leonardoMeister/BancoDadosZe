using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Configuration;

namespace BancoDadosZe
{
    static class Program
    {

        // utilizado para monitorar se o usuário esta ou não logado e também para tornar acessível seus dados
        public static bool logado = false;
        public static int idLogado = 0;
        public static string nomeLogado = "";
        public static string cargoLogado = "";
        public static int grupoLogado = 0;
        public static int lojaLogado = 0;
        public static int tipoLoja = 0;




        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(name: ConfigurationManager.AppSettings.Get("Cultura"));

            //Thread.CurrentThread.CurrentUICulture = new CultureInfo();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenu());
        }
    }
}
