using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;

namespace Exercises_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 - Write a program and ask the user to enter the width and height of an image.
            // Then tell if the image is landscape or portrait.



            Console.Write("inter the width of image:");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("inter the height of image:");
            var height = Convert.ToInt32(Console.ReadLine());


            if (width > height)
            {
                Console.WriteLine("your image is landscape");
            }else if (height > width)
            {
                Console.WriteLine("your image is portarait");
            }



        }
    }
}
