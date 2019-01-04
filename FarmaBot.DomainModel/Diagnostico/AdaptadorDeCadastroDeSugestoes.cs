using FarmaBot.DomainModel.Cadastro.Sugestoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaBot.DomainModel.Diagnostico
{
    public class AdaptadorDeCadastroDeSugestoes
    {
        private readonly IRepositorioDeSugestoes repositorioDeSugestoes;

        private readonly TradutorDeSintoma tradutorDeSintoma;

        public AdaptadorDeCadastroDeSugestoes(IRepositorioDeSugestoes repositorioDeSugestoes, TradutorDeSintoma tradutorDeSintoma)
        {
            this.repositorioDeSugestoes = repositorioDeSugestoes;

            this.tradutorDeSintoma = tradutorDeSintoma;
        }

        public SugestaoDeMedicamentoPorSintoma[] ObtemSugestoesDeMedicamentosPorSintomas(string descricaoDeSintomas)
        {
            //var sintomas = sintoma.AsList();

            //var result = new List<string>();

            //if (string.IsNullOrEmpty(Descricao)) return result;

            //result.AddRange(Descricao.Split(','));

            //return result;

            var sintomasCadastrados = repositorioDeSugestoes.ObtemSintomasAPartirDeUmaDescricao(descricaoDeSintomas);

            var sintomas = sintomasCadastrados.Select(p => tradutorDeSintoma.CadastroParaDiagnostico(p));

            return sintomas.ToArray();
        }
    }
}
