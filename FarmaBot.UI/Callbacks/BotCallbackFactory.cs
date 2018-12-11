using System.Collections.Generic;
using Telegram.Bot;

namespace FarmaBot.UI.Callbacks
{
    public class BotCallbackFactory
    {
        private static Dictionary<BotCallbackType, BotCallback> callbacks;

        public static void CreateCallbacks(App app)
        {
            callbacks = new Dictionary<BotCallbackType, BotCallback>
            {
                { BotCallbackType.ADD_CARRINHO_CALLBACK, new AdicionarCarrinhoCallback(app) },
                { BotCallbackType.FINALIZAR_PEDIDO_CALLBACK, new FinalizarPedidoCallback(app) }
            };
        }

        public static BotCallback Get(BotCallbackType type, TelegramBotClient bot)
        {
            if (callbacks.TryGetValue(type, out BotCallback callback))
            {
                callback.Bot = bot;
            }

            return callback;
        }
    }
}
