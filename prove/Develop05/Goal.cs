public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public string GetShortName(){
        return _shortName;

    }
    public string GetDescription(){
        return _description;

    }
    public string GetPoints(){
        return _points;

    }

    
    public Goal (string name, string description, string points){
        _shortName = name;
        _description = description;
        _points = points;
    }
    
    //METHODS
    public abstract void RecordEvent();
    // abstract class is going to be used in derived classes with
    //different charachteristics
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();

    
    
}