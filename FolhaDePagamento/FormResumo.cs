using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FolhaDePagamento
{
    public partial class FormResumo : Form
    {
        public string nomeDoFuncionario;
        public string matriculaDoFuncionario;
        public string cargoDoFuncionario;

        public FormResumo(
            List<(string nome, decimal valor)> ganhos,
            List<(string nome, decimal valor)> descontos,
            decimal salarioBruto,
            decimal salarioLiquido, 
            string nomeFuncionario, 
            string matricula, 
            string cargo)
        {
            InitializeComponent();
            nomeDoFuncionario = string.IsNullOrWhiteSpace(nomeFuncionario) ? "Não informado" : nomeFuncionario;
            matriculaDoFuncionario = string.IsNullOrWhiteSpace(matricula) ? "Não informado" : matricula;
            cargoDoFuncionario = string.IsNullOrWhiteSpace(cargo) ? "Não informado" : cargo;

            // Preencher tabela de ganhos
            foreach (var item in ganhos)
            {
                dgvGanhos.Rows.Add(item.nome, item.valor.ToString("C2"));
            }

            // Preencher tabela de descontos
            foreach (var item in descontos)
            {
                dgvDescontos.Rows.Add(item.nome, item.valor.ToString("C2"));
            }

            lblBruto.Text = "Salário Bruto: " + salarioBruto.ToString("C2");
            lblLiquido.Text = "Salário Líquido: " + salarioLiquido.ToString("C2");
        }

        private void FormResumo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog();
            salvar.Filter = "Arquivo PDF (*.pdf)|*.pdf";
            salvar.Title = "Salvar Folha de Pagamento";

            if (salvar.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, new FileStream(salvar.FileName, FileMode.Create));
                doc.Open();

                // Título
                var titulo = new Paragraph("Folha de Pagamento", FontFactory.GetFont("Arial", 16.ToString(), Font.Bold));
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);
                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph("Funcionário: " + nomeDoFuncionario));
                doc.Add(new Paragraph("Matrícula: " + matriculaDoFuncionario));
                doc.Add(new Paragraph("Cargo: " + cargoDoFuncionario));
                doc.Add(new Paragraph("\n"));
                // Tabela de ganhos
                PdfPTable tabelaGanhos = new PdfPTable(2);
                tabelaGanhos.WidthPercentage = 100;
                tabelaGanhos.AddCell("Ganhos");
                tabelaGanhos.AddCell("Valor");

                foreach (DataGridViewRow row in dgvGanhos.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        tabelaGanhos.AddCell(row.Cells[0].Value.ToString());
                        tabelaGanhos.AddCell(row.Cells[1].Value.ToString());
                    }
                }

                doc.Add(tabelaGanhos);
                doc.Add(new Paragraph("\n"));

                // Tabela de descontos
                PdfPTable tabelaDescontos = new PdfPTable(2);
                tabelaDescontos.WidthPercentage = 100;
                tabelaDescontos.AddCell("Descontos");
                tabelaDescontos.AddCell("Valor");

                foreach (DataGridViewRow row in dgvDescontos.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        tabelaDescontos.AddCell(row.Cells[0].Value.ToString());
                        tabelaDescontos.AddCell(row.Cells[1].Value.ToString());
                    }
                }

                doc.Add(tabelaDescontos);
                doc.Add(new Paragraph("\n"));

                // Totais
                var bruto = new Paragraph(lblBruto.Text, FontFactory.GetFont("Arial", 12.ToString(), Font.Bold));
                var liquido = new Paragraph(lblLiquido.Text, FontFactory.GetFont("Arial", 12.ToString(), Font.Bold));
                doc.Add(bruto);
                doc.Add(liquido);

                doc.Close();
                MessageBox.Show("PDF exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
