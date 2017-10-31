using System;

namespace banco
{
    public class Cliente
    {
        public String Nome{get;set;}
        public int Cpf {get; set;}

        public Cliente(String nome){
            this.Nome = nome;
        }
    }
}
