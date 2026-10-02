using System.Diagnostics;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through a series of deep breaths.")
    { }

    private void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            System.Threading.Thread.Sleep(1000);
        }

        Console.WriteLine();
    }

    public void run()
    {
        var timer = Stopwatch.StartNew();
        var breathingDuration = 10; // Duration for each breathing cycle in seconds
        Console.Write("How long, in seconds, would you like for your session? ");
        var totalDuration = int.Parse(Console.ReadLine() ?? "0");

        while (timer.Elapsed.TotalSeconds < totalDuration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(breathingDuration);

            Console.WriteLine("Breathe out...");
            ShowCountDown(breathingDuration);

            var remaining = totalDuration - (int)timer.Elapsed.TotalSeconds;
            if (remaining > 0)
            {
                breathingDuration = Math.Min(breathingDuration, remaining);
                Console.WriteLine("Final breathing cycle...");
                ShowCountDown(breathingDuration);
                Console.WriteLine($"You have {remaining} seconds left in this activity.");
            }
        }
    }
}