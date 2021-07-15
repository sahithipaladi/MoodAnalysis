using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyse moodAnalyse;
        /// <summary>
        /// TC 1.1
        /// </summary>
        [TestMethod]
        public void GivenMessageReturnSad()
        {
            ///AAA MEthodology
            //Arrange
            string expected = "SAD";
            moodAnalyse = new MoodAnalyse("I am in Sad Mood");
            //Act
            string actual = moodAnalyse.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC 1.2
        /// </summary>
        [TestMethod]
        public void GivenMessageReturnHappy()
        {
            ///AAA MEthodology
            //Arrange
            string expected = "HAPPY";
            moodAnalyse = new MoodAnalyse("I am in Happy Mood");
            //Act
            string actual = moodAnalyse.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}