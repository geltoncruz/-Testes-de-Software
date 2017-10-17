using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Xunit;
using Selenium.Utils;

namespace ConversaoDistancias.Testes
{
    public class Testes
    {
        private IConfiguration _configuration;

        public Testes()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json");
            _configuration = builder.Build();
        }

        private void ExecutarTesteSelenium(Browser browser,
            double valorMilhas, double valorKm)
        {
            TelaConversaoDistancias tela =
                new TelaConversaoDistancias(_configuration, browser);

            tela.CarregarPagina();
            tela.PreencherDistanciaMilhas(valorMilhas);
            tela.ProcessarConversao();
            double resultado = tela.ObterDistanciaKm();
            tela.Fechar();

            Assert.Equal(valorKm, resultado);
        }

        [Fact]
        public void TestarFirefox()
        {
            ExecutarTesteSelenium(Browser.Firefox, 100, 160.90);
        }

        [Fact]
        public void TestarChrome()
        {
            ExecutarTesteSelenium(Browser.Chrome, 230.05, 370.1505);
        }

        [Fact]
        public void TestarEdge()
        {
            ExecutarTesteSelenium(Browser.Edge, 250.50, 403.0545);
        }

        [Fact]
        public void TestarInternetExplorer()
        {
            ExecutarTesteSelenium(Browser.InternetExplorer, 200, 321.80);
        }
    }
}