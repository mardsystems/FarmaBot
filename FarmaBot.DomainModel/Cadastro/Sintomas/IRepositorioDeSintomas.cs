using System;
using System.Collections.Generic;
using System.DomainModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaBot.DomainModel.Cadastro.Sintomas
{
    public interface IRepositorioDeSintomas : IRepository<Sintoma>
    {
        IEnumerable<Sintoma> ObtemSintomasAPartirDeUmaDescricao(string descricaoDeSintomas);
    }
}
