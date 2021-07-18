using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
using System;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyse moodAnalyse;

        /// <summary>
        /// TC 3.1
        /// </summary>
        [TestMethod]
        public void GivenNullShouldReturnCustomException()
        {
            ///AAA Methodology
            //Arrange
            string expected = "Mood should not be null";
            try
            {
                moodAnalyse = new MoodAnalyse(null);
                //Act
                moodAnalyse.AnalyseMood();
            }
            catch (CustomMoodAnalyserException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
        /// <summary>
        /// TC 3.2
        /// </summary>
        [TestMethod]
        public void GivenEmptyShouldReturnCustomException()
        {
            ///AAA Methodology
            //Arrange
            string expected = "Mood should not be empty";
            try
            {
                moodAnalyse = new MoodAnalyse(" ");
                //Act
                moodAnalyse.AnalyseMood();
            }
            catch (CustomMoodAnalyserException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}