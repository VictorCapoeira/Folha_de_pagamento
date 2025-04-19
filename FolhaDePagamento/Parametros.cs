using System;
using System.Collections.Generic;
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
    }

}
