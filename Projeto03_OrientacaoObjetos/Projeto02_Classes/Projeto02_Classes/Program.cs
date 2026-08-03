using Projeto02_Classes.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            carro1.modelo = "fusca"; 
            carro1.ano = 1980;
            carro1.cor = "azul";

            Console.WriteLine($"modelo: {carro1.modelo}\n" +
                $"ano: {carro1.ano}\n" +
                $"cor: {carro1.cor}");

            //metodo acelerar ,guardado numa string mensagemAcelerar, para depois ser exibida no console. 
            string mensagemAcelerar = carro1.acelerar();
            Console.WriteLine(mensagemAcelerar);

            string mensagemAbastecer1 = carro1.abastecer(20);
            string mensagemAbastecer2 = carro1.abastecer(20);

            Console.WriteLine(mensagemAbastecer1);
            Console.WriteLine(mensagemAbastecer2);

            Console.ReadKey();
        }
    }// get - local vago para o programa,
    // onde o codigo é pego.
}
