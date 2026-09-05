using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your mark? ");
        String mark = Console.ReadLine();
        int percent = int.Parse(mark);

        string letter = "";
        string sign = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
            int last_digit = (int)percent % 10;

            if (last_digit >= 7)
            {
                sign = "+";
            }
            else if (last_digit < 3)
            {
                sign = "-";
            }
            if (percent >= 93)
            {
                sign = "";
            }
            if (percent < 60)
            {
                sign = "";
            }
            else
            {
                sign = "";
            }
        Console.WriteLine($" Your grade is: {letter}{sign}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulation, you have passed!");
        }
        else
        {
            Console.WriteLine("Sorry try next time!");
        }

    }
}