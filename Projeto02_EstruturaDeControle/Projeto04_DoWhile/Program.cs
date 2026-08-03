using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Do While - Estrutura de repetição que executa 
             * um bloco de código pelo menos uma vez,
            e depois continua
            Exigindo apenas uma condicao no while */

            // faça enquanto a condição for verdadeira,
            // sera executado pelo menos uma vez
            /* int contador = 0;
          do
             {
                 Console.WriteLine("O contador é: " + contador);
                 contador++;
             } while (contador < 5);

         Console.WriteLine("Saiu do contador");
         Console.ReadKey(); */

            int numeroSecreto = 8;
            int chute;
          

            do
            {
                Console.WriteLine("Digite um numero entre 1 e 10: ");
                chute = int.Parse(Console.ReadLine());
                
               
            } while (chute != numeroSecreto );

            Console.WriteLine("Parabéns! Você acertou o número secreto!");
            Console.ReadKey();


        }
    }
}
