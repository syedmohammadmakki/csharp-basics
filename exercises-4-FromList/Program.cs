using System.ComponentModel;

namespace exercises_4_FromList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4- Write a program and ask the user to continuously enter a number
            //or type "Quit" to exit.
            //The list of numbers may include duplicates.
            //Display the unique numbers that the user has entered.


            List<int> lists = new List<int>();
        
           

            while (true)
            {
                Console.Write("enter a number or quit to exit :");
                var number = (Console.ReadLine());
                if (number == "quit")
                {
                    break;
                }

              
                //foreach (var stringToint in number)
                //{
                //    listOfInts.Add(int.TryParse);
                //}

            }

                var listOfInts = new List<int>();

                foreach (int item in lists)
                {

                }
              
        }
    }
}
