

namespace _1.Match_full_name
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    public class MatchFullName
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = @"[A-Z][a-z]+\s[A-Z][a-z]+";
            var regex = new Regex(pattern);

            var isMatch = regex.IsMatch(text);

            Console.WriteLine(isMatch);
        }
    }
}
