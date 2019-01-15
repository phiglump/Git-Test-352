using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            int counter = 1;
            int lowBound = 0;
            int HighBound = 0;

            Console.WriteLine("What is the lower and upper bound you want to set");
            Console.WriteLine("What is the lower bound you want to set?");
            lowBound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the Higher bound you want to set?");
            HighBound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("I am thinking of a number from " + lowBound + " to " + HighBound + ".");
            Console.WriteLine("Take a guess at what the number is.");

            Random random = new Random();
            int randomNum = random.Next(lowBound, HighBound);

            userInput = Convert.ToInt32(Console.ReadLine());
            bool done = false;
            while (done == false)
            {
                if (randomNum == userInput)
                {
                    Console.WriteLine("You Guessed It! Great Job!");
                    Console.WriteLine("The number was " + randomNum);
                    Console.WriteLine("You only took " + counter + " Time(s).");
                    done = true;
                }
                else if (randomNum < userInput)
                {
                    Console.WriteLine("Your guess was too high.");
                    Console.WriteLine("Try again.");
                    userInput = Convert.ToInt32(Console.ReadLine());
                    ++counter;
                }
                else if (randomNum > userInput)
                {
                    Console.WriteLine("Your guess was too low.");
                    Console.WriteLine("Try again.");
                    userInput = Convert.ToInt32(Console.ReadLine());
                    ++counter;
                }
                else
                {
                    Console.WriteLine("Sorry that is the wrong number.");
                    Console.WriteLine("Try again.");
                    userInput = Convert.ToInt32(Console.ReadLine());
                    ++counter;
                }
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
