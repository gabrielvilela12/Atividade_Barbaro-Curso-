using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coruja_exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio  3 do coruja

            int i_nmr1 = 0, i_nmr2 = 0;

            Console.Write("Digite um numero: ");
            i_nmr1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro numero: ");
            i_nmr2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A Soma entre eles: {0}", i_nmr1 + i_nmr2);

            Console.WriteLine("A subtração entre eles: {0}", i_nmr1 - i_nmr2);

            Console.WriteLine("A multiplicação entre eles: {0}", i_nmr1 * i_nmr2);

            Console.ReadLine();


        }
    }
}
