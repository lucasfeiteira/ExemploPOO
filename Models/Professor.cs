using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoal 
    {
        public Professor()
        {
            
        }
        public Professor(string nome) : base(nome)
        {

        }
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
             Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor e ganho {Salario}");
        }
    }
}