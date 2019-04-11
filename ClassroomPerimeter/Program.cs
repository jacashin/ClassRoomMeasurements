using System;

namespace ClassroomPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

                Console.WriteLine("Hey, what is the length of the room?");

                string userInput1 = Console.ReadLine();

                double.TryParse(userInput1, out double x);

                Console.WriteLine("Hey, what is the width of the room?");

                string userInput2 = Console.ReadLine();

                double.TryParse(userInput2, out double a);

                Console.WriteLine("Hey, what is the height of the room?");

                string userInput3 = Console.ReadLine();

                double.TryParse(userInput3, out double z);

                Console.WriteLine($"Your area is {x * a}");

                Console.WriteLine($"Your perimeter is {(x * 2) + (2 * a)}");

                Console.WriteLine($"Your volume is {x * a * z}");

                Console.WriteLine("Try again? (y/n)");

            }
            while (Console.ReadLine()=="y");
        }
    }
}

