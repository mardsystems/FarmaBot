using FarmaBot.DomainModel.Medicamentos;
using FarmaBot.DomainModel.Sintomas;
using System.Collections.Generic;

namespace FarmaBot.DomainModel.Diagnostico
{
    public interface IDiagnostico
    {
        List<Medicamento> Diagnosticar(Sintoma sintoma);
    }
}
