public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (Product element in _products)
        {
            total += element.GetTotalCost();
        }

        if (_customer.LivesInUsa() == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product element in _products)
        {
            label += $"Name: {element.GetName()} - Product ID: {element.GetProductId()}\n";
        }
        return label;

    }
    
    public string GetShippingLabel()
    {
        return $"Name: {_customer.GetName()} \nAddress: {_customer.GetAddress()}";
    }

}