using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Threading.Tasks;

namespace Mood_Analyzer
{
    /// <summary>
    /// UC 4: Creating a method to make an object of Mood_Analyzer_Program class
    /// </summary>
    public class Mood_Aanalyzer_Factory
    {
        public static object CreateMoodAnalyze(string className, string constructorName)
        {
            string pattern = @"." + className + "$";
            Match result = Regex.Match(pattern, constructorName);
            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyzeType = assembly.GetType(className);
                    return Activator.CreateInstance(moodAnalyzeType);
                }
                catch (ArgumentNullException)
                {
                    throw new MA_Custom_Exceptions(MA_Custom_Exceptions.Exception_Type.NO_SUCH_CLASS, "Class not found");
                }
            }
            else throw new MA_Custom_Exceptions(MA_Custom_Exceptions.Exception_Type.NO_SUCH_CONSTRUCTOR, "Constructor not found");
        }
        public static object CreateMoodAnalyze_Parameter_Constructor(string className, string constructorName)
        {
            Type type = typeof(Mood_Analyzer_Program);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructor = type.GetConstructor(new[] { typeof(string) });
                    object instance = constructor.Invoke(new object[] { "HAPPY" });
                    return instance;
                }
                else throw new MA_Custom_Exceptions(MA_Custom_Exceptions.Exception_Type.NO_SUCH_CONSTRUCTOR, "Constructor not found");
            }
            else throw new MA_Custom_Exceptions(MA_Custom_Exceptions.Exception_Type.NO_SUCH_CLASS, "Class not found");
        }
    }
}
