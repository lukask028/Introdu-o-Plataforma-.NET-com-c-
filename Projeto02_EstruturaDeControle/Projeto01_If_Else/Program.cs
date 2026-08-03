using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estrutura if else, é usada para tomada de decisões 
            /*if (condicao)
            { 
            
            }*/

            int numero = 0;
            if (numero > 0) // bloco que executa se a condição primária for atendida
            {
                Console.WriteLine("O número é positivo");
            }
            else if (numero < 0) // bloco que executa se uma condição secundária for atendida
            {
                Console.WriteLine("O número é negativo");
            }
            else //bloco padrão se nenhuma condição for atendida
            {
                Console.WriteLine("O número é zero");
            }

            int nota = 200;
            //regra de negócio de exemplo
            // maior ou igual a 90 = nota A 
            // maior ou igual a 80 = nota B 
            // senao a nota é F 

            if (nota >= 90)
            {
                Console.WriteLine("Nota A");
            }
            else if (nota < 90 && nota >= 80)
            {
                Console.WriteLine("Nota B");
            }
            else
            {
                Console.WriteLine("Nota F");
            }
        }
    }
}

