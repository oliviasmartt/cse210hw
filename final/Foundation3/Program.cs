using System;

class Program
{
    static void Main(string[] args)
    {
        Address[] OSaddresses = new Address[3];
        OSaddresses[0] = new Address("8754 Plumb Branch St.", "La Vergne", "Tennesse", "37086", "United States");
        OSaddresses[1] = new Address("8222 Gulf Street", "Fort Lee", "New Jersey", "07024", "United States");
        OSaddresses[2] = new Address("586 East Locust St.", "Voltaire", "Zurich", "61236", "Switzerland");

        Event[] OSevents = new Event[3];
        OSevents[0] = new LectureEvent("Introduction to Floral Design course", "Let's learn the basics of Designing Flowers", "12/12/2023", "11:00am", OSaddresses[0], "Livi", "25 People");
        OSevents[1] = new ReceptionEvent("Hailee and Rigdon's Wedding", "Join us in celebrating the Wedding of Rigdon and Hailee", "10/14/2023", "06;30pm", OSaddresses[1], "rigandhailee@gmail.com");
        OSevents[2] = new OutdoorGatheringEvent("Pickleball Tournament", "Come join our pickleball tournament!", "11/11/2023", "08:00am", OSaddresses[2], "Sunny");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Event N: {i + 1}");
            Console.WriteLine("\n-STANDARD DETAILS-");
            Console.WriteLine(OSevents[i].OSStandardDetails());
            Console.WriteLine("-SHORT DETAILS- ");
            Console.WriteLine(OSevents[i].OSShortDetails());
            Console.WriteLine("-FULL DETAILS-");
            Console.WriteLine(OSevents[i].OSFullDetails());

        }
    }
}