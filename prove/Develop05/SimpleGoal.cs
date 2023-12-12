public class SimpleGoal: Goal{
    //attributes
    private bool _isComplete;
    //constructor
    public SimpleGoal(string goal, string description, string points) : base (goal,description,points){

    }
    public override void RecordEvent(){
        _isComplete = true;
    }
    public override bool IsComplete(){
        return _isComplete;
        
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