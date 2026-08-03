using Projeto06_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06_Interface.Classes
{
    internal class EmailNotificacao : INotificacao

    {
        public string Agendar(string mensagem, DateTime dataEnvio)
        {
            return $"Notificação agendada para {dataEnvio}: {mensagem}";
        }

        public string Enviar(string mensagem)
        {
            return $"Email enviado: {mensagem}";
        }
    }
}
