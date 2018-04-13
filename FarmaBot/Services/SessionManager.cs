using System.Collections.Concurrent;
using Telegram.Bot.Types;

namespace FarmaBot.Models
{
    public static class SessionManager
    {
        public static Sessao Current
        {
            get
            {
                return _sessions.GetOrAdd(User.Username, new Sessao());
            }
        }

        public static void Destroy()
        {
            _sessions.TryRemove(User.Username, out Sessao sessao);
        }

        public static User User { get; set; }
        private static ConcurrentDictionary<string, Sessao> _sessions = new ConcurrentDictionary<string, Sessao>();
    }
}
