using System;

namespace MoodAnalyzerProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Mood Analyser------------");
            Console.WriteLine("Enter a message to test mood : ");
            string message = Console.ReadLine();
            MoodAnalyse moodAnalyse = new MoodAnalyse();
            string result = moodAnalyse.AnalyseMood(message);
            Console.WriteLine(result);
        }
    }
}