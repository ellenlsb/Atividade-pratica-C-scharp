using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesSC
{
    internal class Ex7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe seu salário: ");
            double salario = Convert.ToInt16(Console.ReadLine());
            double imposto = 0;

            int ValorImposto = salario <= 1500 ? 1 :
                               salario <= 3000 ? 2 : 3;

            switch (ValorImposto)
            {
                case 1:
                    imposto = salario * 0.05;
                    break;

                case 2:
                    imposto = salario * 0.10;
                    break;

                case 3:
                    imposto = salario * 0.15;
                    break;
            }
            Console.WriteLine("O valor do imposto é: R$ " + imposto.ToString("F2")); // ToString("F2") ter duas casas decimais.
        }
    }
}

