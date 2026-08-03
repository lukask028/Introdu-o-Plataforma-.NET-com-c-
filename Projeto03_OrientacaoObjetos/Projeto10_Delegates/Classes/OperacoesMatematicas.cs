using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto10_Delegates.Classes
{
    // static - não é necessário criar uma instância da classe para acessar seus membros, 
    // os membros são compartilhados entre todas as instâncias da classe
    internal static class OperacoesMatematicas
    {
        
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public static int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}
