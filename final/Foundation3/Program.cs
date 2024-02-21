using System;

class Program
{
    static void Main(string[] args)
    {
        Address eventAddress = new Address("123 Main St", "Anytown", "CA", "USA");

        Event conferenceEvent = new ConferenceEvent("Tech Summit", "Annual tech conference", new DateTime(2024, 4, 15), new TimeSpan(9, 0, 0), eventAddress, "John Smith", 200);
        Event receptionEvent = new ReceptionEvent("Company Anniversary", "Celebrating 10 years of success", new DateTime(2024, 5, 20), new TimeSpan(18, 0, 0), eventAddress, "info@example.com");
        Event outdoorMeetingEvent = new OutdoorMeetingEvent("Team Building Day", "Outdoor activities and team bonding", new DateTime(2024, 6, 30), new TimeSpan(10, 0, 0), eventAddress, "Sunny with occasional clouds");

        Console.WriteLine("Conference Event Marketing Messages:");
        Console.WriteLine(conferenceEvent.GetStandardDetails());
        Console.WriteLine(conferenceEvent.GetFullDetails());
        Console.WriteLine(conferenceEvent.GetBriefDescription());

        Console.WriteLine("\nReception Event Marketing Messages:");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetBriefDescription());

        Console.WriteLine("\nOutdoor Meeting Event Marketing Messages:");
        Console.WriteLine(outdoorMeetingEvent.GetStandardDetails());
        Console.WriteLine(outdoorMeetingEvent.GetFullDetails());
        Console.WriteLine(outdoorMeetingEvent.GetBriefDescription());
    }
}
