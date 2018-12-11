using FarmaBot.DomainModel;
using FarmaBot.UI;
using FarmaBot.UI.Callbacks;
using FarmaBot.UI.Commands;
using System;
using System.Configuration;
using System.Linq;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;

namespace FarmaBot
{
    public class Program
    {
        private static TelegramBotClient bot;

        private static App app;

        public static void Main(string[] args)
        {
            app = new App();

            InMemoryDatabase.InitData();

            BotCommandFactory.CreateCommands(app);

            BotCallbackFactory.CreateCallbacks(app);

            SessionManager.Create(app);

            Init();
        }

        private static void Init()
        {
            var telegramApiToken = ConfigurationManager.AppSettings["TelegramApiToken"];

            bot = new TelegramBotClient(telegramApiToken);

            var user = bot.GetMeAsync().Result;

            Console.Title = user.Username;

            bot.OnMessage += OnMessage;
            bot.OnMessageEdited += OnMessage;
            bot.OnCallbackQuery += OnCallbackQuery;
            bot.OnUpdate += OnUpdate;
            bot.OnReceiveError += OnReceiveError;

            bot.StartReceiving(Array.Empty<UpdateType>());

            Console.WriteLine($"FarmaBot iniciado - @{user.Username} - Aguardando comandos... (Pressione qualquer tecla para sair)");

            Console.ReadLine();

            bot.StopReceiving();
        }

        private static async void OnMessage(object sender, MessageEventArgs messageEventArgs)
        {
            var message = messageEventArgs.Message;

            if (message == null || message.Type != MessageType.Text)
            {
                return;
            }

            Console.WriteLine($"Comando recebido: @{message.Text}");

            await bot.SendChatActionAsync(message.Chat.Id, ChatAction.Typing);

            var commandText = message.Text.Split(' ').First();

            var command = BotCommandFactory.Get(commandText, bot);

            command.Execute(message);
        }

        private static void OnCallbackQuery(object sender, CallbackQueryEventArgs callbackQueryEventArgs)
        {
            var callbackQuery = callbackQueryEventArgs.CallbackQuery;

            var callback = BotCallbackFactory.Get(callbackQuery.Data.ParseType(), bot);

            callback?.Execute(callbackQuery);
        }

        private static void OnUpdate(object sender, UpdateEventArgs updateEventArgs)
        {
            if (updateEventArgs.Update.Message?.From != null)
            {
                SessionManager.User = updateEventArgs.Update.Message.From;
            }

            if (updateEventArgs.Update.Message?.Location != null)
            {
                SessionManager.Current.AlterarLocalizacao(
                    new Endereco
                    {
                        Latitude = updateEventArgs.Update.Message.Location.Latitude,
                        Longitude = updateEventArgs.Update.Message.Location.Longitude
                    }
                );
            }
        }

        private static void OnReceiveError(object sender, ReceiveErrorEventArgs receiveErrorEventArgs)
        {
            Console.WriteLine("ERRO: {0} — {1}",
                receiveErrorEventArgs.ApiRequestException.ErrorCode,
                receiveErrorEventArgs.ApiRequestException.Message);
        }
    }
}
