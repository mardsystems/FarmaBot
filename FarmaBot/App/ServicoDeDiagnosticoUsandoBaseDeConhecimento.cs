using System;
using System.Collections.Generic;
using FarmaBot.Model.Medicamentos;
using FarmaBot.Model.Sintomas;

namespace FarmaBot.App
{
    public class ServicoDeDiagnosticoUsandoBaseDeConhecimento : IRealizacaoDeDiagnosticos
    {
        public List<Medicamento> RealizaDiagnostico(Sintoma sintoma)
        {
            throw new NotImplementedException();
        }
    }
}
