using System;
using Mood_Analyzer;
using NUnit.Framework;

namespace Mood_Analyzer_Testing
{
    public class Tests
    {
        Mood_Analyzer_Program analyze;
        Mood_Aanalyzer_Factory analyse_class;

        [SetUp]
        public void Setup()
        {
            analyze = new Mood_Analyzer_Program();
            analyse_class = new Mood_Aanalyzer_Factory();
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
        /// <summary>
        /// TC 2: Given Null Mood Should Return Happy
        /// TC 3.1: Given NULL Mood Should Throw "Mood can not be Empty"
        /// </summary>
        [Test]
        public void When_Given_NULL_Should_Return_Custom_Null_Message()
        {
            try
            {
                string Message = null;
                analyze = new Mood_Analyzer_Program(Message);
            }
            catch (ArgumentNullException Exception)
            {
                Assert.AreEqual("Mood can not be Null.", Exception.Message);
            }
        }
        /// <summary>
        /// TC 3.2: Given NULL Mood Should Throw "Mood can not be Empty"
        /// </summary>
        [Test]
        public void When_Given_EMPTY_Message_Should_Return_Custom_Empty_Message()
        {
            try
            {
                analyze = new Mood_Analyzer_Program("");
                string Returned_Message = analyze.MoodAnalyzer();
                Assert.AreEqual("HAPPY", Returned_Message);
            }
            catch (MA_Custom_Exceptions Exception)
            {
                Assert.AreEqual("Mood can not be Empty.", Exception.Message);
            }
        }
        /// <summary>
        /// TC 4.1: Given Mood_Analyzer_Program Class Name Should Return Mood_Analyzer_Program Object
        /// </summary>
        [Test]
        public void When_Given_ClassName_Should_Return_Object()
        {
            object expected = new Mood_Analyzer_Program();
            object returned = Mood_Aanalyzer_Factory.CreateMoodAnalyze("Mood_Analyzer.Mood_Analyzer_Program", "Mood_Analyzer_Program");
            expected.Equals(returned);
        }
        /// <summary>
        /// TC 4.2: When given improper class name should throw "Class not found" exception
        /// </summary>
        [Test]
        public void When_Given_Improper_ClassName_Should_Throw_Exception()
        {
            try
            {
                object returned = Mood_Aanalyzer_Factory.CreateMoodAnalyze("Mood_Analyzer.Mood", "Mood");
            }
            catch (MA_Custom_Exceptions Exception)
            {
                Assert.AreEqual("Class not found", Exception.Message);
            }
        }
        /// <summary>
        /// TC 4.3: When given improper constructor name should throw "Constructor not found" exception
        /// </summary>
        [Test]
        public void When_Given_Improper_ConstuctorName_Should_Throw_Exception()
        {
            try
            {
                object returned = Mood_Aanalyzer_Factory.CreateMoodAnalyze("Mood_Analyzer.Mood_Analyzer_Program", "Mood");
            }
            catch (MA_Custom_Exceptions Exception)
            {
                Assert.AreEqual("Constructor not found", Exception.Message);
            }
        }
    }
}