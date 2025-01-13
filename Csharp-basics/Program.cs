namespace Csharp_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inter a nuber :");
            var number = Convert.ToInt32(Console.ReadLine());

           if (number <= 10)
            {
                Console.WriteLine("valed");

            }else if (number >11) 
            {
                Console.WriteLine("invalid");
            }else
            {
                Console.WriteLine("please inter  a nuber ");
            }
        }
    }
}
