using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Águia_exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Águia_exercicio_3
            string s_nome = "";


            Console.Write("Digite seu nome: ");
            s_nome = Console.ReadLine();
            Console.Write("\n");
            Console.WriteLine("Bem vindo {0}, tenha um otimo dia, que hoje o sextou vai ser em casa", s_nome);
            Console.Write("\n");
            Console.WriteLine("Tecle ENTER para finalizar");
            Console.ReadLine();




        }
    }
}
