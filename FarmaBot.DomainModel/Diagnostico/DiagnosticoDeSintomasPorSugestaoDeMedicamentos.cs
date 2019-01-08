using FarmaBot.DomainModel.Cadastro.Sugestoes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmaBot.DomainModel.Diagnostico
{
    public class DiagnosticoDeSintomasPorSugestaoDeMedicamentos : IDiagnosticoDeSintomas
    {
        private readonly IRepositorioDeSugestoes repositorioDeSugestoes;

        public DiagnosticoDeSintomasPorSugestaoDeMedicamentos(IRepositorioDeSugestoes repositorioDeSugestoes)
        {
            this.repositorioDeSugestoes = repositorioDeSugestoes;
        }

        public Medicamento[] Diagnostica(Sintoma[] sintomas)
        {
            // Busca os medicamentos que cobrem os sintomas um a um e os adiciona em uma lista.

            Dictionary<Cadastro.Medicamentos.CodigoDeMedicamento, int> quantidadePorMedicamentoSugerido = new Dictionary<Cadastro.Medicamentos.CodigoDeMedicamento, int>();

            //var medicamentos = repositorioDeSugestoes.ObtemSugestoesDeMedicamentosPorSintomas(sintomas);

            //foreach (var s in sintomas)
            //{
            //    foreach (var medicamento in medicamentos)
            //    {
            //        if (medicamento.CobreSintoma(s))
            //        {
            //            if (quantidadePorMedicamentoSugerido.TryGetValue(medicamento.Id, out int total))
            //            {
            //                quantidadePorMedicamentoSugerido[medicamento.Id] = total + 1;
            //            }
            //            else
            //            {
            //                quantidadePorMedicamentoSugerido.Add(medicamento.Id, 1);
            //            }
            //        }
            //    }
            //}

            //// Seleciona os 4 primeiros medicamentos que mais aparecem na lista.

            //const int QUANTIDADE_DE_MEDICAMENTOS_SUGERIDOS = 4;

            //var idsDeMedicamentosMaisSugeridos = quantidadePorMedicamentoSugerido.OrderByDescending(p => p.Value).Take(QUANTIDADE_DE_MEDICAMENTOS_SUGERIDOS);

            //var medicamentosSugeridos = new List<Medicamento>();

            //foreach (var idDeMedicamento in idsDeMedicamentosMaisSugeridos)
            //{
            //    medicamentosSugeridos.Add(medicamentos.Single(p => p.CodigoDoMedicamentoSugerido == idDeMedicamento.Key));
            //}

            //return medicamentosSugeridos;

            throw new NotImplementedException();
        }
    }
}
