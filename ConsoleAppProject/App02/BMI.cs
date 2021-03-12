using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Chris Edgley
    /// </author>
    public class BMI
    {
        //comment here     
        public const double UNDERWEIGHT = 18.50;
        public const double NORMAL = 24.99;
        public const double OVERWEIGHT= 29.99;
        public const double OBESEI = 34.99;
        public const double OBESEII = 39.99;
        public const double OBESEIII = 40.00;
        

        //comments here
        public const int PoundsToStones = 14;
        public const int InchesToFeet = 12;


        private double height;
        private double weight;

        public double BMIIndex = 0.00;

        public void CalcBMIIndex()
        {
            OutputHeader();
            
            int Unit = GetUnits();
            if (Unit == 1)
            {
                GetMetres();
                GetKG();
                CalculateMetricBMI();
            } 
            else if (Unit == 2)
            {
                GetInches();
                GetPounds();
                CalculateImperialBMI();
            }
            
            OutputHealthMessage(BMIIndex);
            OutputBAME();
        }

        public void OutputHeader()
        {
            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("-  BMI Calculator  -");
            Console.WriteLine("-        By       -");
            Console.WriteLine("--------------------------------\n");
        }

        private int GetUnits()
        {
            int unit = 0;
            Console.WriteLine("Enter Metric or Imperial : ");
            string value = Console.ReadLine();
            if (String.Equals(value, "metric")) unit = 1;
            else if (String.Equals(value, "imperial")) unit = 2;
            return unit;
        }

        private void GetMetres()
        {
            Console.Write("Please enter your height in metres : ");
            String value = Console.ReadLine();
            height = Convert.ToDouble(value);
        }

        private void GetKG()
        {
            Console.Write("Please enter your weight in kg: ");
            String value = Console.ReadLine();
            weight = Convert.ToDouble(value);
        }

        private void CalculateMetricBMI()
        {
            BMIIndex = weight / (height * height);
        }

        private void OutputHealthMessage(double BMIIndex)
        {
            Console.Write("Your BMI is:");
            Console.WriteLine(BMIIndex);
            if (BMIIndex < 18.50) Console.WriteLine("You are underweight");
            else if (BMIIndex < 25) Console.WriteLine("You are of a normal weight!");
            else if (BMIIndex < 30) Console.WriteLine("You are overweight");
            else if (BMIIndex < 35) Console.WriteLine("You are obese");
            else if (BMIIndex < 40) Console.WriteLine("You are morbidly obese");
            else Console.WriteLine("Consult a Doctor Straight Away!");

        }

        private void GetInches()
        {
            Console.Write("Please enter your height in inches : ");
            String value = Console.ReadLine();
            height = Convert.ToDouble(value);
        }

        private void GetPounds()
        {
            Console.Write("Please enter your weight in pounds: ");
            String value = Console.ReadLine();
            weight = Convert.ToDouble(value);
        }

        private void CalculateImperialBMI()
        {
            BMIIndex = Math.Floor((double) weight / (height * height) * 703 );
            // BMIIndex = weight * 703 / (height * height);
        }

        public void OutputBAME()
        {
            Console.Write("You have selected that you ");
            Console.WriteLine("are of a higher risk group.");
            Console.Write("This means that this BMI test ");
            Console.WriteLine("may not be suitable for you.");
            Console.Write("Please consult your Doctor for ");
            Console.WriteLine("a BMI test based upon your circumstances.");
        }

        
            
    }
}

