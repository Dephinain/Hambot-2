using Hambot2._1.YoutubeLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HambotTest
{
    [TestClass]
    public class YoutubeTests
    {
        [TestMethod]
        public void YoutubeSearch_NullReferenceException_ShouldFail()
        {
            var logic = new YoutubeLogic();
            var trueFalse = logic.YoutubeSearch(null);

            Assert.IsTrue(trueFalse == null);
        }
    }
}
