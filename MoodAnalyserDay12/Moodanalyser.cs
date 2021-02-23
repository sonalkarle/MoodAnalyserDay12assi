using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserDay12
{
    public class MoodAnalyser
    {
        public string message;

        /// <summary>
        /// parameteri 
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalyser()
        {
            this.message = null;
        }
        /// <summary>
        /// parameterised constructor with null or empty message 
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        /// <summary>
        /// Method to analyse mood with custom exception
        /// </summary>
        /// <returns></returns>
        public string AnalyserMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new moodanalysercustomException(moodanalysercustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("SAD"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new moodanalysercustomException(moodanalysercustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null message");
            }

        }
    }
}