using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class DistanceConverter
    {
        private double miles;
        private double feet;
        private double metres;


        public void ConvertDistance()
        {
            OutputHeading();
            InputOptions();
        }

        public void InputOptions()
        {
            Console.Write("Please state what you wish to convert: ");

            String input = Console.ReadLine();
            switch (input)
            {

                case "1": InputMetres();
                    break;

                case "2": InputMiles();
                    break;

                case "3": InputFeet();
                    break;

                default: Console.Write("Please select an option from 1-3!");
                   break;
            }
        }

        private void InputMetres()
        {
            Console.WriteLine("So you have chosen Metres to Miles");
            Console.WriteLine("Please enter the number of metres: ");
            string input = Console.ReadLine();
            metres = Convert.ToDouble(input);
            CalculateMiles();
            OutputMiles();

        }

        private void InputMiles()
        {
            Console.WriteLine("So you have chosen Miles to Feet");
            Console.WriteLine("Please enter the number of miles: ");
            string input = Console.ReadLine();
            miles = Convert.ToDouble(input);
            CalculateFeet();
            OutputFeet();
        }

        private void InputFeet()
        {
            Console.WriteLine("So you have chosen Feet to Metres ");
            Console.WriteLine("Please enter the number of miles: ");
            string input = Console.ReadLine();
            feet = Convert.ToDouble(input);
            CalculateMetres();
            OutputMetres();
        }

        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        private void CalculateMetres()
        {
            metres = feet / 3.241;
        }

        private void CalculateMiles()
        {
            miles = metres / 1609;
        }


        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }

        private void OutputMetres()
        {
            Console.WriteLine(feet + " feet is " + metres + " metres!");
        }

        private void OutputMiles()
        {
            Console.WriteLine(metres + " metres is " + miles + " miles!");

        }
        private void OutputHeading()
        {
            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("-   Converting Miles to Feet   -");
            Console.WriteLine("-  Converting Metres to Miles  -");
            Console.WriteLine("-  Converting Feet to Metres   -");
            Console.WriteLine("-        By Chris Edgley       -");
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("Press the 1 key for Metres to Miles!");
            Console.WriteLine("Press the 2 key for Miles to Feet!");
            Console.WriteLine("Press the 3 key for Feet to Metres!\n");
        }
    }
}
