﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace Csharp_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exercises-1
           // 1 - Write a program and ask the user to enter a number.
           // The number should be between 1 to 10.If the user enters a valid number,
           // display "Valid" on the console.Otherwise, display "Invalid".
           // (This logic is used a lot in applications where values entered into input boxes need to be validated.)

            Console.Write("inter a number :");
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
