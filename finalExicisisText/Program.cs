namespace finalExicisisText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2- Write a program that
            //reads a text file and displays the longest word in the file.
          




            var path = @"C:\Source\csharp-basics\New Text Document.txt";
            var contain = File.ReadAllLines(path);
           string ReadText = string.Join(". ", contain);
           var finalvalue = ReadText.Split(" ");
            var largest = "";




            foreach (var item in finalvalue)
            {
                if (item.Length > largest.Length)
                {
                    largest = item;
                }
            }

            Console.WriteLine(largest);









        }
    }
}
