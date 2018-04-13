using FarmaBot.Models;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace FarmaBot.Bot.Commands
{
    public abstract class FarmaBotCommandBase
    {
        public abstract void Execute(Message message);

        public TelegramBotClient Bot { get; set; }
        protected IBotService BotService = new BotService();
    }
}
