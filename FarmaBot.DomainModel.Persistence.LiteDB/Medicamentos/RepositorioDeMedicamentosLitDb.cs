using System.Collections.Generic;

namespace FarmaBot.DomainModel.Medicamentos
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
            {
                Nome = "Advil"
            });
            medicamentos.Add(new Medicamento
            {
                Nome = "Dorflex"
            });
            medicamentos.Add(new Medicamento
            {
                Nome = "Aspirina"
            });
            medicamentos.Add(new Medicamento
            {
                Nome = "Neosaldina"
            });

            return medicamentos;
        }
    }
}
