using Projeto10_Delegates.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto10_Delegates
{
    internal class Program
    {
        public delegate int Operacao(int a, int b);
        // delegate pode assumir outros metodos 
        static void Main(string[] args)
        {
 Operacao opsoma = OperacoesMatematicas.Somar;
            int resultadoSoma = opsoma(10, 5);
            Operacao opsubtracao = OperacoesMatematicas.Subtrair;
            int resultadoSubtracao = opsubtracao(10, 5);

            Console.WriteLine("Soma: " + resultadoSoma);
            Console.WriteLine("Subtração: " + resultadoSubtracao);
            Console.ReadKey();

        }
    }
}
