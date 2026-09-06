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
            int lastDigit = percent % 10;

            if (letter == "B" && lastDigit > 7)
            {
                sign = "+";
            }
            else if (letter == "C" && lastDigit > 7)
            {
                sign = "+";
            }
            else if (letter == "D" && lastDigit > 7)
            {
                sign = "+";
            }
            if (letter == "A" && lastDigit > 3)
            {
                sign = "";
            }
            else if (letter == "F")
            {
                sign = "";
            }
            else if (letter == "D" && lastDigit < 3)
            {
               sign = "-";
            }
            else if (letter == "C" && lastDigit < 3)
            {
                sign = "-";
            }
            else if (letter == "B" && lastDigit < 3)
            {
                sign = "-";
            }
            else if (letter == "A" && lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            Console.WriteLine($"Your grade is: {letter}{sign}");

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