using Newtonsoft.Json;
using System;

namespace FarmaBot.UI.Callbacks
{
    public enum BotCallbackType
    {
        INVALID_TYPE = 0,
        ADD_CARRINHO_CALLBACK = 1,
        FINALIZAR_PEDIDO_CALLBACK = 2
    }

    public static class BotCallbackTypeExtensions
    {
        public static BotCallbackType ParseType(this string value)
        {
            try
            {
                dynamic json = JsonConvert.DeserializeObject(value);

                int type = json.type;

                return (BotCallbackType)type;
            }
            catch (Exception)
            {
                return BotCallbackType.INVALID_TYPE;
            }
        }
    }

}
