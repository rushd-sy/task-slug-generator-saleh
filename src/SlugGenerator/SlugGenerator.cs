using System.Text.RegularExpressions;

namespace SlugGenerator;
public class SlugGenerator
{
    public static string Generate(string text,char c = '-')
    {
        if(text == null) throw new ArgumentNullException(nameof(text));

        var cleaned = Regex.Replace(text.ToLowerInvariant(), @"[^\p{L}\d\s_-]+", "");
        var parts = cleaned.Split(new[] { ' ', '-', '_' }, StringSplitOptions.RemoveEmptyEntries);
        return string.Join(c, parts);
    }
}
