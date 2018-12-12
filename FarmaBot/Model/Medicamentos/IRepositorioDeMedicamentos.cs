using System.Collections.Generic;

namespace FarmaBot.Model.Medicamentos
{
    public interface IRepositorioDeMedicamentos
    {
        List<Medicamento> ObtemMedicamentosParaDiagnostico();

        List<Medicamento> ObtemMedicamentosParaCompras();
    }
}
