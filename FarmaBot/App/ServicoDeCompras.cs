using System;
using FarmaBot.Model.Compras;

namespace FarmaBot.App
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
