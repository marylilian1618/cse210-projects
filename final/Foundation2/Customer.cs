public class Customer{
    //Attributes
    private string _name;
    Address _address;
    //Constructor
    public Customer (string name, Address address){
        _name = name;
        _address = address;
    }
    //Get
    public string GetName(){
        return _name;
    }
    public string GetAddress(){
        return _address.AdressComplete();
        //adress es una instancia de la clase adress 
    }
    //Methods
    public bool LiveInUsa(){
        return _address.IsUSA();
    }
}