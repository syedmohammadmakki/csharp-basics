using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace exercises_3_fromText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3- Write a program and ask the user to
            //enter a time value in the 24-hour time format (e.g. 19:00).
            //A valid time should be between 00:00 and 23:59. If the time is valid,
            //display "Ok"; otherwise, display "Invalid Time".
            //If the user doesn't provide any values,
            //consider it as invalid time.

            Console.Write("enter a time value in the 24-hour time format (e.g.19:00) :");
            var userINput = Console.ReadLine();

            

            var currentTime = DateTime.Now;

            Console.WriteLine(currentTime.ToString());

            if (userINput != currentTime.ToString())
            {
                Console.WriteLine("your time is not valid");
            }  else
            {
                Console.WriteLine("okay" );
            }
           


        }
    }
}
