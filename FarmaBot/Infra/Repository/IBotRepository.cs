using FarmaBot.Model;
using System.Collections.Generic;

namespace FarmaBot.Infra.Repository
{
    public interface IBotRepository
    {
        List<Medicamento> BuscarMedicamentos(Sintoma sintoma);
        int RealizarPedido(Pedido pedido);
    }
}
