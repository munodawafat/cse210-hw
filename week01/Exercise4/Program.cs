using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;        

        Console.WriteLine("Enter 0 to quit.");
        while (userNumber != 0)
        {
            Console.Write("Enter negative and positive numbers (0 to quit): ");
        
            userNumber = Convert.ToInt32(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } 
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"Sum: {sum}");

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"Average: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"Maximum: {max}");

        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        Console.WriteLine($"Smallest Positive: {smallestPositive}");

        numbers.Sort();
        Console.WriteLine("Sorted Numbers: ");
        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }
}