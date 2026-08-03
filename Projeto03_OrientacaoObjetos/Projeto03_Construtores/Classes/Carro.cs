using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_Classes.Classes
{
    internal class Carro
    {
        // niveis de acesso
        // private(privado)
        //definição de um carro. 
        // mudando atributos para public , para que 
        // possam ser acessados fora da classe, no caso
        // na classe program.cs 
        public string modelo;
        public string cor;
        public int ano;

        // prop tab + tab 
        // atalho p/ criar propriedades,
        // propriedades são como se fossem metodos, porem tem a função de acessar os atributos privados.
        // get- local vago para o programa , onde o codigo é pego; 
        // set - local vago para o programa, onde o codigo é setado;

        public int Combustivel { get; set; }

        //metodo construtor  - recebe sempre o nome da classe
        // e tem a funcao de inicializar os atributos da classe 
        // ou seja atribuir um valor a eles, quando um objeto for criado. 

        public Carro()
            {
            //valores padroes para propriedades 
            modelo = "Modelo Padrão";
            cor = "cor não informada";
            ano = 0;
           }
        // modelo de metodo construtor com parametros
        // sendo possivel atribuir valores a propriedades no momento da criação do objeto.
        public Carro(string modelo, string cor, int ano)
        {
            this.modelo = modelo;
            this.cor = cor;
            this.ano = ano;
        }
        // metodo é uma funcao definida por uma classe
        // representa um comportamento de um objeto.

        // esse metodo em questao retorna um valor do tipo stringo, logo a necessidade do return 
        public string acelerar()
        {
            return $"O {modelo} está acelerando";
        }

        public string abastecer(int litros)
        {
            Combustivel += litros;
            return $"O {litros} litros adicionados. Combustivel atua: {Combustivel}";
        }
    }
}
