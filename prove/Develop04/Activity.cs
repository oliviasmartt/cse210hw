using System;

class Activity
{
    protected string OSName;
    protected string OSDescription;
    protected int OSDuration;
    protected List<string> OSPrompts = new List<string>();
    private List<string> OSAnimationItems = new List<string> { "|", "/", "-", "\\" };



    public Activity(string OSName, string OSDescription)
    {
        this.OSName = OSName;
        this.OSDescription = OSDescription;
    }


    public Activity(string OSName, string OSDescription, List<string> OSPrompts)
    {
        this.OSName = OSName;
        this.OSDescription = OSDescription;
        this.OSPrompts = OSPrompts;
    }
    protected void OSCreateAnimation(int time)
    {
        DateTime OSStartTime = DateTime.Now;
        DateTime OSEndTime = OSStartTime.AddSeconds(time);
        int i = 0;
        while (DateTime.Now < OSEndTime)
        {
            string s = OSAnimationItems[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i == OSAnimationItems.Count())
            {
                i = 0;
            }


        }
        // foreach (string item in OSAnimationItems){
        //     Console.Write(item);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");

        // }
    }

    protected void OSCreateCountdown(int OSNumber)
    {
        for (int i = OSNumber; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
    }

    protected int OSReturnRandomNumber(List<string> OSList)
    {
        Random OSGenerator = new Random();
        int OSNumber = OSGenerator.Next(0, OSList.Count());
        return OSNumber;
    }
    protected void OSStartingMessage()
    {
        Console.WriteLine($" Welcome to the{OSName}. ");
        Console.WriteLine();
        Console.WriteLine($"{OSDescription} ");
        Console.WriteLine();
        Thread.Sleep(2000);
        Console.Write("How long, in seconds, would you like your session to last? ");

        OSDuration = int.Parse(Console.ReadLine());


        Thread.Sleep(1000);
        Console.WriteLine($"Your activity will last for {OSDuration} seconds.");
        Console.WriteLine();
        Thread.Sleep(2000);
        Console.Write("Get ready...");
        OSCreateAnimation(5);
        Console.WriteLine();
        // Thread.Sleep(2000);
    }

    protected void OSEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine();
        Thread.Sleep(2000);
        Console.WriteLine($"You have completed another {OSDuration} seconds of {OSName}");
        Thread.Sleep(2000);

    }





}