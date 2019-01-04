using FarmaBot.ApplicationModel.RealizacaoDeDiagnosticos;
using FarmaBot.ApplicationModel.RealizacaoDePedidos;
using FarmaBot.DomainModel.Cadastro.Medicamentos;
using FarmaBot.DomainModel.Cadastro.Sugestoes;
using FarmaBot.DomainModel.Compras;
using FarmaBot.DomainModel.Diagnostico;

namespace FarmaBot
{
    public class App
    {
        private readonly IRealizacaoDeDiagnosticos realizacaoDeDiagnosticos;

        private readonly IRealizacaoDePedidos realizacaoDePedidos;

        private readonly CarrinhoDeCompras carrinhoDeCompras;

        public App()
        {
            var repositorioDeMedicamentos = new RepositorioDeMedicamentosInMemory();

            var repositorioDeSugestoes = new RepositorioDeSugestoesInMemory();

            var servicoDeDiagnostico = new DiagnosticoPorSugestaoDeMedicamentos(repositorioDeSugestoes);

            realizacaoDeDiagnosticos = new ServicoDeDiagnostico(servicoDeDiagnostico, null);

            var repositorioDePedidos = new RepositorioDePedidosInMemory();

            realizacaoDePedidos = new ServicoDeCompras(repositorioDePedidos);

            carrinhoDeCompras = new CarrinhoDeCompras(repositorioDeMedicamentos);
        }

        public IRealizacaoDeDiagnosticos ObtemInterfaceDeRealizacaoDeDiagnosticos()
        {
            return realizacaoDeDiagnosticos;
        }

        public IRealizacaoDePedidos ObtemInterfaceDeRealizacaoDePedidos()
        {
            return realizacaoDePedidos;
        }

        public CarrinhoDeCompras ObtemCarrinhoDeCompras()
        {
            return carrinhoDeCompras;
        }
    }
}
