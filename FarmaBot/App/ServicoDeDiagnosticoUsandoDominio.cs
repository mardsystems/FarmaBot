using FarmaBot.Model.Diagnostico;
using FarmaBot.Model.Medicamentos;
using FarmaBot.Model.Sintomas;
using System.Collections.Generic;

namespace FarmaBot.App
{
    public class ServicoDeDiagnosticoUsandoDominio : IRealizacaoDeDiagnosticos
    {
        private readonly IDiagnostico sintomasService;

        public ServicoDeDiagnosticoUsandoDominio(IDiagnostico sintomasService)
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
