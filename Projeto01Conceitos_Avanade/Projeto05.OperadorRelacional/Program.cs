using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto05.OperadorRelacional
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            // operadores relacionais
            bool igual = a == b; // verifica se a é igual a b
 
            bool diferente = a != b; // verifica se a é diferente de b

            bool maior = a > b; // verifica se a é maior que b

            bool menor = a < b; // verifica se a é menor que b
          
            bool maiorOuIgual = a >= b; // verifica se a é maior ou igual a b
           
            bool menorOuIgual = a <= b; // verifica se a é menor ou igual a b

            Console.WriteLine($"a == b: {igual}\na != b: {diferente}\na > b: {maior}\na < b: {menor}\na >= b: {maiorOuIgual}\na <= b: {menorOuIgual}"); // imprime os resultados
            Console.ReadKey(); // aguarda uma ação do usuario
        }
    }
}
