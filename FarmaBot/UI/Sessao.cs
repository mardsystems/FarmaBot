using FarmaBot.Model;
using FarmaBot.Model.Compras;
using FarmaBot.Model.Medicamentos;

namespace FarmaBot.UI
{
    public class Sessao
    {
        public CarrinhoDeCompras Carrinho { get; private set; }

        public Endereco Endereco { get; private set; }

        public Sessao(Infra.App app)
        {
            Carrinho = app.ObtemCarrinhoDeCompras();
        }

        public void AlterarLocalizacao(Endereco endereco)
        {
            Endereco = endereco;
        }
    }
}
