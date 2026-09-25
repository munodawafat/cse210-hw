using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double GetTotalCost()
    {
        double Total = 0;
        foreach (Product product in _products)
        {
            Total += product.GetTotalCost();
        }
        if (_customer.LivesInUSA())
        {
            Total += 5;
        }
        else
        {
            Total += 35;
        }
        return Total;
    }
    public string GetPackingLabel()
    {
        string label = "PACKING LABEL\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} - {product.GetNProductID()}\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        string label = "SHIPPING LABEL\n";
        label += $"{_customer.GetName()}\n";
        label += _customer.GetAddress().ToString();

        return label;
    }
}