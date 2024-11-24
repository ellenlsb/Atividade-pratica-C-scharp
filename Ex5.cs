using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesSC
{
    internal class Ex5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite sua nota (De 0 a 10): ");
            Console.WriteLine("-----------------------------");
            int nota = Convert.ToInt16(Console.ReadLine());

            switch (nota)
            {

                case int n when (n >= 0 && n <= 2):
                    Console.WriteLine("Sua classificação é F, estude mais.");
                    break;

                case int n when (n == 3 || n == 4):
                    Console.WriteLine("Sua classificação é D, pode melhorar.");
                    break;

                case int n when (n == 5 || n == 6):
                    Console.WriteLine("Sua classificação é C, quase lá.");
                    break;

                case int n when (n == 7 || n == 8):
                    Console.WriteLine("Sua classificação é B, bom.");
                    break;

                case int n when n == 9 || n == 10:
                    Console.WriteLine("Sua classificação é A, perfect.");
                    break;

                default:
                    Console.WriteLine("Erro: nota inválida");
                    break;

            }
        }
    }
}
