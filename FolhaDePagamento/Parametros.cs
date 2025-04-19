using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento
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

    }

}
