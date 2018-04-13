using FarmaBot.Bot.Callbacks;
using FarmaBot.Bot.Commands;
using FarmaBot.Models;
using System;
using System.Configuration;
using System.Linq;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;

namespace FarmaBot.Bot
{
    public class FarmaBot
    {
        public static void Init()
        {
            var botUser = Instance.GetMeAsync().Result;
            Console.Title = botUser.Username;

            Instance.OnMessage += FarmaBot_OnMessage;
            Instance.OnMessageEdited += FarmaBot_OnMessage;
            Instance.OnReceiveError += FarmaBot_OnReceiveError;
            Instance.OnCallbackQuery += FarmaBot_OnCallbackQuery;
            Instance.OnUpdate += Instance_OnUpdate;

            Instance.StartReceiving(Array.Empty<UpdateType>());

            Console.WriteLine($"FarmaBot iniciado - @{botUser.Username} - Aguardando comandos...");
            Console.ReadLine();

            Instance.StopReceiving();
        }

        private static void Instance_OnUpdate(object sender, UpdateEventArgs updateEventArgs)
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

        private static void FarmaBot_OnCallbackQuery(object sender, CallbackQueryEventArgs callbackQueryEventArgs)
        {
            var callbackQuery = callbackQueryEventArgs.CallbackQuery;

            var callback = BotCallbackFactory.Get(callbackQuery.Data.ParseType(), Instance);
            callback?.Execute(callbackQuery);
        }

        private static void FarmaBot_OnReceiveError(object sender, ReceiveErrorEventArgs receiveErrorEventArgs)
        {
            Console.WriteLine("ERRO: {0} — {1}",
                receiveErrorEventArgs.ApiRequestException.ErrorCode,
                receiveErrorEventArgs.ApiRequestException.Message);
        }

        private static async void FarmaBot_OnMessage(object sender, MessageEventArgs messageEventArgs)
        {
            var message = messageEventArgs.Message;

            if (message == null || message.Type != MessageType.TextMessage)
                return;

            Console.WriteLine($"Comando recebido: @{message.Text}");

            await Instance.SendChatActionAsync(message.Chat.Id, ChatAction.Typing);

            var comando = message.Text.Split(' ').First();

            var cmd = BotCommandFactory.Get(comando, Instance);
            cmd.Execute(message);
        }

        private static TelegramBotClient Instance = new TelegramBotClient(ConfigurationManager.AppSettings["TelegramApiToken"]);
    }
}