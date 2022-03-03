using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary><This App allows the user to convert distances measured in one unit of distance into another unit of distance, for example it will convert a distance measured in miles into the same distance measured in feet </>

    /// Amie version 0.1
    public static class Program
    public class DistanceConverter
    {
        private double miles;
        private double feet;

        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }
        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary> 
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles >");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }
        private void CalculateFeet()
        {

        }

        private void OutputFeet()







}
