using System;

namespace eleicao
{
    class Candidato
    {
        public String Nome{get; set;}
        public String SobreNome{get; set;}
        public int Numero{get; set;}

        Candidato(String n, String sn, int num){
            this.Nome = n;
            this.SobreNome = sn;
            this.Numero = num;
        }

        public int ExibirNumeroCandidato(){
            return this.Numero;
        }

    }
}