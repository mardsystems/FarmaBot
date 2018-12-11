using System.Collections.Generic;
using FarmaBot.Model.Medicamentos;

namespace FarmaBot.Infra.Data.InMemory
{
    public class RepositorioDeMedicamentosInMemory : IRepositorioDeMedicamentos
    {
        public List<Medicamento> ObtemMedicamentosParaDiagnostico()
        {
            return InMemoryDatabase.Medicamentos;
        }

        public List<Medicamento> ObtemMedicamentosParaCompras()
        {
            return InMemoryDatabase.Medicamentos;
        }
    }
}
