using FarmaBot.DomainModel.Cadastro.Medicamentos;
using FarmaBot.DomainModel.Cadastro.Sintomas;
using System;
using System.Collections.Generic;
using System.DomainModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaBot.DomainModel.Cadastro.Sugestoes
{
    public class SugestaoDeMedicamento : Entity
    {
        public CodigoDeMedicamento CodigoDoMedicamentoSugerido { get; private set; }

        public CodigoDeSintoma CodigoDoSintomaCoberto { get; private set; }

        public int Prioridade { get; private set; }

        public int Quantidade { get; private set; }
    }
}
