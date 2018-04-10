﻿using FarmaBot.Models;
using Newtonsoft.Json;
using Telegram.Bot.Types;

namespace FarmaBot.Bot.Callbacks
{
    public class AdicionarCarrinhoCallback : BotBaseCallback
    {
        public override void Execute(CallbackQuery callbackQuery)
        {
            dynamic response = JsonConvert.DeserializeObject(callbackQuery.Data);
            int id = response.id;

            var med = CarrinhoCompras.Instance.AdicionarMedicamento(id);

            if (med != null)
            {
                Bot.AnswerCallbackQueryAsync(
                    callbackQuery.Id,
                    $"Medicamento {med.Nome} foi adicionado ao carrinho.");

                Bot.SendTextMessageAsync(
                    callbackQuery.Message.Chat.Id,
                    $"Medicamento {med.Nome} foi adicionado ao carrinho." + "\n\n" +
                    "Use o comando /pedido para finalizar a compra.");
            }
        }

        public override BotCallbackType GetType()
        {
            return BotCallbackType.ADD_CARRINHO_CALLBACK;
        }
    }
}
