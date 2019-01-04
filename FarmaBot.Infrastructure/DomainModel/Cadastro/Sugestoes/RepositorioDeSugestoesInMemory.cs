using System;
using System.Collections.Generic;
using System.Linq;
using FarmaBot.DomainModel.Cadastro.Sintomas;

namespace FarmaBot.DomainModel.Cadastro.Sugestoes
{
    public class RepositorioDeSugestoesInMemory : IRepositorioDeSugestoes
    {
        public IEnumerable<SugestaoDeMedicamentoPorSintoma> ObtemSugestoesDeMedicamentosPorSintomas(Sintoma[] sintomas)
        {
            throw new NotImplementedException();
        }

        public IQueryable<SugestaoDeMedicamentoPorSintoma> AsQueryable()
        {
            throw new NotImplementedException();
        }

        public void Add(SugestaoDeMedicamentoPorSintoma entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(SugestaoDeMedicamentoPorSintoma[] entities)
        {
            throw new NotImplementedException();
        }

        public void Update(SugestaoDeMedicamentoPorSintoma entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(SugestaoDeMedicamentoPorSintoma entity)
        {
            throw new NotImplementedException();
        }
    }
}
