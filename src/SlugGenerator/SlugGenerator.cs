namespace SlugGenerator;

public class SlugGenerator
{
    public static string Generate(string text)
    {
        string result = string.Empty;
        text = text.ToLower();

        foreach (char c in text)
        {
            if (char.IsLetter(c))
                result = result + c;
            else if ((c == '-' || c == '_' || c == ' ') && result.Length > 0)
            {
                if (result.Last() != '-' && result.Last() != '_' && result.Last() != ' ')
                    result = result + "-";
                else continue;
            }
            else continue;
        }
        result = result.TrimEnd('-');
        return result;
    }
}
