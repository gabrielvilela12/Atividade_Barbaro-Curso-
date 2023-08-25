using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 4 Coruja

            double peso = 0, altura = 0;

            Console.Write("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());


            Console.Write("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine());


            Console.Write("Sua IMC será: {0}", peso / (altura * 2));
            Console.ReadLine();




        }
    }
}
