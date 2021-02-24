﻿using System;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserDay12
{
    public class MoodAnalyserfactory
    {
        /// <summary>
        /// UC-4 CreateMoodAnalyse method create object of MoodAnalyse class 
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructorName"></param>
        /// <returns></returns>
        public static object CreateMoodAnalyse(string className, string constructorName)
        {
            //Create pattern to check class name and constructor name are same or not
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            //Computation
            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = assembly.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new moodanalysercustomException(moodanalysercustomException.ExceptionType.NO_SUCH_CLASS, "Class not found");

                }
            }
            else
            {
                throw new moodanalysercustomException(moodanalysercustomException.ExceptionType.NO_SUCH_METHOD, "Method not found");
            }
        }

    }
}
