class StationaryBicycle : Activity
{
    private double Speed;

    public StationaryBicycle(DateTime date, int durationInMinutes, double speed) : base(date, durationInMinutes)
    {
        Speed = speed;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }
    public override string GetActivity(){
        return "Bicycle activity";
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {Speed} kph, Pace: {GetPace()} min per km";
    }
}