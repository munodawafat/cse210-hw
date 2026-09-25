public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetNProductID()
    {
        return _productID;
    }
    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public double GetTotalCost()
    {
       return _price * _quantity;
    }
}