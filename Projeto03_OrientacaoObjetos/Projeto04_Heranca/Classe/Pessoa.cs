using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04_Heranca.NewFolder1
{
    internal class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }


        public string Apresentar()
        {
            return $"Olá, meu nome é {Nome} e tenho {Idade} anos.";
        }
    }
    
}
