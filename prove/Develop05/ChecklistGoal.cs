public class ChecklistGoal: Goal{
    //attributes
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    //constructor
     public ChecklistGoal(string goal, string description, string points, int target, int bonus) : base (goal,description,points){
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent(){
        _amountCompleted++;
        
    }
    public override bool IsComplete(){
        return _amountCompleted >= _target;
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName} - {_description}";
        
    }
    public override string GetDetailsString(){
        return $"Completed {_amountCompleted}/{_target} times";

    }
}