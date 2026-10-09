using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
      List<Activity> activities = new List<Activity>();

        // Create instances of different activities
        activities.Add(new Running("2026-10-01", 30, 3.0)); // 3 miles in 30 minutes
        activities.Add(new Cycling("2026-10-02", 45, 15.0)); // 15 mph for 45 minutes
        activities.Add(new Swimming("2026-10-03", 60, 40)); // 40 laps in 60 minutes

        // Display summaries for each activity
        foreach (var activity in activities)
        {
            activity.DisplaySummary();
            Console.WriteLine(); // Add a blank line between summaries
        }
    }
}