class Address{
    //Attributes
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    //Constructors
    public Address(string street, string city, string state, string country){
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    //methods
    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }


}