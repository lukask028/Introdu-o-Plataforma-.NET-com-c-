using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04.OperadoresAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 5;
            //adicionar 5 ao valor atual do x 

            x = x + 5;
            Console.WriteLine("valor atual do x:" + x);
            Console.ReadLine();

            //atribuicao de um valor a uma variavel 
            x += 5; // equivalente a x = x + 5;
            Console.WriteLine("valor atual do x:" + x);
            Console.ReadLine();
            x -= 3; // equivalente a x = x - 3;
            Console.WriteLine("valor atual do x da subtracao:" + x);
            
            Console.ReadLine();

            x *= 10;
            Console.WriteLine("valor atual do x da multiplacao x10:" + x);
            Console.ReadLine();

        }
    }
}
