using FarmaBot.App;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace FarmaBot.UI.Commands
{
    public abstract class FarmaBotCommandBase
    {
        public abstract void Execute(Message message);

        public TelegramBotClient Bot { get; set; }
        protected IBotService BotService = new BotService();
    }
}
