using System;

public class ConferenceEvent : Event
{
    private string speaker;
    private int capacity;

    public ConferenceEvent(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"Type: Conference\nSpeaker: {speaker}\nCapacity: {capacity}\n";
    }
}
