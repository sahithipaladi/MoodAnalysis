using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyse moodAnalyse = new MoodAnalyse();
        /// <summary>
        /// TC 1.1
        /// </summary>
        [TestMethod]
        public void GivenMessageReturnSad()
        {
            ///AAA MEthodology
            //Arrange
            string expected = "SAD";
            //Act
            string actual = moodAnalyse.AnalyseMood("I am in SAD mood");
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
            //Act
            string actual = moodAnalyse.AnalyseMood("I am  in HAPPY  mood");
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}