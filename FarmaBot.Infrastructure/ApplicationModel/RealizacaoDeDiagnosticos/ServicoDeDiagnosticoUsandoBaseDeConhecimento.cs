using System;
using System.Collections.Generic;
using FarmaBot.DomainModel.Medicamentos;
using FarmaBot.DomainModel.Sintomas;

namespace FarmaBot.ApplicationModel.RealizacaoDeDiagnosticos
{
    public class ServicoDeDiagnosticoUsandoBaseDeConhecimento : IRealizacaoDeDiagnosticos
    {
        public List<Medicamento> RealizaDiagnostico(Sintoma sintoma)
        {
            throw new NotImplementedException();
        }
    }
}
