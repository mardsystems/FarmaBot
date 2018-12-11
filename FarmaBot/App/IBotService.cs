using FarmaBot.Model;
using System.Collections.Generic;

namespace FarmaBot.App
{
    public interface IBotService
    {
        List<Medicamento> Diagnosticar(Sintoma sintoma);
        int RealizarPedido(Pedido pedido);
    }
}
