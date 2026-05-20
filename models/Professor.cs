using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_SENAI_20._05.models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public virtual void Apresentar(){
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade} anos, meu salário atual é de R${Salario}");
        }
    }
}