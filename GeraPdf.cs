using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleEstoqueDao.DAO;
using iText.IO.Font;
using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace BancoDadosZe
{
    class GeraPdf
    {
        readonly static string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        readonly static string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        public static void PdfEntradas(string pathArquivo, int id) // se passar id 0 pega tudo, id definido gera pdf excluisivo
        {
            try
            {
                #region ESTRUTURA DO ITEXT 7 
                // pathArquivo() é o método criado para pegar o local onde o pdf será salvo
                using (PdfWriter pdfWriter = new PdfWriter(pathArquivo))
                using (PdfDocument pdfDocument = new PdfDocument(pdfWriter))
                using (Document document = new Document(pdfDocument, PageSize.A4.Rotate()))
                { //PageSize.A4 - vertical ou PageSize.A4.Rotate() - horizontal
                    document.Add(new Paragraph("Controle de Estoque do Zé").SetTextAlignment(TextAlignment.CENTER).SetFontSize(25));
                    document.Add(new LineSeparator(new SolidLine()));
                    #endregion

                    #region BUSCANDO TODAS AS ENTRADAS DE ESTOQUE PARA PERCORRER
                    // realiza a busca no Banco de Dados
                    EntradaEstoqueDAO daoEntrada = new EntradaEstoqueDAO();
                    EntradaEstoque entradaEstoque = new EntradaEstoque
                    {
                        IdEntradaEstoque = id,
                        NumeroNf = "",
                    };
                    DataTable linhasEntrada = daoEntrada.SelectDbProvider(provider, strConnection, entradaEstoque);
                    #endregion

                    //PERCORRENDO AS ENTRADAS
                    foreach (DataRow row in linhasEntrada.Rows)
                    {
                        #region BUSCANDO DADOS GERAIS DA ENTRADA PARA TABELA LINHAUM E LINHADOIS
                        //CRIANDO TABELA UM E TABELA DOIS
                        Table tableLinhaDois;
                        Table tableLinhaUm;
                        tableLinhaUm = new Table(4, false);
                        tableLinhaUm.SetWidth(UnitValue.CreatePercentValue(100));
                        tableLinhaUm.SetTextAlignment(TextAlignment.LEFT);
                        tableLinhaDois = new Table(1, false);
                        tableLinhaDois.SetWidth(UnitValue.CreatePercentValue(100));
                        tableLinhaDois.SetTextAlignment(TextAlignment.LEFT);

                        PreenchendoTabelaUM(tableLinhaUm, row);
                        PreenchendoTabelaDois(tableLinhaDois, row);
                        #endregion

                        #region FORNECEDOR PARA ADICIONAR NA TABELA FORNECEDOR
                        //CRIANDO TABELA FORNECEDOR
                        Table tableLinhaFornecedor;
                        Table tableLinhaFornecedorDois;
                        tableLinhaFornecedor = new Table(4, false);
                        tableLinhaFornecedor.SetWidth(UnitValue.CreatePercentValue(100));
                        tableLinhaFornecedor.SetTextAlignment(TextAlignment.LEFT);
                        tableLinhaFornecedorDois = new Table(1, false);
                        tableLinhaFornecedorDois.SetWidth(UnitValue.CreatePercentValue(100));
                        tableLinhaFornecedorDois.SetTextAlignment(TextAlignment.LEFT);
                        PreenchendoTabelaParaFornecedor(row, tableLinhaFornecedor, tableLinhaFornecedorDois);
                        #endregion

                        #region LOJA PARA ADICIONAR NA TABELA LOJA
                        //CRIANDO TABELA LOJA
                        Table tableLinhaLoja;
                        Table tableLinhaLojaDois;
                        tableLinhaLoja = new Table(3, false);
                        tableLinhaLoja.SetWidth(UnitValue.CreatePercentValue(100));
                        tableLinhaLoja.SetTextAlignment(TextAlignment.LEFT);
                        tableLinhaLojaDois = new Table(1, false);
                        tableLinhaLojaDois.SetWidth(UnitValue.CreatePercentValue(100));
                        tableLinhaLojaDois.SetTextAlignment(TextAlignment.LEFT);
                        PreenchendoTabelaLoja(row, tableLinhaLoja, tableLinhaLojaDois);
                        #endregion

                        #region PRODUTOS PARA TABELA PRODUTO
                        Table tableLineItensEntrada = new Table(8, false);
                        tableLineItensEntrada.SetWidth(UnitValue.CreatePercentValue(100));
                        tableLineItensEntrada.SetTextAlignment(TextAlignment.LEFT);

                        PreencheATabelaProdutos(row, tableLineItensEntrada);
                        #endregion

                        #region ADICIONANDO OS COMPONENTES NO PDF
                        //ADICIONANDO COMPONENTES NO PDF
                        document.Add(new Paragraph("Entrada").SetTextAlignment(TextAlignment.CENTER).SetFontSize(15).SetBold());
                        document.Add(new LineSeparator(new DashedLine()));
                        document.Add(tableLinhaUm);
                        document.Add(tableLinhaDois);

                        document.Add(new Paragraph("Fornecedor da Entrada").SetTextAlignment(TextAlignment.CENTER).SetFontSize(15).SetBold());
                        document.Add(new LineSeparator(new DashedLine()));
                        document.Add(tableLinhaFornecedor);
                        document.Add(tableLinhaFornecedorDois);

                        document.Add(new Paragraph("Loja Da Entrada").SetTextAlignment(TextAlignment.CENTER).SetFontSize(15).SetBold());
                        document.Add(new LineSeparator(new DashedLine()));
                        document.Add(tableLinhaLoja);
                        document.Add(tableLinhaLojaDois);

                        //arrumar o Id Para ver se tem mais de um produto ou n
                        document.Add(new Paragraph("Produtos da Entrada").SetTextAlignment(TextAlignment.CENTER).SetFontSize(15).SetBold());
                        document.Add(new LineSeparator(new DashedLine()));
                        document.Add(tableLineItensEntrada);

                        document.Add(new AreaBreak());
                        #endregion

                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static string pathArquivo(string nome)
        {
            SaveFileDialog savePath = new SaveFileDialog();
            savePath.Title = "Selecione o local e o nome para salvar seu relatório";
            savePath.Filter = "Arquivo|*.pdf";
            savePath.FileName = nome + "-" + Convert.ToString(DateTime.Now).Replace("/", "-").Replace(":", "-") + ".pdf";
            if (savePath.ShowDialog() == DialogResult.OK)
            {
                return Convert.ToString(savePath.FileName);
            }
            else
            {
                return "ControleEstoque.pdf";
            }
        }

        #region METODOS PRIVADOS DA CLASSE, PARA CRIACAO DE PDF ENTRADAS
        private static void PreenchendoTabelaParaFornecedor(DataRow row, Table tableLinhaFornecedor, Table tableLinhaFornecedorDois)
        {
            //pegando dados Fornecedor
            FornecedorDAO daoFornecedor = new FornecedorDAO();
            DataTable linhasFornecedor = daoFornecedor.SelectDbProvider(provider, strConnection, new Fornecedor(Convert.ToInt32(row[8].ToString()), ""));
            //percorrendo DadosFornecedor
            foreach (DataRow rowFornecedor in linhasFornecedor.Rows)
            {
                Paragraph paragraph;

                paragraph = new Paragraph();
                paragraph.Add(new Text("CNPJ: ").SetBorder(Border.NO_BORDER).SetBold());
                paragraph.Add(new Text(rowFornecedor[1].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
                tableLinhaFornecedor.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));

                paragraph = new Paragraph();
                paragraph.Add(new Text("IE: ").SetBorder(Border.NO_BORDER).SetBold());
                paragraph.Add(new Text(rowFornecedor[2].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
                tableLinhaFornecedor.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));

                paragraph = new Paragraph();
                paragraph.Add(new Text("Cidade: ").SetBorder(Border.NO_BORDER).SetBold());
                paragraph.Add(new Text(rowFornecedor[7].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
                tableLinhaFornecedor.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));

                paragraph = new Paragraph();
                paragraph.Add(new Text("Telefone: ").SetBorder(Border.NO_BORDER).SetBold());
                paragraph.Add(new Text(rowFornecedor[5].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
                tableLinhaFornecedor.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));

                paragraph = new Paragraph();
                paragraph.Add(new Text("Logradouro: ").SetBorder(Border.NO_BORDER).SetBold());
                paragraph.Add(new Text(rowFornecedor[8].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
                tableLinhaFornecedor.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));

                paragraph = new Paragraph();
                paragraph.Add(new Text("Email: ").SetBorder(Border.NO_BORDER).SetBold());
                paragraph.Add(new Text(rowFornecedor[6].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
                tableLinhaFornecedor.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));

                paragraph = new Paragraph();
                paragraph.Add(new Text("Contato: ").SetBorder(Border.NO_BORDER).SetBold());
                paragraph.Add(new Text(rowFornecedor[9].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
                tableLinhaFornecedor.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));

                //Outra Tabela
                paragraph = new Paragraph();
                paragraph.Add(new Text("Razao Social: ").SetBorder(Border.NO_BORDER).SetBold());
                paragraph.Add(new Text(rowFornecedor[3].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
                tableLinhaFornecedorDois.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));

                paragraph = new Paragraph();
                paragraph.Add(new Text("Nome Fantasia: ").SetBorder(Border.NO_BORDER).SetBold());
                paragraph.Add(new Text(rowFornecedor[4].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada

                tableLinhaFornecedorDois.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));
                tableLinhaFornecedorDois.AddCell(new Cell().Add(new Paragraph(new Text(" "))).SetBorder(Border.NO_BORDER));
                tableLinhaFornecedorDois.AddCell(new Cell().Add(new Paragraph(new Text(" "))).SetBorder(Border.NO_BORDER));
            }
        }

        private static void PreenchendoTabelaLoja(DataRow row, Table tableLinhaLoja, Table tableLinhaLojaDois)
        {
            //pegando dados Loja
            LojaDAO daoLoja = new LojaDAO();
            DataTable linhasLoja = daoLoja.SelectDbProvider(provider, strConnection, new Loja(Convert.ToInt32(row[9].ToString()), ""));
            //percorrendo DadosFornecedor
            foreach (DataRow rowLoja in linhasLoja.Rows)
            {
                Paragraph paragraph;

                //Observação
                paragraph = new Paragraph();
                paragraph.Add(new Text("CNPJ: ").SetBorder(Border.NO_BORDER).SetBold());
                paragraph.Add(new Text(rowLoja[1].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
                tableLinhaLoja.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));

                paragraph = new Paragraph();
                paragraph.Add(new Text("IE: ").SetBorder(Border.NO_BORDER).SetBold());
                paragraph.Add(new Text(rowLoja[2].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
                tableLinhaLoja.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));

                paragraph = new Paragraph();
                paragraph.Add(new Text("Telefone: ").SetBorder(Border.NO_BORDER).SetBold());
                paragraph.Add(new Text(rowLoja[5].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
                tableLinhaLoja.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));
                //new line
                paragraph = new Paragraph();
                paragraph.Add(new Text("Email: ").SetBorder(Border.NO_BORDER).SetBold());
                paragraph.Add(new Text(rowLoja[6].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
                tableLinhaLoja.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));

                paragraph = new Paragraph();
                paragraph.Add(new Text("Cidade: ").SetBorder(Border.NO_BORDER).SetBold());
                paragraph.Add(new Text(rowLoja[7].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
                tableLinhaLoja.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));

                paragraph = new Paragraph();
                paragraph.Add(new Text("Tipo Loja: ").SetBorder(Border.NO_BORDER).SetBold());
                paragraph.Add(new Text(rowLoja[9].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
                tableLinhaLoja.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));
                //new table
                paragraph = new Paragraph();
                paragraph.Add(new Text("Razao Social: ").SetBorder(Border.NO_BORDER).SetBold());
                paragraph.Add(new Text(rowLoja[3].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
                tableLinhaLojaDois.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));

                paragraph = new Paragraph();
                paragraph.Add(new Text("Nome Fantasia: ").SetBorder(Border.NO_BORDER).SetBold());
                paragraph.Add(new Text(rowLoja[4].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
                tableLinhaLojaDois.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));
            }
        }

        private static void PreencheATabelaProdutos(DataRow row, Table tableLineItensEntrada)
        {
            // realiza a busca no Banco de Dados
            ItensEntradaDAO daoItensEntrada = new ItensEntradaDAO();
            ItensEntrada itenEntrada = new ItensEntrada
            {
                EntradasEstoqueId = Convert.ToInt32(row[0].ToString()),
            };
            DataTable linhas = daoItensEntrada.SelectDbProvider(provider, strConnection, itenEntrada);
            tableLineItensEntrada.AddCell(new Cell().Add(new Paragraph("ID")).SetBorder(Border.NO_BORDER));
            tableLineItensEntrada.AddCell(new Cell().Add(new Paragraph("Produto")).SetBorder(Border.NO_BORDER));
            tableLineItensEntrada.AddCell(new Cell().Add(new Paragraph("Quantidade")).SetBorder(Border.NO_BORDER));
            tableLineItensEntrada.AddCell(new Cell().Add(new Paragraph("Valor Un")).SetBorder(Border.NO_BORDER));
            tableLineItensEntrada.AddCell(new Cell().Add(new Paragraph("Marca")).SetBorder(Border.NO_BORDER));
            tableLineItensEntrada.AddCell(new Cell().Add(new Paragraph("Modelo")).SetBorder(Border.NO_BORDER));
            tableLineItensEntrada.AddCell(new Cell().Add(new Paragraph("Lote")).SetBorder(Border.NO_BORDER));
            tableLineItensEntrada.AddCell(new Cell().Add(new Paragraph("Validade")).SetBorder(Border.NO_BORDER));

            foreach (DataRow rowProduto in linhas.Rows)
            {
                tableLineItensEntrada.AddCell(new Cell().Add(new Paragraph(rowProduto[0].ToString())).SetBorder(Border.NO_BORDER));
                tableLineItensEntrada.AddCell(new Cell().Add(new Paragraph(rowProduto[6].ToString())).SetBorder(Border.NO_BORDER));
                tableLineItensEntrada.AddCell(new Cell().Add(new Paragraph(rowProduto[1].ToString())).SetBorder(Border.NO_BORDER));
                tableLineItensEntrada.AddCell(new Cell().Add(new Paragraph(rowProduto[2].ToString())).SetBorder(Border.NO_BORDER));
                tableLineItensEntrada.AddCell(new Cell().Add(new Paragraph(rowProduto[7].ToString())).SetBorder(Border.NO_BORDER));
                tableLineItensEntrada.AddCell(new Cell().Add(new Paragraph(rowProduto[3].ToString())).SetBorder(Border.NO_BORDER));
                tableLineItensEntrada.AddCell(new Cell().Add(new Paragraph(rowProduto[4].ToString())).SetBorder(Border.NO_BORDER));
                tableLineItensEntrada.AddCell(new Cell().Add(new Paragraph(rowProduto[5].ToString())).SetBorder(Border.NO_BORDER));
            }
        }

        private static void PreenchendoTabelaDois(Table tableLinhaDois, DataRow row)
        {
            Paragraph paragraph;

            //Observação
            paragraph = new Paragraph();
            paragraph.Add(new Text("Observação: ").SetBorder(Border.NO_BORDER).SetBold());
            paragraph.Add(new Text(row[6].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
            tableLinhaDois.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));
            //Chave Nf
            paragraph = new Paragraph();
            paragraph.Add(new Text("Chave Nota Fiscal: ").SetBorder(Border.NO_BORDER).SetBold());
            paragraph.Add(new Text(row[4].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
            tableLinhaDois.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));
            //LinhaVazia
            tableLinhaDois.AddCell(new Cell().Add(new Paragraph()).SetBorder(Border.NO_BORDER));
            //LinhaVazia
            tableLinhaDois.AddCell(new Cell().Add(new Paragraph()).SetBorder(Border.NO_BORDER));
        }

        private static void PreenchendoTabelaUM(Table tableLinhaUm, DataRow row)
        {
            Paragraph paragraph;
            //id
            paragraph = new Paragraph();
            paragraph.Add(new Text("ID Entrada: ").SetBorder(Border.NO_BORDER).SetBold());
            paragraph.Add(new Text(row[0].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT));
            tableLinhaUm.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));
            //Fornecedor
            paragraph = new Paragraph();
            paragraph.Add(new Text("ID Fornecedor: ").SetBorder(Border.NO_BORDER).SetBold());
            paragraph.Add(new Text(row[8].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //fornecedor
            tableLinhaUm.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));
            //Numero Nf
            paragraph = new Paragraph();
            paragraph.Add(new Text("Serie NF: ").SetBorder(Border.NO_BORDER).SetBold());
            paragraph.Add(new Text(row[2].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Serie
            tableLinhaUm.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));
            //Data Nf
            paragraph = new Paragraph();
            paragraph.Add(new Text("Data NF: ").SetBorder(Border.NO_BORDER).SetBold());
            paragraph.Add(new Text(row[3].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Nf
            tableLinhaUm.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));
            //Id Loja
            paragraph = new Paragraph();
            paragraph.Add(new Text("Id Loja: ").SetBorder(Border.NO_BORDER).SetBold());
            paragraph.Add(new Text(row[9].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
            tableLinhaUm.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));
            //Valor Total Nota
            paragraph = new Paragraph();
            paragraph.Add(new Text("Valor Total Nota: ").SetBorder(Border.NO_BORDER).SetBold());
            paragraph.Add(new Text(row[7].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
            tableLinhaUm.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));
            //Data Entrada 
            paragraph = new Paragraph();
            paragraph.Add(new Text("Data Entrada: ").SetBorder(Border.NO_BORDER).SetBold());
            paragraph.Add(new Text(row[5].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
            tableLinhaUm.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));
            //Numero Nota
            paragraph = new Paragraph();
            paragraph.Add(new Text("Numero NF: ").SetBorder(Border.NO_BORDER).SetBold());
            paragraph.Add(new Text(row[1].ToString()).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT)); //Data Entrada
            tableLinhaUm.AddCell(new Cell().Add(paragraph).SetBorder(Border.NO_BORDER));
        }
        #endregion
    }
}
