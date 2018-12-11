using System;
using FarmaBot.DomainModel.Compras;

namespace FarmaBot.ApplicationModel.RealizacaoDePedidos
{
    public class ServicoDeCompras : IRealizacaoDePedidos
    {
        private readonly IRepositorioDePedidos repositorioDePedidos;

        public ServicoDeCompras(IRepositorioDePedidos repositorioDePedidos)
        {
            this.repositorioDePedidos = repositorioDePedidos;
        }

        public int RealizaPedido(Pedido pedido)
        {
            return repositorioDePedidos.RealizarPedido(pedido);
        }
    }
}
