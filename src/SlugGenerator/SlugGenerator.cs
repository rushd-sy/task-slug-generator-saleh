using System.Text.RegularExpressions;

namespace SlugGenerator;

public class SlugGenerator
{
    public static string Generate(string text)
    {
        string result = text.ToLower();
        result = string.Join("-", result.Split(new char[] { ' ', '-', '_' }, StringSplitOptions.RemoveEmptyEntries));
        result = Regex.Replace(result, "[^a-z-ا-ي]", "");

        return result;
    }
}
