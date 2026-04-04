using System.Text.RegularExpressions;

namespace SlugGenerator;
public class SlugGenerator
{
    public static string Generate(string text,char c = '-')
    {
        if(text == null) throw new ArgumentNullException(nameof(text));

        return  Regex.Replace(
                Regex.Replace(text.ToLowerInvariant(), @"[^\p{L}\d\s\-_]", ""),
                @"[\s\-_]+", c.ToString())
                .Trim('-');
    }
}
