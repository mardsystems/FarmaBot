using FarmaBot.Model.Medicamentos;
using FarmaBot.Model.Sintomas;
using System.Collections.Generic;

namespace FarmaBot.App
{
    public interface IRealizacaoDeDiagnosticos
    {
        List<Medicamento> RealizaDiagnostico(Sintoma sintoma);
    }
}
