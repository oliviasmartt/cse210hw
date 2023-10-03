using System;
using System.Globalization;
using System.Transactions;
class Journal
{
    // Menu
    static string JTPMenuMethod(){
        Console.WriteLine("Welcome to your electronic Journal!");
        Console.WriteLine("Enter 1 to write a new entry");
        Console.WriteLine("Enter 2 to show the dates you made entries");
        Console.WriteLine("Enter 3 to Save your Journal to a New File");
        Console.WriteLine("Enter 4 to Load a File");
        Console.WriteLine("Enter 0 to Exit this Program");
        string prompt = "";
        do{
        int number=Convert.ToInt32(Console.ReadLine());
        if (number == 1){
           prompt = "New Entry";
        }
        else if (number == 2){
            prompt = "Select an entry";
        }
        else if (number == 3){
            prompt = "Save your Journal";
        }
        else if (number == 4){
            prompt = "Load a file";
        }
        else if (number == 0){
            prompt = "Exit this program";
        }
        }
        while (prompt == "");
        return prompt;
    }
    // New Entry (The Return should be in the form of a dictionary 0 being date 1 being the entry Adam S.)
 
    // Select an Entry (A list of Dates should be created and prompted to the user. After they should be able to select the desired date Lisa H.)
 
    // Save Journal (Save the current journal into a CSV file Emma S.)
 
    // Load a File (It should return a list of entries in their given dictionaries from a CSV file in the same format that a saved file would be inserted. Olivia S.)
 
    // Exit this program (Done)
    static void Main(string[] args)
    {
        string menuPrompt = "";
        do{
        menuPrompt = JTPMenuMethod();
        Console.WriteLine("you have chosen to " + menuPrompt);}
        while(menuPrompt != "Exit this program");
    }
}