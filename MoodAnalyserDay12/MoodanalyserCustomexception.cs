using System;
using System.Collections.Generic;
using System.Text;

namespace MoodanalyserDay12
{
    public class moodanalyserCustomeexception : Exception
    {
        Exceptiontype type;

        public enum Exceptiontype
        {
            EMPTY_MOOD,
            EMPTY_NULL,
            NO_SUCH_CONSTRUCTOR,
            NO_SUCH_CLASS
        }

        public moodanalyserCustomeexception(Exceptiontype type, string message) : base(message)
        {
            this.type = type;
        }

    }
}