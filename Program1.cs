using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
          //  1.Crie um programa que calcule a área de um círculo. 

            double raio;
            const double valorPi = 3.14;
            double area;

            Console.WriteLine("Insira o raio da circunferencia: ");
            raio = Convert.ToDouble(Console.ReadLine());

            area = valorPi * (raio * raio);

            Console.WriteLine("A area do circulo = {0:F2}", area);
            

        }
    }
}
