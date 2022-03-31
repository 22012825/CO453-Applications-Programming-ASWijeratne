using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary><This App allows the user to convert distances measured in one unit of distance into another unit of distance, for example it will convert a distance measured in miles into the same distance measured in feet </>
    /// <author
    /// Amie version 0.1
    public class DistanceConverter
    {
        //Distance measured in miles
        private double miles;
        //Distance measured in feet
        private double feet;

       /// <summary>
       /// This method will input the distance measured in mukes
       /// calculate the same distance in feet, and output the 
       /// distance in feet.
       /// </summary>

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



        private void CalculateFeet();
        {

        }



        private void OutputFeet();







}
