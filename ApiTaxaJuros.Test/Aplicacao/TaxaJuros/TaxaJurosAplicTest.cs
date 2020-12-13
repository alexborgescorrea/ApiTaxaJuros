using ApiTaxaJuros.Aplicacao.TaxaJuros;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ApiTaxaJuros.Test.Aplicacao.TaxaJuros
{
    public class TaxaJurosAplicTest
    {
        [Fact]
        public void TaxaPadrao_DeveRetornar00_1()
        {
            var aplic = new TaxaJurosAplic();                        

            var taxaPadrao = aplic.TaxaPadrao();

            Assert.Equal(0.01m, taxaPadrao);
        }
    }
}
