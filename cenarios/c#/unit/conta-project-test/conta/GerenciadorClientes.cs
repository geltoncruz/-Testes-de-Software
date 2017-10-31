using System;
using System.Collections.Generic;

namespace conta
{
    public class GerenciadorCliente{
        public List<Cliente> Lista{get; set;}

        // public GerenciadorCliente(List<Cliente> lista){
        //     this.Lista = lista;
        // }
        public void AdicionarClienteLista(Cliente cli){
                    Lista.Add(cli);
                }        
        public void CadastrarNovoCliente(){
            // try{

                Console.WriteLine("Informe Seu primeiro nome");
                String Nome = Console.ReadLine();
                Console.WriteLine("Informe Seu ultimo nome");
                String Snome = Console.ReadLine();
                Console.WriteLine("Informe sua agencia");
                int Agencia = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe sua Conta");
                int Conta = int.Parse(Console.ReadLine());
                Console.WriteLine("Conta Ativa?:");
                bool situacao = bool.Parse(Console.ReadLine());
                AdicionarClienteLista(new Cliente(Nome,Snome,Agencia,Conta,situacao));    
                Console.WriteLine("Sua lista contem :",ExibirTamanhoLista());           
            
        }
        public int ExibirTamanhoLista(){
            return Lista.Count;
        }

        public void ListarTodosClientes(){
            /* */
            Console.WriteLine("\nRELAÇÃO DE TODOS CLIENTES: ");
            foreach(Cliente c in Lista){
                // Console.WriteLine("Codigo: "+c.Codigo);
                Console.WriteLine("Nome: "+ c.Nome);
                switch(c.Ativo){
                    case true:
                        Console.WriteLine("Ativo");
                        break;
                    case false:
                        Console.WriteLine("Inativo");
                        break;
                    default:
                    Console.WriteLine("Opção Inválida");
                    break;
                }
                Console.WriteLine("--------------------");
            }
        }
    
    }
}