using Projeto11_ExpressoesLambda.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto11_ExpressoesLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // => operador lambda
            // usado para criar expressões lambda,
            // que são funções anônimas que podem ser usadas para criar delegados
            // ou expressões de árvore

            Func<int,int> mulltiplicaPorDois = x => x * 2;
            int resultado = mulltiplicaPorDois(5);
            Console.WriteLine("Resultado: " + resultado);
            Console.ReadKey();

            List<Pessoa> pessoas = new List<Pessoa>
            {
                new Pessoa { nome = "João", idade = 25 },
                new Pessoa { nome = "Maria", idade = 30 },
                new Pessoa { nome = "Pedro", idade = 15 }
            };

            // Pessoas que possuem mais de 18 anos
            List<Pessoa> adultos = pessoas.Where(p => p.idade > 18).ToList();
            foreach (var adulto in adultos)
            {
                Console.WriteLine("Nome: " + adulto.nome + ", Idade: " + adulto.idade);
            }
            Console.ReadKey();
        }

    }
}
