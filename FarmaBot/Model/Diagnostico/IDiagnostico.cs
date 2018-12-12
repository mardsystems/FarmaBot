using FarmaBot.Model.Medicamentos;
using FarmaBot.Model.Sintomas;
using System.Collections.Generic;

namespace FarmaBot.Model.Diagnostico
{
    public interface IDiagnostico
    {
        List<Medicamento> Diagnosticar(Sintoma sintoma);
    }
}
