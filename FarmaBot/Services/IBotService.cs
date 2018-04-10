using FarmaBot.Models;
using System.Collections.Generic;

namespace FarmaBot.Services
{
    public interface IBotService
    {
        List<Medicamento> Diagnosticar(Sintoma sintoma);
        int RealizarPedido(Pedido pedido);
    }
}
