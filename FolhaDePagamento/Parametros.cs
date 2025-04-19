using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaDePagamento_Parametros
{
    public class Parametros
    {
        public List<decimal> InssFaixas { get; set; }
        public List<decimal> InssAliquotas { get; set; }
        public List<decimal> IrrfFaixas { get; set; }
        public List<decimal> IrrfAliquotas { get; set; }
        public List<decimal> IrrfDeducoes { get; set; }
        public decimal Fgts { get; set; }
        public decimal SalarioFamilia { get; set; }
        public decimal LimiteSalarioFamilia { get; set; }
        public Parametros CarregarParametrosPorAno(string ano)
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "parametros.txt");
            var linhas = File.ReadAllLines(caminho);

            var parametros = new Parametros();
            bool anoEncontrado = false;

            foreach (var linha in linhas)
            {
                if (linha.Trim() == $"[{ano}]")
                {
                    anoEncontrado = true;
                    continue;
                }

                if (anoEncontrado)
                {
                    if (string.IsNullOrWhiteSpace(linha)) break;

                    var partes = linha.Split('=');
                    if (partes.Length != 2) continue;

                    string chave = partes[0];
                    string valor = partes[1];

                    switch (chave)
                    {
                        case "INSS_FAIXAS":
                            parametros.InssFaixas = valor.Split(',').Select(v => decimal.Parse(v)).ToList();
                            break;
                        case "INSS_ALIQUOTAS":
                            parametros.InssAliquotas = valor.Split(',').Select(v => decimal.Parse(v)).ToList();
                            break;
                        case "IRRF_FAIXAS":
                            parametros.IrrfFaixas = valor.Split(',').Select(v => decimal.Parse(v)).ToList();
                            break;
                        case "IRRF_ALIQUOTAS":
                            parametros.IrrfAliquotas = valor.Split(',').Select(v => decimal.Parse(v)).ToList();
                            break;
                        case "IRRF_DEDUCOES":
                            parametros.IrrfDeducoes = valor.Split(',').Select(v => decimal.Parse(v)).ToList();
                            break;
                        case "FGTS":
                            parametros.Fgts = decimal.Parse(valor);
                            break;
                        case "SALARIO_FAMILIA":
                            parametros.SalarioFamilia = decimal.Parse(valor);
                            break;
                        case "LIMITE_SALARIO_FAMILIA":
                            parametros.LimiteSalarioFamilia = decimal.Parse(valor);
                            break;
                    }
                }
            }

            return parametros;
        }
        public void SalvarParametrosNoArquivo(string ano, Parametros novos)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "parametros.txt");

            // Lê todas as linhas existentes, se houver
            List<string> linhas = File.Exists(path) ? File.ReadAllLines(path).ToList() : new List<string>();

            int indexInicio = linhas.FindIndex(l => l.Trim() == $"[{ano}]");

            if (indexInicio != -1)
            {
                // Encontrar o final do bloco atual
                int indexFim = indexInicio + 1;
                while (indexFim < linhas.Count && !linhas[indexFim].StartsWith("[")) indexFim++;

                linhas.RemoveRange(indexInicio, indexFim - indexInicio);
            }

            // Adiciona os novos dados do ano ao final da lista
            linhas.Add($"[{ano}]");
            linhas.AddRange(GerarLinhasDeParametro(novos));

            // Escreve tudo com StreamWriter
            using (StreamWriter writer = new StreamWriter(path, false)) // false = sobrescreve tudo
            {
                foreach (string linha in linhas)
                {
                    writer.WriteLine(linha);
                }
            }
            MessageBox.Show("Alterações realizadas com sucesso!","Status",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private List<string> GerarLinhasDeParametro(Parametros p)
        {
            return new List<string>
    {
        $"INSS_FAIXAS={string.Join(",", p.InssFaixas)}",
        $"INSS_ALIQUOTAS={string.Join(",", p.InssAliquotas)}",
        $"IRRF_FAIXAS={string.Join(",", p.IrrfFaixas)}",
        $"IRRF_ALIQUOTAS={string.Join(",", p.IrrfAliquotas)}",
        $"IRRF_DEDUCOES={string.Join(",", p.IrrfDeducoes)}",
        $"FGTS={p.Fgts}"
    };
        }



    }

}
