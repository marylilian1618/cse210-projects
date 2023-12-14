
class Running : Activity
{
    private double Distance;

    public Running(DateTime date, int durationInMinutes, double distance) : base(date, durationInMinutes)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / GetDurationInMinutes() * 60;
    }

    public override double GetPace()
    {
        return GetDurationInMinutes() / Distance;
    }
    public override string GetActivity(){
        return "Running Activity";
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {Distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}