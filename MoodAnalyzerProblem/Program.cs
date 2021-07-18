using System;

namespace MoodAnalyzerProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Mood Analyser------------");
            try
            {
                MoodAnalyse moodAnalyse = new MoodAnalyse();
                string result = moodAnalyse.AnalyseMood();
                Console.WriteLine(result);
            }
            catch (CustomMoodAnalyserException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}