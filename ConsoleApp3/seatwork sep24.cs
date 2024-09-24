using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int userInput = int.Parse(Console.ReadLine());

            int evenCount = 0;
            int oddCount = 0;
            
            if (userInput <= -1 )
            {
                Console.WriteLine("Negative number not allowed");
            }

            if (userInput == 0)
            {
                System.Environment.Exit(1);
            }
            if (userInput % 2 == 0)
            {
                Console.WriteLine($"{userInput} is a multiple of 2.");
                evenCount++;
            }
            if (userInput % 3 == 0)
            {
                Console.WriteLine($"{userInput} is a multiple of 3.");
                oddCount++;
            }
            if (userInput % 4 == 0)
            {
                Console.WriteLine($"{userInput} is a multiple of 4.");
                evenCount++;
            }
            if (userInput % 5 == 0)
            {
                Console.WriteLine($"{userInput} is a multiple of 5.");
                oddCount++;
            }
            if (userInput % 6 == 0)
            {
                Console.WriteLine($"{userInput} is a multiple of 6.");
                evenCount++;
            }
            if (userInput % 7 == 0)
            {
                Console.WriteLine($"{userInput} is a multiple of 7.");
                oddCount++;
            }
            if (userInput % 8 == 0)
            {
                Console.WriteLine($"{userInput} is a multiple of 8.");
                evenCount++;
            }
            if (userInput % 9 == 0)
            {
                Console.WriteLine($"{userInput} is a multiple of 9.");
                oddCount++;
            }
            if (userInput % 10 == 0)
            {
                Console.WriteLine($"{userInput} is a multiple of 10.");
                evenCount++;
            }
            if (userInput % 11 == 0)
            {
                Console.WriteLine($"{userInput} is a multiple of 11.");
                oddCount++;
            }
            if (userInput % 12 == 0)
            {
                Console.WriteLine($"{userInput} is a multiple of 12.");
                evenCount++;
            }
            if (userInput % 13 == 0)
            {
                Console.WriteLine($"{userInput} is a multiple of 13.");
                oddCount++;
            }
            if (userInput % 14 == 0)
            {
                Console.WriteLine($"{userInput} is a multiple of 14.");
                evenCount++;
            }
            if (userInput % 15 == 0)
            {
                Console.WriteLine($"{userInput} is a multiple of 15.");
                oddCount++;
            }

            if (evenCount > oddCount)
                Console.WriteLine($"{userInput} has more even multiples.");
            else if (oddCount > evenCount)
                Console.WriteLine($"{userInput} has more odd multiples.");
            else
                Console.WriteLine($"{userInput} has an equal number of odd and even multiples.");
        }
    }
}
