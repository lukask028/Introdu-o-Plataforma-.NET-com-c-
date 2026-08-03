using Projeto07_Genericos.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto07_Genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // caixa de inteiros
            Caixa<int> caixaInt = new Caixa<int>();

            // chama o metodo de atualizar valor da caixa de int
            // e mostra o valor atualizado
            string valorAttInt = caixaInt.ValorAtualizado(10);
            Console.WriteLine(caixaInt.MostrarValor());
            Console.ReadKey();

            Console.WriteLine("-----------------");
            //caixa de string 
            Caixa<string> caixaString = new Caixa<string>();
            // chama o metodo de atualizar valor da caixa de string
            // e mostra o valor atualizado
            string valorAttString = caixaString.ValorAtualizado("Olá, mundo!");
            Console.WriteLine(caixaString.MostrarValor());
            Console.ReadKey();
        }
    }
}
