using Projeto05_Polimorfismo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto05_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notificacao notificacao = new Notificacao();
            string retornoNotificao = notificacao.Enviar("Olá, esta é uma notificação.");
            Console.WriteLine(retornoNotificao);

            Notificacao notificacaoEmail = new NotificacaoEmail();
            string retornoNotificaoEmail = notificacaoEmail.Enviar("Olá, esta é uma notificação por email.");
            Console.WriteLine(retornoNotificaoEmail);

            Notificacao notificacaoSMS = new NotificacaoSMS();
            string retornoNotificaoSMS = notificacaoSMS.Enviar("Olá, esta é uma notificação por SMS.");
            Console.WriteLine(retornoNotificaoSMS);

            Console.ReadKey();
        }
    }
}
