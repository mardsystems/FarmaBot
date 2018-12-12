using FarmaBot.App;
using FarmaBot.Model.Sintomas;
using FarmaBot.UI.Callbacks;
using Newtonsoft.Json;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InlineKeyboardButtons;
using Telegram.Bot.Types.ReplyMarkups;

namespace FarmaBot.UI.Commands
{
    public class DiagnoseBotCommand : BotCommand
    {
        protected IRealizacaoDeDiagnosticos realizacaoDeDiagnosticos;

        public DiagnoseBotCommand(Infra.App app)
        {
            realizacaoDeDiagnosticos = app.ObtemInterfaceDeRealizacaoDeDiagnosticos();
        }

        public override async void Execute(Message message)
        {
            if (message.Text.Split(' ').Length <= 1)
            {
                await Bot.SendTextMessageAsync(
                           message.Chat.Id,
                           "Por favor, informe um sintoma. " + "\n" +
                           "Ex.: /diagnose dor de cabeça, febre, dor no corpo",
                           replyMarkup: new ReplyKeyboardRemove());
                return;
            }

            var sintoma = new Sintoma
            {
                Descricao = message.Text.Substring(message.Text.IndexOf(" ")).Trim()
            };

            var medicamentos = realizacaoDeDiagnosticos.RealizaDiagnostico(sintoma);

            if (medicamentos.Count == 0)
            {
                await Bot.SendTextMessageAsync(
                    message.Chat.Id,
                    "Desculpe, mas nenhum medicamento foi encontrado para o(s) sintoma(s) informado(s).",
                    replyMarkup: new ReplyKeyboardRemove());
            }
            else
            {
                InlineKeyboardButton[] opcoes = new InlineKeyboardButton[medicamentos.Count];

                var idx = 0;

                foreach (var medicamento in medicamentos)
                {
                    opcoes[idx] = InlineKeyboardButton.WithCallbackData(medicamento.Nome, JsonConvert.SerializeObject(new
                    {
                        type = BotCallbackType.ADD_CARRINHO_CALLBACK,
                        id = medicamento.Id
                    }));

                    idx++;
                }

                var inlineKeyboard = new InlineKeyboardMarkup(opcoes);

                await Bot.SendTextMessageAsync(
                    message.Chat.Id,
                    "Baseado no(s) sintoma(s) informado(s), os seguintes medicamentos foram sugeridos:",
                    replyMarkup: inlineKeyboard);
            }
        }
    }
}
