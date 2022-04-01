using System;

namespace Mood_Analyzer
{
    public class Mood_Analyzer_Program
    {
        public Mood_Analyzer_Program()
        {

        }
        public string MoodAnalyzer(string Message)
        {
            if (Message.ToUpper().Contains("SAD"))
                return "SAD";
            else return "HAPPY";
        }
        public static void Main(string[] args)
        {

        }
    }
}