using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Chris Edgley 05/02/2020
    /// </summary>
    public static class Program
    {
        private static DistanceConverter converter = new DistanceConverter();
        private static BMI index = new BMI();
        private static StudentGradesInvoker studentGradesInvoker = new StudentGradesInvoker();

        public static void Main(string[] args )
        {
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();

            // Using an extension method for each enumeration
            // Console.WriteLine("Using MyEnum Extension Method!\n");
            // Console.WriteLine("MyEnum Value = " + MyEnum.FirstValue);
            // Console.WriteLine("MyEnum Friendly Value = " + MyEnum.FirstValue.EnumValue());
            // Console.WriteLine();

            // Using an extension method for any enumeration
            //StudentGrades grades = new StudentGrades();
            //grades.TestGradesEnumeration();
            Console.WriteLine("Options for the user");
            Console.WriteLine("Created by Chris Edgley");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Distance Converter");
            Console.WriteLine("2. BMI Index");
            Console.WriteLine("3. Student Grades");
            Console.WriteLine("4. Social Network");


            string options = Console.ReadLine();

            if (options == "1")
            {
                converter.ConvertDistance();
            }

            else if (options == "2")
            {
                index.CalcBMIIndex();
            }
            else if (options == "3")
            {
                studentGradesInvoker.Run();
            }
            else if (options == "4")
            {

            }

        }
    }
}


