using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto05_Polimorfismo.Classes
{
    internal class Notificacao
    {   // virtual indica que o metodo pode ser sobrescrito pelas classes filhas
        public virtual string Enviar(String mensagem)
        {
            return $"Notificação: {mensagem}";
        }
    }
}
