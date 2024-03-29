using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _12._5_GetSet.Models
{
    public class Pessoa
    {
        // get e set são utilizados para trazer a informação (get) e definir a informação (set)
        // get e set tornam nome e idade de certa forma privados automaticamente e nao publicos (particularidade do C#)
        public string? Nome { get; set; }
        public int Idade { get; set; }

        // criação do metodo apresentar que utiliza as propriedades Nome e Idade
        public void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}