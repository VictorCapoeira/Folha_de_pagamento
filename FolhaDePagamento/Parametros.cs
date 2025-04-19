using System;
using System.Collections.Generic;
using System.Globalization;
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
        public decimal SalarioMinimo { get; set; }
    }
    public class BaseDeParametros
    {
        private readonly string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "parametros.txt");

        public Parametros CarregarParametrosPorAno(string ano)
        {
            var linhas = File.ReadAllLines(path);
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
                            parametros.InssFaixas = valor.Split(',').Select(v => decimal.Parse(v.Trim(), CultureInfo.InvariantCulture)).ToList();
                            break;
                        case "INSS_ALIQUOTAS":
                            parametros.InssAliquotas = valor.Split(',').Select(v => decimal.Parse(v.Trim(), CultureInfo.InvariantCulture)).ToList();
                            break;
                        case "IRRF_FAIXAS":
                            parametros.IrrfFaixas = valor.Split(',').Select(v => decimal.Parse(v.Trim(), CultureInfo.InvariantCulture)).ToList();
                            break;
                        case "IRRF_ALIQUOTAS":
                            parametros.IrrfAliquotas = valor.Split(',').Select(v => decimal.Parse(v.Trim(), CultureInfo.InvariantCulture)).ToList();
                            break;
                        case "IRRF_DEDUCOES":
                            parametros.IrrfDeducoes = valor.Split(',').Select(v => decimal.Parse(v.Trim(), CultureInfo.InvariantCulture)).ToList();
                            break;
                        case "FGTS":
                            parametros.Fgts = decimal.Parse(valor.Trim(), CultureInfo.InvariantCulture);
                            break;
                        case "SALARIO_FAMILIA":
                            parametros.SalarioFamilia = decimal.Parse(valor.Trim(), CultureInfo.InvariantCulture);
                            break;
                        case "LIMITE_SALARIO_FAMILIA":
                            parametros.LimiteSalarioFamilia = decimal.Parse(valor.Trim(), CultureInfo.InvariantCulture);
                            break; 
                        case "SALARIO_MINIMO":
                            parametros.SalarioMinimo = decimal.Parse(valor.Trim(), CultureInfo.InvariantCulture);
                            break;
                    }
                }
            }

            return parametros;
        }

        public void SalvarParametros(string ano, Parametros novos)
        {
            List<string> linhas = File.Exists(path) ? File.ReadAllLines(path).ToList() : new List<string>();

            int indexInicio = linhas.FindIndex(l => l.Trim() == $"[{ano}]");
            if (indexInicio != -1)
            {
                int indexFim = indexInicio + 1;
                while (indexFim < linhas.Count && !linhas[indexFim].StartsWith("[")) indexFim++;
                linhas.RemoveRange(indexInicio, indexFim - indexInicio);
            }

            linhas.Add($"[{ano}]");
            linhas.AddRange(GerarLinhasDeParametro(novos));

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (string linha in linhas)
                {
                    writer.WriteLine(linha);
                }
            }
        }

        private List<string> GerarLinhasDeParametro(Parametros p)
        {
            return new List<string>
    {
        $"INSS_FAIXAS={string.Join(",", p.InssFaixas.Select(v => v.ToString("F2", CultureInfo.InvariantCulture)))}",
        $"INSS_ALIQUOTAS={string.Join(",", p.InssAliquotas.Select(v => v.ToString("F2", CultureInfo.InvariantCulture)))}",
        $"IRRF_FAIXAS={string.Join(",", p.IrrfFaixas.Select(v => v.ToString("F2", CultureInfo.InvariantCulture)))}",
        $"IRRF_ALIQUOTAS={string.Join(",", p.IrrfAliquotas.Select(v => v.ToString("F2", CultureInfo.InvariantCulture)))}",
        $"IRRF_DEDUCOES={string.Join(",", p.IrrfDeducoes.Select(v => v.ToString("F2", CultureInfo.InvariantCulture)))}",
        $"FGTS={p.Fgts.ToString("F2", CultureInfo.InvariantCulture)}",
        $"SALARIO_MINIMO={p.SalarioMinimo.ToString("F2", CultureInfo.InvariantCulture)}"
    };
        }

        public decimal CalcularINSS(decimal salario, string ano)
        {
            Parametros p = CarregarParametrosPorAno(ano);
            decimal total = 0;
            decimal faixaAnterior = 0;

            for (int i = 0; i < p.InssFaixas.Count; i++)
            {
                decimal faixaAtual = p.InssFaixas[i];
                decimal aliquota = p.InssAliquotas[i];

                if (salario > faixaAtual)
                {
                    total += (faixaAtual - faixaAnterior) * aliquota;
                }
                else
                {
                    total += (salario - faixaAnterior) * aliquota;
                    break;
                }

                faixaAnterior = faixaAtual;
            }

            return Math.Round(total, 2);
        }




        public decimal CalcularIRRF(decimal baseCalculo, string ano)
        {
            Parametros p = CarregarParametrosPorAno(ano);
            for (int i = p.IrrfFaixas.Count - 1; i >= 0; i--)
            {
                if (baseCalculo > p.IrrfFaixas[i])
                {
                    return Math.Round(baseCalculo * p.IrrfAliquotas[i] - p.IrrfDeducoes[i], 2);
                }
            }

            return 0;
        }
    }

}
