﻿namespace exercises_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that picks a random number between 1 and 10.
            // Give the user 4 chances to guess the number.
            // If the user guesses the number, display “You won";
            // otherwise, display “You lost".
            // (To make sure the program is behaving correctly,
            // you can display the secret number on the console first.)

            var randomNumber = new Random().Next(1,10);
          

          
            
               for (int i = 0; i < 4; i++)
               {

                Console.Write("enter a guess number :");
                var guess = Convert.ToInt32(Console.ReadLine());
                if (randomNumber == guess)
                {
                    Console.WriteLine("you win!");
                }
               }
                  Console.WriteLine("your loss");
                  
                
            
        }
    }
}
