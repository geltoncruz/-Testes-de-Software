using System;
using Xunit;
using Conta;

namespace Conta.Test
{
    public class ClienteTest
    {
        private readonly Cliente _cliente;

    public ClienteTest(){
        _cliente   = new Cliente();
    }

        [Fact]
        public void Test1()
        {
            _cliente.Nome = "Gelton";
            _cliente.SobreNome = "Cruz";

            Assert.Equal(_cliente.getFullName(),_cliente.Nome+" "+_cliente.SobreNome);
            
        }
        [Fact]
        public void Test2(){
            ;
            Assert.True(_cliente.checkMaiorIdade(1986));
        }

        [Theory]
        [InlineData (17)]
        [InlineData (66)]
        public void checarLimiteIdade(int  value){
            Assert.False(_cliente.verificarIdadeLimite(value));
        }
    }
}
