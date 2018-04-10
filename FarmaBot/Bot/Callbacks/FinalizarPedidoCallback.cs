using FarmaBot.Models;
using FarmaBot.Services;
using Newtonsoft.Json;
using System;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace FarmaBot.Bot.Callbacks
{
    public class FinalizarPedidoCallback : BotBaseCallback
    {
        public override void Execute(CallbackQuery callbackQuery)
        {
            dynamic response = JsonConvert.DeserializeObject(callbackQuery.Data);
            bool finalizarPedido = response.value;

            if (!finalizarPedido)
            {
                Bot.SendTextMessageAsync(
                    callbackQuery.Message.Chat.Id,
                    $"Ok! Pode continuar a sua compra!.");
            }
            else
            {
                if (CarrinhoCompras.Instance.Localizacao == null)
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
                    Medicamentos = CarrinhoCompras.Instance.Medicamentos,
                    Endereco = new Endereco
                    {
                        Latitude = CarrinhoCompras.Instance.Localizacao.Latitude,
                        Longitude = CarrinhoCompras.Instance.Localizacao.Longitude
                    }
                };

                var botService = new BotService();

                var id = botService.RealizarPedido(pedido);

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
            }
        }

        public override BotCallbackType GetType()
        {
            return BotCallbackType.FINALIZAR_PEDIDO_CALLBACK;
        }
    }
}
