using FarmaBot.DomainModel.Cadastro.Sintomas;
using System;
using System.Collections.Generic;
using System.DomainModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaBot.DomainModel.Diagnostico
{
    public class Sintoma : ValueObject
    {
        public CodigoDeSintoma Codigo { get; private set; }

        public string Descricao { get; private set; }

        public Sintoma(CodigoDeSintoma codigo, string descricao)
        {
            Codigo = codigo;

            Descricao = descricao;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Codigo;
            yield return Descricao;
        }
    }
}
