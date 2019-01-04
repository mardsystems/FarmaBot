using FarmaBot.DomainModel.Cadastro.Sintomas;
using System;
using System.Collections.Generic;
using System.DomainModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaBot.DomainModel.Cadastro.Sugestoes
{
    public interface IRepositorioDeSugestoes : IRepository<SugestaoDeMedicamentoPorSintoma>
    {
        IEnumerable<SugestaoDeMedicamentoPorSintoma> ObtemSugestoesDeMedicamentosPorSintomas(Sintoma[] sintomas);
    }
}
