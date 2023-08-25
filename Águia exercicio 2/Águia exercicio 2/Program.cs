using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Águia_exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d_quant = 0;

            Console.Write("Digite a quantidade de Laudas: ");
            d_quant = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("A quantidade multiplicada por R$50.00: {0}", d_quant * 50);

            double d_total = d_quant * 50;
            Console.WriteLine("\n");

            Console.WriteLine("Quantidade parcelada em 3 vezes iguais: {0}", (d_total / 3));
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}

