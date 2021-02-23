
using System;

namespace MoodanalyserDay12
{
    public class Moodanalyser
    {
        private string message;
        /// <summary>
        /// Parametrized constructor with sad or happy message
        /// </summary>
        /// <returns></returns>
        public Moodanalyser()
        {
            Console.WriteLine("Default constructor");
        }

        /// <summary>
        /// Parametrized constructor with sad or happpy message
        /// </summary>
        /// <returns></returns>
       public Moodanalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))

                    throw new moodanalyserCustomeexception(moodanalyserCustomeexception.Exceptiontype.EMPTY_MOOD, "Mood should not be empty");

                else if (this.message.Contains("SAD"))

                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new moodanalyserCustomeexception(moodanalyserCustomeexception.Exceptiontype.EMPTY_NULL, "Mood should not be null");
              
            }

        }
    }
}
