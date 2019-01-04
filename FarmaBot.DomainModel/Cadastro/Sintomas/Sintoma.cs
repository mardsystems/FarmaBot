using System.Collections.Generic;
using System.DomainModel;

namespace FarmaBot.DomainModel.Cadastro.Sintomas
{
    public class Sintoma : Entity
    {
        public CodigoDeSintoma Codigo { get; private set; }

        public string Descricao { get; private set; }

        public Sintoma(string descricao)
        {
            Descricao = descricao;
        }
    }
}
