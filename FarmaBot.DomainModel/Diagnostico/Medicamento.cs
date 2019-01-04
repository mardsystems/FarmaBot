using FarmaBot.DomainModel.Cadastro.Medicamentos;
using System;
using System.Collections.Generic;
using System.DomainModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaBot.DomainModel.Diagnostico
{
    public class Medicamento : ValueObject
    {
        public CodigoDeMedicamento Codigo { get; private set; }

        public string Nome { get; private set; }

        public List<string> Tags { get; private set; } = new List<string>();

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Codigo;
        }
    }
}
