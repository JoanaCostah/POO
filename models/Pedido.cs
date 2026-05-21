using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_SENAI_20._05.models
{
    public class Pedido
    {
        public double ValorTotal { get; set; }

        public virtual double CalcularEntrega()
        {
            return 0;
        }
    }
}