﻿using FarmaBot.Utils;
using System.Collections.Generic;

namespace FarmaBot.Models
{
    public class Medicamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public List<string> Tags { get; set; } = new List<string>();

        public bool CobreSintoma(string sintoma)
        {
            return Tags.Contains(sintoma.Raw());
        }
    }
}
