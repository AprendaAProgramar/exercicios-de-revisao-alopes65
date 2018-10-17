using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            7.Crie um programa que verifique se uma pessoa pode ou não pedir a reforma sem penalização tendo em conta as seguintes restrições:
            a.Ter no mínimo 67 anos
            b.Ter trabalhado no mínimo 40 anos e ter no mínimo 60 anos.
            */

            int idade;
            int anostrabalhados;

            Console.WriteLine("Insira a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira os anos de trabalho/descontos: ");
            anostrabalhados = Convert.ToInt32(Console.ReadLine());

            if (idade >= 67 || (idade >= 60 && anostrabalhados >= 40))
            {
                Console.WriteLine("Idade inserida = {0} e anos trabalhados = {1}", idade, anostrabalhados);
                Console.WriteLine("Pode solicitar a reforma sem penalização.");
            }
            else
            {
                Console.WriteLine("Idade inserida = {0} e anos trabalhados = {1}", idade, anostrabalhados);
                Console.WriteLine("Não pode solicitar a reforma sem penalização.");
            }

        }
    }
}
