using FarmaBot.Models;
using System.Collections.Generic;

namespace FarmaBot.Repository
{
    public interface IBotRepository
    {
        List<Medicamento> BuscarMedicamentos(Sintoma sintoma);
        int RealizarPedido(Pedido pedido);
    }
}
