using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_SENAI_20._05.models
{
    public class ContaBancaria
    {
        public int Numero { get; set; }
        public string Titular { get; set; }

        protected double Saldo;

        public double ConsultarSaldo()
        {
            return Saldo;
        }

        public virtual void Depositar(double valor)
        {
            Saldo += valor;
        }

        public virtual void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine("Saque realizado.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public virtual void MostrarDados()
        {
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Saldo: R${saldo}");
        }
    }
}