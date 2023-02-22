using MoodAnalyzerP;

namespace MoodAnalyzerTest

{
    [TestClass]
    public class UnitTest1
    {
        //UC3
        //TC 3.1
        [TestMethod]
        public void GivenNullMessage_WhenAnalyse_ShouldReturnHappy()
        {
            string message = null;
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            try
            {
                string actutal = moodAnalyzer.AnalyseMood();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Message is ull");
            }
        }
    }
}