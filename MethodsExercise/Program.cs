using System.Diagnostics.CodeAnalysis;

namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Subract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;

        }
        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        public static bool IsNumberEven(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            return false;

        }
        static void Main(string[] args)
        {
            // -------------------------------Exercise 1
            Console.WriteLine("Hello, What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName} What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is a great color.  What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"{userName}'s {color} {animal} likes to listen to {band}");

            // ---------------------------------Exercise 2

            var amountofCars = Sum(2, 4);

            var tires = Multiply(60, 2, 4);

            var numberOfTiresPerCar = Divide(80, 4);

            var airFresheners = Subract(10, 2);

            Console.WriteLine($"{IsNumberEven(9)}");


            Console.WriteLine($"We have {amountofCars} cars available");

            Console.WriteLine($"There are {tires} tires in stock");

            Console.WriteLine($"We have enought tires for {numberOfTiresPerCar} cars");

            Console.WriteLine($"We only have {airFresheners} left");

        }
    }
}
