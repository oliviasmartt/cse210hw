using System;

class ReflectionActivity : Activity
{
    private List<string> OSQuestions = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private int OSTimePerQuestion;


    public ReflectionActivity(string OSName, string OSDescription, List<string> OSPrompts, int OSTimePerQuestion) : base(OSName, OSDescription, OSPrompts)
    {
        this.OSTimePerQuestion = OSTimePerQuestion;
    }



    public void OSRunActivity()
    {

        base.OSStartingMessage();

        Console.WriteLine("Please read the following prompt:");
        int OSRandomPrompt = base.OSReturnRandomNumber(OSPrompts);
        string OSChosenPrompt = OSPrompts[OSRandomPrompt];
        Console.WriteLine($"{OSChosenPrompt}");
        Console.Write("Press enter to continue.");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
        Thread.Sleep(2000);
        Console.Write("You may begin in: ");
        OSCreateCountdown(5);
        DateTime OSStartActivity = DateTime.Now;
        DateTime OSEndTime = OSStartActivity.AddSeconds(OSDuration);
        Console.Clear();

        while (DateTime.Now < OSEndTime)
        {

            int OSRandom = base.OSReturnRandomNumber(OSQuestions);
            string OSChosenQuestion = OSQuestions[OSRandom];
            Console.Write($"--- {OSChosenQuestion} ---");
            base.OSCreateAnimation(OSTimePerQuestion);
            Console.WriteLine();
        }


        base.OSEndingMessage();
        Thread.Sleep(2000);
        Console.Clear();
    }
}