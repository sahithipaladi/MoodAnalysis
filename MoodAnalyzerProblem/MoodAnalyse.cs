using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyse
    {
        string message;
        //Default Constructor.......
        public MoodAnalyse()
        {
            this.message = "";
        }
        //Parameterized Constructor.........
        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty");
                }
                if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.NULL_EXCEPTION, "Mood should not be null");
            }
        }
    }
}