using Projeto02_Classes.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//aula 03 - construtores
namespace Projeto03_Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();

            Console.WriteLine($"modelo: {carro1.modelo}\n" +
                $"ano: {carro1.ano}\n" +
                $"cor: {carro1.cor}");

            Console.WriteLine("--------------------------------------");

            carro1.modelo = "Fusca";
            carro1.cor = "Azul";
            carro1.ano = 1980;
            Console.WriteLine($"modelo: {carro1.modelo}\n" +
               $"ano: {carro1.ano}\n" +
               $"cor: {carro1.cor}");

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Criando um novo carro utilizando o construtor com parâmetros");
            Carro carro2 = new Carro("Gol bolinha", "Prata", 2010);
            Console.WriteLine($"modelo: {carro2.modelo}\n" +
               $"ano: {carro2.ano}\n" +
               $"cor: {carro2.cor}");

            Console.ReadKey();
        }
    }
}
