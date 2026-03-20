using System.Text.RegularExpressions;

namespace SlugGenerator;

public class SlugGenerator
{
    public static string Generate(string text)
    {
        if(text == null) return string.Empty;

        return string.Join(
            "-", Regex.Replace(text.ToLower(),
            "[^\\p{L}\\d\\s-_]", "").Split(new char[] { ' ', '-', '_' },
            StringSplitOptions.RemoveEmptyEntries));
    }
}
