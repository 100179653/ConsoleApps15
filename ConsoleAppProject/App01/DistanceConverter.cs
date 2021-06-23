using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This application can convert distances like:
    /// metres to miles, miles to feet and feet to metres
    /// </summary>
    /// <author>
    /// Chris Edgley
    /// </author>
    public class DistanceConverter
    {
        // This is setting up editable variables that the
        // user can type in 
        private double miles;
        private double feet;
        private double metres;

        // This runs when the program starts, it outputs 
        // a heading and allows the user to select an option
        public void ConvertDistance()
        {
            OutputHeading();
            InputOptions();
        }

        // This method allows a user to select which
        // distance to convert from and to
        
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

        // This method allows a user to input metres and calculate
        // what that would be in miles, then showing it to the user

        private void InputMetres()
        {
            Console.WriteLine("So you have chosen Metres to Miles");
            Console.WriteLine("Please enter the number of metres: ");
            string input = Console.ReadLine();
            metres = Convert.ToDouble(input);
            CalculateMiles();
            OutputMiles();

        }

        // This method allows a user to input miles and calculate
        // what that would be in feet, then showing it to the user

        private void InputMiles()
        {
            Console.WriteLine("So you have chosen Miles to Feet");
            Console.WriteLine("Please enter the number of miles: ");
            string input = Console.ReadLine();
            miles = Convert.ToDouble(input);
            CalculateFeet();
            OutputFeet();
        }

        // This method allows a user to input feet and calculate
        // what that would be in metres, then showing it to the user

        private void InputFeet()
        {
            Console.WriteLine("So you have chosen Feet to Metres ");
            Console.WriteLine("Please enter the number of feet: ");
            string input = Console.ReadLine();
            feet = Convert.ToDouble(input);
            CalculateMetres();
            OutputMetres();
        }
        // This method allows the computer to "convert" miles to feet
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }
        // This method allows the computer to "convert" feet to metres
        private void CalculateMetres()
        {
            metres = feet / 3.241;
        }
        // This method allows the computer to "convert" metres to miles
        private void CalculateMiles()
        {
            miles = metres / 1609;
        }

        // this method outputs the calculation of miles to feet
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }
        // this method outputs the calculation of feet to metres
        private void OutputMetres()
        {
            Console.WriteLine(feet + " feet is " + metres + " metres!");
        }
        // this method outputs the calculation of metres to miles
        private void OutputMiles()
        {
            Console.WriteLine(metres + " metres is " + miles + " miles!");

        }
        // this method outputs the heading for the user  to see when they load
        // the program

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
