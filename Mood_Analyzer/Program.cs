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
                    throw new MA_Custom_Exceptions(MA_Custom_Exceptions.Exception_Type.EMPTY_MOOD, "Mood can not be Empty.");
                else if (Message.ToUpper().Contains("SAD"))
                    return "SAD";
                else return "HAPPY";
            }
            catch (NullReferenceException)
            {
                //return "HAPPY";
                throw new MA_Custom_Exceptions(MA_Custom_Exceptions.Exception_Type.NULL_MOOD, "Mood can not be Null.");
            }
        }
        public static void Main(string[] args)
        {

        }
    }
}