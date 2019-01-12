using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagSystemSomethingSomething;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagSystemSomethingSomething.Tests
{
    [TestClass()]
    public class TagSearchTests
    {
        [TestMethod()]
        [Timeout(2000)]
        public void GetTagsTest()
        {
            string inputPost = @"#testing Test #Hi #test#test2 #test3 #test4 #ą #ąęrtg #aerę #tes/t";
            TagSearch tagSrch = new TagSearch();
            string[] tags = tagSrch.GetTags(inputPost);
            Assert.AreEqual("#testing", tags[0]);
            Assert.AreEqual("#hi", tags[1]);
            Assert.AreEqual("#test", tags[2]);
            Assert.AreEqual("#test2", tags[3]);
            Assert.AreEqual("#test3", tags[4]);
            Assert.AreEqual("#test4", tags[5]);
            Assert.AreEqual("#aer", tags[6]);
            tags = tagSrch.GetTags(inputPost);
        }
    }
}