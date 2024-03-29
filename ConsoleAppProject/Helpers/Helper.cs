﻿namespace ConsoleAppProject.Common
{
    using System;

    using static Constants.Common;

    /// <summary>
    /// Helper class is responsible for keeping methods 
    /// that are used in more than one App
    /// </summary>
    /// <author>Chris Edgley</author>
    /// <version>1.0</version>
    public static class Helper
    {
        /// <summary>
        /// Print out the menu heading
        /// </summary>
        public static void PrintMenuHeading()
        {
            Console.WriteLine($"\n\r\n\r\n\r{MENU_HEADING}");
        }

        /// <summary>
        /// Print out the heading of an App and its brief description
        /// </summary>
        /// <param name="appDescription">The description of an application</param>
        public static void PrintHeading(string appName, string appDescription)
        {
            Console.WriteLine("--------------------------------------\n\r" +
                              $"           {appName}                 \n\r" +
                              "            by Chris Edgley           \n\r" +
                              "--------------------------------------\n\r" +
                              "\n\r" +
                              $"{appDescription}");
        }

        /// <summary>
        /// Print out the result on the console
        /// </summary>
        /// <param name="result">The result of an application</param>
        public static void PrintResult(string result)
        {
            Console.WriteLine(result);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.CursorVisible = false;

            Console.Write("Press any key to return in the menu.");
            Console.ReadKey();
        }

        /// <summary>
        /// This method recieve the type of a class. 
        /// Get the attribute and return the value of the custom attribute class name.
        /// </summary>
        /// <param name="className">The type of a class</param>
        /// <returns>The value(the name) of the given class</returns>
        public static string GetClassNameByAttribute(Type classType)
        {
            var attribute = (ClassNameAttribute)Attribute
                .GetCustomAttribute(classType, typeof(ClassNameAttribute));

            if (attribute != null)
            {
                return attribute.Name;
            }
         
            throw new NullReferenceException($"The attribute is null or not used on this {classType.Name} class.");
        }
    }
}
