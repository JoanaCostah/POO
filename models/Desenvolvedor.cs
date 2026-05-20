using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_SENAI_20._05.models
{
    public class Desenvolvedor : Funcionario
    {
            public override void ApresentarSalario(){
            Console.WriteLine($" Posição: Desenvolvedor  ======   Nome: {Nome} ======= Salario: {Salario + (Salario * (10/100))} ");
        }
    }
}