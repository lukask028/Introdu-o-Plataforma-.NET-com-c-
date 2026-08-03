using Projeto04_Heranca.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("João", 20, 12345);
            string retornoApresentar = aluno1.Apresentar();
            string retornoEstudar = aluno1.Estudar();
            // associa o retorno do apresentar e do estudar,
            // associando a duas string, retornoApresentar e retornoEstudar 
            Console.WriteLine(retornoApresentar + "\n" + retornoEstudar );

            Console.ReadKey();
        }
    }
}
