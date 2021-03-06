using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace BancoDadosZe
{

    /// <summary>
    /// classe para usar funções com métodos estaticos
    /// </summary>
    class ClassFuncoes
    {

        /// <summary>
        /// Criptografar senha
        /// </summary>
        /// <param name="senha"></param>
        /// <returns></returns>
        public static string Sha256(string senha)
        {
            var crypt = new SHA256Managed();
            var hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(senha));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }

        /// <summary>
        /// Converte imagens
        /// </summary>
        /// <param name="pData"></param>
        /// <returns></returns>
        public static Image ConverteByteArrayParaImagem(byte[] pData)
        {
            try
            {
                ImageConverter imgConverter = new ImageConverter();
                return imgConverter.ConvertFrom(pData) as Image;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Converte image para array
        /// </summary>
        /// <param name="img"></param>
        /// <param name="pictureBox"></param>
        /// <returns></returns>
        public static byte[] ConverteImagemParaByteArray(Image img, PictureBox pictureBox)
        {
            MemoryStream ms = new MemoryStream();
            if (pictureBox.Image != null)
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            return ms.ToArray();
        }
        /// <summary>
        /// Dando Destaque para o campo de texto selecionado
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        public static void CampoEventoEnter(object sender, EventArgs e)
        {
            if (sender is TextBoxBase txt) //MaskedTextBox, TextBox
            {
                txt.BackColor = Color.LightCyan;
            }
            else if (sender is ComboBox cb)
            {
                cb.BackColor = Color.LightCyan;
            }
            else if (sender is RadioButton rb)
            {
                rb.BackColor = Color.LightCyan;
            }
            else if (sender is ButtonBase btn)
            {
                btn.BackColor = Color.LightGreen;
            }
        }
        /// <summary>
        /// Removendo o destaque dos campos selecionados
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        public static void CampoEventoLeave(object sender, EventArgs e)
        {
            if (sender is TextBoxBase txt)
            {
                txt.BackColor = Color.White;
            }
            else if (sender is ComboBox cb)
            {
                cb.BackColor = Color.White;
            }
            else if (sender is RadioButton rb)
            {
                rb.BackColor = SystemColors.ActiveBorder;
            }
            else if (sender is ButtonBase btn)
            {
                btn.BackColor = Color.Red;
            }
        }
        /// <summary>
        /// Evento de teclado para Tab, Esc, Enter
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        public static void FormEventoKeyDown(object sender, KeyEventArgs e)
        {
            //obtém o form onde o componente gerou o evento
            Control x = (Control)sender;
            Form form = x.FindForm();
            //verifica se foi pressionado ENTER
            if (e.KeyCode == Keys.Enter)
            {
                //SendKeys.Send("{TAB}");
                form.SelectNextControl(form.ActiveControl, !e.Shift, true, true, true);
            }
            //verifica se foi pressionado ESC
            else if (e.KeyCode == Keys.Escape)
            {
                
                DialogResult confirm = MessageBox.Show(Properties.Resources.ResourceManager.GetString("titulo_desejaSair"), Properties.Resources.ResourceManager.GetString("titulo_salvar"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES")
                {
                    form.Close();
                }
            }
        }

        /// <summary>
        /// Método de solicitar confirmação para deletar dados do banco
        /// </summary>
        /// <returns></returns>
        public static bool PerguntaSeDeletarDados()
        {
            DialogResult confirm = MessageBox.Show(Properties.Resources.ResourceManager.GetString("titulo_desejaDeletar"), Properties.Resources.ResourceManager.GetString("titulo_deletar"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Fechando a tela
        /// </summary>
        public static void FecharTela(Form form)
        {
            form.Close();
        }

        //Métodos de campos mascarados   -----------------------------------------------------------------------------------------------------
        static string valor;

        /// <summary>
        /// Método para auxiliar a aplicar campo mascarado de moeda 2
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        public static void Aplica_KeyPress_Mascara(object sender, KeyPressEventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(","));
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        /// <summary>
        /// Método para realizar o campo mascarado ao deixar o foco do campo
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        public static void Aplica_Leave_Mascara(object sender, EventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            valor = txt.Text.Replace("R$", "");
            txt.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }



        //---------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Método para retornar mascara de moeda
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        public static void RetornarMascaraMoeda(object sender, EventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            txt.Text = double.Parse(txt.Text).ToString("C2");
        }
        /// <summary>
        /// Função para retirar a mascara
        /// </summary>
        /// <param name="sender">referência ao objeto que gerou o evento</param>
        /// <param name="e">Passa um objeto específico para o evento que está sendo manipulado</param>
        public static void TirarMascaraMoeda(object sender, EventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }
        /// <summary>
        /// método para permitir apenas pontos, virgulas e numeros no campo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void ApenasValorNumericoMoeda(object sender, KeyPressEventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = txt.Text.Contains(",");
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        /// <summary>
        /// Aplica todas as funções aos respectivos eventos de campo mascarado
        /// </summary>
        /// <param name="txt">Enviar o campo ao qual vai ser aplicada a mascara para valor numerico</param>
        public static void AplicaMascaraMoeda(TextBoxBase txt)
        {
            txt.Enter += TirarMascaraMoeda;
            txt.Leave += RetornarMascaraMoeda;
            txt.KeyPress += ApenasValorNumericoMoeda;
        }


    }
}