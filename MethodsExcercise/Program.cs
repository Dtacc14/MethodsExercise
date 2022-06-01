using System;

namespace MethodsExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            Console.Write("What is your favorite color? ");
            var favoriteColor = Console.ReadLine();
            Console.Write("What is you favorite TV show? ");
            var favoriteShow = Console.ReadLine();
            Console.Write("What is you favorite food? ");
            var favoriteFood = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"This one person {name}, who is not very important, really liked watching {favoriteShow}.");
            Console.WriteLine($"One day while watching {favoriteShow}, {name} dropped {favoriteFood} on their shirt.");
            Console.WriteLine($"{name} really liked this shirt because it was their favorite color, {favoriteColor}. What an idiot...");
            Console.WriteLine();

            Console.WriteLine(add(4, 6));
            Console.WriteLine(subtract(9, 3));
            Console.WriteLine(multiply(3,5));
            Console.WriteLine(divide(16,4));
        }

        public static int add(int x, int y)
        {
            return x + y;
        }
        public static int subtract(int x, int y)
        {
            return x - y;
        }
        public static int multiply(int x, int y)
        {
            return x * y;
        }
        public static int divide(int x, int y)
        {
            return x / y;
        }
    }
}
