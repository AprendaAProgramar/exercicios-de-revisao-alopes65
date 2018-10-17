using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa que calcule o custo do combustível por km percorrido.

            double precoLitro;
            double litrosCombustivel;
            double Kmpercorridos;
            double precoKm;

            Console.WriteLine("Insira os Km percorridos: ");
            Kmpercorridos = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira os litros cobustivel consumidos: ");
            litrosCombustivel = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o preço por litro de combustivel consumido: ");
            precoLitro = Convert.ToDouble(Console.ReadLine());

            precoKm = (precoLitro * litrosCombustivel)/Kmpercorridos;

            Console.WriteLine("Km percorridos = {0}", Kmpercorridos);
            Console.WriteLine("Litros combustivel consumido = {0}",litrosCombustivel );
            Console.WriteLine("Preço do combustivel por litro = {0}", precoLitro);
            Console.WriteLine("O custo do combstivel por Km/percorrido = {0:F2}", precoKm);


        }
    }
}
