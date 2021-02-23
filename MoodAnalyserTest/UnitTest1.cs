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

        [Test]
        public void Given_moodanalyserReflection_return_Moodanalyserobject()
        {
            Moodanalyser obj = new Moodanalyser();
            object result = Moodfactory.CreateMoodAnalyserObject("MoodanalyserDay11.Moodanalyser", "Moodanalyser");
            obj.Equals(result);
        }
        [Test]
        public void GivenMoodAnalyser_Reflection_return_MoodanalyserParametarized_object()
        {
            var obj = new Moodanalyser("I am in HAPPY mood");
            object result = Moodfactory.CreateMoodanalyseParameterizedConstructor("MoodAnalyserDay12.Moodanalyser", "Moodanalyser", "Happy");
            obj.Equals(result);
        }
        
      
    }
}