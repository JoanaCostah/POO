using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_SENAI_20._05.models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        
        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, minha idade é {Idade} e minha nota foi {Nota}");
        }

    }
}