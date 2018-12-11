namespace FarmaBot.Model
{
    public class Sessao
    {
        public Sessao()
        {
            Carrinho = new CarrinhoCompras();
        }

        public void AlterarLocalizacao(Endereco endereco)
        {
            Endereco = endereco;
        }

        public CarrinhoCompras Carrinho { get; private set; }
        public Endereco Endereco { get; private set; }
    }
}
