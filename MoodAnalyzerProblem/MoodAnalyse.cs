using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MoodAnalyzerProblem
{
    public class MoodAnalyse
    {
        public string AnalyseMood(string message)
        {
            if (message.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}