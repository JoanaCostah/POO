using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_SENAI_20._05.models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar(){
            Console.WriteLine($"Meu nome é {Nome}, sou professor e tenho {Idade} anos, meu salário atual é de R${Salario}");
        }
    }
}