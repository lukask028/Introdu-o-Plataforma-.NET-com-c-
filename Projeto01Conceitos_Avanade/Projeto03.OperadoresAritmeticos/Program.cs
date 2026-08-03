using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            // operadores aritmeticos
            int soma = a + b; // adicao
            int subtracao = a - b; // subtracao
            int multiplicacao = a * b; // multiplicacao
            int divisao = a / b; // divisao
            int modulo = a % b; // modulo, retorna o resto da divisao

            Console.WriteLine($"Soma:{soma}\nsubtracao:{subtracao} \nmultiplicacao: {multiplicacao} \ndivisao:  { divisao} \nmodulo: { modulo}"); // imprime os resultados

            Console.ReadKey(); // aguarda uma ação do usuario

            
            int c = 20;
            int resultadoComParenteses = (a + b) * c;
            Console.WriteLine("Resultado com parenteses:" + resultadoComParenteses);

            Console.ReadKey();


        }
    }
}
