using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array é uma estrutura de dados que é capaz de armazenar
            //valores em uma unica variavel

            //vetor - sequencia nao ordenada de itens

            //os itens sempre iniciam no indice 0 

           /* int[] numeros = new int[5];*/

            int[] outrosnumeros = { 1, 2, 3, 4, 5, 150, 250 };

            /*Console.WriteLine("O terceiro numero e:"+ outrosnumeros[2]);
            Console.ReadKey(); */


            for (int i = 0; i < outrosnumeros.Length; i++)
            {
                Console.WriteLine("Valor do indice " + i + ": " + outrosnumeros[i]);
            }
        }
    }
}
