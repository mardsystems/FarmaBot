﻿using FarmaBot.DomainModel.Diagnostico;
using System.Collections.Generic;
using System.Linq;

namespace FarmaBot.ApplicationModel.RealizacaoDeDiagnosticos
{
    public class ServicoDeDiagnostico : IRealizacaoDeDiagnosticos
    {
        private readonly IDiagnosticoDeSintomas servicoDeDiagnostico;

        private readonly AdaptadorDeCadastroDeSintomas adaptadorDeCadastroDeSintomas;

        public ServicoDeDiagnostico(IDiagnosticoDeSintomas servicoDeDiagnostico, AdaptadorDeCadastroDeSintomas adaptadorDeCadastroDeSintomas)
        {
            this.servicoDeDiagnostico = servicoDeDiagnostico;

            this.adaptadorDeCadastroDeSintomas = adaptadorDeCadastroDeSintomas;
        }

        public Medicamento[] RealizaDiagnostico(string descricaoDeSintomas)
        {
            var sintomas = adaptadorDeCadastroDeSintomas.ObtemSintomasAPartirDeUmaDescricao(descricaoDeSintomas);

            var medicamentos = servicoDeDiagnostico.Diagnostica(sintomas);

            return medicamentos;
        }
    }
}
