using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_SENAI_20._05.models
{
    public class Gerente : Funcionario
    {
        
        public override void ApresentarSalario(){
            Console.WriteLine($" Posição: Gerente ======== Nome: {Nome} ======= Salario: {Salario + (Salario * (20/100))} ");
        }

    }
}