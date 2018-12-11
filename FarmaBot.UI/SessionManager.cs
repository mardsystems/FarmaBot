using System.Collections.Concurrent;
using Telegram.Bot.Types;

namespace FarmaBot.UI
{
    public static class SessionManager
    {
        private static ConcurrentDictionary<string, Sessao> sessions = new ConcurrentDictionary<string, Sessao>();

        public static User User { get; set; }

        private static App app;

        public static Sessao Current
        {
            get
            {
                return sessions.GetOrAdd(User.Username, new Sessao(app));
            }
        }

        public static void Create(App app)
        {
            SessionManager.app = app;
        }

        public static void Destroy()
        {
            sessions.TryRemove(User.Username, out Sessao sessao);
        }
    }
}
