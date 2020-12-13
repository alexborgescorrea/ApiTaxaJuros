using ApiTaxaJuros.Aplicacao.TaxaJuros;
using ApiTaxaJuros.Controllers;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ApiTaxaJuros.Test.Controllers
{
    public class TaxaJurosControllerTest
    {
        [Fact]
        public void TaxaPadrao_DeveRetornar0_01()
        {
            var taxaPadrao = 0.01m;
            var mockTaxaJurosAplic = new Mock<ITaxaJurosAplic>();

            mockTaxaJurosAplic.Setup(p => p.TaxaPadrao()).Returns(taxaPadrao);

            var taxaJurosController = new TaxaJurosController(mockTaxaJurosAplic.Object);
            var valorAtual = taxaJurosController.TaxaParao();

            Assert.Equal(0.01m, valorAtual);
        }
    }
}
