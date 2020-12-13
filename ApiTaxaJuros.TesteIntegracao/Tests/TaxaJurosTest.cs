using ApiTaxaJuros.TesteIntegracao.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace ApiTaxaJuros.TesteIntegracao.Tests
{
    public class TaxaJurosTest
    {        
        private readonly TestContext _testContext;
        private readonly string _controller = "/taxajuros";

        public TaxaJurosTest()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public async Task TaxaPadrao_RespostaOk()
        {
            var response = await _testContext.Client.GetAsync(_controller);

            response.EnsureSuccessStatusCode();

            Assert.True(response.IsSuccessStatusCode);
        }

        [Fact]
        public async Task TaxaPadrao_DeveRetornar0_01()
        {
            var response = await _testContext.Client.GetAsync(_controller);

            response.EnsureSuccessStatusCode();

            var valorAtual = await JsonSerializer.DeserializeAsync<decimal>(await response.Content.ReadAsStreamAsync());

            Assert.Equal(0.01m, valorAtual);
        }
    }
}
