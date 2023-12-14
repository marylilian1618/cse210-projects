class OutdoorEvent: Event{
    private string _weather;
    public OutdoorEvent(string title, string description, DateTime date, TimeSpan time, Address address, string weather):base(title, description, date, time, address){
        _weather = weather;
    }
    public override string FullDetails()
    {
        return $"{base.StandardDetails()}\nType: Outdoor \n Weather: {_weather}";
    }

}