using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System;

namespace exercises_5_fromText
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  5 - Write a program and ask the user to enter an English word
            //  .Count the number of vowels(a, e, o, u, i) in the word.
            //  So, if the user enters "inadequate",
            //  the program should display 6 on the console.


            Console.Write("enter a word :");
            var userInput = Console.ReadLine();

            var totalCount = 0; 
            
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i]=='a'
                   || userInput[i]=='e'
                   ||  userInput[i]=='i'
                   || userInput[i]=='o'
                   || userInput[i]=='u')
                   
                {
                    totalCount++;
                }
            }
                Console.WriteLine("Your total number of vowels is: {0}", totalCount);
                                                                






        }
    }
}
