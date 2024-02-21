using System;

public class ReceptionEvent : Event
{
    private string email;

    public ReceptionEvent(string title, string description, DateTime date, TimeSpan time, Address address, string email)
        : base(title, description, date, time, address)
    {
        this.email = email;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"Type: Reception\nEmail for RSVP: {email}\n";
    }
}
