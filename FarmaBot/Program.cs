using FarmaBot.Data;

namespace FarmaBot
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryDatabase.InitData();

            Bot.FarmaBot.Init();
        }
    }
}
