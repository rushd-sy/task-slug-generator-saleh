using System;
using System.Collections.Generic;
using System.Text;

namespace SlugGenerator
{
    public static class SlugExtension
    {
        public static string ToSlug(this string text, char separator = '-')
        {
            return SlugGenerator.Generate(text, separator);
        }
    }
}
