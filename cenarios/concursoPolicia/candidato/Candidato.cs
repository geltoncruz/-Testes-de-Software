using System;

namespace candidato
{
    public class Candidato
    {
        public String Nome {get; set;}
        public String Sobrenome {get; set;}
        public int Idade {get; set;}

        public Candidato(){}
        public String ExibeNomeCompleto(){
            return this.Nome+" "+this.Sobrenome;
        }

        public bool checkIdade(int age){
            this.Idade = age;

            if(this.Idade >= 18 && this.Idade <= 45){
                return true;
            }else{
                return false;
            }
        }
    }
}
