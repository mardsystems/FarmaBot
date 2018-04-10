using FarmaBot.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telegram.Bot.Types;

namespace FarmaBot.Models
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

        public bool Vazio { get { return Medicamentos.Count == 0; } }

        public static CarrinhoCompras Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CarrinhoCompras();
                }

                return _instance;
            }
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

        public void AlterarLocalizacao(Location location)
        {
            Localizacao = location;
        }        

        private static CarrinhoCompras _instance;
        public List<Medicamento> Medicamentos { get; }
        public Location Localizacao { get; private set; }
    }
}
