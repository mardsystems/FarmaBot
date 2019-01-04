using System;
using System.Collections.Generic;
using System.DomainModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaBot.DomainModel.Cadastro.Medicamentos
{
    public class CodigoDeMedicamento : ValueObject
    {
        public string Valor { get; private set; }

        public CodigoDeMedicamento(string valor)
        {
            Valor = valor;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Valor;
        }
    }
}
