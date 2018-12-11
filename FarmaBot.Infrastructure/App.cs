using FarmaBot.ApplicationModel.RealizacaoDeDiagnosticos;
using FarmaBot.ApplicationModel.RealizacaoDePedidos;
using FarmaBot.DomainModel.Compras;
using FarmaBot.DomainModel.Diagnostico;
using FarmaBot.DomainModel.Medicamentos;

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

            var servicoDeDiagnostico = new DomainModel.Diagnostico.ServicoDeDiagnostico(repositorioDeMedicamentos);

            realizacaoDeDiagnosticos = new ApplicationModel.RealizacaoDeDiagnosticos.ServicoDeDiagnostico(servicoDeDiagnostico);

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
