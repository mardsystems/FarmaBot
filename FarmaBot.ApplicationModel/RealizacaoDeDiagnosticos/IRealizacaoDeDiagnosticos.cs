using FarmaBot.DomainModel.Diagnostico;
using System.Collections.Generic;

namespace FarmaBot.ApplicationModel.RealizacaoDeDiagnosticos
{
    public interface IRealizacaoDeDiagnosticos
    {
        Medicamento[] RealizaDiagnostico(string descricaoDeSintomas);
    }
}
