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

    public static string GenerateUnique(string text , char separator = '-')
    {
        var slug = Generate(text, separator);
        var uniqueId = Guid.NewGuid().ToString("N").Substring(0, 8);
        return $"{slug}{separator}{uniqueId}";
    }
}
