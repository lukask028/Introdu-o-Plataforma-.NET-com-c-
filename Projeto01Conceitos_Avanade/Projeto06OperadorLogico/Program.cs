using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06OperadorLogico
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definições
            // E - && - retorna true se ambas as expressões forem verdadeiras
            // OU - || - retorna true se pelo menos uma das expressões for verdadeira
            // !NOT - nega uma condicao

            // operador logico && 
            bool a = true;
            bool b = false;

            bool resultadoE = a && b; // resultado será false, pois b é false
            Console.WriteLine("Resultado do operador E (&&): " + resultadoE); // imprime o resultado do operador E
            Console.ReadKey(); // aguarda uma ação do usuario

            // operador logico ||
            //bool a = true;
            //bool b = false; 

            bool resultadoOu = a || b; // resultado será true, pois a é true
            Console.WriteLine("Resultado do operador OU (||): " + resultadoOu); // imprime o resultado do operador OU
            Console.ReadKey(); // aguarda uma ação do usuario

            // operador logico ! (NOT)
            a = true;
            bool resultado = !a;
            Console.WriteLine("! inverte o valor de a: " + resultado); // imprime o resultado do operador NOT
            Console.ReadKey(); // aguarda uma ação do usuario

        }
    }
}
