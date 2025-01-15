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

     


            Console.Write("enter your car speed :");
            var carSpeed = Convert.ToDouble(Console.ReadLine());

            var CitySpeedLimit = 70;
            var count = 0;

            if (carSpeed < CitySpeedLimit)
            {
                Console.WriteLine("your speed is ok.. ");
            }else if (carSpeed > CitySpeedLimit)
            {
                Console.WriteLine("one point demerit  ..... ");
            } while (count > 0)
            {
                count++;
                if (count > 12)
                {
                    Console.WriteLine("your license suspended");
                }
            }
















        }
    }
}
