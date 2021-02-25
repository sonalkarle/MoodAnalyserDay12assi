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
        public void MoodAnalyserClassName_ShouldReturn_MoodAnalyserObject()
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
        public void MoodAnalyserClassName_Improper_Should_ThrowMoodAnalyserException()
        {
            string expected = "Class not found";
            try
            {
                object obj = MoodAnalyserfactory.CreateMoodAnalyse("MoodAnalyserDay12.Mood", "Mood");
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
        public void MoodAnalyserClassName_ConstructorIsImproper_Should_ThrowMoodAnalyserException()
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
        public void MoodAnalyserClassName_ShouldReturn_MoodAnalyserObject_UsingParametrizedConstructor()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserfactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserDay12.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        /// <summary>
        /// TC-5.2  Given MoodAnalyse Class Name When Improper Should Throw Exception
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_Improper_UsingParametrizedConstructor_ShouldThrow_Excpetion()
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
        public void MoodAnalyserClassName_ConstructorIsImproper_UsingParametrizedConstructor_Should_ThrowExcpetion()
        {
            string expected = "Constructor not found";
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
        public void GivenHppyMessge_WhenIMProperMethod_Should_ThrowException()
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
        /// TC-7.1  Given Hppy Should Return Hppy
        /// </summary>
        [Test]
        public void Given_HAPPYMessage_WithReflector_Should_ReturnHAPPY()
        {
            string result = MoodAnalyserfactory.SetField("HAPPY", "message");
            Assert.AreEqual("HAPPY", result);
        }

        /// <summary>
        /// TC-7.2  Set Field When Improper Should Throw Exception 
        /// </summary>
        [Test]
        public void SetField_ImProper_ShouldThrowException()
        {
            try
            {
                string result = MoodAnalyserfactory.SetField("HAPPY", "me");
            }
            catch (moodanalysercustomException exception)
            {
                Assert.AreEqual("Field is not found", exception.Message);
            }
        }

        /// <summary>
        /// TC-7.3  Set Null Messge  Should Throw Exception 
        /// </summary>
        [Test]
        public void Setting_NullMessge_ShouldThrowException()
        {
            try
            {
                string result = MoodAnalyserfactory.SetField(null, "message");
            }
            catch (moodanalysercustomException exception)
            {
                Assert.AreEqual("Message should not be null", exception.Message);
            }
        }

    }
}