class Activity
{
    private DateTime _date;
    private int _durationInMinutes;

    public Activity(DateTime date, int durationInMinutes){
        _date = date;
        _durationInMinutes = durationInMinutes;
    }
    public int GetDurationInMinutes(){
        return _durationInMinutes;
    }

    public virtual double GetDistance(){
        return 0;
    }

    public virtual double GetSpeed(){
        return 0; 
    }

    public virtual double GetPace(){
        return 0; 
    }
    public virtual string GetActivity(){
        return "";
    }

    public virtual string GetSummary(){
        return $"{_date.ToShortDateString()} ({GetActivity()}) - {_durationInMinutes} min";
    }
}