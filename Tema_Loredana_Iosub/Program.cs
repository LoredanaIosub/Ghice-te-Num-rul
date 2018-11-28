using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Loredana_Iosub
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int guess = 0;
            int number = random.Next(0, 100);
            Console.WriteLine("Guess a number between 0 and 100");

            while (guess != number)
            {
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > number)
                    {
                        Console.WriteLine("The number is too big, try again");
                    }
                    else
                    {
                        Console.WriteLine("The number is too small, try again");
                    }
                }
                catch
                {
                    Console.WriteLine("Go on!");
                }
            }

            Console.WriteLine("The number is correct");
            Console.ReadLine();
        }
    }
}
