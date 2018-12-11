using System;
using System.Collections.Generic;
using System.Linq;
using FarmaBot.Infra.Data;
using FarmaBot.Model;

namespace FarmaBot.Infra.Data.Memory
{
    public class SintomasRepository : ISintomasRepository
    {
        public List<Medicamento> BuscarMedicamentos(Sintoma sintoma)
        {
            List<Medicamento> medicamentos = new List<Medicamento>();
            Dictionary<int, int> results = new Dictionary<int, int>();

            /***
             * Busca os medicamentos que cobrem os sintomas um a um e os adiciona em uma lista.
             ***/

            var sintomas = sintoma.AsList();
            foreach (var s in sintomas)
            {
                foreach (var med in MemoryDatabase.Medicamentos)
                {
                    if (med.CobreSintoma(s))
                    {
                        if (results.TryGetValue(med.Id, out int total))
                        {
                            results[med.Id] = total + 1;
                        }
                        else
                        {
                            results.Add(med.Id, 1);
                        }
                    }
                }
            }

            /***
             * Seleciona os 4 primeiros medicamentos que mais aparecem na lista.
             ***/

            var _result = results.OrderByDescending(k => k.Value).Take(4);
            foreach (var item in _result)
            {
                medicamentos.Add(MemoryDatabase.Medicamentos.Single(m => m.Id.Equals(item.Key)));
            }

            return medicamentos;
        }

        public int RealizarPedido(Pedido pedido)
        {
            return new Random().Next();
        }
    }
}
