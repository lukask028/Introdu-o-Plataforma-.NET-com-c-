using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estrutura switch case, é usada para quando há muitas condições a serem tomadas
            // Executa em cascata
            // Deve parar manualmente a execucao com comando break
            // Possui uma execução padrao chamada Default 

            string produto = "jaqueta";

            switch (produto) // switch analisa tanto string quanto numeros inteiros
            {
                case "camiseta":
                    Console.WriteLine("O produto é uma camiseta , preço: R$ 10,00");
                    break;
                case "calça":
                    Console.WriteLine("O produto é uma calça, preço: R$ 49,99");
                    break;
                case "sapato":
                    Console.WriteLine("O produto é um sapato, preço: R$ 39,99");
                    break;
                default:
                    Console.WriteLine("Produto não encontrado");
                    break;
            }
            Console.ReadKey();

            int diaSemana = 3;

            switch (diaSemana)
            {
                case 3:
                    Console.WriteLine("Hoje é quarta-feira");
                    break;
                default:
                    Console.WriteLine("Dia da semana não registrado");
                    break;
            }
        }
    }
}
