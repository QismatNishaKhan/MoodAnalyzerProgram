using MoodAnalyzerP;

namespace MoodAnalyzerTest

{
    [TestClass]
    public class UnitTest1
    {
        //UC1
        //Display Sad message
        //TC 1.1
        [TestMethod]
        public void GivenSadMoodMessage_WhenAnalyse_ShouldReturnSAD()
        {

            string message = "I am sad mood";
            string expectedValue = "SAD";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer();

            string result = moodAnalyser.AnalyseMood(message);

            Assert.AreEqual(expectedValue, result);
        }
        //Display Happy message
        //TC 1.2
        [TestMethod]
        public void GivenSadMoodMessage_WhenAnalyse_ShouldReturnHAPPY()
        {

            string message = "I am happy mood";
            string expectedValue = "HAPPY";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer();
            string result = moodAnalyser.AnalyseMood(message);
            Assert.AreEqual(expectedValue, result);
        }
    }
}