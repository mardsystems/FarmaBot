using System;
using System.Collections.Generic;
using System.Linq;
using FarmaBot.DomainModel.Cadastro.Sintomas;

namespace FarmaBot.DomainModel.Cadastro.Sugestoes
{
    public class RepositorioDeSugestoesInMemory : IRepositorioDeSugestoes
    {
        public IEnumerable<SugestaoDeMedicamento> ObtemSugestoesDeMedicamentosPorSintomas(Sintoma[] sintomas)
        {
            throw new NotImplementedException();
        }

        public IQueryable<SugestaoDeMedicamento> AsQueryable()
        {
            throw new NotImplementedException();
        }

        public void Add(SugestaoDeMedicamento entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(SugestaoDeMedicamento[] entities)
        {
            throw new NotImplementedException();
        }

        public void Update(SugestaoDeMedicamento entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(SugestaoDeMedicamento entity)
        {
            throw new NotImplementedException();
        }
    }
}
