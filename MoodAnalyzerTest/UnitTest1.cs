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
        /// TC 2.1
        /// </summary>
        [TestMethod]
        public void GivenMessageReturnHappy()
        {
            ///AAA MEthodology
            //Arrange
            string expected = "HAPPY";
            try
            {
                moodAnalyse = new MoodAnalyse(null);
                //Act
                string actual = moodAnalyse.AnalyseMood();
            }
            catch (Exception ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}