using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Moq;
using Softplayer.Calculadora.Controllers;
using Softplayer.Calculadora.Repositorio;
using Xunit;

namespace Softplayer.Calculadora.Test
{
    public class CalculadoraTest
    {
        private readonly TesteContexto _testeContexto;

        public CalculadoraTest()
        {
            _testeContexto = new TesteContexto();
        }

        [Fact]
        public async Task Calculadora_Calculajuros_ReturnsOkResponse()
        {
            var response = await _testeContexto.Client.GetAsync("/v1/Calculadora/calculajuros?valorinicial=100.12&meses=5");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Calculadora_Calculajuros_ReturnsBadResponse_ValorInicial()
        {
            var response = await _testeContexto.Client.GetAsync("/v1/Calculadora/calculajuros?valorinicial=XXX&meses=5");
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Calculadora_Calculajuros_ReturnsBadResponse_Meses()
        {
            var response = await _testeContexto.Client.GetAsync("/v1/Calculadora/calculajuros?valorinicial=233&meses=XXX");
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Calculadora_Calculajuros_CorrectContentType()
        {
            var response = await _testeContexto.Client.GetAsync("/v1/Calculadora/calculajuros?valorinicial=100.12&meses=5");
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType.ToString().Should().Be("text/plain; charset=utf-8");
        }

        [Fact]
        public async Task Calculadora_Calculajuros_Taxa_UM_Porcento()
        {
            var response = await _testeContexto.Client.GetAsync("/v1/Calculadora/calculajuros?valorinicial=100&meses=5");
            response.EnsureSuccessStatusCode();
            var montante = await response.Content.ReadAsStringAsync();
            montante.Should().Be("105.10");
        }
    }
}
