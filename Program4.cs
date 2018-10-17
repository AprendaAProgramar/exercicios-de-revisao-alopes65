using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            //   4.Crie um programa que verifique se um número introduzido pelo utilizador é múltiplo de 5.
            int num;

            Console.WriteLine("Insira um numero");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 5 == 0 && num!=0)
                Console.WriteLine("{0} é multiplo de 5.", num);
            else
                Console.WriteLine("{0} não é multiplo de 5.", num);


        }
    }
}
