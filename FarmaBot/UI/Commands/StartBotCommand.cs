using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace FarmaBot.UI.Commands
{
    public class StartBotCommand : FarmaBotCommandBase
    {
        public override async void Execute(Message message)
        {
            var user = message.From.FirstName;

            string msg = $@"
Olá {user}, bem vindo ao FarmaBot.
Modo de uso:
/diagnose {{Descrição do sintoma}} - Sugere remédios baseados em sintomas informados pelo usuário.

/pedido  - Realiza pedidos de remédios junto a farmácias conveniadas.";

            await Bot.SendTextMessageAsync(
                        message.Chat.Id,
                        msg,
                        replyMarkup: new ReplyKeyboardRemove());
        }
    }
}
