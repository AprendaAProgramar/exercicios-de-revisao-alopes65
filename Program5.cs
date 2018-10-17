using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  5.Crie um programa que apresente a diferença entre o maior e o menor valor.
             Os valores podem ser introduzidos por qualquer ordem. */

            int num1, num2;

            Console.WriteLine("Insira um numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira outro numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Maior = {0}, menor = {1} e a diferença = {2}", num1, num2, num1-num2);
            }
            else
            {
                Console.WriteLine("Maior = {0}, menor = {1} e a diferença = {2}", num2, num1, num2 - num1);
            }

        }
    }
}
