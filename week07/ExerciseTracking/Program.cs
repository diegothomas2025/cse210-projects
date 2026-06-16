using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new RunningActivity(DateTime.Now.ToString("dd MMM yyyy", CultureInfo.InvariantCulture), "Running", 10, 4.8));
        activities.Add(new CyclingActivity(DateTime.Now.ToString("dd MMM yyyy", CultureInfo.InvariantCulture), "Cycling", 10, 9.7));
        activities.Add(new SwimmingActivity(DateTime.Now.ToString("dd MMM yyyy", CultureInfo.InvariantCulture), "Swimming", 10, 20));

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}