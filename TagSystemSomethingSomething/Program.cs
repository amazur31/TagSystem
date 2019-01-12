using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagSystemSomethingSomething
{
    class Program
    {
        static void Main(string[] args)
        {
            TagSearch search = new TagSearch();
            string[] test = search.GetTags("#testing #żółć #русский Test #汉字/漢字 #Hi #test#test2 #test3 #test4 #ą #ąęrtg #aerę #tes/t");
            foreach (string i in test)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
