using Telegram.Bot;
using Telegram.Bot.Types;

namespace FarmaBot.UI.Commands
{
    public abstract class BotCommand
    {
        public TelegramBotClient Bot { get; set; }

        public abstract void Execute(Message message);
    }
}
