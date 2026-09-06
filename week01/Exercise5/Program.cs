using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        displayMessage();

       
        string userName = "";
        userName = displayPersonalMessage(userName);
        

        int number = 0;
        number = favoriteNumber(number);

        int squaredNumber = squareNumber(number);

        DisplayResult(userName, squaredNumber);
    }

    static void displayMessage()
    {
        Console.WriteLine("Hello World! This is the Program.");
    }
    static string displayPersonalMessage(string userName)
    {
        Console.Write("What is your name? ");
        userName = Console.ReadLine();
        Console.WriteLine($"Hello {userName}!");
        return userName;
    }
    static int favoriteNumber(int number)

    {
        Console.Write("What is your favorite number? ");
        number = int.Parse(Console.ReadLine());
        return number;
    }

    static int squareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"Hello {userName}, the square of your favorite number is {squaredNumber}.");
    }
}