using FarmaBot.Infra.Data.Memory;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarmaBot.Model
{
    public class CarrinhoCompras
    {
        public CarrinhoCompras()
        {
            Medicamentos = new List<Medicamento>();
        }

        public Medicamento AdicionarMedicamento(int id)
        {
            var med = MemoryDatabase.Medicamentos.Single(m => m.Id.Equals(id));

            if (med != null) Medicamentos.Add(med);

            return med;
        }

        public decimal ValorTotal
        {
            get
            {
                return Medicamentos.Sum(m => m.Preco);
            }
        }

        public string Resumo()
        {
            var sb = new StringBuilder();

            foreach (var m in Medicamentos)
            {
                sb.AppendLine($" * - {m.Nome}");
            }

            sb.AppendLine("");
            sb.AppendLine($"Valor total: {string.Format("{0:C}", ValorTotal)}");

            return sb.ToString();
        }

        public bool Vazio { get { return Medicamentos.Count == 0; } }

        public List<Medicamento> Medicamentos { get; }
    }
}
