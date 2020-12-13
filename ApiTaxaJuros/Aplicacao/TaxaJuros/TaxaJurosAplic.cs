using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTaxaJuros.Aplicacao.TaxaJuros
{
    public class TaxaJurosAplic : ITaxaJurosAplic
    {
        public decimal TaxaPadrao()
        {
            return 00.1m;
        }
    }
}
