using System.Collections.Generic;

namespace FarmaBot.DomainModel.Sintomas
{
    public class Sintoma
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public List<string> AsList()
        {
            var result = new List<string>();

            if (string.IsNullOrEmpty(Descricao)) return result;

            result.AddRange(Descricao.Split(','));

            return result;
        }
    }
}
