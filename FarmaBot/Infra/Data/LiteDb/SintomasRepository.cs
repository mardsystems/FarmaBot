using FarmaBot.Model;
using System;
using System.Collections.Generic;

namespace FarmaBot.Infra.Data.LiteDb
{
    public class SintomasRepository : ISintomasRepository
    {
        public List<Medicamento> BuscarMedicamentos(Sintoma sintoma)
        {
            List<Medicamento> result = new List<Medicamento>();

            result.Add(new Medicamento
            {
                Nome = "Advil"
            });
            result.Add(new Medicamento
            {
                Nome = "Dorflex"
            });
            result.Add(new Medicamento
            {
                Nome = "Aspirina"
            });
            result.Add(new Medicamento
            {
                Nome = "Neosaldina"
            });

            return result;
        }

        public int RealizarPedido(Pedido pedido)
        {
            return 0;
        }
    }
}
