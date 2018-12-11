namespace FarmaBot.DomainModel.Compras
{
    public interface IRepositorioDePedidos
    {
        int RealizarPedido(Pedido pedido);
    }
}
