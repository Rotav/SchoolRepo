using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            const int number = 6;
            Console.WriteLine("Try to guess the number!");
            int guess;
            int lives = 6;
            while (true)
            {
                Console.Beep(400, (lives * 100));

                while (true)
                {
                    if (Int32.TryParse(Console.ReadLine(), out guess))
                    {
                        if (guess == number)
                        {
                            Console.WriteLine("You have successfully guessed the number!");
                            Console.ReadLine();
                            //exit
                        }
                        else if (number > guess)
                        {
                            Console.WriteLine("Your number is too low, try again.");
                            Console.ReadLine();
                            lives = lives - 1;
                        }
                        else if (number < guess)
                            Console.WriteLine("Your number is too high, try again.");
                        Console.ReadLine();
                        lives = lives - 1;
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid number.");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
