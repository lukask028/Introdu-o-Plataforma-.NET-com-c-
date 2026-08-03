using Projeto04_Heranca.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04_Heranca.Classe
{
    internal class Aluno:Pessoa
    {
        //classe Aluno herda da classe Pessoa, ou seja, Aluno é uma Pessoa
        // herdando propriedades e metodos da classe Pessoa
        // e aluno podera ter suas proprias propriedades e metodos
        
        public int Matricula { get; set; }
        
        public string Estudar()
        {
            return $"O aluno {Nome} está estudando.";
        }

        public Aluno(string nome, int idade, int matricula)
        {
            Nome = nome;
            Idade = idade;
            Matricula = matricula;
        }

    }
}
