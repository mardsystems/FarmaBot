using FarmaBot.Model;
using System.Collections.Generic;

namespace FarmaBot.Model
{
    public interface ISintomasRepository
    {
        List<Medicamento> BuscarMedicamentos(Sintoma sintoma);
        int RealizarPedido(Pedido pedido);
    }
}
