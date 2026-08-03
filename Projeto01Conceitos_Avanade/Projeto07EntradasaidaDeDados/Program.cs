using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto07EntradasaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados
            Console.WriteLine("Entrada de dados:"); // imprime uma mensagem indicando que o programa está esperando uma entrada de dados
            Console.WriteLine("Digite seu nome:"); // solicita ao usuario que digite seu nome
            string nome = Console.ReadLine(); // lê a entrada do usuario e armazena na variável nome
            Console.WriteLine("Digite sua idade:"); // solicita ao usuario que digite sua idade
            int idade = int.Parse(Console.ReadLine()); // lê a entrada do usuario, converte para inteiro e armazena na variável idade

            Console.WriteLine("--------------------------");
            // Saída de dados
            Console.WriteLine("Saida de dados"); // imprime uma mensagem indicando que o programa está prestes a exibir a saída de dados
            Console.WriteLine($"Olá, {nome}! Você tem {idade} anos."); // imprime uma mensagem personalizada usando interpolação de string
            Console.ReadKey(); // aguarda uma ação do usuario
        }
    }//$ interpolação de string permite inserir variáveis diretamente dentro de uma string, facilitando a formatação e leitura do código

}
