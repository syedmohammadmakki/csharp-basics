using System.Globalization;

namespace exercises_4_FromWorkingText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4- Write a program and ask the user to
            //enter a few words separated by a space.
            //Use the words to create a variable name with PascalCase.
            //For example, if the user types: "number of students",
            //display "NumberOfStudents".
            //Make sure that the program is not dependent on the input.
            //So, if the user types "NUMBER OF STUDENTS",
            //the program should still display "NumberOfStudents".


            Console.Write("enter a few words separated by a apace :");
            var userInput = Console.ReadLine();

            string[] newinput = userInput.Split(" ");

            string finalPascalString = "";

            for (int i = 0; i < newinput.Length; i++)
            {
                var firstLetter = newinput[i].Substring(0,1).ToUpper();
                var restOfName = newinput[i].Substring(1, newinput[i].Length - 1).ToLower();

                finalPascalString += firstLetter + restOfName;
            }
            Console.WriteLine(finalPascalString);

        }
    }
}
