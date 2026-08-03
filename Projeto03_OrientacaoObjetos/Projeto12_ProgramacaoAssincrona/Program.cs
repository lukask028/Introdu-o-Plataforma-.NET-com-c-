using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto12_ProgramacaoAssincrona
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // task - representa uma operação assíncrona 
            // que pode ser aguardada e cancelada, e que pode retornar um valor

            // async - modificador usado para indicar que um método é assíncrono

            // await - operador usado para aguardar 
            // a conclusão de uma operação assíncrona, sem bloquear a thread atual

            // Task.whenAll - método estático que aguarda a conclusão 
            // de todas as tarefas em uma coleção de tarefas 
            // e retorna uma tarefa que é concluída quando todas as outras da coleção forem concluídas 

            Task task1 = EscreverMensagemAsync("Olá, mundo!", 1000);
            Task task2 = EscreverMensagemAsync("Programação assíncrona em C#", 500);

            await Task.WhenAll(task1, task2); // aguarda a conclusão de todas as tarefas

            Console.WriteLine("Todas as mensagens foram escritas.");
            Console.ReadKey();
        }
            static async Task EscreverMensagemAsync(string mensagem, int delay)
            {
                for (int i = 0; i < 10; i++)
                {
                // simula um tempo de processamento 
                await Task.Delay(delay); // só vale para milissegundos, não segundos
                Console.WriteLine(mensagem);
                }
            }
        
    }
}
