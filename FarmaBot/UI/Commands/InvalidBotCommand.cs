using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace FarmaBot.UI.Commands
{
    public class InvalidBotCommand : BotCommand
    {       
        public override async void Execute(Message message)
        {
            var msg = @"
Ops, comando inválido. Tente um desses abaixo: 
/diagnose {Descrição do sintoma} - Sugere remédios baseados em sintomas informados pelo usuário.

/pedido  - Realiza pedidos de remédios junto a farmácias conveniadas.
";
            await Bot.SendTextMessageAsync(
                        message.Chat.Id,
                        msg,
                        replyMarkup: new ReplyKeyboardRemove());
        }
    }
}
