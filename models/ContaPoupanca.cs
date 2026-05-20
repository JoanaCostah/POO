using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_SENAI_20._05.models
{
    public class ContaPoupanca : ContaBancaria
    {
        public double RendimentoMensal { get; set; }

        public void AplicarRendimento()
        {
            Saldo += Saldo * (RendimentoMensal / 100);
        }
    }
}