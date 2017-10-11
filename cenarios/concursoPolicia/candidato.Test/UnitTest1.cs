using System;
using Xunit;
using candidato;

namespace candidato.Test
{
    public class CandidatoTest
    {
        private readonly Candidato _candi;

        public CandidatoTest(){
            _candi = new Candidato();
        }
        [Fact]
        public void ExibeNomeCompletoTest()
        {
            _candi.Nome = "Gelton";
            _candi.Sobrenome = "Cruz";

            Assert.Equal(_candi.ExibeNomeCompleto(),_candi.Nome+" "+_candi.Sobrenome);
        }
        [Theory]
        [InlineData(17)]
        [InlineData(46)]
        [InlineData(22)]

        public void checkIdadeTest(int value){
            //Assert.True(_candi.checkIdade(value));
            Assert.InRange(value,18,45);
        }
        
    }
}
