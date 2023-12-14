class ReceptionEvent : Event {
    //attributes
    private string _email;
    public ReceptionEvent(string title, string description, DateTime date, TimeSpan time, Address address, string email):base(title, description, date, time, address){
        _email = email;
    }
    public override string FullDetails()
    {
        return $"{base.StandardDetails()}\nType: Reception\nEmail: {_email}";
    }

}