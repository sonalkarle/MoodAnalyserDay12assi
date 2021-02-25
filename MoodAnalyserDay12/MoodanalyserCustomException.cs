using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserDay12
{
    public class moodanalysercustomException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            NO_SUCH_CLASS,
            NO_SUCH_CONSTRUCTOR,
            EMPTY_MESSAGE,
            NULL_MESSAGE,
        }

        public moodanalysercustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
