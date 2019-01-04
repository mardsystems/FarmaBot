using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaBot.DomainModel.Diagnostico
{
    public class TradutorDeSintoma
    {
        public Sintoma CadastroParaDiagnostico(Cadastro.Sintomas.Sintoma sintomaCadastrado)
        {
            return new Sintoma(
                sintomaCadastrado.Codigo,
                sintomaCadastrado.Descricao
            );
        }
    }
}
