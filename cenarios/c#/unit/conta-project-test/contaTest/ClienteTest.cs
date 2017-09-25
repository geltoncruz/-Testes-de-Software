using System;
using Xunit;
using conta;

namespace contaTest
{
    public class ClienteTest
    {
        private readonly Cliente _cliente;

        public ClienteTest(){
            _cliente = new Cliente();
        }
        
        [Fact]
        public void TestNomeCompleto()
        {
            _cliente.Nome = "Gelton";
            _cliente.Sobrenome = "Cruz";
         Assert.Equal(_cliente.Nome+" "+_cliente.Sobrenome,_cliente.getFullName());
        }
        //[Fact]
        [Theory]
        [InlineData(18)]
        [InlineData(18)]
        [InlineData(30)]
        public void TestIdadeLimite(int value){
            _cliente.Idade = value;
            Assert.True(_cliente.checkIdade(value), userMessage: $"{value} foi avaliado falso");
        }

    }
}
