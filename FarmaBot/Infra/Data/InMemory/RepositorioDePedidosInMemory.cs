using FarmaBot.Model.Compras;
using System;

namespace FarmaBot.Infra.Data.InMemory
{
    public class RepositorioDePedidosInMemory : IRepositorioDePedidos
    {
        public int RealizarPedido(Pedido pedido)
        {
            return new Random().Next();
        }
    }
}
