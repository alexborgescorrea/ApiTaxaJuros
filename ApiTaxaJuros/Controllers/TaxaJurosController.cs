using ApiTaxaJuros.Aplicacao.TaxaJuros;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTaxaJuros.Controllers
{
    [ApiController]
    [Route("TaxaJuros")]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJurosAplic _taxaJurosAplic;

        public TaxaJurosController(ITaxaJurosAplic taxaJurosAplic)
        {
            _taxaJurosAplic = taxaJurosAplic;
        }

        [HttpGet]
        public decimal TaxaParao()
        {
            return _taxaJurosAplic.TaxaPadrao();
        }
    }
}
