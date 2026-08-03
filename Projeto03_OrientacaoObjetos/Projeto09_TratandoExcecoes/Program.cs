using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto09_TratandoExcecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TRY - Bloco de codigo que pode gerar uma exceção

            // CATCH - Bloco de codigo que trata a exceção, o erro no caso

            // f9 - debuga - passo a passo o código para identificar onde ocorre o erro
            // f10 - executa o código até o próximo ponto de interrupção ou até o final do programa
            // f5 continua o codigo ate o final ou ate o prox breakpoint
            try
            {
                int[] numero = { 1, 2, 3, 4, 5 };
                Console.WriteLine(numero[3]);
            }
            catch (Exception ex) //ex representa o valor do Exception
            {
                Console.WriteLine("Ocorreu um erro: " + ex.ToString());
                Console.ReadKey();
                //throw;
                //trhow - relança a exceção para ser tratada em outro lugar
                //ou para encerrar o programa
            }
            finally // finally - Bloco de codigo que sempre , é opcional o finally
            // executa, independentemente de uma exceção ter sido lançada ou não
            // com ou sem erro
            {
                Console.WriteLine("Bloco finally sempre sera executado.");
                Console.ReadKey();
            }
            // Exception forma generica de pegar todos os erros
        }
    }
}
