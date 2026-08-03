using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_While
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //repete o bloco de codigo enquanto a condição for verdadeira
             int contador = 0;
             //bloco de codigo a ser repetido
             while (contador <= 10)
             {
                 Console.WriteLine("Contador: " + contador);
                 contador++;
             }
             Console.WriteLine("Fim do loop while."); */

            string entrada = "";

            //!= diferente
            while (entrada != "sair")
            {
                Console.WriteLine("Digite algo (ou 'sair' para encerrar):");
                entrada = Console.ReadLine();
                Console.WriteLine("Você digitou: " + entrada);
                

                
            }
            Console.WriteLine("Programa Encerrado");
            Console.ReadKey();
        }
    }
}