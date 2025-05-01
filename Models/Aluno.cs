using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoal
    {
        public Aluno()
        {
             
        }
        public Aluno(string nome) : base(nome)
        {

        }
        public double Nota { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}");
        }
    }
}