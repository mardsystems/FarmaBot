using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmaBot.DomainModel.Cadastro.Medicamentos
{
    public class RepositorioDeMedicamentosLitDb : IRepositorioDeMedicamentos
    {
        public List<Medicamento> ObtemMedicamentosParaDiagnostico()
        {
            return ObtemMedicamentos();
        }

        public List<Medicamento> ObtemMedicamentosParaCompras()
        {
            return ObtemMedicamentos();
        }

        private static List<Medicamento> ObtemMedicamentos()
        {
            var medicamentos = new List<Medicamento>();

            medicamentos.Add(new Medicamento
            (
                "Advil"
            ));
            medicamentos.Add(new Medicamento
            (
                "Dorflex"
            ));
            medicamentos.Add(new Medicamento
            (
                "Aspirina"
            ));
            medicamentos.Add(new Medicamento
            (
                "Neosaldina"
            ));

            return medicamentos;
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
