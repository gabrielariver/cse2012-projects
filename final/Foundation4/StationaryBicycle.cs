using System;

public class StationaryBicycle : Activity
{
    private double speed;

    public StationaryBicycle(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return speed * minutes / 60;
    }

    public override double GetPace()
    {
        return minutes / (speed * 60);
    }

    public override string GetSummary()
    {
        return $"{date.ToShortDateString()} Stationary Bicycle ({minutes} min) - Speed: {speed} mph, Distance: {GetDistance()} miles";
    }
}
