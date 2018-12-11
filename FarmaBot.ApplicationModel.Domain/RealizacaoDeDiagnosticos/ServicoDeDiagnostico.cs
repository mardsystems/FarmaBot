using FarmaBot.DomainModel.Diagnostico;
using FarmaBot.DomainModel.Medicamentos;
using FarmaBot.DomainModel.Sintomas;
using System.Collections.Generic;

namespace FarmaBot.ApplicationModel.RealizacaoDeDiagnosticos
{
    public class ServicoDeDiagnostico : IRealizacaoDeDiagnosticos
    {
        private readonly IDiagnostico sintomasService;

        public ServicoDeDiagnostico(IDiagnostico sintomasService)
        {
            this.sintomasService = sintomasService;
        }

        public List<Medicamento> RealizaDiagnostico(Sintoma sintoma)
        {
            var medicamentos = sintomasService.Diagnosticar(sintoma);

            return medicamentos;
        }
    }
}
