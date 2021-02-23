using NUnit.Framework;
using MoodAnalyserDay12;


namespace NUnitTestProject
{

    public class Tests
    {

        MoodAnalyserfactory moodAnalyserfactory;
        [SetUp]
        public void Setup()
        {
            moodAnalyserfactory = new MoodAnalyserfactory();

        }

        /// <summary>
        /// TC-4.1 Given MoodAnalyse Class Name Should Return MoodAnalyser Object
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_ShouldReturn_MoodAnalyser_Object()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserfactory.CreateMoodAnalyse("MoodAnalyserDay12.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        /// <summary>
        /// TC-4.2 Given MoodAnalyse Class Name When Improper Should Throw Exception
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_WhenImproper_Should_ThrowMood_AnalyserException()
        {
            object obj = null;
            
            string expected = "Class not found";
            try
            {
                obj = MoodAnalyserfactory.CreateMoodAnalyse("MoodAnalyserDay12.Mood", "Mood");
            }
            catch (moodanalysercustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// TC-4.3 Given MoodAnalyse Class Name When Constructor is Improper Should Throw Exception
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_WhenConstructorIsImproper_ShouldThrowMoodAnalyserException()
        {
            object obj = null;
            
            string expected = "Method not found";
            try
            {
                obj = MoodAnalyserfactory.CreateMoodAnalyse("MoodAnalyserDay12.MoodAnalyser", "AnalyserMood");
            }
            catch (moodanalysercustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }













    }
}