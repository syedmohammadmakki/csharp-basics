using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;

namespace Exercises_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Write a program and ask the user to enter a number.
            //  Compute the factorial of the number and print it on the console. For example,
            //  if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            Console.Write("enter a number:");
            var number = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;

            for (int i = 1; i <=number; i++)
            
               factorial *= i;
                Console.WriteLine("{0}! = {1}", number, factorial);
            
        }
           
    }
}
