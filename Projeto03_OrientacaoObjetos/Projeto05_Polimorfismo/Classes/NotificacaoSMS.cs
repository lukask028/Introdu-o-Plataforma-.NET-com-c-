using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto05_Polimorfismo.Classes
{
    internal class NotificacaoSMS:Notificacao
    {
        public override string Enviar(string mensagem)
        {
            return $"Notificação por SMS: {mensagem}";
        }
    }
}
