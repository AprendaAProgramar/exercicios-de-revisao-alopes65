using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  6.Crie um programa que leia o nome de duas equipas de futebol e
              número de golos marcado num jogo e apresente o nome do vencedor. */

            string a;
            string b;
            int golosa;
            int golosb;

            Console.WriteLine("Insira o nome da primeira equipa: ");
            a = Console.ReadLine();

            Console.WriteLine("Insira o nome da segunda equipa: ");
            b = Console.ReadLine();

            Console.WriteLine("Equipa a = {0} e b = {1}\n", a, b);
            Console.WriteLine("Insira os golos marcados pela equipa {0}", a);
            golosa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira os golos marcados pela equipa {0}", b);
            golosb = Convert.ToInt32(Console.ReadLine());

            if (golosa > golosb)
                Console.WriteLine("Venceu a equipa do {0} com {1} golos", a, golosa);
            else
                Console.WriteLine("Venceu a equipa do {0} com {1} golos", b, golosb);
        }
    }
}
