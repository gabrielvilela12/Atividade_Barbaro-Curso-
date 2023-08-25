using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1 Águia

            int i_nmr = 0;

            Console.Write("O numero que será mutiplicado 10 vezes: ");
            i_nmr = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} X 1 = {1}", i_nmr, i_nmr * 1);
            Console.WriteLine("{0} X 2 = {1}", i_nmr, i_nmr * 2);
            Console.WriteLine("{0} X 3 = {1}", i_nmr, i_nmr * 3);
            Console.WriteLine("{0} X 4 = {1}", i_nmr, i_nmr * 4);
            Console.WriteLine("{0} X 5 = {1}", i_nmr, i_nmr * 5);
            Console.WriteLine("{0} X 6 = {1}", i_nmr, i_nmr * 6);
            Console.WriteLine("{0} X 7 = {1}", i_nmr, i_nmr * 7);
            Console.WriteLine("{0} X 8 = {1}", i_nmr, i_nmr * 8);
            Console.WriteLine("{0} X 9 = {1}", i_nmr, i_nmr * 9);
            Console.WriteLine("{0} X 10 = {1}", i_nmr, i_nmr * 10);
            Console.ReadLine();



        }
    }
}
