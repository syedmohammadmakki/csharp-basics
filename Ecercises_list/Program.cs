namespace Ecercises_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inter your name: ");
            var name = Console.ReadLine();

            var array = new char[name.Length];

            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];
            Console.Write(array);

        }
    }
}
