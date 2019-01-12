using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TagSystemSomethingSomething
{
    public class TagSearch
    {
        public string[] GetTags (string inputPost)
        {
            inputPost = inputPost.ToLower();

            //Transform polish letters to a-z, delete others.
            inputPost = Encoding.ASCII.GetString(Encoding.GetEncoding("Cyrillic").GetBytes(inputPost));

            //Hashtag regex
            Regex regex = new Regex(@"([#][\w_-]+)");

            //MatchCollection to string array
            string[] tags = regex.Matches(inputPost).OfType<Match>().Select(m => m.Groups[0].Value).ToArray();
            return tags;
        }

    }
}
