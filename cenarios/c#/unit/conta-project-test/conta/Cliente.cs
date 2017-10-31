using System;
namespace conta{
    public class Cliente{
        public int Agencia{get;set;}
        public int NumeroConta{get; set;}
        public String Nome {get; set;}
        public String Sobrenome{get; set;}
        public String Email{get; set;}
        public bool Ativo{get; set;}
        public int Idade{get; set;}

public Cliente(){}
        public Cliente(String nome, String sNome, int ag, int nConta, bool ativo)
        {
            this.Agencia = ag;
            this.NumeroConta = nConta;
            this.Nome = nome;
            this.Sobrenome = sNome;
            this.Ativo = ativo;

        }
        public String VerificarAgenciaConta(){
            String agenConta;
            return  agenConta = this.Agencia+"-"+this.NumeroConta;
        }
        public String getFullName(){
            return this.Nome+" "+this.Sobrenome;
            // return "Gelton Cruz";
        }
        public bool checkIdade(int age){
            //verificar se idade maior que 18
            this.Idade = age;
            if(this.Idade >= 18){
                return true;
            }else{
                return false;
            }
            
        }

    }
}
