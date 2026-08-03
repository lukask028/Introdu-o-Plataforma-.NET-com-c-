using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto05_Polimorfismo.Classes
{
    internal class NotificacaoEmail: Notificacao
    { //overrride indica que o metodo esta sobrescrevendo o metodo da classe pai
        public override string Enviar(string mensagem)
        {
            return $"Notificação por Email: {mensagem}";
        }

    }
}
