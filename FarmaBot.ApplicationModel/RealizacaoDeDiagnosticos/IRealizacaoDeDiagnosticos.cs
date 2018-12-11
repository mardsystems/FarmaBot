using FarmaBot.DomainModel.Medicamentos;
using FarmaBot.DomainModel.Sintomas;
using System.Collections.Generic;

namespace FarmaBot.ApplicationModel.RealizacaoDeDiagnosticos
{
    public interface IRealizacaoDeDiagnosticos
    {
        List<Medicamento> RealizaDiagnostico(Sintoma sintoma);
    }
}
