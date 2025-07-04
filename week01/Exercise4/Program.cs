using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        int sum = 0;
        int Number = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (Number != 0)
        {
            Console.Write("Enter Number: ");
            string userInput = Console.ReadLine();
            Number = int.Parse(userInput);
            if (Number != 0)
            {
                numbers.Add(Number);
            }
        }
        foreach (int Num in numbers)
        {
            sum += Num;
        }
        Console.WriteLine($"The sum is {sum}");

        float ave = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {ave}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

        int minPositive = numbers[0];
        foreach (int num in numbers)
        {
            if (num > 0 && num < minPositive)
            {
                minPositive = num;
            }
        }
        Console.WriteLine($"The smallest positive number is: {minPositive}");

        numbers.Sort();
        Console.WriteLine("Sorted numbers:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}