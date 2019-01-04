using FarmaBot.DomainModel.Cadastro.Sintomas;
using LiteDB;
using System.IO;

namespace FarmaBot.DomainModel
{
    public class LiteDbDatabase
    {
        public static void InitData()
        {
            if (File.Exists(@"BotData.db"))
            {
                File.Delete(@"BotData.db");
            }

            using (var db = new LiteDatabase(@"BotData.db"))
            {
                var sintomas = db.GetCollection<Sintoma>("sintomas");

                sintomas.Insert(new Sintoma
                (
                    "Sintoma 1"
                ));
            }
        }
    }
}
