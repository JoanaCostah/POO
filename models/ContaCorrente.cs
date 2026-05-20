using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_SENAI_20._05.models
{
    public class ContaCorrente : ContaBancaria
    {

        public double TaxaSaque { get; set; }

        public override void Sacar(double valor)
        {
            double valorTotal = valor + TaxaSaque;

            if (valorTotal <= Saldo)
            {
                Saldo -= valorTotal;
                Console.WriteLine("Saque realizado.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }
    }
}