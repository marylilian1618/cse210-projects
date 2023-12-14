class Swimming : Activity
{
    private int Laps;

    public Swimming(DateTime date, int durationInMinutes, int laps) : base(date, durationInMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000; // Convert meters to kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetDurationInMinutes() * 60;
    }

    public override double GetPace()
    {
        return GetDurationInMinutes() / GetDistance();
    }

    public override string GetActivity(){
        return "Swimming Activity";
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}