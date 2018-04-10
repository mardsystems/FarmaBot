using System.Globalization;
using System.Linq;
using System.Text;

namespace FarmaBot.Utils
{
    public static class StringExtensions
    {
        public static string Raw(this string values)
        {
            return new string(values.Trim().ToLowerInvariant().Normalize(NormalizationForm.FormD)
                .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                .ToArray());
        }
    }
}
