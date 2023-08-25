using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Boss_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "";

            Console.Write("Digite seu nome completo aqui: ", nome);
            nome = Console.ReadLine();

            char primeira = nome[0];


            Console.WriteLine("Sua primeira caractere: {0}", primeira);

            char ultima = nome[nome.Length - 1];
            Console.WriteLine("Ultimo caractere: {0}", ultima);

            string tresPrimeirasLetras = nome.Substring(0, Math.Min(3, nome.Length));
            Console.WriteLine("Os 3 primeiros caracteres: {0}", tresPrimeirasLetras);

            char quarta = nome[3];
            Console.WriteLine("A quarta caractere: {0}", quarta);

            string TodasMenosPrimeira = nome.Substring(1);
            Console.WriteLine("Todas menos a primeira caractere: {0}", TodasMenosPrimeira);

            string ultimosDoisCaracteres = nome.Substring(nome.Length - 2);
            Console.WriteLine("As duas ultimas: {0}", ultimosDoisCaracteres);

            Console.ReadLine();






        }
    }
}
