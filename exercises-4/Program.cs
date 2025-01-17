using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System;

namespace exercises_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // exercises -4
            //  Your job is to write a program for a speed camera.*-
            //  For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
            //  Write a program that asks the user to enter the speed limit.Once set,
            //  the program asks for the speed of a car.If the user enters a value less than the speed limit,
            //  program should display Ok on the console.

            //  If the value is above the speed limit, the program should calculate the number of demerit points.
            //  For every 5km / hr above the speed limit,
            //  1 demerit points should be incurred and displayed on the console.
            //  If the number of demerit points is above 12, the program should display License Suspended.

            var citySpeedLimit = 70;
            var demeritCount = 0;
            
            while (true)
            {
                Console.Write("enter your car speed :");
                var carSpeed = Convert.ToInt32(Console.ReadLine());

                if (carSpeed < citySpeedLimit)
                {
                    Console.WriteLine("your speed is ok.. ");
                }else if (carSpeed > citySpeedLimit)
                {
                    int extraSpeed = carSpeed - citySpeedLimit;
                    int numberOfDemerit = extraSpeed / 5;
                    Console.WriteLine($"{numberOfDemerit} point demerit  ..... ");
                    demeritCount = demeritCount + numberOfDemerit;
                }
              
                if (demeritCount > 12)
                {
                    Console.WriteLine("your license suspended");
                    break;
                }
            }
        }
    }
}
