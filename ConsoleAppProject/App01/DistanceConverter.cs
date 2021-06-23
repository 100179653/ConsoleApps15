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

                case "1":MetresToMiles();
                    break;

                case "2": FeetToMiles();
                    break;

                case "3": MetresToFeet();
                    break;
                case "4": MilesToMetres();
                    break;
                case "5": MilesToFeet();
                    break;
                case "6": FeetToMetres();
                    break;
                default: Console.Write("Please select an option from 1-6!");
                    break;
            }
        }

        // This method allows a user to input metres and calculate
        // what that would be in miles, then showing it to the user

        private void MilesToMetres()
        {
            Console.WriteLine("So you have chosen Metres to Miles");
            Console.WriteLine("Please enter the number of metres: ");
            string input = Console.ReadLine();
            metres = Convert.ToDouble(input);
            CalculateMetresToMiles();
            OutputMetresToMiles();

        }
        // This method allows a user to input metres and calculate
        // what that would be in miles, then showing it to the user
        private void MetresToMiles()
        {
            Console.WriteLine("So you have chosen Miles to Metres");
            Console.WriteLine("Please enter the number of miles: ");
            string input = Console.ReadLine();
            miles = Convert.ToDouble(input);
            CalculateMilesToMetres();
            OutputMilesToMetres();

        }
        // This method allows a user to input miles and calculate
        // what that would be in feet, then showing it to the user

        private void MilesToFeet()
        {
            Console.WriteLine("So you have chosen Miles to Feet");
            Console.WriteLine("Please enter the number of miles: ");
            string input = Console.ReadLine();
            miles = Convert.ToDouble(input);
            CalculateMilesToFeet();
            OutputMilesToFeet();
        }
        // This method allows a user to input feet and calculate
        // what that would be in miles, then showing it to the user
        private void FeetToMiles()
        {
            Console.WriteLine("So you have chosen Feet to Miles");
            Console.WriteLine("Please enter the number of Feet: ");
            string input = Console.ReadLine();
            feet = Convert.ToDouble(input);
            CalculateFeetToMiles();
            OutputFeetToMiles();
        }

        // This method allows a user to input feet and calculate
        // what that would be in metres, then showing it to the user

        private void FeetToMetres()
        {
            Console.WriteLine("So you have chosen Feet to Metres ");
            Console.WriteLine("Please enter the number of feet: ");
            string input = Console.ReadLine();
            feet = Convert.ToDouble(input);
            CalculateFeetToMetres();
            OutputFeetToMetres();
        }

        // This method allows a user to input metres and calculate
        // what that would be in feet, then showing it to the user
        private void MetresToFeet()
        {
            Console.WriteLine("So you have chosen Metres to Feet ");
            Console.WriteLine("Please enter the number of metres: ");
            string input = Console.ReadLine();
            metres = Convert.ToDouble(input);
            CalculateMetresToFeet();
            OutputMetresToFeet();
        }

        // This method allows the computer to "convert" miles to feet
        private void CalculateMilesToFeet()
        {
            feet = miles * 5280;
        }
        // This method allows the computer to "convert" feet to metres
        private void CalculateFeetToMetres()
        {
            metres = feet / 3.28084;
        }
        // This method allows the computer to "convert" metres to miles
        private void CalculateMetresToMiles()
        {
            miles = metres / 1609.344;
        }
        // This method allows the computer to "convert" miles to metres
        private void CalculateMilesToMetres()
        {
            metres = miles * 1609.344;
        }
        // This method allows the computer to "convert" feet to miles
        private void CalculateFeetToMiles()
        {
            miles = feet / 5280;
        }
        // This method allows the computer to "convert" metres to feet
        private void CalculateMetresToFeet()
        {
            feet = metres * 3.28084;
        }
        // this method outputs the calculation of miles to feet
        private void OutputMilesToFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }
        // this method outputs the calculation of feet to metres
        private void OutputFeetToMetres()
        {
            Console.WriteLine(feet + " feet is " + metres + " metres!");
        }
        // this method outputs the calculation of metres to miles
        private void OutputMetresToMiles()
        {
            Console.WriteLine(metres + " metres is " + miles + " miles!");

        }
        // this method outputs to calculation of feet to miles
        private void OutputFeetToMiles()
        {
            Console.WriteLine(feet + " feet is " + miles + " miles!");
        }
        // this method outputs the calculation of metres to feet 
        private void OutputMetresToFeet()
        {
            Console.WriteLine(metres + " metres is " + feet + " feet!");
        }
        // this method outputs the calculation of miles to metres
        private void OutputMilesToMetres()
        {
            Console.WriteLine(miles + " miles is " + metres + " metres!");

        }
        // this method outputs the heading for the user to see when they load
        // the program

        private void OutputHeading()
        {
            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("-      Distance Converter      -");
            Console.WriteLine("-        By Chris Edgley       -");
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("Press the 1 key for Miles to Metres!");
            Console.WriteLine("Press the 2 key for Feet to Miles!");
            Console.WriteLine("Press the 3 key for Metres to Feet!");
            Console.WriteLine("Press the 4 key for Metres to Miles!");
            Console.WriteLine("Press the 5 key for Miles to Feet!");
            Console.WriteLine("Press the 6 key for Feet to Metres!\n");

        }
    }
}
