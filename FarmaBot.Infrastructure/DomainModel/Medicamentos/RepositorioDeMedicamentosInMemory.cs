using System.Collections.Generic;

namespace FarmaBot.DomainModel.Medicamentos
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
