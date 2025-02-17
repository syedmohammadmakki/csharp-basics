using System.ComponentModel;

namespace exercises_5_FromList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5- Write a program and ask the user to supply a list of comma separated numbers
            //(e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers,
            //display "Invalid List" and ask the user to re-try; otherwise,
            //display the 3 smallest numbers in the list.



            Console.Write("supply a list of comma separated numbers :");
            var userNumber = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(userNumber))
            {
                Console.WriteLine("invalid list try again");
                return;
            }
            var newList = userNumber.Split(',');
            var listOfInts = new List<int>();

            foreach (var item in newList)
            {
                listOfInts.Add(int.Parse(item));
            }

            listOfInts.Sort();

            if (listOfInts.Count() < 4)
            {
                Console.WriteLine("invalid list try again");
            } else
            {
                Console.WriteLine(listOfInts[0]);
                Console.WriteLine(listOfInts[1]);
                Console.WriteLine(listOfInts[2]);
            }
        }
    }
}
