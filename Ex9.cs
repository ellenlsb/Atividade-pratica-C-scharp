using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesSC
{
    internal class Ex9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a classificação etária do filme (G, PG, PG-13, R): ");
            string classificacao = Console.ReadLine().ToUpper(); // Converte para maiúsculo

            switch (classificacao)
            {
                case "G":
                    Console.WriteLine("Faixa etária: Livre.");
                    break;

                case "PG":
                    Console.WriteLine("Faixa etária: Maior de 10 anos.");
                    break;

                case "PG-13":
                    Console.WriteLine("Faixa etária: Maior de 13 anos.");
                    break;

                case "R":
                    Console.WriteLine("Faixa etária: Maior de 18 anos.");
                    break;

                default:
                    Console.WriteLine("Classificação inválida.");
                    break;

            }
        }
    }
}
