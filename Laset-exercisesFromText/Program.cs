using System;

namespace Laset_exercisesFromText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Write a program that reads a text file and displays the number of words.

            Console.WriteLine("reads a text file ");

            var path = @"C:\Source\csharp-basics\New Text Document.txt";
            var contain = File.ReadAllLines(path);
           var ReadText =string.Join(". ", contain);
           var displayText = ReadText.Split(",");


            Console.WriteLine(displayText.Length);
            Console.WriteLine(displayText[0]);



















        }
    }
}
