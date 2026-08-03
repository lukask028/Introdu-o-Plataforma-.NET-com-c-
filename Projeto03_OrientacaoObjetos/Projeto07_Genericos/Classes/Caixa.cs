using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto07_Genericos.Classes
{
    // A classe do tipo generico 
    // Pode armazenar valor de qualquer tipo
    // propriedade Valor do tipo generico A
    internal class Caixa<A>
    {
        public A Valor { get; set; }
        public String MostrarValor()
        {
            return $"O valor armazenado é: {Valor}";
        }

        public string ValorAtualizado(A novovalor)
        {
            Valor = novovalor;
            return $"O valor atualizado é: {Valor}";
        }
    }
}
