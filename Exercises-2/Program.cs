using System.ComponentModel;

namespace Exercises_2
{
    internal class Program
    { 
        static void Main(string[] args)
        {

            //  2 - Write a program which takes two numbers
            //  from the console and displays the maximum of the two.

            Console.Write("inter a number first number :");
            var numberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("inter a second number :");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            if (numberOne > secondNumber)
            {
                Console.WriteLine(numberOne);
            }else if (secondNumber > numberOne)
            {
                Console.WriteLine(secondNumber);
            }

        }
    }
}
