using FarmaBot.Infra.Data.Memory;

namespace FarmaBot
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryDatabase.InitData();

            UI.FarmaBot.Init();
        }
    }
}
