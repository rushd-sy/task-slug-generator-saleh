using System.Text.RegularExpressions;

namespace SlugGenerator;
public class SlugGenerator
{
    public static string Generate(string text,char separator = '-')
    {
        if(text == null) throw new ArgumentNullException(nameof(text));

        return  Regex.Replace(
                Regex.Replace(text.ToLowerInvariant(), @"[^\p{L}\d\s\-_]", ""),
                @"[\s\-_]+", separator.ToString())
                .Trim(separator);
    }

    public static string GenerateUnique(string text , char separator = '-')
    {
        var slug = Generate(text, separator);
        var uniqueId = Guid.NewGuid().ToString("N").Substring(0, 8);
        return $"{slug}{separator}{uniqueId}";
    }
}
