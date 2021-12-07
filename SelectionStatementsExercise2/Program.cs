using System;

namespace SelectionStatementsExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Try to guess my favorite number!");
            var userInput = int.Parse(Console.ReadLine());

            if (favNumber > userInput)
            {
                Console.WriteLine("Too low.");
            }
            else if (favNumber < userInput)
            {
                Console.WriteLine("Too high.");
            }
            else
            {
                Console.WriteLine("Congratulations! That's the number!");
            }
            Console.WriteLine("What is your favorite school subject?");
            var schoolsubject = Console.ReadLine();
            switch (schoolsubject)
            {
                case "Math":
                    Console.WriteLine($"{schoolsubject} is my favorite class.");
                    break;
                case "Science":
                    Console.WriteLine($"{schoolsubject} is so much fun to learn about.");
                    break;
                case "Theater":
                    Console.WriteLine($"My teacher is very knowledgeable about {schoolsubject}.");
                    break;
                case "Arts":
                    Console.WriteLine($"I find myself studying {schoolsubject} outside of school.");
                    break;
                default:
                    Console.WriteLine($"One day, I hope to find a career in {schoolsubject}.");
                    break;
            }
        }
    }
}
