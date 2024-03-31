using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Pessoa
    {
        public string Nome { get; set; } 
        public int Idade { get; set; } 
        public string Email { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, Meu nome é {Nome}. Eu tenho {Idade} anos");
        }
    }
}