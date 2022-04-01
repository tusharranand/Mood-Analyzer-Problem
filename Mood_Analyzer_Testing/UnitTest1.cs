using Mood_Analyzer;
using NUnit.Framework;

namespace Mood_Analyzer_Testing
{
    public class Tests
    {
        Mood_Analyzer_Program analyze;
        [SetUp]
        public void Setup()
        {
           analyze = new Mood_Analyzer_Program();
        }
        /// <summary>
        /// TC 1.1: Given “I am in Sad Mood” message Should Return SAD
        /// </summary>
        [Test]
        public void When_Given_Sad_Message_Should_Return_SAD()
        {
            analyze = new Mood_Analyzer_Program("I am in sad mood");
            string Returned_Message = analyze.MoodAnalyzer();
            Assert.AreEqual("SAD", Returned_Message);
        }
        /// <summary>
        /// TC 1.2: Given “I am in Any Mood” message Should Return HAPPY
        /// </summary>
        [Test]
        public void When_Given_Any_Message_Should_Return_HAPPY()
        {
            analyze = new Mood_Analyzer_Program("I am in any mood");
            string Returned_Message = analyze.MoodAnalyzer();
            Assert.AreEqual("HAPPY", Returned_Message);
        }
    }
}