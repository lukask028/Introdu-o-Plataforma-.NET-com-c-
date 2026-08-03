using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01_Funcoes
{
    internal class Program
    {
        // o main é um exemplo de funcao (metodo)
        // funcao pode ou nao retornar um valor, e pode ou nao receber parametros
        // começam sempre com letr maiuscula
        static void Main(string[] args)
        {
            // chama a funcao criada
            ExibirMensagem();
            ExibirMensagemPersonalizada("Lucas");

        }
        // static pertence a classe
        // void a funcao nao retorna valor 
        static void ExibirMensagem()
        {

            Console.WriteLine("Olá, seja bem-vindo!");
            Console.ReadKey();
        }
        // funcao que recebe um parametro do tipo string e nao retorna valor
        static void ExibirMensagemPersonalizada(string nome)
        {
            Console.WriteLine($"Ola, {nome} bem vindo a tecnologia!");
            Console.ReadKey();
        }
    }
}
