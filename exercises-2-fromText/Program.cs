namespace exercises_2_fromText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2- Write a program and ask the user to enter a few numbers
            //separated by a hyphen. If the user simply presses Enter,
            //without supplying an input, exit immediately; otherwise,
            //check to see if there are duplicates. If so,
            //display "Duplicate" on the console.

            while (true)
            {
                Console.Write("enter a few numbers separated by hyphen :");
                var name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    break;
                }

                var newstring =  name.Split('-');
                
                // First method
                for (int i = 0; i < newstring.Length; i++)
                {
                    var numberOfOccurences = newstring
                        .Where(x => x.Equals(newstring[i]))
                        .Count();

                    if (numberOfOccurences > 1)
                    {
                        Console.WriteLine("Duplicate");
                        break;
                    }
                }

                // Second method
                var intList = newstring.Select(x => int.Parse(x)).ToList();
                intList.Sort();
                for (int i = 0; i < intList.Count-1; i++)
                {
                    if (intList[i].Equals(intList[i+1]))
                    {
                        Console.WriteLine("Duplicate");
                        break;
                    }
                }
            }

       
        }
    }
}
