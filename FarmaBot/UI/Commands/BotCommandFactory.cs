using FarmaBot.Infra;
using System.Collections.Generic;
using Telegram.Bot;

namespace FarmaBot.UI.Commands
{
    public class BotCommandFactory
    {
        private static Dictionary<string, BotCommand> commands;

        public static void CreateCommands(Infra.App app)
        {
            commands = new Dictionary<string, BotCommand>
            {
                { "/start", new StartBotCommand() },
                { "/diagnose", new DiagnoseBotCommand(app) },
                { "/pedido", new PedidoBotCommand(app) }
            };
        }

        public static BotCommand Get(string command, TelegramBotClient bot)
        {
            if (commands.TryGetValue(command, out BotCommand cmd))
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
