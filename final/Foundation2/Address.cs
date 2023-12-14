public class Address{
    //Attributes
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    //Constructors
    public Address(string streetAddress, string city, string state, string country){
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country= country;
    }
    //Methods
    public bool IsUSA(){
        return _country.ToLower() =="usa";
    }
    public string AdressComplete(){
        return $"{_streetAddress} {_city} {_state} {_country}";
    }
}