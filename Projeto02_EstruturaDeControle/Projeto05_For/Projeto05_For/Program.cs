using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto05_For
{
    internal class Program
    {
        /*Enquanto for verdadeiro
         * Exige 3 parametros:
         * Contador: Variável que controla o número de vezes 
         * que o código será executado
         * Condição: Expressão que é avaliada antes de cada iteração
         * Incremento: Expressão que é executada após cada iteração, 
         * geralmente usada para atualizar o contador
         */
        static void Main(string[] args)
        {
            /*for  (contador , condicao, incremento)
            {

            }*/
            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Valor de i: " + i);
            }
            Console.ReadKey();*/

           
            for (int contadorPares = 0; contadorPares <= 10; contadorPares++)
            {
                if (contadorPares % 2 == 0)
                {
                    Console.WriteLine("Valor de contadorPares: " + contadorPares);
                    contadorPares++;
                }
            }
        }
    }
}
