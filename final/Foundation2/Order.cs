public class Order{
    private Customer _customer;
    List <Product> _products;
    //Constructors
    public Order(Customer customer, List<Product> products){
        _customer = customer;
        _products = products;
    }
    //Methods
    public double TotalCoast(){
        double total = _products.Sum(product => product.GetPrice());
        double shippingCost = _customer.LiveInUsa() ? 5 : 35;
        return total + shippingCost;

    }
    public string PackingLabel(){
        string packingLabel = "";
        foreach (var product in _products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }
    public string ShippingLabel(){
        return $"Customer: {_customer.GetName()}\nAddress:\n{_customer.GetAddress()}";
    }
}