using FarmaBot.ApplicationModel.RealizacaoDePedidos;
using FarmaBot.UI.Callbacks;
using Newtonsoft.Json;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace FarmaBot.UI.Commands
{
    public class PedidoBotCommand : BotCommand
    {
        private readonly IRealizacaoDePedidos realizacaoDePedidos;

        public PedidoBotCommand(App app)
        {
            realizacaoDePedidos = app.ObtemInterfaceDeRealizacaoDePedidos();
        }

        public override async void Execute(Message message)
        {
            if (SessionManager.Current.Carrinho.Vazio)
            {
                var msg = @"
Ops, nenhum remédio adicionado ao carrinho. " + "\n" +
"Tente adicionar um remédio antes de finalizar o pedido.";
                await Bot.SendTextMessageAsync(
                            message.Chat.Id,
                            msg,
                            replyMarkup: new ReplyKeyboardRemove());

                return;
            }

            InlineKeyboardButton[] opcoes = new InlineKeyboardButton[2];

            opcoes[0] = InlineKeyboardButton.WithCallbackData("Sim", JsonConvert.SerializeObject(new
            {
                type = BotCallbackType.FINALIZAR_PEDIDO_CALLBACK,
                value = true
            }));

            opcoes[1] = InlineKeyboardButton.WithCallbackData("Não", JsonConvert.SerializeObject(new
            {
                type = BotCallbackType.FINALIZAR_PEDIDO_CALLBACK,
                value = false
            }));

            await Bot.SendTextMessageAsync(
                message.Chat.Id,
                $"Resumo do pedido: \n {SessionManager.Current.Carrinho.Resumo()} \n Deseja finalizar o pedido?",
                replyMarkup: new InlineKeyboardMarkup(opcoes));
        }
    }
}
