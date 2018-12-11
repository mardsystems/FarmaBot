using System.Collections.Generic;

namespace FarmaBot.DomainModel.Medicamentos
{
    public interface IRepositorioDeMedicamentos
    {
        List<Medicamento> ObtemMedicamentosParaDiagnostico();

        List<Medicamento> ObtemMedicamentosParaCompras();
    }
}
