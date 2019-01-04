using System;
using System.Collections.Generic;
using FarmaBot.DomainModel.Diagnostico;

namespace FarmaBot.ApplicationModel.RealizacaoDeDiagnosticos
{
    public class ServicoDeDiagnosticoUsandoBaseDeConhecimento : IRealizacaoDeDiagnosticos
    {
        public Medicamento[] RealizaDiagnostico(string descricaoDeSintomas)
        {
            throw new NotImplementedException();
        }
    }
}
