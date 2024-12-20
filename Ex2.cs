﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesSC
{
    internal class Ex2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o operador(+, -, *, /): ");
            char operador = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = Convert.ToInt16(Console.ReadLine());

            switch (operador)
            {
                case '+':
                    Console.WriteLine("O resultado é: " + (numero1 + numero2));
                    break;

                case '-':
                    Console.WriteLine("O resultado é: " + (numero1 - numero2));
                    break;

                case '*':
                    Console.WriteLine("O resultado é: " + (numero1 * numero2));
                    break;

                case '/':
                    if (numero2 != 0)
                    {
                        Console.WriteLine("O resultado é: " + (numero1 / numero2));
                    }
                    else
                    {
                        Console.WriteLine("Erro: divisão por zero não!");
                    }
                    break;

                default:
                    Console.WriteLine("Operador inválido");
                    break;
            }
        }

    }
}
