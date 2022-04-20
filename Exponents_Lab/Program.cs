using System;

namespace Exponents_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            Console.WriteLine("Learn your squares and cubes!");
            do
            {
                Console.Write("Please enter an integer: ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Number" + "\t\t" + "Square" + "\t\t" + "Cubed");
                Console.WriteLine("=======" + "\t\t" + "=======" + "\t\t" + "=======");
                for (int i = 1; i <= number; i++)
                {
                    int square = i * i;
                    int cubed = i * i * i;
                    Console.WriteLine(i + "\t\t" + square + "\t\t" + cubed);
                }

                Console.WriteLine("Would you like to enter another number?");
                answer = Console.ReadLine();
            }
            while (answer == "yes" || answer == "y" || answer == "Yes" || answer == "Y") ;
            Console.WriteLine("");
            Console.WriteLine("Goodbye!");

        }
    }
}
