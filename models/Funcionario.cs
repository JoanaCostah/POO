using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_SENAI_20._05.models
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public decimal Salario { get; set; }

        public virtual void ApresentarSalario()
        {
            Console.WriteLine($"Nome: {Nome} ======= Salario: {Salario} ");
        }
    }
}