using Projeto06_Interface.Classes;
using Projeto06_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotificacao notificacaoEmail = new EmailNotificacao();
            DateTime agora = DateTime.Now;
            string retornoEmail = notificacaoEmail.Enviar("Olá, esta é uma notificação por email!");
            string retornoAgendarEmail = notificacaoEmail.Agendar("Esta é uma notificação agendada por email!" , DateTime.Now);

            Console.WriteLine(retornoEmail);
            Console.WriteLine(retornoAgendarEmail);
            Console.ReadKey();

        }
    }
}
