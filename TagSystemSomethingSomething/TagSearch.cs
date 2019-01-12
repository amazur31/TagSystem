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
        /* 1. Get input string
         * 2. Search the input string for #
         * 3. Get the text after # until spacebar or another #
         * 4. Add the text to List
         * 5. Continue the search
         * 
         * 
         * 
         * */
        public string[] GetTags (string inputPost)
        {
            inputPost = inputPost.ToLower();
            Regex regex = new Regex(@"([#][\w_-]+)");
            string[] tags = regex.Matches(inputPost).OfType<Match>().Select(m => m.Groups[0].Value).ToArray(); ;
            return tags;
        }

    }
}
