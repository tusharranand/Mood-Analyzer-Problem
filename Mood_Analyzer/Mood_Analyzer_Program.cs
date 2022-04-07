using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// <summary>
        /// Method for mood analysis with custom exception messages
        /// </summary>
        /// <returns></returns>
        /// <exception cref="MA_Custom_Exceptions"></exception>
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
                //throw new NullReferenceException("Mood can not be Null.");
                throw new MA_Custom_Exceptions(MA_Custom_Exceptions.Exception_Type.NULL_MOOD, "Mood can not be Null.");
            }
        }
    }
}
