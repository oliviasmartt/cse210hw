using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> OSactivities = new List<Activity>();
        OSactivities.Add(new RunningActivity("13 Dec 1989", 5.8, 40));
        OSactivities.Add(new CyclingActivity("4 Jul 1776", 6.2, 30));
        OSactivities.Add(new Swimming("17 Aug 2016", 85, 45));

        int index = 1;
        foreach (Activity OSactivity in OSactivities)
        {
            Console.WriteLine($"\nACTIVITY N{index}:\n{OSactivity.OSGetSummary()}");
            index++;
        }
        Console.WriteLine();
    }
}