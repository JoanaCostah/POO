using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_SENAI_20._05.models
{
    class Mago : Personagem
    {
        public int Mana { get; set; }

        public override void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Vida: {Vida}");
            Console.WriteLine($"Ataque: {Ataque}");
            Console.WriteLine($"Arma: Mana {Mana}");

        }
    }
}