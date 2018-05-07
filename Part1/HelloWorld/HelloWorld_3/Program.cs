using System;

namespace HelloWorld_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string age;
            int convertedAge;

            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            Console.Write("Please enter you age: ");
            age = Console.ReadLine();
            convertedAge = /*Convert age here*/;

            Console.WriteLine($"Hello {name}.  You are {convertedAge}");

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}