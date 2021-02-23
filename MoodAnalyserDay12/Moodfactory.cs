﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodanalyserDay12
{
    public class Moodfactory
    {
        public static object CreateMoodAnalyserObject(string className, string constructor)
        {
            string pattern = @" . " + constructor + "$";
            var result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {

                    Type type = Type.GetType("MoodanalyserDay12.Moodanalyser");
                    var res = Activator.CreateInstance(type);
                    return res;

                }
                catch (NullReferenceException)
                {
                    throw new moodanalyserCustomeexception(moodanalyserCustomeexception.Exceptiontype.NO_SUCH_CLASS, "No such class found");
                }
            }
            else
            {
                throw new moodanalyserCustomeexception(moodanalyserCustomeexception.Exceptiontype.NO_SUCH_CONSTRUCTOR, "No such constructor found");
            }
        }
        public static object CreateMoodanalyseParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(Moodanalyser);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { message });
                    return instance;
                }
                else
                {

                    throw new moodanalyserCustomeexception(moodanalyserCustomeexception.Exceptiontype.NO_SUCH_CONSTRUCTOR, "Constructor Not found");
                }
            }
            else
            {
                throw new moodanalyserCustomeexception(moodanalyserCustomeexception.Exceptiontype.NO_SUCH_CLASS, "Class is Not found");
            }

        }
    }
}