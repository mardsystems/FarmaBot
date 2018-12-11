using System.Collections.Generic;
using Telegram.Bot;

namespace FarmaBot.UI.Callbacks
{
    public class BotCallbackFactory
    {
        private static Dictionary<BotCallbackType, BotBaseCallback> callbacks = new Dictionary<BotCallbackType, BotBaseCallback>
        {
            { BotCallbackType.ADD_CARRINHO_CALLBACK, new AdicionarCarrinhoCallback() },
            { BotCallbackType.FINALIZAR_PEDIDO_CALLBACK, new FinalizarPedidoCallback() }
        };

        public static BotBaseCallback Get(BotCallbackType type, TelegramBotClient bot)
        {
            if (callbacks.TryGetValue(type, out BotBaseCallback callback))
            {
                callback.Bot = bot;
            }

            return callback;
        }
    }
}
