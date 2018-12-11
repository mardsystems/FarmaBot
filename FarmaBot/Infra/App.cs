using FarmaBot.App;
using FarmaBot.Infra.Data.InMemory;
using FarmaBot.Model.Compras;
using FarmaBot.Model.Diagnostico;

namespace FarmaBot.Infra
{
    public class App
    {
        private readonly IRealizacaoDeDiagnosticos realizacaoDeDiagnosticos;

        private readonly IRealizacaoDePedidos realizacaoDePedidos;

        private readonly CarrinhoDeCompras carrinhoDeCompras;

        public App()
        {
            var repositorioDeMedicamentos = new RepositorioDeMedicamentosInMemory();

            var servicoDeDiagnostico = new ServicoDeDiagnostico(repositorioDeMedicamentos);

            realizacaoDeDiagnosticos = new ServicoDeDiagnosticoUsandoDominio(servicoDeDiagnostico);

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
