using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_SENAI_20._05.models
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, sou diretor e tenho {Idade} anos, meu salário atual é de R${Salario}");
        }
    }
}