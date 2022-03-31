using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Amie Shanaya Wijeratne 22012825 05/02/2022
    /// </summary>
    public static class Program
    { 
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
            Console.WriteLine("        by Amie   ");
            Console.Beep();

            DistanceConverter converter = new DistanceConverter();
            converter.Run();
        }
    }
}
