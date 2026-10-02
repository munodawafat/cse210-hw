using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new BreathingActivity(),
            new ReflectingActivity()
        };
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Exit");
            Console.Write("Select an activity (1-3): ");

            var input = Console.ReadLine();
            if (input == "3")
                break;

            int choice;
            if (int.TryParse(input, out choice) && choice >= 1 && choice <= 2)
            {
                var selectedActivity = activities[choice - 1];
                Console.Write($"Enter duration in seconds for {selectedActivity.GetType().Name}: ");
                int duration;
                while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
                {
                    Console.Write("Please enter a valid positive number of seconds: ");
                }
                selectedActivity.SetDuration(duration);
                selectedActivity.DisplayStartingMessage();
                selectedActivity.ShowSpinner();
                selectedActivity.ShowCountDown();
                selectedActivity.DisplayEndingMessage();
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}