namespace workingWithText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Write a program and ask the user to enter a few numbers separated by a hyphen.
            //Work out if the numbers are consecutive.
            //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
            //display a message: "Consecutive"; otherwise, display "Not Consecutive".

            Console.Write("enter a few numbers separated by a hyphen. : ");
            var numbers = Console.ReadLine();

            string [] intsplit = numbers.Split('-');

          

            for (int i = 0; i <= intsplit.Length-1; i++)
            {
               if (i > 1 && (Convert.ToInt32(intsplit[i]) != Convert.ToInt32(intsplit[i - 1]) + 1))
                {
                    Console.WriteLine("not consecutive" );
                    break;
                }
               if (i == intsplit.Length - 1)
                {
                    Console.WriteLine("consecutive");
                }
            }
























            //  var listOfInts = new List<int>();

            //  foreach (var item in newList)
            //   {
            //  listOfInts.Add(int.Parse(item));
            //  }


        }
    }
}
