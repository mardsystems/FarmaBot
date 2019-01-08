using System.Collections.Generic;

namespace FarmaBot.DomainModel.Diagnostico
{
    public interface IDiagnosticoDeSintomas
    {
        Medicamento[] Diagnostica(Sintoma[] sintomas);
    }
}
