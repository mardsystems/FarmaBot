using System.Collections.Generic;

namespace FarmaBot.DomainModel.Diagnostico
{
    public interface IServicoDeDiagnostico
    {
        Medicamento[] Diagnostica(Sintoma[] sintomas);
    }
}
