using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesSC
{
    internal class Ex6
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Digite uma opção");
            Console.WriteLine("------------------");
            Console.WriteLine("1) Café");
            Console.WriteLine("2) Chá");
            Console.WriteLine("3) Suco");
            Console.WriteLine(" ");
            int opcao = Convert.ToInt16(Console.ReadLine());

            switch(opcao)
            {
                case 1:
                    Console.WriteLine("Opções disponiveis");
                    Console.WriteLine("------------------");
                    Console.WriteLine("Café coado");
                    Console.WriteLine("Café c/ leite");
                    Console.WriteLine("Café espresso");
                    break;

                    case 2:
                    Console.WriteLine("Opções disponiveis");
                    Console.WriteLine("------------------");
                    Console.WriteLine("Camomila");
                    Console.WriteLine("Erva-doce");
                    Console.WriteLine("Alecrim");
                    break;

                    case 3:
                    Console.WriteLine("Opções disponiveis");
                    Console.WriteLine("------------------");
                    Console.WriteLine("Laranja");
                    Console.WriteLine("Manga");
                    Console.WriteLine("Acerola");
                    break;

                default:
                    Console.WriteLine("Erro. Opção inválida");
                    break;
            }
        }
    }
}
