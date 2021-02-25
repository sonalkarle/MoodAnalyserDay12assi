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
        public void MoodAnalyserClassName_ShouldReturnMoodAnalyserObject()
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
        public void MoodAnalyserClassName_WhenImproper_ShouldThrowMoodAnalyserException()
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
            
            string expected = "Constructor not found";
            try
            {
                obj = MoodAnalyserfactory.CreateMoodAnalyse("MoodAnalyserDay12.MoodAnalyser", "AnalyserMood");
            }
            catch (moodanalysercustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }


        /// <summary>
        /// TC-5.1  Given MoodAnalyse Class Name Should Return MoodAnalyser Object
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_ShouldReturnMoodAnalyserObject_UsingParametrizedConstructor()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserfactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserDay12.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        /// <summary>
        /// TC-5.2  Given MoodAnalyse Class Name When Improper Should Throw Exception
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_WhenImproper_UsingParametrizedConstructor_ShouldThrowExcpetion()
        {
            string expected = "Class not found";
            try
            {
                object obj = MoodAnalyserfactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserDay12.Mood", "MoodAnalyser");
            }
            catch (moodanalysercustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// TC-5.3  Given MoodAnalyse Class Name When Constructor is Improper Should Throw Exception
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_WhenConstructorIsImproper_UsingParametrizedConstructor_ShouldThrowExcpetion()
        {
            string expected = "Constcructor not found";
            try
            {
                object obj = MoodAnalyserfactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserDay12.MoodAnalyser", "Mood");
            }
            catch (moodanalysercustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// TC-6.1  Given Happy Message Using Using Reflector When Proper Should Return Hppy Name Should Return MoodAnalyser Object
        /// </summary>
        [Test]
        public void GivenHppyMessge_Proper_ShouldReturnHppy()
        {
            string expected = "HAPPY";
            string mood = MoodAnalyserfactory.InvokeAnalyseMood("HAPPY", "AnalyserMood");
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// TC-6.2  Given Happy Message Using Using Reflector When ImProper Method Should Return Hppy Name Should Throw Exception
        /// </summary>
        [Test]
        public void GivenHppyMessge_WhenIMProperMethod_ShouldThrowException()
        {
            string expected = "Constructor not found";
            try
            {
                string mood = MoodAnalyserfactory.InvokeAnalyseMood("HAPPY", "Analyser");
            }
            catch (moodanalysercustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// TC-6.2  Given Happy Message Using Using Reflector When ImProper Method Should Return Hppy Name Should Throw Exception
        /// </summary>
        [Test]
        public void GivenHppyMessge_WhenIMProperMethod_Should_ThrowException()
        {
            string expected = "Constcructor not found";
            try
            {
                string mood = MoodAnalyserfactory.InvokeAnalyseMood("HAPPY", "Analyser");
            }
            catch (moodanalysercustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}