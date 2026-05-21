using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_SENAI_20._05.models
{
    public class PedidoInternacional : Pedido
    {
        public override double CalcularEntrega()
        {
            return 50;
        }
    }
}