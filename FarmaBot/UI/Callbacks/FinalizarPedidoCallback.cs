using FarmaBot.App;
using FarmaBot.Model.Compras;
using Newtonsoft.Json;
using System;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace FarmaBot.UI.Callbacks
{
    public class FinalizarPedidoCallback : BotCallback
    {
        private readonly IRealizacaoDePedidos realizacaoDePedidos;

        public FinalizarPedidoCallback(Infra.App app)
        {
            realizacaoDePedidos = app.ObtemInterfaceDeRealizacaoDePedidos();
        }

        public override void Execute(CallbackQuery callbackQuery)
        {
            dynamic response = JsonConvert.DeserializeObject(callbackQuery.Data);
            bool finalizarPedido = response.value;

            if (!finalizarPedido)
            {
                Bot.SendTextMessageAsync(
                    callbackQuery.Message.Chat.Id,
                    $"Ok! Pode continuar a sua compra!");
            }
            else
            {
                if (SessionManager.Current.Endereco == null)
                {
                    var bt = new KeyboardButton("Compartilhar minha localização atual")
                    {
                        RequestLocation = true
                    };

                    var RequestReplyKeyboard = new ReplyKeyboardMarkup(new[]
                        {
                            bt,
                        },
                        resizeKeyboard: false
                    );

                    Bot.SendTextMessageAsync(
                        callbackQuery.Message.Chat.Id,
                        "Muito bem! Para continuar, preciso saber a sua localização." + Environment.NewLine +
                        "Por favor, compartilhe sua localização e use /pedido novamente.",
                        replyMarkup: RequestReplyKeyboard);

                    return;
                };

                var pedido = new Pedido
                {
                    Data = DateTime.Now,
                    Cliente = callbackQuery.Message.Chat.Username,
                    Medicamentos = SessionManager.Current.Carrinho.MedicamentosComprados,
                    Endereco = SessionManager.Current.Endereco
                };

                var id = realizacaoDePedidos.RealizaPedido(pedido);

                var valor = String.Format("{0:C}", pedido.ValorTotal);

                var info = $@"Pedido nº{id} realizado com sucesso." + Environment.NewLine +
                            $"Valor total de {valor}" + Environment.NewLine +
                            $"Obrigado {callbackQuery.Message.Chat.FirstName}!";

                var result = Bot.SendTextMessageAsync(
                                callbackQuery.Message.Chat.Id,
                                info,
                                replyMarkup: new ReplyKeyboardRemove());

                result
                    .ContinueWith(a =>
                            Bot.SendTextMessageAsync(
                                callbackQuery.Message.Chat.Id,
                                "Seu pedido será enviado para:",
                                replyMarkup: new ReplyKeyboardRemove()))
                    .ContinueWith(a =>
                            Bot.SendLocationAsync(
                                callbackQuery.Message.Chat.Id,
                                pedido.Endereco.Latitude,
                                pedido.Endereco.Longitude,
                                replyMarkup: new ReplyKeyboardRemove()));

                SessionManager.Destroy();
            }
        }

        public override BotCallbackType GetType()
        {
            return BotCallbackType.FINALIZAR_PEDIDO_CALLBACK;
        }
    }
}
