class ListingActivity : Activity
{
    private List<string> OSUserInputs = new List<string>();

    public ListingActivity(string OSName, string OSDescription, List<string> OSPrompts) : base(OSName, OSDescription, OSPrompts)
    {

    }


    public void OSSpecificActivity()
    {
        Console.Write(">");
        string OSNewInput = Console.ReadLine();
        OSUserInputs.Add(OSNewInput);
    }

    public void OSRunActivity()
    {

        OSStartingMessage();
        DateTime OSStartActivity = DateTime.Now;
        DateTime OSEndTime = OSStartActivity.AddSeconds(OSDuration);

        Console.WriteLine("Please read the following prompt:");
        int OSRandomPrompt = base.OSReturnRandomNumber(OSPrompts);
        string OSChosenPrompt = OSPrompts[OSRandomPrompt];
        Console.WriteLine($"{OSChosenPrompt}");
        Thread.Sleep(1000);
        Console.Write("You may begin in: ");
        OSCreateCountdown(5);
        Console.WriteLine();

        while (DateTime.Now < OSEndTime)
        {
            Console.Write(">");
            string OSNewInput = Console.ReadLine();
            OSUserInputs.Add(OSNewInput);
        }
        Console.WriteLine($"You entered in {OSUserInputs.Count()} items. ");


        OSEndingMessage();
        Thread.Sleep(2000);
        Console.Clear();
    }
}