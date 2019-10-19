using Hambot2._1.YoutubeLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HambotTest
{
    [TestClass]
    public class YoutubeTests
    {

        [TestMethod]
        public void YoutubeSearch_SuccessfulSearch_ShouldSucceed()
        {
            var logic = new YoutubeLogic();
            var result = logic.YoutubeSearch("Half in the Bag: The Fanatic");
            Assert.IsTrue(result.Snippet.Description.Equals(
                "Mike and Jay take a deep dive into one of the biggest box office flops of the year, The Fanatic! Starring John Travolta and directed by Limp Bizkit."));
        }
    }
}
