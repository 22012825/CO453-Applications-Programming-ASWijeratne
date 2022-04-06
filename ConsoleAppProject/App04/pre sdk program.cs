using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Amie Shanaya Wijeratne 22012825
    /// </summary>
    public static class Program
    {
        private static DistanceConverter converter = new DistanceConverter ();

        private static BMI calculator = new BMI();

        private static StudentGrades grades = new StudentGrades();

        private static NetworkApp app04 = new NetworkApp ();

        public static BMI BMI
        {
            get => default; 
        }

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
            Console.WriteLine("        by Amie   ");
            Console.Beep();

            int choiceNo = ConsoleHelper.SelectChoice(choiceNo);

            if (choiceNo == 1)
            {
                converter.ConvertDistance();
            }
            else if (choiceNo == 2)
            {
                calculator.CalculateIndex();
            }
            else if (choiceNo == 3)
            {
                app04.DisplayMenu();
            }
            else if (choiceNo == 4)
            {
            }
            else Console.WriteLine("Invalid Choice!");

        }
    }
}
