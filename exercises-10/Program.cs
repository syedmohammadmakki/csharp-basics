namespace exercises_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a series of numbers separated by comma.
            //Find the maximum of the numbers and display it on the console. For example,
            //if the user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.Write("enter a numeber separated by comma. :");
            var userNumber = Console.ReadLine();

            var numbers = userNumber.Split(',');

            int max = 0;

            foreach (var number in numbers)
            {
                var finalNumber = Convert.ToInt32(number);
                if (finalNumber > max)
                {
                   max = finalNumber;
                }
            }
            Console.WriteLine(max);



  





        }
    }
}
   