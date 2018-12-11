using FarmaBot.DomainModel.Medicamentos;
using FarmaBot.DomainModel.Sintomas;
using System.Collections.Generic;
using System.Linq;

namespace FarmaBot.DomainModel.Diagnostico
{
    public class ServicoDeDiagnostico : IDiagnostico
    {
        private readonly IRepositorioDeMedicamentos repositorioDeMedicamentos;

        public ServicoDeDiagnostico(IRepositorioDeMedicamentos repositorioDeMedicamentos)
        {
            this.repositorioDeMedicamentos = repositorioDeMedicamentos;
        }

        public List<Medicamento> Diagnosticar(Sintoma sintoma)
        {
            // Busca os medicamentos que cobrem os sintomas um a um e os adiciona em uma lista.

            Dictionary<int, int> quantidadePorMedicamentoSugerido = new Dictionary<int, int>();

            var sintomas = sintoma.AsList();

            var medicamentos = repositorioDeMedicamentos.ObtemMedicamentosParaDiagnostico();

            foreach (var s in sintomas)
            {
                foreach (var medicamento in medicamentos)
                {
                    if (medicamento.CobreSintoma(s))
                    {
                        if (quantidadePorMedicamentoSugerido.TryGetValue(medicamento.Id, out int total))
                        {
                            quantidadePorMedicamentoSugerido[medicamento.Id] = total + 1;
                        }
                        else
                        {
                            quantidadePorMedicamentoSugerido.Add(medicamento.Id, 1);
                        }
                    }
                }
            }

            // Seleciona os 4 primeiros medicamentos que mais aparecem na lista.

            const int QUANTIDADE_DE_MEDICAMENTOS_SUGERIDOS = 4;

            var idsDeMedicamentosMaisSugeridos = quantidadePorMedicamentoSugerido.OrderByDescending(p => p.Value).Take(QUANTIDADE_DE_MEDICAMENTOS_SUGERIDOS);

            var medicamentosSugeridos = new List<Medicamento>();

            foreach (var idDeMedicamento in idsDeMedicamentosMaisSugeridos)
            {
                medicamentosSugeridos.Add(medicamentos.Single(p => p.Id == idDeMedicamento.Key));
            }

            return medicamentosSugeridos;
        }
    }
}
