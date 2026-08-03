using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // variaveis inteiras 
            sbyte medida = 127; // sybte suporta apenas de -128 ate o 127;
            byte tamanho = 255; // 0 a 255;
            short quantidade = 100; // -37268 a 32768
            int idade = 34; // -2.147.483.648 a 2.147.483.647

            // variaveis de texto 


            string nome = "Lucas"; // string armazena uma sequencia de caracteres

            char inicial_nome = 'L'; // char armazena apenas um caractere

            // tipo booleano 
            // é usado para armazenar valores booleanos 
            // true ou false; 

            bool esta_chovendo = true; // variavel booleana que indica se esta chovendo ou nao

            // tipos flutuantes, 
            // usados para armazenar numeros com casas decimais
            float altura = 1.75f; // o 'f' é usado para indicar que é um numero do tipo float, é menos preciso 

            double peso = 70.5; // o tipo double é usado para armazenar numeros com maior precisao do que o float

        }
    }
}
