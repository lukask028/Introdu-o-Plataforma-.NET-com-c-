using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach é uma estrutura de repetição usada para iterar 
            //percorrer elementos da lista de forma completa 
            // array nao se mistura os tipos de dados na lista


            int[] numeros_loteria = { 1, 23, 63, 42, 45, 76, 87, 98, 59, 10 };
            foreach (int numero in numeros_loteria)
            {
                Console.WriteLine("Valor do numero: " + numero);
            }
            Console.ReadKey();

            Console.WriteLine("------------------------------");


            string[] nomes = { "João", "Maria", "Pedro", "Ana", "Carlos" };
            foreach (string nomeAtual in nomes)
            {
                Console.WriteLine("Nome: " + nomeAtual);
            }
            Console.ReadKey();
        } 
    } 
}
