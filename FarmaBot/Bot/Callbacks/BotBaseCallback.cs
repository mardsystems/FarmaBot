using Telegram.Bot;
using Telegram.Bot.Types;

namespace FarmaBot.Bot.Callbacks
{
    public abstract class BotBaseCallback
    {
        public abstract new BotCallbackType GetType();
        public abstract void Execute(CallbackQuery callbackQuery);

        public TelegramBotClient Bot { get; set; }
    }    
}
