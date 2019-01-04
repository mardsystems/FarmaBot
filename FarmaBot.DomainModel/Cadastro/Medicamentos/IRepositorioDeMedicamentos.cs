using System.Collections.Generic;
using System.DomainModel;

namespace FarmaBot.DomainModel.Cadastro.Medicamentos
{
    public interface IRepositorioDeMedicamentos : IRepository<Medicamento>
    {
        List<Medicamento> ObtemMedicamentosParaDiagnostico();

        List<Medicamento> ObtemMedicamentosParaCompras();
    }
}
