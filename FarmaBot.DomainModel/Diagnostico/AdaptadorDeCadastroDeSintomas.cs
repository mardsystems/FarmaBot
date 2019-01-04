using FarmaBot.DomainModel.Cadastro.Sintomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaBot.DomainModel.Diagnostico
{
    public class AdaptadorDeCadastroDeSintomas
    {
        private readonly IRepositorioDeSintomas repositorioDeSintomas;

        private readonly TradutorDeSintoma tradutorDeSintoma;

        public AdaptadorDeCadastroDeSintomas(IRepositorioDeSintomas repositorioDeSintomas, TradutorDeSintoma tradutorDeSintoma)
        {
            this.repositorioDeSintomas = repositorioDeSintomas;

            this.tradutorDeSintoma = tradutorDeSintoma;
        }

        public Sintoma[] ObtemSintomasAPartirDeUmaDescricao(string descricaoDeSintomas)
        {
            //var sintomas = sintoma.AsList();

            //var result = new List<string>();

            //if (string.IsNullOrEmpty(Descricao)) return result;

            //result.AddRange(Descricao.Split(','));

            //return result;

            var sintomasCadastrados = repositorioDeSintomas.ObtemSintomasAPartirDeUmaDescricao(descricaoDeSintomas);

            var sintomas = sintomasCadastrados.Select(p => tradutorDeSintoma.CadastroParaDiagnostico(p));

            return sintomas.ToArray();
        }
    }
}
