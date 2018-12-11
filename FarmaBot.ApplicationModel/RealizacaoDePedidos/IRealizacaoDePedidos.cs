using FarmaBot.DomainModel.Compras;

namespace FarmaBot.ApplicationModel.RealizacaoDePedidos
{
    public interface IRealizacaoDePedidos
    {
        int RealizaPedido(Pedido pedido);
    }
}
