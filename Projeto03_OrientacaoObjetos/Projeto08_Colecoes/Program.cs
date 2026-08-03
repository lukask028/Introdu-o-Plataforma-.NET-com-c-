using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto08_Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Maça, laranja , pera , uva, melancia 
            // List<T> - Armazena uma lista de objetos em uma sequencia
            // de maneira ordenada 
            List<string> frutas = new List<string>();
            frutas.Add("Maça");
            frutas.Add("laranja");
            frutas.Add("pera");
            frutas.Add("uva");
            frutas.Add("melancia");

            string primeiraFruta = frutas[0];
            Console.Write(primeiraFruta+ "\n");


            frutas.Remove("laranja");
            // foreach para percorrer a coleção e exibir os itens
            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            // dicionario - Armazena pares de chave-valor
            // auxilia para busca rapidas 
            Dictionary<string, string> capitais = new Dictionary<string, string>();
            capitais.Add("Brasil", "Brasília");
            capitais.Add("França", "Paris");
            capitais.Add("Japão", "Tóquio");

            string capital = capitais["Brasil"];
            Console.WriteLine($"A capital do Brasil é: {capital}");

            foreach (var item in capitais)
            {
                Console.WriteLine($"País: {item.Key}, Capital: {item.Value}");
            }


            Dictionary<int, string> alunos = new Dictionary<int, string>();
            alunos.Add(1, "João");
            alunos.Add(2, "Maria");
            alunos.Add(3, "Pedro");

            string alunos3 = alunos[3];
            Console.WriteLine($"O aluno com ID 3 é: {alunos3}");
            // percorrer o dicionário de alunos e exibir os IDs e nomes
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"ID: {aluno.Key}, Nome: {aluno.Value}");
            }

            Console.ReadKey ();
        }
    }
}
