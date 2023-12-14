using System;

class Program
{
    static void Main(string[] args){
        List<Activity> activities = new List<Activity>();

        DateTime date = DateTime.Now;

        Running runningActivity = new Running(date, 30, 3.0);
        StationaryBicycle bicycleActivity = new StationaryBicycle(date, 45, 25.0);
        Swimming swimmingActivity = new Swimming(date, 40, 20);

        activities.Add(runningActivity);
        activities.Add(bicycleActivity);
        activities.Add(swimmingActivity);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
    
