using NUnit.Framework;
using MoodanalyserDay12;

namespace MoodAnalyserTest
{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
           
        }
        /// <summary>
        /// UC 4: Use reflection to create mood analyser with default constructor
        /// </summary>
        [Test]
        public void Given_moodanalyserReflection_return_Moodanalyserobject()
        {
            Moodanalyser obj = new Moodanalyser();
            object result = Moodfactory.CreateMoodAnalyserObject("MoodanalyserDay11.Moodanalyser", "Moodanalyser");
            obj.Equals(result);
        }
    }
}