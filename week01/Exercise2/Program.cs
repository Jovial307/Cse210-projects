using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade percentege: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;
        string letter = "";
        string signs = "";


        if (grade >= a)
        {
            letter = "A";
        }
        else if (grade >= b && grade < a)
        {
            letter = "B";
        }
        else if (grade >= c && grade < b)
        {
            letter = "C";
        }
        else if (grade >= d && grade < c)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter == "A")
        {
            if (grade % 10 <= 3)
            {
                signs = "-";
            }
        }
        
        else if (letter != "F")
        {
            if (grade % 10 >= 7)
            {
                signs = "+";
            }
            if (grade % 10 <= 3)
            {
                signs = "-";
            }
        }


        Console.WriteLine($"Your grade is {letter}{signs}");

        if (grade >= c)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry! Try harder next time.");
        }
    }
}