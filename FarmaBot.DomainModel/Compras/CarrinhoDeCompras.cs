using FarmaBot.DomainModel.Medicamentos;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarmaBot.DomainModel.Compras
{
    public class CarrinhoDeCompras
    {
        private readonly IRepositorioDeMedicamentos repositorioDeMedicamentos;

        public List<Medicamento> MedicamentosComprados;

        public bool Vazio { get { return MedicamentosComprados.Count == 0; } }

        public CarrinhoDeCompras(IRepositorioDeMedicamentos repositorioDeMedicamentos)
        {
            MedicamentosComprados = new List<Medicamento>();

            this.repositorioDeMedicamentos = repositorioDeMedicamentos;
        }

        public Medicamento AdicionarMedicamento(int id)
        {
            var medicamentos = repositorioDeMedicamentos.ObtemMedicamentosParaCompras();

            var med = medicamentos.Single(m => m.Id.Equals(id));

            if (med != null) MedicamentosComprados.Add(med);

            return med;
        }

        public decimal ValorTotal
        {
            get
            {
                return MedicamentosComprados.Sum(m => m.Preco);
            }
        }

        public string Resumo()
        {
            var sb = new StringBuilder();

            foreach (var m in MedicamentosComprados)
            {
                sb.AppendLine($" * - {m.Nome}");
            }

            sb.AppendLine("");

            sb.AppendLine($"Valor total: {string.Format("{0:C}", ValorTotal)}");

            return sb.ToString();
        }
    }
}
