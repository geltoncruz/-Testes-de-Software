using System;

namespace Conta
{
    public class Cliente
    {
        public String Nome{get;set;}
        public String SobreNome{get; set;}
        public int Idade{get; set;}

        public String getFullName(){
            return this.Nome+" "+this.SobreNome;
        }

        public bool checkMaiorIdade(int nascimento){
            
            int idade  = 2017 - nascimento;
            if(idade >= 18){
                return true;
            }else{
                return false;
            }

        }

        public bool verificarIdadeLimite(int idade){
            if(idade >= 18 && idade <= 65){
                return true;
            }else{
                return false;
            }
        }
    }
}
