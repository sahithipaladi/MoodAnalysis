using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    /// <summary>
    /// CreateMoodAnalyse method to create object of MoodAnalyse calss
    /// </summary>
    public class MoodAnalyseFactory
    {
        //For Default Constructor........
        public static object CreateMoodAnalyseUsingDefault(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.NO_SUCH_CLASS, "Class not found");
                }
            }
            else
            {
                throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "Constructor not found");
            }
        }
        //For Parameterized Constructor............
        public static object CreateMoodAnalyseUsingParameter(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyse);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                    object instance = constructorInfo.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "Constructor not found");
                }
            }
            else
            {
                throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.NO_SUCH_CLASS, "Class not found");
            }
        }
    }
}