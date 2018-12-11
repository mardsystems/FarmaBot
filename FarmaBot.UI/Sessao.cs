﻿using FarmaBot.DomainModel;
using FarmaBot.DomainModel.Compras;
using FarmaBot.DomainModel.Medicamentos;

namespace FarmaBot.UI
{
    public class Sessao
    {
        public CarrinhoDeCompras Carrinho { get; private set; }

        public Endereco Endereco { get; private set; }

        public Sessao(App app)
        {
            Carrinho = app.ObtemCarrinhoDeCompras();
        }

        public void AlterarLocalizacao(Endereco endereco)
        {
            Endereco = endereco;
        }
    }
}
