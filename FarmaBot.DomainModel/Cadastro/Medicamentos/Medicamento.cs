using System;
using System.Collections.Generic;
using System.DomainModel;

namespace FarmaBot.DomainModel.Cadastro.Medicamentos
{
    public class Medicamento : Entity
    {
        public CodigoDeMedicamento Codigo { get; private set; }

        public string Nome { get; private set; }

        public decimal Preco { get; private set; }

        public Medicamento(string nome)
        {
            Nome = nome;
        }
    }
}
