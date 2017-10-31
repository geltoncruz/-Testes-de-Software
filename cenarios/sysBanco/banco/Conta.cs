using System;

namespace banco
{
    public class Conta
    {
        public int IdConta{get; set;}
        public Cliente Cliente;
        public double Saldo{get; set;}
        public bool Status{get; set;}

        public Conta(int Id, Cliente cliente, bool Situacao){
            this.IdConta = Id;
            // this.NomeCliente = Nome;
            this.Cliente = cliente;
            this.Status = Situacao;
        }
    }
}
