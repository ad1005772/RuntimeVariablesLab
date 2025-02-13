using System;

namespace RuntimeVariablesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string message = "Initial message";

            for (int i = 0; i < 5; i++)
            {
                counter += i;
                Console.WriteLine($"Loop {i}, Counter: {counter}");
            }

            Console.WriteLine($"Final Message: {message}");
            Console.ReadLine();
        }
    }
}

