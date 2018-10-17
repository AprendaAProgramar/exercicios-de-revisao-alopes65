using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            //  3.Crie um programa que determine o valor absoluto de um número.

            double num;

            Console.WriteLine("Insira um numero real:");
            num = Convert.ToDouble(Console.ReadLine());

            if (num >0)
            {
                Console.WriteLine("Numero absoluto/modulo |{0}| = {1}", num, num);
            }
            else
                if (num<0)
            {
                Console.WriteLine("Numero absoluto/modulo |{0}| = {1}", num, -1*num);
            }



        }
    }
}
