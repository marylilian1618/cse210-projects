public class EternalGoal : Goal
{
    public EternalGoal(string goal, string description, string points) : base(goal, description, points)
    {
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {

        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName} - {_description}";
    }

    public override string GetDetailsString()
    {
        throw new NotImplementedException();
    }
}