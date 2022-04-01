using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyzer
{
    public class MA_Custom_Exceptions : Exception
    {
        Exception_Type type;
        public enum Exception_Type
        {
            EMPTY_MOOD,
            NULL_MOOD
        }
        public MA_Custom_Exceptions(Exception_Type type, string Message) : base(Message)
        {
            this.type = type;
        }
    }
}
