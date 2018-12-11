using System.Collections.Generic;
using FarmaBot.Model;
using FarmaBot.Infra.Repository;

namespace FarmaBot.App
{
    public class BotService : IBotService
    {
        public List<Medicamento> Diagnosticar(Sintoma sintoma)
        {
            return _botRepository.BuscarMedicamentos(sintoma);
        }

        public int RealizarPedido(Pedido pedido)
        {
            return _botRepository.RealizarPedido(pedido);
        }

        private readonly IBotRepository _botRepository = new MemoryRepository();
    }
}
