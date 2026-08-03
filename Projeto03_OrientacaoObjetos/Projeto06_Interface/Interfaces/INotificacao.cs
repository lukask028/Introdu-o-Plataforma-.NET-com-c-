using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06_Interface.Interfaces
{   // Contrato todos que herdarem
    // tem obrigação de implementar
    // propriedades e métodos 
    internal interface INotificacao
    {
        // interface é apenas uma orientacao
        // deve criar um metodo chamado enviar, 
        // recebe um parametro do tipo string e retorna o mesmo tipo. 
        string Enviar(string mensagem);

        string Agendar(string mensagem, DateTime dataEnvio);
    }
}
