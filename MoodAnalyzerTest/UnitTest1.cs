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
        /// <summary>
        /// TC 4.1
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalysisObject()
        {
            string className = "MoodAnalyzerProblem.MoodAnalyse";
            string constructorName = "MoodAnalyse";
            object expected = new MoodAnalyse();
            object actual = MoodAnalyseFactory.CreateMoodAnalyseUsingDefault(className, constructorName);
            expected.Equals(actual);
        }
        /// <summary>
        /// TC 4.2
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturnNoSuchClass()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyserProblem.MoodAnalyse";
                string constructorName = "MoodAnalyse";
                //Act
                object resultObj = MoodAnalyseFactory.CreateMoodAnalyseUsingDefault(className, constructorName);
            }
            catch (CustomMoodAnalyserException ex)
            {
                //Assert
                Assert.AreEqual("Class not found", ex.Message);
            }
        }
        /// <summary>
        /// TC 4.3
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturnNoSuchConstructor()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyzerProblem.MoodAnalyse";
                string constructorName = "MoodAnalyze";
                //Act
                object resultObj = MoodAnalyseFactory.CreateMoodAnalyseUsingDefault(className, constructorName);
            }
            catch (CustomMoodAnalyserException ex)
            {
                //Assert
                Assert.AreEqual("Constructor not found", ex.Message);
            }
        }
        /// <summary>
        /// TC 5.1
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalysisObject_UsingParameterizedConstructor()
        {
            string className = "MoodAnalyzerProblem.MoodAnalyse";
            string constructorName = "MoodAnalyse";
            object expected = new MoodAnalyse("Happy");
            object actual = MoodAnalyseFactory.CreateMoodAnalyseUsingParameter(className, constructorName, "Happy");
            expected.Equals(actual);
        }
        /// <summary>
        /// TC 5.2
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturnNoSuchClass_UsingParameterizedConstructor()
        {
            string expected = "Class not found";
            try
            {
                //Arrange
                string className = "MoodAnalyserProblem.MoodAnalyse";
                string constructorName = "MoodAnalyse";

                //Act
                object resultObj = MoodAnalyseFactory.CreateMoodAnalyseUsingParameter(className, constructorName, expected);
            }
            catch (CustomMoodAnalyserException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
        /// <summary>
        /// TC 5.3
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturnNoSuchConstructor_UsingParameterizedConstructor()
        {
            string expected = "Constructor not found";
            try
            {
                //Arrange
                string className = "MoodAnalyzerProblem.MoodAnalyse";
                string constructorName = "MoodAnalyze";
                //Act
                object resultObj = MoodAnalyseFactory.CreateMoodAnalyseUsingDefault(className, constructorName);
            }
            catch (CustomMoodAnalyserException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
        /// <summary>
        /// TC 6.1
        /// </summary>
        [TestMethod]
        public void GivenHappyShouldReturnHappy()
        {
            ///AAA Methodology
            //Arrange
            string expected = "HAPPY";
            //Act
            string actual = MoodAnalyseFactory.InvokeAnalyseMethod("Happy", "AnalyseMood");
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC 6.2
        /// </summary>
        [TestMethod]
        public void GivenHappyShouldRetuenException()
        {
            string expected = "Method not found";
            try
            {
                //Arrange
                string methodName = "AnalyzeMod";
                //Act
                object resultObj = MoodAnalyseFactory.InvokeAnalyseMethod("Happy", methodName);
            }
            catch (CustomMoodAnalyserException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
        /// <summary>
        /// TC 7.1
        /// </summary>
        [TestMethod]
        public void GivenHappy_WithReflector_ShouldReturnHappy()
        {
            ///AAA Methodology
            //Arrange
            string expected = "HAPPY";
            //Act
            string actual = MoodAnalyseFactory.SetField("HAPPY", "message");
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC 7.2
        /// </summary>
        [TestMethod]
        public void GivenHappy_WithReflector_ShouldReturnNoSuchField()
        {
            string expected = "Field not found";
            try
            {
                //Arrange
                string fieldName = "mesage";
                //Act
                string actual = MoodAnalyseFactory.SetField("Happy", fieldName);
            }
            catch (CustomMoodAnalyserException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
        /// <summary>
        /// TC 7.3
        /// </summary>
        [TestMethod]
        public void GivenHappy_WithReflector_ShouldReturnNullException()
        {
            string expected = "Message should not be null";
            try
            {
                //Arrange
                string fieldName = "message";
                //Act
                string actual = MoodAnalyseFactory.SetField(null, fieldName);
            }
            catch (CustomMoodAnalyserException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}