using System;

namespace FarmaBot.DomainModel.Compras
{
    public class RepositorioDePedidosInMemory : IRepositorioDePedidos
    {
        public int RealizarPedido(Pedido pedido)
        {
            return new Random().Next();
        }
    }
}
