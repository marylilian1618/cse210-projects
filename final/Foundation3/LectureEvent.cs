class LectureEvent : Event{
    //attributes
    private string _speaker;
    private int _capacity;
    //constructor
    public LectureEvent(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity):base(title, description, date, time, address){
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string FullDetails(){
        return $"{base.StandardDetails()}\n Type: Lecture \nSpeaker{_speaker}\n Capacity: {_capacity} attendees";
    
    }


}