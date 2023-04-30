using desafiolorena.Comprador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafiolorena.Pedidos
{
    internal class Pedido
    {
        public int numeroPedido;
        public Cliente comprador;
        public string item;
        public int qtdItens;
        public double valorTotalPedido;
    }
}
