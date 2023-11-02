using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Transactions;
class Program
{
    // Menu
    static string JTPMenuMethod(eesMyJournal){
        
        Console.WriteLine("Welcome to your electronic Journal!");
        Console.WriteLine("Enter 1 to Write");
        Console.WriteLine("Enter 2 to Display (Save First)");
        Console.WriteLine("Enter 3 to Save");
        Console.WriteLine("Enter 4 to Load");
        Console.WriteLine("Enter 5 to Exit");
        string prompt = "";
        do{
        int number=Convert.ToInt32(Console.ReadLine());
        if (number == 1){
            prompt = "Create an Entry";
           EesEntry eesEntry1 = new EesEntry();
            int eesPromptNumber = eesEntry1.EesChoosePrompt();
             eesEntry1._eesPrompt = eesEntry1.EesPrompts[eesPromptNumber];
                
            eesEntry1.EesFormatEntry();
            eesMyJournal._eesEntry.Add(eesEntry1);
        }
        else if (number == 2){
            prompt = "Select an entry";
            eesMyJournal.DisplayJournal();
        }
        else if (number == 3){
            prompt = "Save your Journal";
            Console.WriteLine("Which file would you like to save your Journal to? ");
            string eesUserFile = Console.ReadLine();
            EesSaveFile(eesUserFile, eesMyJournal);
        }
        else if (number == 4){
            prompt = "Load a file";
        }
        else if (number == 5){
            prompt = "Exit this program";
        }
        }
        while (prompt == "");
        return prompt;
    }
    // New Entry (The Return should be in the form of a dictionary 0 being date 1 being the entry Adam S.)
 
    // Select an Entry (A list of Dates should be created and prompted to the user. After they should be able to select the desired date Lisa H.)
class LhSelectEntry 
{
    static void Main()
    {
        //get dat from super
        Console.Write("Enter the date you want to select (MM/DD/YYYY): ");
        string lhDateInput = Console.ReadLine();
        //check if input is valid 
        if (!lhDateInput.Contains("/") || lhDateInput.Length != 10)
        {
            Console.WriteLine("Invalid Date Format.");
            return;
        }
        //look for file
        string lhFilePath = "journal.csv";
        //check to see if file exists
        if (!File.Exists(lhFilePath))
        {
            Console.WriteLine("The journal.csv file does not exist.");
            return;
        }
        //read the jounral.csv file and look for the date the user gave
        var LhLines = File.ReadLines(lhFilePath);
        var LhEntry = LhLines.FirstOrDefault(line => line.StartsWith(lhDateInput));
        //if entry found display date, prompt, entry
        if (LhEntry != null)
        {
            var LhFeilds = LhEntry.Split(',');
            Console.WriteLine("Date: {0}", LhFeilds[0]);
            Console.WriteLine("Prompt: {0}", LhFeilds[1]);
            Console.WriteLine("Journal entry: {0}", LhFeilds[2]);
        }
        else
        {
            //if no date found
            Console.WriteLine("No Jounral Entry found for the date {0}.", lhDateInput);
        }
    }
}
 
    // Save Journal (Save the current journal into a CSV file Emma S.)
 static void EesSaveFile(string fileName, EesJournal eesMyJournal){

        using (StreamWriter writer = new StreamWriter(fileName, true)){
            writer.Write(eesMyJournal.FormatJournal());
        }
    }
    // Load a File (It should return a list of entries in their given dictionaries from a CSV file in the same format that a saved file would be inserted. Olivia S.)
    static List<Dictionary<string, string>> LoadJournalEntries(string OSfilePath)
    {
    List<Dictionary<string, string>> entries = new List<Dictionary<string, string>>();

    if (File.Exists(OSfilePath))
    {
    var OSlines = File.ReadLines(OSfilePath);

    foreach (var OSline in OSlines)
    {
    var OSfields = OSline.Split(',');

    if (OSfields.Length >= 3) // Ensure there are at least three fields (date, prompt, entry)
    {
    var OSentry = new Dictionary<string, string>
    {
    { "Date", OSfields[0] },
    { "Prompt", OSfields[1] },
    { "JournalEntry", OSfields[2] }
    };
    entries.Add(OSentry);
    }
    }
    }

    return entries;
    }

    static void Main(string[] args)
    {
    string OSmenuPrompt = "";
    string journalFilePath = "journal.csv"; // Change this to the path of your journal file.

    do
    {
    OSmenuPrompt = JTPMenuMethod();
    Console.WriteLine("You have chosen to " + OSmenuPrompt);

    if (OSmenuPrompt == "Load a File")
    {
    List<Dictionary<string, string>> loadedEntries = LoadJournalEntries(journalFilePath);

    // Display loaded entries
    foreach (var entry in loadedEntries)
    {
    Console.WriteLine("Date: " + entry["Date"]);
    Console.WriteLine("Prompt: " + entry["Prompt"]);
    Console.WriteLine("Journal entry: " + entry["JournalEntry"]);
    Console.WriteLine();
    }
    }

    Console.WriteLine("");
    }
    while (OSmenuPrompt != "Exit this program");
    }

 
    // Exit this program (Done)
}