using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8.Troque o valor de duas variáveis.

            int a;
            int b;
            int aux;

            Console.WriteLine("Insira o valor de a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o valor de b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("a= {0} e b = {1}", a, b);

            aux = a;
            a = b;
            b = aux;

            Console.WriteLine("a= {0} e b = {1}", a, b);

        }
    }
}
