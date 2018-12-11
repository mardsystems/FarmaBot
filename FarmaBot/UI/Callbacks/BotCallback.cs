using Telegram.Bot;
using Telegram.Bot.Types;

namespace FarmaBot.UI.Callbacks
{
    public abstract class BotCallback
    {
        public abstract new BotCallbackType GetType();

        public abstract void Execute(CallbackQuery callbackQuery);

        public TelegramBotClient Bot { get; set; }
    }    
}
