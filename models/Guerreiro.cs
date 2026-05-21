using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_SENAI_20._05.models
{
    public class Guerreiro : Personagem
    {
        public string Espada { get; set; }

        public override void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Vida: {Vida}");
            Console.WriteLine($"Ataque: {Ataque}");
            Console.WriteLine($"Arma: Espada {Espada}");

        }
    }
}   