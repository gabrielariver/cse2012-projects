using System;

public class OutdoorMeetingEvent : Event
{
    private string weatherForecast;

    public OutdoorMeetingEvent(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"Type: Outdoor Meeting\nWeather Forecast: {weatherForecast}\n";
    }
}
