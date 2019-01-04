using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmaBot.DomainModel.Cadastro.Medicamentos
{
    public class RepositorioDeMedicamentosInMemory : IRepositorioDeMedicamentos
    {
        public List<Medicamento> ObtemMedicamentosParaDiagnostico()
        {
            throw new NotImplementedException();

            //return InMemoryDatabase.Medicamentos;
        }

        public List<Medicamento> ObtemMedicamentosParaCompras()
        {
            throw new NotImplementedException();

            //return InMemoryDatabase.Medicamentos;
        }

        public IQueryable<Medicamento> AsQueryable()
        {
            throw new NotImplementedException();
        }

        public void Add(Medicamento entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(Medicamento[] entities)
        {
            throw new NotImplementedException();
        }

        public void Update(Medicamento entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Medicamento entity)
        {
            throw new NotImplementedException();
        }
    }
}
