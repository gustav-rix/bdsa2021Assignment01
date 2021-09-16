using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment1
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
            var pattern = "[^a-zA-Z0-9]+";
            foreach(var line in lines)
            {
                var words = Regex.Split(line, pattern);
                foreach(var word in words){
                    if(word != "")
                    {
                        yield return word;
                    }
                }
            }
        }

        public static IEnumerable<(int width, int height)> Resolution(string resolutions)
        {
            string pattern = @"(?<width>\d{3,4})x(?<height>\d{3,4})";

            Regex rgx = new Regex(pattern);

            foreach (Match match in rgx.Matches(resolutions))
            {
                yield return (int.Parse(match.Groups["width"].Value), int.Parse(match.Groups["height"].Value));
            }
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            var pattern1 = $@"<({tag}).*?>(?<innertext>.*?)<\/\1>";
            var pattern2 = @"<.*?>";

            var matches = Regex.Matches(html, pattern1);
            {
                foreach (Match match in matches)
                {
                    var innertext = match.Groups["innertext"].Value;
                    yield return Regex.Replace(innertext, pattern2, "");
                }
            }
        }
    }
}
