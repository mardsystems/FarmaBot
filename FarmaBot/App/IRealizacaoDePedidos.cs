using FarmaBot.Model.Compras;

namespace FarmaBot.App
{
    public interface IRealizacaoDePedidos
    {
        int RealizaPedido(Pedido pedido);
    }
}
