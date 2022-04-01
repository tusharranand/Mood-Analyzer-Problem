using System;

namespace Mood_Analyzer
{
    public class Mood_Analyzer_Program
    {
        string Message;
        public Mood_Analyzer_Program()
        {

        }
        public Mood_Analyzer_Program(string Message)
        {
            this.Message = Message;
        }
        public string MoodAnalyzer()
        {
            try
            {
                if (Message.Equals(string.Empty))
                    return "HAPPY";
                else if (Message.ToUpper().Contains("SAD"))
                    return "SAD";
                else return "HAPPY";
            }
            catch (NullReferenceException Exception)
            {
                return "HAPPY";
            }
        }
        public static void Main(string[] args){}
    }
}