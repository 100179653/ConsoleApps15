﻿namespace ConsoleAppProject.Common
{
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is a wrapping class of all nested class responsible for constants for each app
    /// </summary>
    /// <author>Chris Edgley</author>
    /// <version>2.0</version>
    public static class Constants
    {
        /// <summary>
        /// This class keeps all constants that are used in more than one program
        /// </summary>
        public static class Common
        {
            /// <summary>
            /// Print out this message when the user choice is invalid
            /// </summary>
            public const string INVALID_CHOICE_MSG = "\n\rInvalid choice!";
            /// <summary>
            ///  Print out this message when the user input is not valid in a given context
            /// </summary>
            public const string INVALID_INPUT_MSG = "\n\rInvalid input!";
            /// <summary>
            /// Print out this message when the user should choose 
            /// </summary>
            public const string INPUT_CHOICE_MSG = "Please enter your choice > ";
            /// <summary>
            /// Print out this message when the user select a distance unit
            /// </summary>
            public const string SELECTION_MSG = "\n\rYou have selected ";
            /// <summary>
            /// Print out this message when the menu is loaded
            /// </summary>
            public const string MENU_HEADING = "BNU CO453 Applications Programming 2020-2021!\n\r" +
                                               "---------------------------------------------";
            public const string NULL_OR_EMPTY_MSG = "The value cannot be null or empty.";
        }

        /// <summary>
        /// This class keeps all constants of Distance Converter program
        /// </summary>
        public static class DistanceConverter
        {
            /// <summary>
            /// The name of this app
            /// </summary>
            public const string PROGRAM_NAME = "Distance Converter";
            /// <summary>
            /// Print out this message when the distance is negative number
            /// </summary>
            public const string NEGATIVE_DISTANCE_MSG = "\n\rDistance cannot be less than zero!";
            /// <summary>
            /// User choice for feet
            /// </summary>
            public const int FEET = 1;
            /// <summary>
            /// User choice for metres
            /// </summary>
            public const int METRES = 2;
            /// <summary>
            /// User choice for miles
            /// </summary>
            public const int MILES = 3;
            /// <summary>
            /// 1 mile is 5280 feet
            /// </summary>
            public const double MILE_IN_FEET = 5280;
            /// <summary>
            /// 1 foot is 0.3048 metres
            /// </summary>
            public const double FEET_IN_METRES = 0.3048;
            /// <summary>
            /// 1 foot is 0.000189394 miles
            /// </summary>
            public const double FEET_IN_MILES = 0.00018939;
            /// <summary>
            /// 1 metre is 0.000621371 miles
            /// </summary>
            public const double METRES_IN_MILES = 0.00062137;
            /// <summary>
            /// 1 metre is 3.28084 feet
            /// </summary>
            public const double METRES_IN_FEET = 3.28084;

            /// <summary>
            /// Print out this message when the user should select one of 3 options
            /// </summary>
            /// <param name="direction">Unit to convert from or to</param>
            /// <returns></returns>
            public static string SelectUnitMsg(string direction)
                => $"\n\rSelect distance unit to convert {direction} >\n\r" +
                    "\n\r1. Feet" +
                    "\n\r2. Metres" +
                    "\n\r3. Miles";

            /// <summary>
            /// Print out this message after two units are selected
            /// </summary>
            /// <param name="fromUnit">Convert from this unit</param>
            /// <param name="toUnit">Convert to this unit</param>
            /// <returns></returns>
            public static string ConvertMsg(string fromUnit, string toUnit)
                => $"\n\rConverting from {fromUnit} to {toUnit}";

            /// <summary>
            ///  Print out this message when the user should enter distance
            /// </summary>
            /// <param name="fromUnit">Distance in this unit (miles, feet or metres)</param>
            /// <returns></returns>
            public static string EnterDistMsg(string fromUnit)
                => $"\n\rPlease enter distance in {fromUnit} > ";
        }

        /// <summary>
        /// This class keeps all constants of BMI Calculator program
        /// </summary>
        public static class BMICalculator
        {
            /// <summary>
            /// The name of this app
            /// </summary>
            public const string PROGRAM_NAME = "Body Mass Index Calculator";
            /// <summary>
            /// The description of this app
            /// </summary>
            public const string DESCRIPTION =
                "Your BMI, or Body Mass Index, is a measure of your weight compared to your height.\n\r" +
                "Accurate assessments of obesity are important, as being overweight or obese significantly increases \n\r" +
                "your risk of a variety of medical conditions including type 2 diabetes, heart disease and cancer.\n\r" +
                "\n\r" +
                "For most adults, BMI gives a good estimate of your weight-related health risks. If your BMI is\n\r" +
                "over 35, your weight is definitely putting your health at risk, regardless of the factors below.\n\r" +
                "However, there are some situations where BMI may underestimate or overestimate these risks in\n\r" +
                "the 25-35 BMI range. The main ones are:\n\r" +
                "1. Children \n\r" +
                "2. Pregnant women\n\r" +
                "3. Muscle Builders\n\r" +
                "4. BAME: Black, Asian and other minority ethnic groups.\n\r";
            /// <summary>
            /// Print out this message when the user choose unit type
            /// </summary>
            public const string SELECT_UNIT_MSG = "Please choose an unit type:\n\r" +
                "   1. Imperial Units\n\r" +
                "   2. Metric Units\n\r";
            /// <summary>
            /// Print out this message when the weight is negative number
            /// </summary>
            public const string NEGATIVE_WEIGHT_MSG = "Weight cannot be less than zero!\n\r";
            /// <summary>
            /// Print out this message when the height is negative number
            /// </summary>
            public const string NEGATIVE_HEIGHT_MSG = "Height cannot be less than zero!\n\r";
            /// <summary>
            /// Print out this message when the user should input its weight
            /// </summary>
            public const string INPUT_WEIGHT_MSG = "Please enter your weight in ";
            /// <summary>
            /// Print out this message when the user should input its height
            /// </summary>
            public const string INPUT_HEIGHT_MSG = "Please enter your height in ";
            /// <summary>
            /// 1 stone is 14 pounds
            /// </summary>
            public const int STONE_TO_POUNDS = 14;
            /// <summary>
            /// 1 foot is 12 inches
            /// </summary>
            public const int FOOT_TO_INCHES = 12;
            /// <summary>
            /// Underweight weight status
            /// </summary>
            public const string UNDERWEIGHT = "Underweight";
            /// <summary>
            /// Normal weight status
            /// </summary>
            public const string NORMAL = "Normal";
            /// <summary>
            /// Overweight weight status
            /// </summary>
            public const string OVERWEIGHT = "Overweight";
            /// <summary>
            /// Obese class I weight status
            /// </summary>
            public const string OBESE_CLASS_I = "Obese class I";
            /// <summary>
            /// Obese class II weight status
            /// </summary>
            public const string OBESE_CLASS_II = "Obese class II";
            /// <summary>
            /// Obese class III weight status
            /// </summary>
            public const string OBESE_CLASS_III = "Obese class III";
            /// <summary>
            /// Weight status table according to WHO
            /// </summary>
            public const string WEIGHT_STATUS_TABLE =
                "| WHO Weight Status |  BMI kg/m2  |\n\r" +
                "|---------------------------------|\n\r" +
                "| Underweight       |  < 18.50    |\n\r" +
                "| Normal            | 18.5 - 24.9 |\n\r" +
                "| Overweight        | 25.0 - 29.9 |\n\r" +
                "| Obese Class I     | 30.0 - 34.9 |\n\r" +
                "| Obese Class II    | 35.0 - 39.9 |\n\r" +
                "| Obese Class III   |	>= 40.0   |\n\r";
            /// <summary>
            /// Print out this message in the result
            /// </summary>
            public const string BAME_MSG =
                "If you are Black, Asian or other ethnic groups,\n\r" +
                "you have a higher risk.\n\r\n\r" +
                "Adults 23 or more are at increased risk\n\r" +
                "Adults 27.5 or more are at high risk\n\r\n\r";
            /// <summary>
            /// Print out this error message in the web part when the stones field is zero
            /// </summary>
            public const string ZERO_STONES_ERROR_MSG = "Stones cannot be zero!";
            /// <summary>
            /// Print out this error message in the web part when the stones field is zero
            /// </summary>
            public const string ZERO_KG_ERROR_MSG = "Kg cannot be zero!";
            /// <summary>
            /// Print out this error message in the web part when the stones field is zero
            /// </summary>
            public const string ZERO_FEET_ERROR_MSG = "Feet cannot be zero!";
            /// <summary>
            /// Print out this error message in the web part when the stones field is zero
            /// </summary>
            public const string ZERO_METRES_ERROR_MSG = "Metres cannot be zero!";
            /// <summary>
            /// Print out this message when the user submit the form with text in some of the fields
            /// </summary>
            public const string TEXT_NOT_ALLOWED_ERROR_MSG = "Allowed only digits with floating point!";
            /// <summary>
            /// Print out this message when the UnitType prop is not set
            /// </summary>
            public const string UNIT_TYPE_DEFAULT_VALUE_ERROR = "The UnitType property is not set!";

            /// <summary>
            /// Print out this message when the user already selected an unit type
            /// </summary>
            /// <param name="unitType">Unit type can be Imperial and Metric</param>
            /// <returns>Message</returns>
            public static string SelectedUnitMsg(string unitType)
            {
                var stringBuilder = new StringBuilder();

                stringBuilder.Append($"Selected {unitType.ToLower()} units.\n\r");

                switch (unitType)
                {
                    case "Imperial":
                        stringBuilder.Append(" - weight in stone and pounds\n\r");
                        stringBuilder.Append(" - height in feet and inches\n\r");
                        break;
                    case "Metric":
                        stringBuilder.Append(" - weight in kg\n\r");
                        stringBuilder.Append(" - height in metres\n\r");
                        break;
                }

                return stringBuilder.ToString();
            }


        }

        public static class StudentGrades
        {
            /// <summary>
            /// The name of this app
            /// </summary>
            public const string PROGRAM_NAME = "Student Grades";
            /// <summary>
            /// The description of this app
            /// </summary>
            public const string DESCRIPTION =
                "The first version of this application will allow a tutor\n\r" +
                "to enter a single mark of each of a list of students\n\r" +
                "and it will convert that mark into a grade.\n\r" +
                "The application will then be able to calculate simple statistics\n\r" +
                "and also calculate and display a student grade profile.\n\r";
            /// <summary>
            /// Print out this message when the first or last name of a student is less than 2 symbols long
            /// </summary>
            public const string INVALID_STUDENT_NAME_MSG = "The student name cannot be less than two symbols long.";
            /// <summary>
            /// Print out this message when the first or last name of a student is less than 2 symbols long
            /// </summary>
            public const string OUT_OF_RANGE_MARK_MSG = "The mark cannot be less than zero or more than 100.";
            /// <summary>
            /// The mininmum length of a student name
            /// </summary>
            public const int MIN_NAME_LENGTH = 2;
            public const string CLI_HINT_USAGE_MSG = "Please choose one of the commands as type its number";
            /// <summary>
            /// Print out this message when the user should choose a command
            /// </summary>
            /// <param name="commandsNames">Names of all available commands</param>
            /// <returns></returns>
            public static string ChooseOptionMsg(List<string> commandsNames)
            {
                var stringBuilder = new StringBuilder();

                stringBuilder.Append("Please choose an option as type the number:\n\r");

                for (int i = 0; i < commandsNames.Count; i++)
                {
                    stringBuilder.Append($"{commandsNames[i]}\n\r");
                }
                return stringBuilder.ToString();
            }
            /// <summary>
            /// Print out this message when the student`s mark is updated successfully
            /// </summary>
            /// <param name="fullName">The full name of a student</param>
            /// <param name="mark">The mark of a student</param>
            /// <returns></returns>
            public static string UpdateStudentMarkMsg(string fullName, int mark)
                => $"{fullName} was updated with mark {mark}%\n\r";
            /// <summary>
            /// Print out this message when the user invoke grades profile command
            /// </summary>
            /// <param name="gradeProfiles">Grade profiles in percents</param>
            /// <returns>String representation of all grade profiles</returns>
            public static string GradeProfilesMsg(double[] gradeProfiles) 
            {
                var stringBuilder = new StringBuilder();

                stringBuilder.Append(
                    "Statistic: \n\r" +
                    "--------------------------------\n\r" +
                    $"{gradeProfiles[4]:f2}%  | A | First class       \n\r" +
                    $"{gradeProfiles[3]:f2}%  | B | Upper Second Class\n\r" +
                    $"{gradeProfiles[2]:f2}%  | C | Lower Second Class\n\r" +
                    $"{gradeProfiles[1]:f2}%  | D | Third Class       \n\r" +
                    $"{gradeProfiles[0]:f2}%  | F | Fail              \n\r");

                if (gradeProfiles[5] != 0)
                {
                    stringBuilder.Append($"{gradeProfiles[5]:f2}%  | - | No marked         \n\r");
                }

                return stringBuilder.ToString();
            }
        }
    }
}
