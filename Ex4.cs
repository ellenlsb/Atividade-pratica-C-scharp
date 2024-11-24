using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesSC
{
    internal class Ex4
    {
        public static void Main(string[] args)
        {
           // while (true)

            {
                Console.WriteLine("Digite uma opção");
                Console.WriteLine("----------------------");
                Console.WriteLine("1) Olá mundo!");
                Console.WriteLine("----------------------");
                Console.WriteLine("2) Bem-vindo ao C#");
                Console.WriteLine("----------------------");
                Console.WriteLine("3) Sair");
                Console.WriteLine("----------------------"); 
                Console.WriteLine(" ");


                int opcao = Convert.ToInt16(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine(" Olá mundo! " +
                            "Nesse capitulo iremos falar sobre...");
                        break;

                    case 2:
                        Console.WriteLine("Bem vindo ao C#! " +
                         "A linguagem C# foi desenvolvida..."   );
                        break;

                    case 3:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}
