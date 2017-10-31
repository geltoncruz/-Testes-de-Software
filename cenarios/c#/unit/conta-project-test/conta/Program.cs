using System;
using System.Collections.Generic;

namespace conta
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Cliente c1 = new Cliente("Gelton","Cruz",1234,54321,true);
            Console.WriteLine(c1.getFullName());
            /*
            int optMenu;
            GerenciadorCliente g1 = new GerenciadorCliente();

            do{
                Console.WriteLine("Escolha uma opção do menu");
                Console.WriteLine("1 - criar novo cliente");
                Console.WriteLine("2 - Listar Todos clientes");
                Console.WriteLine("3 - Listar clientes por código");
                Console.WriteLine("0 - Sair");

                optMenu = int.Parse(Console.ReadLine());
                switch(optMenu){
                    case 1:
                        g1.CadastrarNovoCliente();
                        break;
                    case 2:
                        
                        break;
                }
            }while(optMenu != 0);

   
        // Cliente c1 = new Cliente("Gelton","Cruz",2497,12345,true) ;
        // Console.WriteLine(c1.getFullName());
                */
        }

    }
     

}

