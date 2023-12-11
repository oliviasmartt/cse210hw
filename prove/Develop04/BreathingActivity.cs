class BreathingActivity : Activity
{
    private string OSBreatheIn = "Breathe In...";
    private string OSBreatheOut = "Breathe Out...";
    private int OSPause;



    public BreathingActivity(string OSName, string OSDescription) : base(OSName, OSDescription)
    {
        OSName = OSName;
        OSDescription = OSDescription;


    }
    public void OSSetPause()
    {
        bool OSPauseAssigned = false;
        do
        {
            Console.Write("Would you like to breathe in 4 second intervals or 7 second intervals? ");

            int OSPauseTime = int.Parse(Console.ReadLine());
            if (OsPauseTime == 4 || OSPauseTime == 7)
            {
                OSPause = OSPauseTime;
                OSPauseAssigned = true;
            }
            else
            {
                Console.WriteLine("You must choose either 4 or 7.");
            }
        } while (OSPauseAssigned == false);

    }





    public void OSRunActivity()
    {

        base.OSStartingMessage();
        OSSetPause();
        DateTime OSStartActivity = DateTime.Now;
        DateTime OSEndTime = OSStartActivity.AddSeconds(OSDuration);

        while (DateTime.Now < OSEndTime)
        {
            Console.Write(OSBreatheIn);
            OSCreateCountdown(OSPause);
            Console.WriteLine();
            Console.Write(OSBreatheOut);
            OSCreateCountdown(OSPause);
            Console.WriteLine();

        }

        base.OSEndingMessage();
        Thread.Sleep(2000);
        Console.Clear();
    }

}