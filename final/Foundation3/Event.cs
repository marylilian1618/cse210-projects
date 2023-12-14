class Event{
    //Attributes:
    private string _eventTitle;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;
    //Constructor
    public Event(string eventTitle, string description, DateTime date,TimeSpan time, Address address){
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address= address;
    }
    public virtual string StandardDetails(){
        return $"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date}\n Time: {_time}\n Adress: {_address.GetFullAddress}"; 
    }
    public virtual string FullDetails(){
        return StandardDetails();
    }
    public virtual string ShortDescription(){
        return $"Type: Event \nTitle: {_eventTitle}\nDate: {_date.ToShortDateString()}";
    }
}