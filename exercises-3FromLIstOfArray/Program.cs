namespace exercises_3FromLIstOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3- Write a program and ask the user to enter 5 numbers.
            //If a number has been previously entered,
            //display an error message and ask the user to re-try.
            //Once the user successfully enters 5 unique numbers,
            //sort them and display the result on the console.

            List<int> numbers = new List<int>();

            int num = 0;

            
            while (num < 5)
            {
                Console.Write("enter a numbers :");
                 
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(userNumber))
                {
                    Console.WriteLine("you enter a repeated number please try again");
                }
                else
                {
                    numbers.Add(userNumber);
                    num++;
                }
            }
            numbers.Sort();
          //  Console.WriteLine(string.Join(",",numbers));
          foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
