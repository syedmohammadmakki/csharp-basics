namespace exercises_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2- Write a program and continuously ask the user to enter a number
            //or "ok" to exit. Calculate the sum of all the previously entered numbers
            //and display it on the console.


            var sum = 0;    
            while (true)
            {
                Console.Write("enter a number or 'ok' to exit : ");
                var userNumber = Console.ReadLine();

                 if (userNumber.ToLower() == "ok")
                 {
                    break;
                }
                sum += Convert.ToInt32(userNumber);
            }
            Console.WriteLine("sum of all previously entered numbers :" + sum);


        }
    }
}
