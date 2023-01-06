namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Hello, What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName} What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is a great color.  What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"{userName}'s {color} {animal} likes to listen to {band}");



        }
    }
}
