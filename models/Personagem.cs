using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_SENAI_20._05.models
{
    public class Personagem
    {

        public string Nome { get; set; }
        public int Vida{ get; set; }
        public int Ataque { get; set; }

        public int VidaPersonagem
        {
            get { return Vida; }

            set
            {
                if (value < 0)
                {
                    Vida = 0;
                }
                else if (value > 100)
                {
                    Vida = 100;
                }
                else
                {
                    Vida = value;
                }
            }
        }

        public virtual void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Vida: {Vida}");
            Console.WriteLine($"Ataque: {Ataque}");
        }
    }
}