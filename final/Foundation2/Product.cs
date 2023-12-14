public class Product{
    //attributes
    private string _name;
    private string _productId;
    private double _price;
    private double _quantity;
    //Constructor
    public Product (string name, string productId, double price, double quantity){
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    //getters
    public string GetName(){
        return _name;
    }
    public string GetProductId(){
        return _productId;
    }
    public double GetPrice(){
        return _price * _quantity;
    }
    public double GetQuantity(){
        return _quantity;
    }

        
}