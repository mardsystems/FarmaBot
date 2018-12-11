using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmaBot.Model
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Cliente { get; set; }
        public Endereco Endereco { get; set; }
        public List<Medicamento> Medicamentos { get; set; } = new List<Medicamento>();

        public decimal ValorTotal
        {
            get
            {
                return Medicamentos.Sum(m => m.Preco);
            }
        }
    }
}
