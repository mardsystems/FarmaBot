using System.Collections.Generic;
using Telegram.Bot;

namespace FarmaBot.Bot.Commands
{
    public class BotCommandFactory
    {
        private static Dictionary<string, FarmaBotCommandBase> commands = new Dictionary<string, FarmaBotCommandBase>
        {
            { "/start", new StartBotCommand() },
            { "/diagnose", new DiagnoseBotCommand() },
            { "/pedido", new PedidoBotCommand() }
        };

        public static FarmaBotCommandBase Get(string command, TelegramBotClient bot)
        {
            if (commands.TryGetValue(command, out FarmaBotCommandBase cmd))
            {
                cmd.Bot = bot;
            }
            else
            {
                cmd = new InvalidBotCommand();
                cmd.Bot = bot;
            }

            return cmd;
        }
    }
}
