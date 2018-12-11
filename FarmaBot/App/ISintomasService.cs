using FarmaBot.Model;
using System.Collections.Generic;

namespace FarmaBot.App
{
    public interface ISintomasService
    {
        List<Medicamento> Diagnosticar(Sintoma sintoma);

        int RealizarPedido(Pedido pedido);
    }
}
