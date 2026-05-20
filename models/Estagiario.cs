using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_SENAI_20._05.models
{
    public class Estagiario : Funcionario
    {
            public override void ApresentarSalario(){
                Console.WriteLine($" Posição: Estagiario  =======  Nome: {Nome} ======= Salario: {Salario + (Salario * (5/100))} ");
        }
    }
}