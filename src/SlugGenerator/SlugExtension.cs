using System;
using System.Collections.Generic;
using System.Text;

namespace SlugGenerator
{
    public static class SlugExtension
    {
        public static string ToSlug(this string text, char c = '-')
        {
            return SlugGenerator.Generate(text, c);
        }
    }
}
